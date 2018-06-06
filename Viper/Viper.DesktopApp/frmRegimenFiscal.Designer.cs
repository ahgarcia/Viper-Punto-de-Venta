﻿namespace Viper.DesktopApp
{
    partial class frmRegimenFiscal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegimenFiscal));
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.btnAceptar = new Telerik.WinControls.UI.RadButton();
            this.lblRegimenFiscal = new Telerik.WinControls.UI.RadLabel();
            this.gvRegimenFiscal = new Telerik.WinControls.UI.RadGridView();
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            this.picEmpresa = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnAceptar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblRegimenFiscal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRegimenFiscal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRegimenFiscal.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEmpresa)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.Location = new System.Drawing.Point(286, 502);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(230, 48);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAceptar.ThemeName = "VisualStudio2012Light";
            // 
            // lblRegimenFiscal
            // 
            this.lblRegimenFiscal.BackColor = System.Drawing.SystemColors.Control;
            this.lblRegimenFiscal.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegimenFiscal.Location = new System.Drawing.Point(286, 53);
            this.lblRegimenFiscal.Name = "lblRegimenFiscal";
            this.lblRegimenFiscal.Size = new System.Drawing.Size(260, 44);
            this.lblRegimenFiscal.TabIndex = 0;
            this.lblRegimenFiscal.Text = "Régimen Fiscal";
            // 
            // gvRegimenFiscal
            // 
            this.gvRegimenFiscal.Location = new System.Drawing.Point(12, 124);
            // 
            // 
            // 
            this.gvRegimenFiscal.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.gvRegimenFiscal.Name = "gvRegimenFiscal";
            this.gvRegimenFiscal.Size = new System.Drawing.Size(760, 372);
            this.gvRegimenFiscal.TabIndex = 0;
            this.gvRegimenFiscal.Text = "radGridView1";
            this.gvRegimenFiscal.ThemeName = "VisualStudio2012Light";
            // 
            // picEmpresa
            // 
            this.picEmpresa.Image = ((System.Drawing.Image)(resources.GetObject("picEmpresa.Image")));
            this.picEmpresa.Location = new System.Drawing.Point(161, 22);
            this.picEmpresa.Name = "picEmpresa";
            this.picEmpresa.Size = new System.Drawing.Size(98, 75);
            this.picEmpresa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picEmpresa.TabIndex = 7;
            this.picEmpresa.TabStop = false;
            // 
            // frmRegimenFiscal
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.picEmpresa);
            this.Controls.Add(this.lblRegimenFiscal);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.gvRegimenFiscal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRegimenFiscal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Punto de Venta Viper-Owaltek S.A. de C.V.";
            ((System.ComponentModel.ISupportInitialize)(this.btnAceptar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblRegimenFiscal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRegimenFiscal.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRegimenFiscal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEmpresa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Telerik.WinControls.UI.RadButton btnAceptar;
        private Telerik.WinControls.UI.RadLabel lblRegimenFiscal;
        private Telerik.WinControls.UI.RadGridView gvRegimenFiscal;
        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
        private System.Windows.Forms.PictureBox picEmpresa;
    }
}