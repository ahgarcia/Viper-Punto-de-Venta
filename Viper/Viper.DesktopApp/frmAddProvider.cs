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
using Viper.BusinessEntities;

namespace Viper.DesktopApp
{
    public partial class frmAddProvider : Form
    {
        #region Variables and Objects of class
        RadButton objButton = null;
        String rutaLogotipo = String.Empty;
        public int idSup;
        #endregion

        #region Constructor
        public frmAddProvider()
        {
            InitializeComponent();
        }
        public frmAddProvider(int idSup)
        {
            this.idSup = idSup;
            InitializeComponent();
            cargarTextbox();
        }
        #endregion

        #region Events of the controls
        public void Button_Click(Object sender, EventArgs args)
        {
            objButton = (RadButton)sender;

            switch (objButton.Name)
            {
                case "btnAceptar":
                    aceptar();
                    break;

                case "btnAceptarFiscal":
                    aceptarFiscal();
                    break;
                case "btnBuscar":
                    buscar();
                    break;
                case "btnExaminar":
                    examinar();
                    break;


            }
        }

        private void frmAddProvider_Load(object sender, EventArgs e)
        {
            fillDropDownList();
            this.btnAceptar.KeyPress += Button_Click;
            this.btnAceptarFiscal.KeyPress += Button_Click;
            this.btnBuscar.KeyPress += Button_Click;
            this.btnExaminar.KeyPress += Button_Click;
            this.Nombre.KeyPress += OnlyLetters_KeyPress;
            this.Correo.KeyPress += OnlyLettersAndNumbers_KeyPress;
            this.Web.KeyPress += OnlyLettersAndNumbers_KeyPress;
            this.Telefono.KeyPress += OnlyNumbers_KeyPress;
            this.Celular.KeyPress += OnlyNumbers_KeyPress;
            this.Vialidad.KeyPress += OnlyLettersAndNumbers_KeyPress;
            this.Código_Postal.KeyPress += OnlyNumbers_KeyPress;
            this.No_Interior.KeyPress += OnlyLettersAndNumbers_KeyPress;
            this.No_Exterior.KeyPress += OnlyLettersAndNumbers_KeyPress;
            this.Colonia.KeyPress += OnlyLettersAndNumbers_KeyPress;
            this.Razón_Social_Fiscal.KeyPress += OnlyLettersAndNumbers_KeyPress;
            this.RFC_Fiscal.KeyPress += OnlyLettersAndNumbers_KeyPress;
            this.CURP_Fiscal.KeyPress += OnlyLettersAndNumbers_KeyPress;
            this.Calle_Fiscal.KeyPress += OnlyLettersAndNumbers_KeyPress;
            this.Número_Exterior_Fiscal.KeyPress += OnlyLettersAndNumbers_KeyPress;
            this.Número_Interior_Fiscal.KeyPress += OnlyLettersAndNumbers_KeyPress;
            this.Colonia.KeyPress += OnlyLettersAndNumbers_KeyPress;
            this.Codigo_Postal_Fiscal.KeyPress += OnlyNumbers_KeyPress;

        }

