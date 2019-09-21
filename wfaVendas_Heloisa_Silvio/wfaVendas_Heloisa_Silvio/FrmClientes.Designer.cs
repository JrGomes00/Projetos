namespace wfaVendas_Heloisa_Silvio
{
    partial class FrmClientes
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClientes));
            this.txtCodigo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCidade = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEndereco = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuMaterialTextbox5 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnPesquisar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCancelar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnGravar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAlterar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnExcluir = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnIncluir = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnSair = new Bunifu.Framework.UI.BunifuImageButton();
            this.label5 = new System.Windows.Forms.Label();
            this.mskUf = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.mskCep = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBairro = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dtpDataNasc = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.mskTelefone = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodigo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCodigo.HintForeColor = System.Drawing.Color.Empty;
            this.txtCodigo.HintText = "";
            this.txtCodigo.isPassword = false;
            this.txtCodigo.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtCodigo.LineIdleColor = System.Drawing.Color.Gray;
            this.txtCodigo.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtCodigo.LineThickness = 3;
            this.txtCodigo.Location = new System.Drawing.Point(147, 72);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(105, 44);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código:";
            // 
            // txtNome
            // 
            this.txtNome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNome.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNome.HintForeColor = System.Drawing.Color.Empty;
            this.txtNome.HintText = "";
            this.txtNome.isPassword = false;
            this.txtNome.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtNome.LineIdleColor = System.Drawing.Color.Gray;
            this.txtNome.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtNome.LineThickness = 3;
            this.txtNome.Location = new System.Drawing.Point(147, 131);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(510, 44);
            this.txtNome.TabIndex = 2;
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cidade:";
            // 
            // txtCidade
            // 
            this.txtCidade.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCidade.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCidade.HintForeColor = System.Drawing.Color.Empty;
            this.txtCidade.HintText = "";
            this.txtCidade.isPassword = false;
            this.txtCidade.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtCidade.LineIdleColor = System.Drawing.Color.Gray;
            this.txtCidade.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtCidade.LineThickness = 3;
            this.txtCidade.Location = new System.Drawing.Point(147, 259);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(4);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(274, 44);
            this.txtCidade.TabIndex = 6;
            this.txtCidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Endereço:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEndereco.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtEndereco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEndereco.HintForeColor = System.Drawing.Color.Empty;
            this.txtEndereco.HintText = "";
            this.txtEndereco.isPassword = false;
            this.txtEndereco.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtEndereco.LineIdleColor = System.Drawing.Color.Gray;
            this.txtEndereco.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtEndereco.LineThickness = 3;
            this.txtEndereco.Location = new System.Drawing.Point(147, 193);
            this.txtEndereco.Margin = new System.Windows.Forms.Padding(4);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(510, 44);
            this.txtEndereco.TabIndex = 4;
            this.txtEndereco.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuMaterialTextbox5
            // 
            this.bunifuMaterialTextbox5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox5.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox5.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox5.HintText = "";
            this.bunifuMaterialTextbox5.isPassword = false;
            this.bunifuMaterialTextbox5.LineFocusedColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox5.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox5.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox5.LineThickness = 3;
            this.bunifuMaterialTextbox5.Location = new System.Drawing.Point(-188, -60);
            this.bunifuMaterialTextbox5.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox5.Name = "bunifuMaterialTextbox5";
            this.bunifuMaterialTextbox5.Size = new System.Drawing.Size(370, 44);
            this.bunifuMaterialTextbox5.TabIndex = 8;
            this.bunifuMaterialTextbox5.Text = "bunifuMaterialTextbox5";
            this.bunifuMaterialTextbox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.btnPesquisar);
            this.bunifuGradientPanel1.Controls.Add(this.btnCancelar);
            this.bunifuGradientPanel1.Controls.Add(this.btnGravar);
            this.bunifuGradientPanel1.Controls.Add(this.btnAlterar);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuMaterialTextbox5);
            this.bunifuGradientPanel1.Controls.Add(this.btnExcluir);
            this.bunifuGradientPanel1.Controls.Add(this.btnIncluir);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Purple;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Blue;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.DarkOrchid;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(1275, 50);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(275, 654);
            this.bunifuGradientPanel1.TabIndex = 10;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Activecolor = System.Drawing.Color.Transparent;
            this.btnPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesquisar.BorderRadius = 0;
            this.btnPesquisar.ButtonText = "Pesquisar";
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.DisabledColor = System.Drawing.Color.Gray;
            this.btnPesquisar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPesquisar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Iconimage")));
            this.btnPesquisar.Iconimage_right = null;
            this.btnPesquisar.Iconimage_right_Selected = null;
            this.btnPesquisar.Iconimage_Selected = null;
            this.btnPesquisar.IconMarginLeft = 0;
            this.btnPesquisar.IconMarginRight = 0;
            this.btnPesquisar.IconRightVisible = true;
            this.btnPesquisar.IconRightZoom = 0D;
            this.btnPesquisar.IconVisible = true;
            this.btnPesquisar.IconZoom = 90D;
            this.btnPesquisar.IsTab = false;
            this.btnPesquisar.Location = new System.Drawing.Point(24, 233);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Normalcolor = System.Drawing.Color.Transparent;
            this.btnPesquisar.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnPesquisar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPesquisar.selected = false;
            this.btnPesquisar.Size = new System.Drawing.Size(236, 41);
            this.btnPesquisar.TabIndex = 21;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Textcolor = System.Drawing.Color.White;
            this.btnPesquisar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnCancelar
            // 
            this.btnCancelar.Activecolor = System.Drawing.Color.Transparent;
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
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
            this.btnCancelar.Location = new System.Drawing.Point(24, 436);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Normalcolor = System.Drawing.Color.Transparent;
            this.btnCancelar.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnCancelar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCancelar.selected = false;
            this.btnCancelar.Size = new System.Drawing.Size(236, 41);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Textcolor = System.Drawing.Color.White;
            this.btnCancelar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnGravar
            // 
            this.btnGravar.Activecolor = System.Drawing.Color.Transparent;
            this.btnGravar.BackColor = System.Drawing.Color.Transparent;
            this.btnGravar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGravar.BorderRadius = 0;
            this.btnGravar.ButtonText = "Gravar";
            this.btnGravar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGravar.DisabledColor = System.Drawing.Color.Gray;
            this.btnGravar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGravar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnGravar.Iconimage")));
            this.btnGravar.Iconimage_right = null;
            this.btnGravar.Iconimage_right_Selected = null;
            this.btnGravar.Iconimage_Selected = null;
            this.btnGravar.IconMarginLeft = 0;
            this.btnGravar.IconMarginRight = 0;
            this.btnGravar.IconRightVisible = true;
            this.btnGravar.IconRightZoom = 0D;
            this.btnGravar.IconVisible = true;
            this.btnGravar.IconZoom = 90D;
            this.btnGravar.IsTab = false;
            this.btnGravar.Location = new System.Drawing.Point(24, 385);
            this.btnGravar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Normalcolor = System.Drawing.Color.Transparent;
            this.btnGravar.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnGravar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGravar.selected = false;
            this.btnGravar.Size = new System.Drawing.Size(236, 41);
            this.btnGravar.TabIndex = 15;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGravar.Textcolor = System.Drawing.Color.White;
            this.btnGravar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.Click += new System.EventHandler(this.BtnGravar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Activecolor = System.Drawing.Color.Transparent;
            this.btnAlterar.BackColor = System.Drawing.Color.Transparent;
            this.btnAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAlterar.BorderRadius = 0;
            this.btnAlterar.ButtonText = "Alterar";
            this.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterar.DisabledColor = System.Drawing.Color.Gray;
            this.btnAlterar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAlterar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Iconimage")));
            this.btnAlterar.Iconimage_right = null;
            this.btnAlterar.Iconimage_right_Selected = null;
            this.btnAlterar.Iconimage_Selected = null;
            this.btnAlterar.IconMarginLeft = 0;
            this.btnAlterar.IconMarginRight = 0;
            this.btnAlterar.IconRightVisible = true;
            this.btnAlterar.IconRightZoom = 0D;
            this.btnAlterar.IconVisible = true;
            this.btnAlterar.IconZoom = 90D;
            this.btnAlterar.IsTab = false;
            this.btnAlterar.Location = new System.Drawing.Point(24, 182);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Normalcolor = System.Drawing.Color.Transparent;
            this.btnAlterar.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnAlterar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAlterar.selected = false;
            this.btnAlterar.Size = new System.Drawing.Size(236, 41);
            this.btnAlterar.TabIndex = 13;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.Textcolor = System.Drawing.Color.White;
            this.btnAlterar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Activecolor = System.Drawing.Color.Transparent;
            this.btnExcluir.BackColor = System.Drawing.Color.Transparent;
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcluir.BorderRadius = 0;
            this.btnExcluir.ButtonText = "Excluir";
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.DisabledColor = System.Drawing.Color.Gray;
            this.btnExcluir.Iconcolor = System.Drawing.Color.Transparent;
            this.btnExcluir.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Iconimage")));
            this.btnExcluir.Iconimage_right = null;
            this.btnExcluir.Iconimage_right_Selected = null;
            this.btnExcluir.Iconimage_Selected = null;
            this.btnExcluir.IconMarginLeft = 0;
            this.btnExcluir.IconMarginRight = 0;
            this.btnExcluir.IconRightVisible = true;
            this.btnExcluir.IconRightZoom = 0D;
            this.btnExcluir.IconVisible = true;
            this.btnExcluir.IconZoom = 90D;
            this.btnExcluir.IsTab = false;
            this.btnExcluir.Location = new System.Drawing.Point(24, 131);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Normalcolor = System.Drawing.Color.Transparent;
            this.btnExcluir.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnExcluir.OnHoverTextColor = System.Drawing.Color.White;
            this.btnExcluir.selected = false;
            this.btnExcluir.Size = new System.Drawing.Size(236, 41);
            this.btnExcluir.TabIndex = 12;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Textcolor = System.Drawing.Color.White;
            this.btnExcluir.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnIncluir
            // 
            this.btnIncluir.Activecolor = System.Drawing.Color.Transparent;
            this.btnIncluir.BackColor = System.Drawing.Color.Transparent;
            this.btnIncluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIncluir.BorderRadius = 0;
            this.btnIncluir.ButtonText = "Incluir";
            this.btnIncluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIncluir.DisabledColor = System.Drawing.Color.Gray;
            this.btnIncluir.Iconcolor = System.Drawing.Color.Transparent;
            this.btnIncluir.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnIncluir.Iconimage")));
            this.btnIncluir.Iconimage_right = null;
            this.btnIncluir.Iconimage_right_Selected = null;
            this.btnIncluir.Iconimage_Selected = null;
            this.btnIncluir.IconMarginLeft = 0;
            this.btnIncluir.IconMarginRight = 0;
            this.btnIncluir.IconRightVisible = true;
            this.btnIncluir.IconRightZoom = 0D;
            this.btnIncluir.IconVisible = true;
            this.btnIncluir.IconZoom = 90D;
            this.btnIncluir.IsTab = false;
            this.btnIncluir.Location = new System.Drawing.Point(24, 80);
            this.btnIncluir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Normalcolor = System.Drawing.Color.Transparent;
            this.btnIncluir.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnIncluir.OnHoverTextColor = System.Drawing.Color.White;
            this.btnIncluir.selected = false;
            this.btnIncluir.Size = new System.Drawing.Size(236, 41);
            this.btnIncluir.TabIndex = 11;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIncluir.Textcolor = System.Drawing.Color.White;
            this.btnIncluir.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluir.Click += new System.EventHandler(this.BtnIncluir_Click);
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.Image")));
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.Location = new System.Drawing.Point(1415, 12);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(36, 32);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton3.TabIndex = 20;
            this.bunifuImageButton3.TabStop = false;
            this.bunifuImageButton3.Zoom = 10;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(1457, 12);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(36, 32);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 19;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageActive = null;
            this.btnSair.Location = new System.Drawing.Point(1499, 12);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(36, 32);
            this.btnSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSair.TabIndex = 11;
            this.btnSair.TabStop = false;
            this.btnSair.Zoom = 10;
            this.btnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(860, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 21);
            this.label5.TabIndex = 17;
            this.label5.Text = "UF:";
            // 
            // mskUf
            // 
            this.mskUf.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mskUf.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.mskUf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mskUf.HintForeColor = System.Drawing.Color.Empty;
            this.mskUf.HintText = "";
            this.mskUf.isPassword = false;
            this.mskUf.LineFocusedColor = System.Drawing.Color.Blue;
            this.mskUf.LineIdleColor = System.Drawing.Color.Gray;
            this.mskUf.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.mskUf.LineThickness = 3;
            this.mskUf.Location = new System.Drawing.Point(914, 193);
            this.mskUf.Margin = new System.Windows.Forms.Padding(4);
            this.mskUf.Name = "mskUf";
            this.mskUf.Size = new System.Drawing.Size(102, 44);
            this.mskUf.TabIndex = 16;
            this.mskUf.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(845, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 21);
            this.label6.TabIndex = 15;
            this.label6.Text = "CEP:";
            // 
            // mskCep
            // 
            this.mskCep.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mskCep.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.mskCep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mskCep.HintForeColor = System.Drawing.Color.Empty;
            this.mskCep.HintText = "";
            this.mskCep.isPassword = false;
            this.mskCep.LineFocusedColor = System.Drawing.Color.Blue;
            this.mskCep.LineIdleColor = System.Drawing.Color.Gray;
            this.mskCep.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.mskCep.LineThickness = 3;
            this.mskCep.Location = new System.Drawing.Point(914, 127);
            this.mskCep.Margin = new System.Windows.Forms.Padding(4);
            this.mskCep.Name = "mskCep";
            this.mskCep.Size = new System.Drawing.Size(214, 44);
            this.mskCep.TabIndex = 14;
            this.mskCep.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(59, 349);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 21);
            this.label7.TabIndex = 13;
            this.label7.Text = "Bairro:";
            // 
            // txtBairro
            // 
            this.txtBairro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBairro.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtBairro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBairro.HintForeColor = System.Drawing.Color.Empty;
            this.txtBairro.HintText = "";
            this.txtBairro.isPassword = false;
            this.txtBairro.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtBairro.LineIdleColor = System.Drawing.Color.Gray;
            this.txtBairro.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtBairro.LineThickness = 3;
            this.txtBairro.Location = new System.Drawing.Point(147, 326);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(4);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(370, 44);
            this.txtBairro.TabIndex = 12;
            this.txtBairro.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // dtpDataNasc
            // 
            this.dtpDataNasc.BackColor = System.Drawing.Color.DarkViolet;
            this.dtpDataNasc.BorderRadius = 0;
            this.dtpDataNasc.ForeColor = System.Drawing.Color.White;
            this.dtpDataNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNasc.FormatCustom = null;
            this.dtpDataNasc.Location = new System.Drawing.Point(914, 333);
            this.dtpDataNasc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpDataNasc.Name = "dtpDataNasc";
            this.dtpDataNasc.Size = new System.Drawing.Size(214, 49);
            this.dtpDataNasc.TabIndex = 18;
            this.dtpDataNasc.Value = new System.DateTime(2019, 9, 21, 11, 58, 19, 866);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(756, 349);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 21);
            this.label8.TabIndex = 19;
            this.label8.Text = "Dt. Nascimento:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(805, 282);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 21);
            this.label9.TabIndex = 21;
            this.label9.Text = "Telefone:";
            // 
            // mskTelefone
            // 
            this.mskTelefone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mskTelefone.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.mskTelefone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mskTelefone.HintForeColor = System.Drawing.Color.Empty;
            this.mskTelefone.HintText = "";
            this.mskTelefone.isPassword = false;
            this.mskTelefone.LineFocusedColor = System.Drawing.Color.Blue;
            this.mskTelefone.LineIdleColor = System.Drawing.Color.Gray;
            this.mskTelefone.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.mskTelefone.LineThickness = 3;
            this.mskTelefone.Location = new System.Drawing.Point(914, 259);
            this.mskTelefone.Margin = new System.Windows.Forms.Padding(4);
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(214, 44);
            this.mskTelefone.TabIndex = 20;
            this.mskTelefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(12, 406);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowHeadersWidth = 62;
            this.dgvClientes.RowTemplate.Height = 28;
            this.dgvClientes.Size = new System.Drawing.Size(1251, 286);
            this.dgvClientes.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.bunifuImageButton3);
            this.panel1.Controls.Add(this.bunifuImageButton2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1550, 53);
            this.panel1.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(53, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(254, 28);
            this.label10.TabIndex = 24;
            this.label10.Text = "Cadastro de clientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome:";
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1548, 704);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.mskTelefone);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpDataNasc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mskUf);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mskCep);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCodigo;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNome;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCidade;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtEndereco;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox5;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        private Bunifu.Framework.UI.BunifuFlatButton btnCancelar;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuFlatButton btnGravar;
        private Bunifu.Framework.UI.BunifuFlatButton btnAlterar;
        private Bunifu.Framework.UI.BunifuFlatButton btnExcluir;
        private Bunifu.Framework.UI.BunifuFlatButton btnIncluir;
        private Bunifu.Framework.UI.BunifuImageButton btnSair;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox mskUf;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox mskCep;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtBairro;
        private Bunifu.Framework.UI.BunifuDatepicker dtpDataNasc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuMaterialTextbox mskTelefone;
        private System.Windows.Forms.DataGridView dgvClientes;
        private Bunifu.Framework.UI.BunifuFlatButton btnPesquisar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
    }
}

