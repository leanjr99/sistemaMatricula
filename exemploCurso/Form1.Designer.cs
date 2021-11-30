
namespace exemploCurso
{
    partial class cadastroForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadastroForm));
            this.nomeLabel = new System.Windows.Forms.Label();
            this.NomeTextBox = new System.Windows.Forms.TextBox();
            this.dataMatriculaLabel = new System.Windows.Forms.Label();
            this.dataDeMatriculaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cidadeLabel = new System.Windows.Forms.Label();
            this.cidadeComboBox = new System.Windows.Forms.ComboBox();
            this.periodosPanel = new System.Windows.Forms.Panel();
            this.periodoNoiteRadioButton = new System.Windows.Forms.RadioButton();
            this.periodoTardeRadioButton = new System.Windows.Forms.RadioButton();
            this.periodoManhaRadioButton = new System.Windows.Forms.RadioButton();
            this.confirmarButton = new System.Windows.Forms.Button();
            this.anoDeInicioLabel = new System.Windows.Forms.Label();
            this.anoTextBox = new System.Windows.Forms.TextBox();
            this.principalMenuStrip = new System.Windows.Forms.MenuStrip();
            this.comandosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limparToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pasteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.periodosPanel.SuspendLayout();
            this.principalMenuStrip.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Location = new System.Drawing.Point(12, 54);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(46, 15);
            this.nomeLabel.TabIndex = 0;
            this.nomeLabel.Text = "Nome: ";
            // 
            // NomeTextBox
            // 
            this.NomeTextBox.Location = new System.Drawing.Point(12, 73);
            this.NomeTextBox.Name = "NomeTextBox";
            this.NomeTextBox.Size = new System.Drawing.Size(100, 23);
            this.NomeTextBox.TabIndex = 1;
            // 
            // dataMatriculaLabel
            // 
            this.dataMatriculaLabel.AutoSize = true;
            this.dataMatriculaLabel.Location = new System.Drawing.Point(12, 99);
            this.dataMatriculaLabel.Name = "dataMatriculaLabel";
            this.dataMatriculaLabel.Size = new System.Drawing.Size(103, 15);
            this.dataMatriculaLabel.TabIndex = 2;
            this.dataMatriculaLabel.Text = "Data de Matrícula:";
            // 
            // dataDeMatriculaDateTimePicker
            // 
            this.dataDeMatriculaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataDeMatriculaDateTimePicker.Location = new System.Drawing.Point(12, 118);
            this.dataDeMatriculaDateTimePicker.Name = "dataDeMatriculaDateTimePicker";
            this.dataDeMatriculaDateTimePicker.Size = new System.Drawing.Size(100, 23);
            this.dataDeMatriculaDateTimePicker.TabIndex = 3;
            // 
            // cidadeLabel
            // 
            this.cidadeLabel.AutoSize = true;
            this.cidadeLabel.Location = new System.Drawing.Point(12, 152);
            this.cidadeLabel.Name = "cidadeLabel";
            this.cidadeLabel.Size = new System.Drawing.Size(47, 15);
            this.cidadeLabel.TabIndex = 4;
            this.cidadeLabel.Text = "Cidade:";
            // 
            // cidadeComboBox
            // 
            this.cidadeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cidadeComboBox.FormattingEnabled = true;
            this.cidadeComboBox.Items.AddRange(new object[] {
            "São Paulo",
            "Rio de Janeiro",
            "Belo Horizonte"});
            this.cidadeComboBox.Location = new System.Drawing.Point(12, 170);
            this.cidadeComboBox.Name = "cidadeComboBox";
            this.cidadeComboBox.Size = new System.Drawing.Size(121, 23);
            this.cidadeComboBox.TabIndex = 5;
            // 
            // periodosPanel
            // 
            this.periodosPanel.Controls.Add(this.periodoNoiteRadioButton);
            this.periodosPanel.Controls.Add(this.periodoTardeRadioButton);
            this.periodosPanel.Controls.Add(this.periodoManhaRadioButton);
            this.periodosPanel.Location = new System.Drawing.Point(12, 199);
            this.periodosPanel.Name = "periodosPanel";
            this.periodosPanel.Size = new System.Drawing.Size(229, 26);
            this.periodosPanel.TabIndex = 6;
            // 
            // periodoNoiteRadioButton
            // 
            this.periodoNoiteRadioButton.AutoSize = true;
            this.periodoNoiteRadioButton.Location = new System.Drawing.Point(153, 4);
            this.periodoNoiteRadioButton.Name = "periodoNoiteRadioButton";
            this.periodoNoiteRadioButton.Size = new System.Drawing.Size(54, 19);
            this.periodoNoiteRadioButton.TabIndex = 2;
            this.periodoNoiteRadioButton.TabStop = true;
            this.periodoNoiteRadioButton.Text = "Noite";
            this.periodoNoiteRadioButton.UseVisualStyleBackColor = true;
            // 
            // periodoTardeRadioButton
            // 
            this.periodoTardeRadioButton.AutoSize = true;
            this.periodoTardeRadioButton.Location = new System.Drawing.Point(83, 4);
            this.periodoTardeRadioButton.Name = "periodoTardeRadioButton";
            this.periodoTardeRadioButton.Size = new System.Drawing.Size(53, 19);
            this.periodoTardeRadioButton.TabIndex = 1;
            this.periodoTardeRadioButton.TabStop = true;
            this.periodoTardeRadioButton.Text = "Tarde";
            this.periodoTardeRadioButton.UseVisualStyleBackColor = true;
            // 
            // periodoManhaRadioButton
            // 
            this.periodoManhaRadioButton.AutoSize = true;
            this.periodoManhaRadioButton.Location = new System.Drawing.Point(4, 4);
            this.periodoManhaRadioButton.Name = "periodoManhaRadioButton";
            this.periodoManhaRadioButton.Size = new System.Drawing.Size(62, 19);
            this.periodoManhaRadioButton.TabIndex = 0;
            this.periodoManhaRadioButton.TabStop = true;
            this.periodoManhaRadioButton.Text = "Manhã";
            this.periodoManhaRadioButton.UseVisualStyleBackColor = true;
            // 
            // confirmarButton
            // 
            this.confirmarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.confirmarButton.Location = new System.Drawing.Point(329, 303);
            this.confirmarButton.Name = "confirmarButton";
            this.confirmarButton.Size = new System.Drawing.Size(75, 23);
            this.confirmarButton.TabIndex = 7;
            this.confirmarButton.Text = "Confirmar\r\n";
            this.confirmarButton.UseVisualStyleBackColor = true;
            this.confirmarButton.Click += new System.EventHandler(this.confirmarButton_Click);
            // 
            // anoDeInicioLabel
            // 
            this.anoDeInicioLabel.AutoSize = true;
            this.anoDeInicioLabel.Location = new System.Drawing.Point(12, 232);
            this.anoDeInicioLabel.Name = "anoDeInicioLabel";
            this.anoDeInicioLabel.Size = new System.Drawing.Size(80, 15);
            this.anoDeInicioLabel.TabIndex = 8;
            this.anoDeInicioLabel.Text = "Ano de Inicio:";
            // 
            // anoTextBox
            // 
            this.anoTextBox.Location = new System.Drawing.Point(16, 250);
            this.anoTextBox.Name = "anoTextBox";
            this.anoTextBox.Size = new System.Drawing.Size(100, 23);
            this.anoTextBox.TabIndex = 9;
            // 
            // principalMenuStrip
            // 
            this.principalMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comandosToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.principalMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.principalMenuStrip.Name = "principalMenuStrip";
            this.principalMenuStrip.Size = new System.Drawing.Size(427, 24);
            this.principalMenuStrip.TabIndex = 10;
            this.principalMenuStrip.Text = "menuStrip1";
            // 
            // comandosToolStripMenuItem
            // 
            this.comandosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.limparToolStripMenuItem,
            this.salvarToolStripMenuItem,
            this.imprimirToolStripMenuItem,
            this.toolStripMenuItem1,
            this.sairToolStripMenuItem});
            this.comandosToolStripMenuItem.Name = "comandosToolStripMenuItem";
            this.comandosToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.comandosToolStripMenuItem.Text = "Comandos";
            // 
            // limparToolStripMenuItem
            // 
            this.limparToolStripMenuItem.Name = "limparToolStripMenuItem";
            this.limparToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.limparToolStripMenuItem.Text = "Limpar";
            this.limparToolStripMenuItem.Click += new System.EventHandler(this.limparToolStripMenuItem_Click);
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.salvarToolStripMenuItem.Text = "Salvar";
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.imprimirToolStripMenuItem.Text = "Imprimir";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(132, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.sobreToolStripMenuItem.Text = "Sobre...";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.printToolStripButton,
            this.toolStripSeparator,
            this.cutToolStripButton,
            this.copyToolStripButton,
            this.pasteToolStripButton,
            this.toolStripSeparator1,
            this.helpToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(427, 25);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.newToolStripButton.Text = "&New";
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openToolStripButton.Text = "&Open";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "&Save";
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.printToolStripButton.Text = "&Print";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // cutToolStripButton
            // 
            this.cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripButton.Image")));
            this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripButton.Name = "cutToolStripButton";
            this.cutToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.cutToolStripButton.Text = "C&ut";
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.copyToolStripButton.Text = "&Copy";
            // 
            // pasteToolStripButton
            // 
            this.pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripButton.Image")));
            this.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripButton.Name = "pasteToolStripButton";
            this.pasteToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.pasteToolStripButton.Text = "&Paste";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.helpToolStripButton.Text = "He&lp";
            this.helpToolStripButton.Click += new System.EventHandler(this.helpToolStripButton_Click);
            // 
            // cadastroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 408);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.anoTextBox);
            this.Controls.Add(this.anoDeInicioLabel);
            this.Controls.Add(this.confirmarButton);
            this.Controls.Add(this.periodosPanel);
            this.Controls.Add(this.cidadeComboBox);
            this.Controls.Add(this.cidadeLabel);
            this.Controls.Add(this.dataDeMatriculaDateTimePicker);
            this.Controls.Add(this.dataMatriculaLabel);
            this.Controls.Add(this.NomeTextBox);
            this.Controls.Add(this.nomeLabel);
            this.Controls.Add(this.principalMenuStrip);
            this.MainMenuStrip = this.principalMenuStrip;
            this.Name = "cadastroForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Aluno";
            this.Load += new System.EventHandler(this.cadastroForm_Load);
            this.periodosPanel.ResumeLayout(false);
            this.periodosPanel.PerformLayout();
            this.principalMenuStrip.ResumeLayout(false);
            this.principalMenuStrip.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.TextBox NomeTextBox;
        private System.Windows.Forms.Label dataMatriculaLabel;
        private System.Windows.Forms.DateTimePicker dataDeMatriculaDateTimePicker;
        private System.Windows.Forms.Label cidadeLabel;
        private System.Windows.Forms.ComboBox cidadeComboBox;
        private System.Windows.Forms.Panel periodosPanel;
        private System.Windows.Forms.RadioButton periodoNoiteRadioButton;
        private System.Windows.Forms.RadioButton periodoTardeRadioButton;
        private System.Windows.Forms.RadioButton periodoManhaRadioButton;
        private System.Windows.Forms.Button confirmarButton;
        private System.Windows.Forms.Label anoDeInicioLabel;
        private System.Windows.Forms.TextBox anoTextBox;
        private System.Windows.Forms.MenuStrip principalMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem comandosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem limparToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton cutToolStripButton;
        private System.Windows.Forms.ToolStripButton copyToolStripButton;
        private System.Windows.Forms.ToolStripButton pasteToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
    }
}