        private void OnlyNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }

            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void OnlyLetters_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void OnlyLettersAndNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }
        #endregion

        #region Methods of the class
        private void cargarTextbox()
        {
            List<Supplier> lista = new List<Supplier>();
            lista = BusinessLogicLayer.AccesoBDBLL.getSupplierId(idSup);
            Nombre.Text = lista[0].ContactName;
            Correo.Text = lista[0].EmailAddress;
            Telefono.Text = lista[0].PhoneNumber;
            Celular.Text = lista[0].CellphoneNumber;
            //direccion

            //facturacion
            Razón_Social_Fiscal.Text = lista[0].CompanyName;
            RFC_Fiscal.Text = lista[0].RFC;
            CURP_Fiscal.Text = lista[0].CURP;
        }
        private void examinar()
        {
            OpenFileDialog BuscarImagen = new OpenFileDialog();
            BuscarImagen.Filter = ".bmp;*.gif;*.jpg;*.png|*.bmp;*.gif;*.jpg;*.png|Imagen Jpg(*.jpg)|*.jpg|Imagen PNG(*.png)|*.png|Imagen Gif(*.gif*)|*.gif";
            BuscarImagen.FileName = "";
            BuscarImagen.Title = "Examinar Imagen";
            if (BuscarImagen.ShowDialog() == DialogResult.OK)
            {
                rutaLogotipo = BuscarImagen.FileName;
                String Direccion = BuscarImagen.FileName;
                picImageProvider.ImageLocation = Direccion;
                picImageProvider.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        private void aceptar()
        {
            Supplier s = new Supplier();
            s.SupplierKey = Clave_Del_Proveedor.Text;
            s.ContactName = Nombre.Text;
            s.EmailAddress = Correo.Text;
            s.PhoneNumber = Telefono.Text;
            s.CellphoneNumber = Celular.Text;
            s.CompanyName = Razón_Social_Fiscal.Text;
            s.RFC = RFC_Fiscal.Text;
            s.CURP = CURP_Fiscal.Text;

            Address add = new Address();
            add.AddressTypeId = Convert.ToInt32(cboTipoDeInmueble.SelectedValue);
            add.RoadTypeId = Convert.ToInt32(cboTipDeVialidad.SelectedValue);
            add.PostalCode = Código_Postal.Text;
            add.AddressLine1 = Vialidad.Text.Trim() + ", " + No_Exterior.Text.Trim() + ", " + Colonia.Text.Trim();
            add.AddressLine2 = No_Interior.Text.Trim();
            add.StateProvinceId = Convert.ToInt32(cboEstado.SelectedValue);
            add.CityId = Convert.ToInt32(cboLocalidad.SelectedValue);

            AddressSAT ads = new AddressSAT();
            ads.RoadTypeId = Convert.ToInt32(cboTipDeVialidad.SelectedValue);
            ads.AddressTypeId = Convert.ToInt32(cboTipoDeInmueble.SelectedValue);
            ads.AddressLine1 = Número_Exterior_Fiscal.Text.Trim();
            ads.AddressLine2 = Número_Interior_Fiscal.Text.Trim();
            //ads.CountryRegionId = Convert.ToInt32(cbo.SelectedValue);
            ads.StateProvinceId = Convert.ToInt32(cboEstado_Fiscal.SelectedValue);
            ads.CityId = Convert.ToInt32(cboMunicipio_Fiscal.SelectedValue);
            ads.PostalCode = Codigo_Postal_Fiscal.Text.Trim();

            string msg = BusinessLogicLayer.AccesoBDBLL.insertSup(s, add, ads);
            if (msg == "")
            {
                MessageBox.Show("Proveedor agregado correctamente");
            }
            else
            {
                MessageBox.Show(msg);
            }

        }

        private void aceptarFiscal()
        {

        }

        private void buscar()
        {

        }

        private void fillDropDownList()
        {
            //cargar en combobox los tipos de inmueble por medio del metodo correspondiente
            //NOTA: POR ALGUNA RAZON NO FUNCIONA EL METODO SI HAY UN CAMPO NULO
            cboTipoDeInmueble.DataSource = BusinessLogicLayer.DropDownListHelperBLL.GetAddressTypeDropDownList();
            cboTipoDeInmueble.DisplayMember = "Name";
            cboTipoDeInmueble.ValueMember = "Id";

            //cargar en combobo los tipos de vialidad
            //NOTA: POR ALGUNA RAZON NO FUNCIONA EL METODO SI HAY UN CAMPO NULO
            cboTipDeVialidad.DataSource = BusinessLogicLayer.DropDownListHelperBLL.GetRoadTypeDropDownList();
            cboTipDeVialidad.DisplayMember = "Name";
            cboTipDeVialidad.ValueMember = "Id";

            //cargar en combobox los estados por medio del metodo correspondiente
            cboEstado.DataSource = BusinessLogicLayer.DropDownListHelperBLL.GetStateProvinceDropDownList(); ;
            cboEstado.DisplayMember = "Description";
            cboEstado.ValueMember = "Id";

            cboEstado_Fiscal.DataSource = BusinessLogicLayer.DropDownListHelperBLL.GetStateProvinceDropDownList();
            cboEstado_Fiscal.DisplayMember = "Description";
            cboEstado_Fiscal.ValueMember = "Id";


            cboPaís_Fiscal.DataSource = BusinessLogicLayer.DropDownListHelperBLL.GetCountryDropDownList();
            cboPaís_Fiscal.DisplayMember = "Description";
            cboPaís_Fiscal.ValueMember = "Id";

            //poner el indice cero por defecto en los combobox
            cboTipoDeInmueble.SelectedIndex = 0;
            cboTipDeVialidad.SelectedIndex = 0;
            cboEstado.SelectedIndex = 0;
            cboLocalidad.SelectedIndex = 0;
            cboPaís_Fiscal.SelectedIndex = 0;
            cboEstado_Fiscal.SelectedIndex = 0;
            cboMunicipio_Fiscal.SelectedIndex = 0;

        }
        #endregion

        #region CONTROLAR TABORDER

        // TAB DE WEB A TELEFONO
        private void Web_Leave(object sender, EventArgs e)
        {
            Telefono.Focus();
        }


        // TAB DE CELULAR A BTNEXAMINAR
        private void Celular_Leave(object sender, EventArgs e)
        {
            btnExaminar.Focus();
        }


        // TAB DE CODIGO POSTAL A NUMERO EXTERIOR
        private void Código_Postal_Leave(object sender, EventArgs e)
        {
            No_Exterior.Focus();
        }

        // TAB DE NUMERO EXTERIOR A NUMERO INTERIOR
        private void No_Ext_Leave(object sender, EventArgs e)
        {
            No_Interior.Focus();
        }

        // TAB DE NUMERO INTERIOR A COLONIA
        private void No_Int_Leave(object sender, EventArgs e)
        {
            Colonia.Focus();
        }

        // TAB ORDER DE BOTON EXAMINAR A CBOTIPODEINMUEBLE
        private void btnExaminar_Leave(object sender, EventArgs e)
        {
            cboTipoDeInmueble.Focus();
        }

        // TAB ORDER DE CBOESTADO A CBOLOCALIDAD
        private void cboEstado_Leave(object sender, EventArgs e)
        {
            cboLocalidad.Focus();
        }

        //TAB ORDER DE LOCALIDAD A BTNACEPTAR
        private void cboLocalidad_Leave(object sender, EventArgs e)
        {
            btnAceptar.Focus();
        }

        //TAB ORDER DE VIALIDAD A CODIGO POSTAL
        private void Vialidad_Leave(object sender, EventArgs e)
        {
            Código_Postal.Focus();
        }




        #endregion

    }
}
