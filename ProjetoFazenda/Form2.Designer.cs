namespace ProjetoFazenda
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.txtNome = new System.Windows.Forms.TextBox();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.txtProp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRaca = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbEspecie = new System.Windows.Forms.ComboBox();
            this.especieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.especieBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.especieBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtNascimento = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.cbBusca = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSexoBusca = new System.Windows.Forms.Label();
            this.lblBusca1 = new System.Windows.Forms.Label();
            this.lblDataF = new System.Windows.Forms.Label();
            this.cbBuscaSexo = new System.Windows.Forms.ComboBox();
            this.txtBusca1 = new System.Windows.Forms.TextBox();
            this.txtDataFBusca = new System.Windows.Forms.TextBox();
            this.btnBusca = new System.Windows.Forms.Button();
            this.cbBuscaEspecie = new System.Windows.Forms.ComboBox();
            this.lblQtdLinhas = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.especieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.especieBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.especieBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtNome.Location = new System.Drawing.Point(73, 29);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(179, 24);
            this.txtNome.TabIndex = 0;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // cbSexo
            // 
            this.cbSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.cbSexo.Location = new System.Drawing.Point(352, 29);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(154, 26);
            this.cbSexo.TabIndex = 1;
            // 
            // txtProp
            // 
            this.txtProp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProp.Location = new System.Drawing.Point(696, 27);
            this.txtProp.Name = "txtProp";
            this.txtProp.Size = new System.Drawing.Size(185, 24);
            this.txtProp.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(297, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sexo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(581, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Proprietario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(539, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Data Nascimento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Raça:";
            // 
            // txtRaca
            // 
            this.txtRaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRaca.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtRaca.Location = new System.Drawing.Point(73, 78);
            this.txtRaca.Name = "txtRaca";
            this.txtRaca.Size = new System.Drawing.Size(179, 24);
            this.txtRaca.TabIndex = 3;
            this.txtRaca.Text = " ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(276, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Espécie:";
            // 
            // cbEspecie
            // 
            this.cbEspecie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEspecie.FormattingEnabled = true;
            this.cbEspecie.Location = new System.Drawing.Point(352, 78);
            this.cbEspecie.Name = "cbEspecie";
            this.cbEspecie.Size = new System.Drawing.Size(154, 26);
            this.cbEspecie.TabIndex = 4;
            // 
            // btnIncluir
            // 
            this.btnIncluir.BackColor = System.Drawing.Color.Transparent;
            this.btnIncluir.BackgroundImage = global::ProjetoFazenda.Properties.Resources.icons8_Mais_26;
            this.btnIncluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIncluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluir.ForeColor = System.Drawing.Color.Transparent;
            this.btnIncluir.Location = new System.Drawing.Point(732, 123);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(31, 36);
            this.btnIncluir.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btnIncluir, "Inserir");
            this.btnIncluir.UseVisualStyleBackColor = false;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackgroundImage = global::ProjetoFazenda.Properties.Resources.icons8_Editar_48;
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(732, 165);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(31, 35);
            this.btnEditar.TabIndex = 16;
            this.toolTip1.SetToolTip(this.btnEditar, "Editar");
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackgroundImage = global::ProjetoFazenda.Properties.Resources.icons8_Excluir_48;
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(732, 206);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnExcluir.Size = new System.Drawing.Size(31, 34);
            this.btnExcluir.TabIndex = 17;
            this.toolTip1.SetToolTip(this.btnExcluir, "Deletar");
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(12, 122);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Size = new System.Drawing.Size(714, 446);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtNascimento
            // 
            this.txtNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNascimento.Location = new System.Drawing.Point(696, 76);
            this.txtNascimento.Name = "txtNascimento";
            this.txtNascimento.Size = new System.Drawing.Size(149, 24);
            this.txtNascimento.TabIndex = 6;
            this.txtNascimento.Click += new System.EventHandler(this.txtNascimento_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::ProjetoFazenda.Properties.Resources.icons8_Cardápio_64;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(732, 533);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(31, 34);
            this.button2.TabIndex = 20;
            this.toolTip1.SetToolTip(this.button2, "Preencher Grid");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbBusca
            // 
            this.cbBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBusca.FormattingEnabled = true;
            this.cbBusca.Items.AddRange(new object[] {
            "Nome",
            "Sexo",
            "Data Nascimento",
            "Sexo e Data Nascimento",
            "Raça",
            "Proprietário",
            "Espécie"});
            this.cbBusca.Location = new System.Drawing.Point(910, 211);
            this.cbBusca.Name = "cbBusca";
            this.cbBusca.Size = new System.Drawing.Size(191, 26);
            this.cbBusca.TabIndex = 21;
            this.cbBusca.SelectedIndexChanged += new System.EventHandler(this.cbBusca_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(841, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Buscar:";
            // 
            // lblSexoBusca
            // 
            this.lblSexoBusca.AutoSize = true;
            this.lblSexoBusca.BackColor = System.Drawing.Color.Transparent;
            this.lblSexoBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexoBusca.Location = new System.Drawing.Point(855, 361);
            this.lblSexoBusca.Name = "lblSexoBusca";
            this.lblSexoBusca.Size = new System.Drawing.Size(49, 20);
            this.lblSexoBusca.TabIndex = 23;
            this.lblSexoBusca.Text = "Sexo:";
            this.lblSexoBusca.Visible = false;
            // 
            // lblBusca1
            // 
            this.lblBusca1.AutoSize = true;
            this.lblBusca1.BackColor = System.Drawing.Color.Transparent;
            this.lblBusca1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusca1.Location = new System.Drawing.Point(812, 268);
            this.lblBusca1.Name = "lblBusca1";
            this.lblBusca1.Size = new System.Drawing.Size(0, 20);
            this.lblBusca1.TabIndex = 24;
            this.lblBusca1.Visible = false;
            // 
            // lblDataF
            // 
            this.lblDataF.AutoSize = true;
            this.lblDataF.BackColor = System.Drawing.Color.Transparent;
            this.lblDataF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataF.Location = new System.Drawing.Point(818, 315);
            this.lblDataF.Name = "lblDataF";
            this.lblDataF.Size = new System.Drawing.Size(86, 20);
            this.lblDataF.TabIndex = 25;
            this.lblDataF.Text = "Data Final:";
            this.lblDataF.Visible = false;
            // 
            // cbBuscaSexo
            // 
            this.cbBuscaSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBuscaSexo.FormattingEnabled = true;
            this.cbBuscaSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.cbBuscaSexo.Location = new System.Drawing.Point(910, 359);
            this.cbBuscaSexo.Name = "cbBuscaSexo";
            this.cbBuscaSexo.Size = new System.Drawing.Size(191, 26);
            this.cbBuscaSexo.TabIndex = 26;
            this.cbBuscaSexo.Visible = false;
            // 
            // txtBusca1
            // 
            this.txtBusca1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusca1.Location = new System.Drawing.Point(910, 268);
            this.txtBusca1.Name = "txtBusca1";
            this.txtBusca1.Size = new System.Drawing.Size(191, 24);
            this.txtBusca1.TabIndex = 27;
            this.txtBusca1.Visible = false;
            this.txtBusca1.Click += new System.EventHandler(this.txtBusca1_Click);
            // 
            // txtDataFBusca
            // 
            this.txtDataFBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataFBusca.Location = new System.Drawing.Point(910, 313);
            this.txtDataFBusca.Name = "txtDataFBusca";
            this.txtDataFBusca.Size = new System.Drawing.Size(191, 24);
            this.txtDataFBusca.TabIndex = 28;
            this.txtDataFBusca.Visible = false;
            this.txtDataFBusca.Click += new System.EventHandler(this.txtDataFBusca_Click);
            // 
            // btnBusca
            // 
            this.btnBusca.BackgroundImage = global::ProjetoFazenda.Properties.Resources.icons8_Pesquisar_Filled_50;
            this.btnBusca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBusca.Location = new System.Drawing.Point(980, 410);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(37, 27);
            this.btnBusca.TabIndex = 29;
            this.toolTip1.SetToolTip(this.btnBusca, "Buscar");
            this.btnBusca.UseVisualStyleBackColor = true;
            this.btnBusca.Visible = false;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // cbBuscaEspecie
            // 
            this.cbBuscaEspecie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBuscaEspecie.FormattingEnabled = true;
            this.cbBuscaEspecie.Location = new System.Drawing.Point(910, 268);
            this.cbBuscaEspecie.Name = "cbBuscaEspecie";
            this.cbBuscaEspecie.Size = new System.Drawing.Size(191, 26);
            this.cbBuscaEspecie.TabIndex = 30;
            this.cbBuscaEspecie.Visible = false;
            // 
            // lblQtdLinhas
            // 
            this.lblQtdLinhas.AutoSize = true;
            this.lblQtdLinhas.BackColor = System.Drawing.Color.Transparent;
            this.lblQtdLinhas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdLinhas.Location = new System.Drawing.Point(798, 547);
            this.lblQtdLinhas.Name = "lblQtdLinhas";
            this.lblQtdLinhas.Size = new System.Drawing.Size(0, 20);
            this.lblQtdLinhas.TabIndex = 31;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = global::ProjetoFazenda.Properties.Resources.abstract_background_design_1297_84;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1113, 579);
            this.Controls.Add(this.lblQtdLinhas);
            this.Controls.Add(this.cbBuscaEspecie);
            this.Controls.Add(this.btnBusca);
            this.Controls.Add(this.txtDataFBusca);
            this.Controls.Add(this.txtBusca1);
            this.Controls.Add(this.cbBuscaSexo);
            this.Controls.Add(this.lblDataF);
            this.Controls.Add(this.lblBusca1);
            this.Controls.Add(this.lblSexoBusca);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbBusca);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtNascimento);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.cbEspecie);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtRaca);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProp);
            this.Controls.Add(this.cbSexo);
            this.Controls.Add(this.txtNome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Animais";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.especieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.especieBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.especieBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.TextBox txtProp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRaca;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbEspecie;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridView dataGridView1;
        //private BDFazendaDataSet bDFazendaDataSet;
        private System.Windows.Forms.BindingSource especieBindingSource;
        //private BDFazendaDataSetTableAdapters.EspecieTableAdapter especieTableAdapter;
        private System.Windows.Forms.BindingSource especieBindingSource1;
        private System.Windows.Forms.TextBox txtNascimento;
        //private BDFazendaDataSet1 bDFazendaDataSet1;
        private System.Windows.Forms.BindingSource especieBindingSource2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cbBusca;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblSexoBusca;
        private System.Windows.Forms.Label lblBusca1;
        private System.Windows.Forms.Label lblDataF;
        private System.Windows.Forms.ComboBox cbBuscaSexo;
        private System.Windows.Forms.TextBox txtBusca1;
        private System.Windows.Forms.TextBox txtDataFBusca;
        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.ComboBox cbBuscaEspecie;
        private System.Windows.Forms.Label lblQtdLinhas;
        private System.Windows.Forms.ToolTip toolTip1;
        //private BDFazendaDataSet1TableAdapters.EspecieTableAdapter especieTableAdapter1;
    }
}