using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Employee
{
    public partial class Employee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
            }
            else
            {
                EmployeeInfo employeeInfo = new EmployeeInfo();
                employeeInfo.ID = Request.Form["id"];
                employeeInfo.Name = Request.Form["name"];
                employeeInfo.Address = Request.Form["address"];
                employeeInfo.City = Request.Form["city"];
                employeeInfo.State = Request.Form["state"];
                //bool result = IsCalifornia(employeeInfo.State);
                bool result = SaveEmployee(employeeInfo); 

                string script = "window.onload = function() { NotCAEmployee('" + result.ToString().ToLower() + "'); };";
                if (!result)
                {                
                    ClientScript.RegisterStartupScript(this.GetType(), "displayalertmessage", script, true);
                }
                else {
                    ClientScript.RegisterStartupScript(this.GetType(), "displayalertmessage", script, true);
                }
            }
        }

        private bool IsCalifornia(string state)
        {
            if (state.ToUpper() == "CA" || state.ToUpper() == "CALIFORNIA")
                return true;
            else
                return false;
        }

        private bool SaveEmployee(EmployeeInfo employeeInfo)
        {
            return IsCalifornia(employeeInfo.State);
        }
    }
}