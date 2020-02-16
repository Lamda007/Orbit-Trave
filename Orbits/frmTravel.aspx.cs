using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Orbits
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        clsBLL BLL = new clsBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            lblError.Text = "";
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            int Orbit1Max = 18;
            int Orbit2Max = 20;
            int Min = 1;

            int parsedValue = 0;
            //bool isNum = Integer.TryParse(txtOrbit1.Text.Trim(), out num);
            if (txtWeather.Text == "")
            {
                lblError.Text = "Please enter weather Conditions e.g Rainy, Windy or Sunny";
                txtWeather.Focus();
                lblError.ForeColor = System.Drawing.Color.Red;
            }
            else if (!int.TryParse(txtOrbit1.Text, out parsedValue))
            {

                lblError.Text = "Please enter Orbit 1 value, numbers only";
                txtOrbit1.Focus();
                lblError.ForeColor = System.Drawing.Color.Red;
            }
            else if (!int.TryParse(txtOrbit2.Text, out parsedValue))
            {
                lblError.Text = "Please enter Orbit 1 value, numbers only";
                txtOrbit2.Focus();
                lblError.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                if (Convert.ToInt32(txtOrbit1.Text) < Min)
                {
                    lblError.Text = "Plaese enter Quantity Greater than 0 ";
                    txtOrbit1.Focus();
                    lblError.ForeColor = System.Drawing.Color.Red;
                    return;
                }
                else if (Convert.ToInt32(txtOrbit1.Text) > Orbit1Max)
                {
                    lblError.Text = "Plaese enter Quantity less than '" + Orbit1Max + "' ";

                    txtOrbit1.Focus();
                    lblError.ForeColor = System.Drawing.Color.Red;
                    return;
                }

                if (Convert.ToInt32(txtOrbit2.Text) < Min)
                {
                    lblError.Text = "Plaese enter Quantity Greater than 0 ";
                    txtOrbit2.Focus();
                    lblError.ForeColor = System.Drawing.Color.Red;
                    return;
                }
                else if (Convert.ToInt32(txtOrbit2.Text) > Orbit2Max)
                {
                    lblError.Text = "Plaese enter Quantity less than '" + Orbit2Max + "' ";
                    txtOrbit2.Focus();
                    lblError.ForeColor = System.Drawing.Color.Red;
                    return;
                }
                lblError.Text = BLL.Calculate(Convert.ToInt32(txtOrbit1.Text), Convert.ToInt32(txtOrbit2.Text), txtWeather.Text);
                lblError.ForeColor = System.Drawing.Color.Green;
            
            }
            

        }
    }
}