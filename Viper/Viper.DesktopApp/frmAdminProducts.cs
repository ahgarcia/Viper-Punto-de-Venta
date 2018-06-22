﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace Viper.DesktopApp
{
    public partial class frmAdminProducts : Form
    {
        RadButton objButton = null;

        public frmAdminProducts()
        {
            InitializeComponent();
        }

        public void Button_Click(Object sender, EventArgs args)
        {
            objButton = (RadButton)sender;

            switch(objButton.Name)
            {
                case "btnAgregar":
                    frmAddProduct form = new frmAddProduct();
                    form.ShowDialog();
                    form.TopMost = true;
                    break;
            }
        }
    }
}