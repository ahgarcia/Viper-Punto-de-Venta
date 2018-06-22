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
    public partial class frmRegisterCompany : Form
    {
        RadButton objButton = null;

        public frmRegisterCompany()
        {
            InitializeComponent();
        }

        public void Button_Click(Object sender, EventArgs args)
        {
            objButton = (RadButton)sender;

            switch(objButton.Name)
            {
                case "btnRegimenFiscal":
                    frmRegimenFiscal form = new frmRegimenFiscal();
                    form.ShowDialog();
                    form.TopMost = true;
                    break;
            }
        }

        private void frmRegisterCompany_Load(object sender, EventArgs e)
        {
            btnRegimenFiscal.Click += Button_Click;
        }
    }
}
