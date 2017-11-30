namespace ProjetoFazenda
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.label1 = new System.Windows.Forms.Label();
            this.cbAnimal = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnGrid = new System.Windows.Forms.Button();
            this.cbBusca = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDataI = new System.Windows.Forms.Label();
            this.lblDataF = new System.Windows.Forms.Label();
            this.txtDataIni = new System.Windows.Forms.TextBox();
            this.txtDataFin = new System.Windows.Forms.TextBox();
            this.cbAnimalBusca = new System.Windows.Forms.ComboBox();
            this.lblAnimal = new System.Windows.Forms.Label();
            this.btnBusca = new System.Windows.Forms.Button();
            this.lblQtdLinhas = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione o animal:";
            // 
            // cbAnimal
            // 
            this.cbAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAnimal.FormattingEnabled = true;
            this.cbAnimal.Location = new System.Drawing.Point(164, 68);
            this.cbAnimal.Name = "cbAnimal";
            this.cbAnimal.Size = new System.Drawing.Size(231, 26);
            this.cbAnimal.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(506, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data da Vascina:";
            // 
            // txtData
            // 
            this.txtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Location = new System.Drawing.Point(643, 68);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(179, 26);
            this.txtData.TabIndex = 3;
            this.txtData.Click += new System.EventHandler(this.txtData_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 156);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(733, 411);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnIncluir
            // 
            this.btnIncluir.BackgroundImage = global::ProjetoFazenda.Properties.Resources.icons8_Mais_26;
            this.btnIncluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIncluir.Location = new System.Drawing.Point(751, 156);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(28, 28);
            this.btnIncluir.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnIncluir, "Inserir");
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackgroundImage = global::ProjetoFazenda.Properties.Resources.icons8_Editar_48;
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditar.Location = new System.Drawing.Point(751, 190);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(28, 32);
            this.btnEditar.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnEditar, "Editar");
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackgroundImage = global::ProjetoFazenda.Properties.Resources.icons8_Excluir_48;
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcluir.Location = new System.Drawing.Point(751, 228);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(28, 31);
            this.btnExcluir.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btnExcluir, "Deletar");
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnGrid
            // 
            this.btnGrid.BackgroundImage = global::ProjetoFazenda.Properties.Resources.icons8_Cardápio_64;
            this.btnGrid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGrid.Location = new System.Drawing.Point(751, 535);
            this.btnGrid.Name = "btnGrid";
            this.btnGrid.Size = new System.Drawing.Size(28, 32);
            this.btnGrid.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btnGrid, "Preencher Grid");
            this.btnGrid.UseVisualStyleBackColor = true;
            this.btnGrid.Click += new System.EventHandler(this.btnGrid_Click);
            // 
            // cbBusca
            // 
            this.cbBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBusca.FormattingEnabled = true;
            this.cbBusca.Items.AddRange(new object[] {
            "Data da Vascina",
            "Animal"});
            this.cbBusca.Location = new System.Drawing.Point(889, 252);
            this.cbBusca.Name = "cbBusca";
            this.cbBusca.Size = new System.Drawing.Size(212, 26);
            this.cbBusca.TabIndex = 9;
            this.cbBusca.SelectedIndexChanged += new System.EventHandler(this.cbBusca_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(820, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Buscar:";
            // 
            // lblDataI
            // 
            this.lblDataI.AutoSize = true;
            this.lblDataI.BackColor = System.Drawing.Color.Transparent;
            this.lblDataI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataI.Location = new System.Drawing.Point(791, 313);
            this.lblDataI.Name = "lblDataI";
            this.lblDataI.Size = new System.Drawing.Size(92, 20);
            this.lblDataI.TabIndex = 11;
            this.lblDataI.Text = "Data Inicial:";
            this.lblDataI.Visible = false;
            // 
            // lblDataF
            // 
            this.lblDataF.AutoSize = true;
            this.lblDataF.BackColor = System.Drawing.Color.Transparent;
            this.lblDataF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataF.Location = new System.Drawing.Point(797, 407);
            this.lblDataF.Name = "lblDataF";
            this.lblDataF.Size = new System.Drawing.Size(86, 20);
            this.lblDataF.TabIndex = 12;
            this.lblDataF.Text = "Data Final:";
            this.lblDataF.Visible = false;
            // 
            // txtDataIni
            // 
            this.txtDataIni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataIni.Location = new System.Drawing.Point(889, 310);
            this.txtDataIni.Name = "txtDataIni";
            this.txtDataIni.Size = new System.Drawing.Size(212, 26);
            this.txtDataIni.TabIndex = 13;
            this.txtDataIni.Visible = false;
            this.txtDataIni.Click += new System.EventHandler(this.txtDataI_Click);
            // 
            // txtDataFin
            // 
            this.txtDataFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataFin.Location = new System.Drawing.Point(889, 401);
            this.txtDataFin.Name = "txtDataFin";
            this.txtDataFin.Size = new System.Drawing.Size(212, 26);
            this.txtDataFin.TabIndex = 14;
            this.txtDataFin.Visible = false;
            this.txtDataFin.Click += new System.EventHandler(this.txtDataF_Click);
            // 
            // cbAnimalBusca
            // 
            this.cbAnimalBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAnimalBusca.FormattingEnabled = true;
            this.cbAnimalBusca.Location = new System.Drawing.Point(889, 353);
            this.cbAnimalBusca.Name = "cbAnimalBusca";
            this.cbAnimalBusca.Size = new System.Drawing.Size(212, 26);
            this.cbAnimalBusca.TabIndex = 15;
            this.cbAnimalBusca.Visible = false;
            // 
            // lblAnimal
            // 
            this.lblAnimal.AutoSize = true;
            this.lblAnimal.BackColor = System.Drawing.Color.Transparent;
            this.lblAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnimal.Location = new System.Drawing.Point(822, 355);
            this.lblAnimal.Name = "lblAnimal";
            this.lblAnimal.Size = new System.Drawing.Size(61, 20);
            this.lblAnimal.TabIndex = 16;
            this.lblAnimal.Text = "Animal:";
            this.lblAnimal.Visible = false;
            // 
            // btnBusca
            // 
            this.btnBusca.BackgroundImage = global::ProjetoFazenda.Properties.Resources.icons8_Pesquisar_Filled_50;
            this.btnBusca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBusca.Location = new System.Drawing.Point(976, 451);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(37, 27);
            this.btnBusca.TabIndex = 30;
            this.toolTip1.SetToolTip(this.btnBusca, "Buscar");
            this.btnBusca.UseVisualStyleBackColor = true;
            this.btnBusca.Visible = false;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // lblQtdLinhas
            // 
            this.lblQtdLinhas.AutoSize = true;
            this.lblQtdLinhas.BackColor = System.Drawing.Color.Transparent;
            this.lblQtdLinhas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdLinhas.Location = new System.Drawing.Point(797, 547);
            this.lblQtdLinhas.Name = "lblQtdLinhas";
            this.lblQtdLinhas.Size = new System.Drawing.Size(0, 20);
            this.lblQtdLinhas.TabIndex = 31;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoFazenda.Properties.Resources.abstract_background_design_1297_84;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1113, 579);
            this.Controls.Add(this.lblQtdLinhas);
            this.Controls.Add(this.btnBusca);
            this.Controls.Add(this.lblAnimal);
            this.Controls.Add(this.cbAnimalBusca);
            this.Controls.Add(this.txtDataFin);
            this.Controls.Add(this.txtDataIni);
            this.Controls.Add(this.lblDataF);
            this.Controls.Add(this.lblDataI);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbBusca);
            this.Controls.Add(this.btnGrid);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbAnimal);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.Text = "Vacinações";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbAnimal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnGrid;
        private System.Windows.Forms.ComboBox cbBusca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDataI;
        private System.Windows.Forms.Label lblDataF;
        private System.Windows.Forms.TextBox txtDataIni;
        private System.Windows.Forms.TextBox txtDataFin;
        private System.Windows.Forms.ComboBox cbAnimalBusca;
        private System.Windows.Forms.Label lblAnimal;
        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.Label lblQtdLinhas;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}