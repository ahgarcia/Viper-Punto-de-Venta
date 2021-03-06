﻿/*
 * ---------------------------------------------------------
 * LIBRERIAS UTILIZADAS EN EL FORMULARIO "frmRegimenFiscal.cs"
 * ---------------------------------------------------------
 */

#region using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

#endregion

namespace Viper.DesktopApp
{
    /// <summary>
    /// CLASE QUE PERMITE MOSTRAR LOS REGIMENES FISCALES EXISTENTES EN LA 
    /// BASE DE DATOS, PARA PODER SELECCIONAR UNO, Y REGISTRARLO AL MOMENTO
    /// DE ADQUIRIR UNA LICENCIA Y REGISTRAR LOS DATOS DE LA EMPRESA QUE LA
    /// ADQUIRIO
    /// </summary>
    public partial class frmRegimenFiscal : Form
    {
        /*
         * ---------------------------------------------------------
         * VARIABLES, OBJETOS, Y COMPONENTES UTILIZADAS EN EL FORMULARIO "frmRegimenFiscal.cs"
         * ---------------------------------------------------------
         */

        #region Variables, Objetos y Componentes

        string cellValue = String.Empty;

        #endregion

        /*
         * ---------------------------------------------------------
         * CONSTRUCTORES UTILIZADOS EN EL FORMULARIO "frmRegimenFiscal.cs"
         * ---------------------------------------------------------
         */

        #region Constructor

        public frmRegimenFiscal()
        {
            InitializeComponent();
        }

        #endregion

        /*
         * ---------------------------------------------------------
         * EVENTOS UTILIZADOS EN EL FORMULARIO "frmRegimenFiscal.cs"
         * ---------------------------------------------------------
         */

        #region Eventos 

        private void frmRegimenFiscal_Load(object sender, EventArgs e)
        {
            //Set default configuration to UI
            this.AcceptButton = btnAceptar;
            this.AutoSize = true;
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Sistema de Punto de Venta Viper-OwalTek Innovation Solutions";

            btnAceptar.Click += btnAceptar_Click;
            txtRegimen.TextChanged += txtRegimen_TextChanged;
            dgvRegimenFiscal.CellClick += dgvRegimenFiscal_CellClick;

            uploadGridWithRegimenFiscal();

            dgvRegimenFiscal.CambiarAnchoColumnas(dgvRegimenFiscal.Columns.Select(c => c.Name).ToArray(), 85, 7, 7);

            this.ActiveControl = txtRegimen;
            this.txtRegimen.Focus();

            // Create the ToolTip and associate with the Form container.
            ToolTip toolTip1 = new ToolTip();

            // Set up the delays for the ToolTip.
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip1.ShowAlways = true;

            // Set up the ToolTip text for the Button and Checkbox.
            toolTip1.SetToolTip(this.btnAceptar, "Debe seleccionar un regimen de la lista anterior, para poder seguir con el proceso de registro de la compañia");
            toolTip1.SetToolTip(this.txtRegimen, "Para facilitar la busqueda, puede teclear en el siguiente campo para filtrar su busqueda");
            toolTip1.SetToolTip(this.dgvRegimenFiscal, "Para poder continuar con el proceso de registro de la compañia, debe seleccionar un regimen de la lista y dar clic en el boton aceptar");
        }

        private void dgvRegimenFiscal_CellClick(object sender, GridViewCellEventArgs e)
        {
            cellValue = e.Row.Cells["Regimen Fiscal"].Value.ToString();
        }

        private void btnAceptar_Click(Object sender, EventArgs args)
        {
            if (!string.IsNullOrEmpty(cellValue))
            {
                frmRegisterCompany.Regimen_Fiscal.Text = cellValue;
                this.Hide();
            }
            else
            {
                MessageBox.Show(new Form { TopMost = true }, "No se ha seleccionado un regimen fiscal, favor de intentarlo nuevamente", "Sistema de Punto de Venta Viper-OwalTek Innovation Solutions", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                this.ActiveControl = txtRegimen;
                this.txtRegimen.Focus();
            }
        }

        private void txtRegimen_TextChanged(object sender, EventArgs e)
        {
            string filter = txtRegimen.Text.Trim().ToString();

            dgvRegimenFiscal.DataSource = BusinessLogicLayer.CompanyBLL.procGetRegimenFiscalByNameToDataTable(filter);
        }

        #endregion

        /*
         * ---------------------------------------------------------
         * METODOS UTILIZADOS EN EL FORMULARIO "frmRegimenFiscal.cs"
         * ---------------------------------------------------------
         */

        #region Metodos

        private void uploadGridWithRegimenFiscal()
        {
            dgvRegimenFiscal.DataSource = BusinessLogicLayer.CompanyBLL.procGetRegimenFiscalToDataTable();
        }

        #endregion
    }
}
