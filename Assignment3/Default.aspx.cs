using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment3
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblTitle.Text = "Enter a number less than 15:";
        }
        // Logic for factorial button
        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                int factorial = 1;
                // Convert input type to integer
                int input = Convert.ToInt32(txtInput.Text);
                if (input < 15)
                {
                    // For loop to calculate factorial
                    for (int i = 1; i <= input; i++)
                    {
                        factorial = factorial * i;
                    }
                    // Print factorial in label
                    lblAnswer.Text = "The factorial is " + factorial;
                }
                else
                {
                    // Popup for numbers entered greater than 15
                    ClientScript.RegisterStartupScript(this.GetType(), "Alert", "alert('" + " The number entered must be less than 15" + "');", true);
                }
            }
            catch (Exception)
            {
                // Runtime exception handling for invalid input
                ClientScript.RegisterStartupScript(this.GetType(), "Alert", "alert('" + "Invalid Input, please try again." + "');", true);
            }
        }
    }
}