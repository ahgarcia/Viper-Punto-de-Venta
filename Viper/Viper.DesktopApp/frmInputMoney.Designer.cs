﻿namespace Viper.DesktopApp
{
    partial class frmInputMoney
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInputMoney));
            this.tlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.tlpCenter = new System.Windows.Forms.TableLayoutPanel();
            this.tlpCentro = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblComentarios = new System.Windows.Forms.Label();
            this.Cantidad = new Telerik.WinControls.UI.RadTextBox();
            this.Comentarios = new Telerik.WinControls.UI.RadTextBox();
            this.lstEntradasEfectivo = new Telerik.WinControls.UI.RadListView();
            this.btnGuardar = new Telerik.WinControls.UI.RadButton();
            this.btnCancelar = new Telerik.WinControls.UI.RadButton();
            this.picLogotipoApp = new System.Windows.Forms.PictureBox();
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            this.tlpPrincipal.SuspendLayout();
            this.tlpCenter.SuspendLayout();
            this.tlpCentro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Comentarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstEntradasEfectivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogotipoApp)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.BackColor = System.Drawing.SystemColors.Window;
            this.tlpPrincipal.ColumnCount = 1;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.Controls.Add(this.tlpCenter, 0, 1);
            this.tlpPrincipal.Controls.Add(this.picLogotipoApp, 0, 0);
            this.tlpPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tlpPrincipal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 2;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.30262F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.60648F));
            this.tlpPrincipal.Size = new System.Drawing.Size(1152, 768);
            this.tlpPrincipal.TabIndex = 1;
            // 
            // tlpCenter
            // 
            this.tlpCenter.BackColor = System.Drawing.SystemColors.Window;
            this.tlpCenter.ColumnCount = 1;
            this.tlpCenter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpCenter.Controls.Add(this.tlpCentro, 0, 0);
            this.tlpCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCenter.Location = new System.Drawing.Point(4, 167);
            this.tlpCenter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tlpCenter.Name = "tlpCenter";
            this.tlpCenter.RowCount = 1;
            this.tlpCenter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCenter.Size = new System.Drawing.Size(1144, 597);
            this.tlpCenter.TabIndex = 5;
            // 
            // tlpCentro
            // 
            this.tlpCentro.AutoSize = true;
            this.tlpCentro.ColumnCount = 4;
            this.tlpCentro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpCentro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpCentro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpCentro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpCentro.Controls.Add(this.lblTitulo, 0, 0);
            this.tlpCentro.Controls.Add(this.lblCantidad, 0, 1);
            this.tlpCentro.Controls.Add(this.lblComentarios, 0, 3);
            this.tlpCentro.Controls.Add(this.Cantidad, 0, 2);
            this.tlpCentro.Controls.Add(this.Comentarios, 0, 4);
            this.tlpCentro.Controls.Add(this.lstEntradasEfectivo, 2, 0);
            this.tlpCentro.Controls.Add(this.btnGuardar, 0, 5);
            this.tlpCentro.Controls.Add(this.btnCancelar, 1, 5);
            this.tlpCentro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCentro.Location = new System.Drawing.Point(4, 4);
            this.tlpCentro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tlpCentro.Name = "tlpCentro";
            this.tlpCentro.RowCount = 6;
            this.tlpCentro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpCentro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpCentro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpCentro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpCentro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpCentro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpCentro.Size = new System.Drawing.Size(1136, 589);
            this.tlpCentro.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Azure;
            this.tlpCentro.SetColumnSpan(this.lblTitulo, 2);
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(4, 0);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(672, 98);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "ENTRADA DE EFECTIVO";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(4, 98);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(332, 98);
            this.lblCantidad.TabIndex = 3;
            this.lblCantidad.Text = "Cantidad:";
            this.lblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblComentarios
            // 
            this.lblComentarios.AutoSize = true;
            this.lblComentarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblComentarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComentarios.Location = new System.Drawing.Point(4, 294);
            this.lblComentarios.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComentarios.Name = "lblComentarios";
            this.lblComentarios.Size = new System.Drawing.Size(332, 98);
            this.lblComentarios.TabIndex = 4;
            this.lblComentarios.Text = "Comentarios:";
            this.lblComentarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSize = false;
            this.Cantidad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cantidad.Location = new System.Drawing.Point(4, 200);
            this.Cantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.NullText = "$ 0.00";
            this.Cantidad.Size = new System.Drawing.Size(332, 90);
            this.Cantidad.TabIndex = 5;
            this.Cantidad.ThemeName = "VisualStudio2012Light";
            // 
            // Comentarios
            // 
            this.Comentarios.AutoSize = false;
            this.Comentarios.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tlpCentro.SetColumnSpan(this.Comentarios, 2);
            this.Comentarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Comentarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Comentarios.Location = new System.Drawing.Point(4, 396);
            this.Comentarios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Comentarios.Multiline = true;
            this.Comentarios.Name = "Comentarios";
            this.Comentarios.NullText = "Escriba un comentario sobre la entrada";
            this.Comentarios.ShowNullText = true;
            this.Comentarios.Size = new System.Drawing.Size(672, 90);
            this.Comentarios.TabIndex = 6;
            this.Comentarios.ThemeName = "VisualStudio2012Light";
            // 
            // lstEntradasEfectivo
            // 
            this.tlpCentro.SetColumnSpan(this.lstEntradasEfectivo, 2);
            this.lstEntradasEfectivo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstEntradasEfectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstEntradasEfectivo.GroupIndent = 34;
            this.lstEntradasEfectivo.GroupItemSize = new System.Drawing.Size(267, 25);
            this.lstEntradasEfectivo.HeaderHeight = 43.07692F;
            this.lstEntradasEfectivo.ItemSize = new System.Drawing.Size(267, 25);
            this.lstEntradasEfectivo.Location = new System.Drawing.Point(684, 4);
            this.lstEntradasEfectivo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstEntradasEfectivo.Name = "lstEntradasEfectivo";
            this.tlpCentro.SetRowSpan(this.lstEntradasEfectivo, 6);
            this.lstEntradasEfectivo.Size = new System.Drawing.Size(448, 581);
            this.lstEntradasEfectivo.TabIndex = 7;
            this.lstEntradasEfectivo.ThemeName = "VisualStudio2012Light";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(4, 494);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(332, 91);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.ThemeName = "VisualStudio2012Light";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Red;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(344, 494);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(332, 91);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.ThemeName = "VisualStudio2012Light";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // picLogotipoApp
            // 
            this.picLogotipoApp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picLogotipoApp.Image = ((System.Drawing.Image)(resources.GetObject("picLogotipoApp.Image")));
            this.picLogotipoApp.Location = new System.Drawing.Point(4, 4);
            this.picLogotipoApp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picLogotipoApp.Name = "picLogotipoApp";
            this.picLogotipoApp.Size = new System.Drawing.Size(1144, 155);
            this.picLogotipoApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogotipoApp.TabIndex = 2;
            this.picLogotipoApp.TabStop = false;
            // 
            // frmInputMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 768);
            this.ControlBox = false;
            this.Controls.Add(this.tlpPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInputMoney";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmInputMoney";
            this.tlpPrincipal.ResumeLayout(false);
            this.tlpCenter.ResumeLayout(false);
            this.tlpCenter.PerformLayout();
            this.tlpCentro.ResumeLayout(false);
            this.tlpCentro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Comentarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstEntradasEfectivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogotipoApp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.TableLayoutPanel tlpCenter;
        private System.Windows.Forms.TableLayoutPanel tlpCentro;
        private System.Windows.Forms.Label lblTitulo;
        private Telerik.WinControls.UI.RadButton btnGuardar;
        private Telerik.WinControls.UI.RadButton btnCancelar;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblComentarios;
        private Telerik.WinControls.UI.RadTextBox Cantidad;
        private Telerik.WinControls.UI.RadTextBox Comentarios;
        private Telerik.WinControls.UI.RadListView lstEntradasEfectivo;
        private System.Windows.Forms.PictureBox picLogotipoApp;
        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
    }
}