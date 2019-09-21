namespace wfaVendas_Heloisa_Silvio
{
    partial class FrmItemCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmItemCompra));
            this.txtDescrição = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cmbProduto = new Bunifu.Framework.UI.BunifuDropdown();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNumCompra = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.nudQuantidade = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrecoUnit = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsubTotal = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnOk = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCancelar = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDescrição
            // 
            this.txtDescrição.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescrição.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtDescrição.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDescrição.HintForeColor = System.Drawing.Color.Empty;
            this.txtDescrição.HintText = "";
            this.txtDescrição.isPassword = false;
            this.txtDescrição.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtDescrição.LineIdleColor = System.Drawing.Color.Gray;
            this.txtDescrição.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtDescrição.LineThickness = 3;
            this.txtDescrição.Location = new System.Drawing.Point(246, 94);
            this.txtDescrição.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescrição.Name = "txtDescrição";
            this.txtDescrição.Size = new System.Drawing.Size(381, 44);
            this.txtDescrição.TabIndex = 55;
            this.txtDescrição.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cmbProduto
            // 
            this.cmbProduto.BackColor = System.Drawing.Color.Transparent;
            this.cmbProduto.BorderRadius = 3;
            this.cmbProduto.ForeColor = System.Drawing.Color.White;
            this.cmbProduto.Items = new string[0];
            this.cmbProduto.Location = new System.Drawing.Point(161, 84);
            this.cmbProduto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbProduto.Name = "cmbProduto";
            this.cmbProduto.NomalColor = System.Drawing.Color.DarkViolet;
            this.cmbProduto.onHoverColor = System.Drawing.Color.DarkViolet;
            this.cmbProduto.selectedIndex = -1;
            this.cmbProduto.Size = new System.Drawing.Size(74, 54);
            this.cmbProduto.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 21);
            this.label1.TabIndex = 53;
            this.label1.Text = "Produto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(60, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 21);
            this.label6.TabIndex = 52;
            this.label6.Text = "Compra:";
            // 
            // txtNumCompra
            // 
            this.txtNumCompra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumCompra.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNumCompra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNumCompra.HintForeColor = System.Drawing.Color.Empty;
            this.txtNumCompra.HintText = "";
            this.txtNumCompra.isPassword = false;
            this.txtNumCompra.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtNumCompra.LineIdleColor = System.Drawing.Color.Gray;
            this.txtNumCompra.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtNumCompra.LineThickness = 3;
            this.txtNumCompra.Location = new System.Drawing.Point(161, 13);
            this.txtNumCompra.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumCompra.Name = "txtNumCompra";
            this.txtNumCompra.Size = new System.Drawing.Size(164, 44);
            this.txtNumCompra.TabIndex = 51;
            this.txtNumCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 21);
            this.label2.TabIndex = 57;
            this.label2.Text = "Quantidade:";
            // 
            // nudQuantidade
            // 
            this.nudQuantidade.Location = new System.Drawing.Point(161, 175);
            this.nudQuantidade.Name = "nudQuantidade";
            this.nudQuantidade.Size = new System.Drawing.Size(74, 26);
            this.nudQuantidade.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 21);
            this.label3.TabIndex = 60;
            this.label3.Text = "Preço Unitário:";
            // 
            // txtPrecoUnit
            // 
            this.txtPrecoUnit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrecoUnit.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPrecoUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPrecoUnit.HintForeColor = System.Drawing.Color.Empty;
            this.txtPrecoUnit.HintText = "";
            this.txtPrecoUnit.isPassword = false;
            this.txtPrecoUnit.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtPrecoUnit.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPrecoUnit.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtPrecoUnit.LineThickness = 3;
            this.txtPrecoUnit.Location = new System.Drawing.Point(161, 230);
            this.txtPrecoUnit.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecoUnit.Name = "txtPrecoUnit";
            this.txtPrecoUnit.Size = new System.Drawing.Size(164, 44);
            this.txtPrecoUnit.TabIndex = 59;
            this.txtPrecoUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 21);
            this.label4.TabIndex = 62;
            this.label4.Text = "Sub Total:";
            // 
            // txtsubTotal
            // 
            this.txtsubTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsubTotal.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtsubTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtsubTotal.HintForeColor = System.Drawing.Color.Empty;
            this.txtsubTotal.HintText = "";
            this.txtsubTotal.isPassword = false;
            this.txtsubTotal.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtsubTotal.LineIdleColor = System.Drawing.Color.Gray;
            this.txtsubTotal.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtsubTotal.LineThickness = 3;
            this.txtsubTotal.Location = new System.Drawing.Point(161, 309);
            this.txtsubTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtsubTotal.Name = "txtsubTotal";
            this.txtsubTotal.Size = new System.Drawing.Size(164, 44);
            this.txtsubTotal.TabIndex = 61;
            this.txtsubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnOk
            // 
            this.btnOk.Activecolor = System.Drawing.Color.DarkViolet;
            this.btnOk.BackColor = System.Drawing.Color.DarkViolet;
            this.btnOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOk.BorderRadius = 0;
            this.btnOk.ButtonText = "OK";
            this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOk.DisabledColor = System.Drawing.Color.Gray;
            this.btnOk.Iconcolor = System.Drawing.Color.Transparent;
            this.btnOk.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnOk.Iconimage")));
            this.btnOk.Iconimage_right = null;
            this.btnOk.Iconimage_right_Selected = null;
            this.btnOk.Iconimage_Selected = null;
            this.btnOk.IconMarginLeft = 0;
            this.btnOk.IconMarginRight = 0;
            this.btnOk.IconRightVisible = true;
            this.btnOk.IconRightZoom = 0D;
            this.btnOk.IconVisible = true;
            this.btnOk.IconZoom = 90D;
            this.btnOk.IsTab = false;
            this.btnOk.Location = new System.Drawing.Point(307, 399);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOk.Name = "btnOk";
            this.btnOk.Normalcolor = System.Drawing.Color.DarkViolet;
            this.btnOk.OnHovercolor = System.Drawing.Color.DarkViolet;
            this.btnOk.OnHoverTextColor = System.Drawing.Color.White;
            this.btnOk.selected = false;
            this.btnOk.Size = new System.Drawing.Size(135, 65);
            this.btnOk.TabIndex = 63;
            this.btnOk.Text = "OK";
            this.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOk.Textcolor = System.Drawing.Color.White;
            this.btnOk.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnCancelar
            // 
            this.btnCancelar.Activecolor = System.Drawing.Color.DarkViolet;
            this.btnCancelar.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.btnCancelar.BackColor = System.Drawing.Color.DarkViolet;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.BorderRadius = 0;
            this.btnCancelar.ButtonText = "Cancelar";
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.DisabledColor = System.Drawing.Color.Gray;
            this.btnCancelar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCancelar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Iconimage")));
            this.btnCancelar.Iconimage_right = null;
            this.btnCancelar.Iconimage_right_Selected = null;
            this.btnCancelar.Iconimage_Selected = null;
            this.btnCancelar.IconMarginLeft = 0;
            this.btnCancelar.IconMarginRight = 0;
            this.btnCancelar.IconRightVisible = true;
            this.btnCancelar.IconRightZoom = 0D;
            this.btnCancelar.IconVisible = true;
            this.btnCancelar.IconZoom = 90D;
            this.btnCancelar.IsTab = false;
            this.btnCancelar.Location = new System.Drawing.Point(450, 399);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Normalcolor = System.Drawing.Color.DarkViolet;
            this.btnCancelar.OnHovercolor = System.Drawing.Color.DarkViolet;
            this.btnCancelar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCancelar.selected = false;
            this.btnCancelar.Size = new System.Drawing.Size(177, 65);
            this.btnCancelar.TabIndex = 64;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Textcolor = System.Drawing.Color.White;
            this.btnCancelar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // FrmItemCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(678, 504);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtsubTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrecoUnit);
            this.Controls.Add(this.nudQuantidade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescrição);
            this.Controls.Add(this.cmbProduto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNumCompra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmItemCompra";
            this.Text = "FrmItemCompra";
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDescrição;
        private Bunifu.Framework.UI.BunifuDropdown cmbProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNumCompra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudQuantidade;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPrecoUnit;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtsubTotal;
        private Bunifu.Framework.UI.BunifuFlatButton btnOk;
        private Bunifu.Framework.UI.BunifuFlatButton btnCancelar;
    }
}