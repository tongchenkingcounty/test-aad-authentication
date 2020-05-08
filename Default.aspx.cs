using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.OpenIdConnect;
using System;
using System.Web;
using System.Web.UI;

namespace TestADFS
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Request.IsAuthenticated)
            {
                HttpContext.Current.GetOwinContext().Authentication.Challenge(
                    new AuthenticationProperties { RedirectUri = "https://localhost:44368/Default" },
                    OpenIdConnectAuthenticationDefaults.AuthenticationType);
            }
        }

        protected void LogoutBtn_Click(object sender, EventArgs e)
        {
            HttpContext.Current.GetOwinContext().Authentication.SignOut(
             CookieAuthenticationDefaults.AuthenticationType,
                 OpenIdConnectAuthenticationDefaults.AuthenticationType

            );
        }
    }
}