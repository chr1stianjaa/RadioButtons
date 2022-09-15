﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RadioButtons
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            if (pencilRadioButton.Checked)
            {
                resultLabel.Text = "You selected Pencil";
            }

            else if (penRadioButton.Checked)
            {
                resultLabel.Text = "You selected Pen";
            }

            else if (phoneRadioButton.Checked)
            {
                resultLabel.Text = "You selected Phone";
            }

            else if (tabletRadioButton.Checked)
            {
                resultLabel.Text = "You selected Tablet";
            }

            else
            {
                resultLabel.Text = "Please select an option";
            }
        }
    }
}