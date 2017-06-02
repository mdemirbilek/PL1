using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Web;
using Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.OpenIdConnect;
using OwinCas;
using Microsoft.Owin.Infrastructure;
using Microsoft.Owin;

namespace PL1
{
    public partial class Startup
    {
        private static string clientId = ConfigurationManager.AppSettings["ida:ClientId"];
        private static string aadInstance = ConfigurationManager.AppSettings["ida:AADInstance"];
        private static string tenantId = ConfigurationManager.AppSettings["ida:TenantId"];
        private static string postLogoutRedirectUri = ConfigurationManager.AppSettings["ida:PostLogoutRedirectUri"];
        private static string authority = aadInstance + tenantId;

        public void ConfigureAuth(IAppBuilder app)
        {
            app.SetDefaultSignInAsAuthenticationType(CookieAuthenticationDefaults.AuthenticationType);

            //app.UseCookieAuthentication(new CookieAuthenticationOptions());

            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                CookieManager = new SystemWebCookieManager()
            });



            app.UseOpenIdConnectAuthentication(
                new OpenIdConnectAuthenticationOptions
                {
                    ClientId = clientId,
                    Authority = authority,
                    PostLogoutRedirectUri = postLogoutRedirectUri,
                    ProtocolValidator = new Microsoft.IdentityModel.Protocols.OpenIdConnectProtocolValidator()
                    {
                        RequireNonce = true
                    }
                });

            //CasAuthenticationOptions casOptions = new CasAuthenticationOptions();
            //casOptions.CasServerUrlBase = "https://secure.vistula.edu.pl/cas/";
            //casOptions.Caption = "Vistula U. Single Sign-On";
            //casOptions.AuthenticationType = "Vistula";
            //app.UseCasAuthentication(casOptions);

        }
    }


    public class SystemWebCookieManager : ICookieManager
    {
        public string GetRequestCookie(IOwinContext context, string key)
        {
            if (context == null)
            {
                throw new ArgumentNullException("context");
            }

            var webContext = context.Get<HttpContextBase>(typeof(HttpContextBase).FullName);
            var cookie = webContext.Request.Cookies[key];
            return cookie == null ? null : cookie.Value;
        }

        public void AppendResponseCookie(IOwinContext context, string key, string value, CookieOptions options)
        {
            if (context == null)
            {
                throw new ArgumentNullException("context");
            }
            if (options == null)
            {
                throw new ArgumentNullException("options");
            }

            var webContext = context.Get<HttpContextBase>(typeof(HttpContextBase).FullName);

            bool domainHasValue = !string.IsNullOrEmpty(options.Domain);
            bool pathHasValue = !string.IsNullOrEmpty(options.Path);
            bool expiresHasValue = options.Expires.HasValue;

            var cookie = new HttpCookie(key, value);
            if (domainHasValue)
            {
                cookie.Domain = options.Domain;
            }
            if (pathHasValue)
            {
                cookie.Path = options.Path;
            }
            if (expiresHasValue)
            {
                cookie.Expires = options.Expires.Value;
            }
            if (options.Secure)
            {
                cookie.Secure = true;
            }
            if (options.HttpOnly)
            {
                cookie.HttpOnly = true;
            }

            webContext.Response.AppendCookie(cookie);
        }

        public void DeleteCookie(IOwinContext context, string key, CookieOptions options)
        {
            if (context == null)
            {
                throw new ArgumentNullException("context");
            }
            if (options == null)
            {
                throw new ArgumentNullException("options");
            }

            AppendResponseCookie(
                context,
                key,
                string.Empty,
                new CookieOptions
                {
                    Path = options.Path,
                    Domain = options.Domain,
                    Expires = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                });
        }
    }


}
