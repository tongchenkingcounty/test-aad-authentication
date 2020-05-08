using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestADFS
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            var userClaims = User.Identity as System.Security.Claims.ClaimsIdentity;

            Label2.Text = "<table border=1>";
            Label2.Text += "<tr><td>" + userClaims?.FindFirst("name")?.Value + "</td></tr>";
            Label2.Text += "<tr><td>" + userClaims?.FindFirst("preferred_username")?.Value + "</td></tr>";
            Label2.Text += "<tr><td>" + userClaims?.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value + "</td></tr>";
            Label2.Text += "<tr><td>" + userClaims?.FindFirst("http://schemas.microsoft.com/identity/claims/tenantid")?.Value + "</td></tr>";

            Label2.Text += "</table>";

            Label1.Text = "<table border=1>";

            foreach (Claim claim in System.Security.Claims.ClaimsPrincipal.Current.Claims)
            {
                Label1.Text += "<tr><td>" + claim.Type + "</td><td>" + claim.Value + "</td></tr>";
            }

            Label1.Text += "</table>";
        }
    }
}