using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JenkinsNetApps
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void OnAction(object sender, EventArgs e)
        {
            btn.Text = "Button was clicked";
        }

        public class Calculator
        {
            private int number1 { get; set; }
            private int number2 { get; set; }
            public int Add(int number1,int number2)
            {

                return number1 + number2;
            }
        }
    }
}