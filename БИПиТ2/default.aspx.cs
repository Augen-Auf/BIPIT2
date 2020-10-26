using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading;

namespace БИПиТ2
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ScriptManager.ScriptResourceMapping.AddDefinition("jquery", new ScriptResourceDefinition
            {
                Path = "~/Content/Js/jquery-3.2.1.min.js",
            });
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            WebService obj = new WebService();
            if (Page.IsValid)
                total.Text = "Результат: " + obj.Calculate(Convert.ToDouble(N.Text), Convert.ToInt32(M.Text));
        }
       
        protected void CustomValidator2_ServerValidate(object source, ServerValidateEventArgs args)
        {
            try
            {
                args.IsValid = Convert.ToDouble(N.Text) >= 0;
            }

            catch
            {
                args.IsValid = false;
            }
        }

        protected void CustomValidator3_ServerValidate(object source, ServerValidateEventArgs args)
        {
            try
            {
                args.IsValid = Convert.ToDouble(M.Text) >= 0;
            }

            catch
            {
                args.IsValid = false;
            }
        }
    }
}