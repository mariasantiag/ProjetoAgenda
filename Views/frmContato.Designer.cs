namespace ProjetoAgenda.Views
{
    partial class frmContato
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
            groupBox1 = new GroupBox();
            cbCategoria = new ComboBox();
            lblCategoria = new Label();
            lblTelefone = new Label();
            lblContato = new Label();
            btnAlterar = new Button();
            btnExcluir = new Button();
            btnCadastrar = new Button();
            txtTelefone = new TextBox();
            txtContato = new TextBox();
            dgvContato = new DataGridView();
            groupBox2 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvContato).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbCategoria);
            groupBox1.Controls.Add(lblCategoria);
            groupBox1.Controls.Add(lblTelefone);
            groupBox1.Controls.Add(lblContato);
            groupBox1.Controls.Add(btnAlterar);
            groupBox1.Controls.Add(btnExcluir);
            groupBox1.Controls.Add(btnCadastrar);
            groupBox1.Controls.Add(txtTelefone);
            groupBox1.Controls.Add(txtContato);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(24, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(276, 340);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cadastrar Contato";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // cbCategoria
            // 
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Location = new Point(18, 178);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(241, 25);
            cbCategoria.TabIndex = 2;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategoria.ForeColor = Color.White;
            lblCategoria.Location = new Point(18, 160);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(69, 16);
            lblCategoria.TabIndex = 8;
            lblCategoria.Text = "Categoria";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTelefone.ForeColor = Color.White;
            lblTelefone.Location = new Point(18, 112);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(62, 16);
            lblTelefone.TabIndex = 7;
            lblTelefone.Text = "Telefone";
            // 
            // lblContato
            // 
            lblContato.AutoSize = true;
            lblContato.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContato.ForeColor = Color.White;
            lblContato.Location = new Point(18, 62);
            lblContato.Name = "lblContato";
            lblContato.Size = new Size(56, 16);
            lblContato.TabIndex = 6;
            lblContato.Text = "Contato";
            // 
            // btnAlterar
            // 
            btnAlterar.BackColor = Color.Silver;
            btnAlterar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAlterar.ForeColor = Color.White;
            btnAlterar.Location = new Point(18, 271);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(106, 40);
            btnAlterar.TabIndex = 5;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = false;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.Silver;
            btnExcluir.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcluir.ForeColor = Color.White;
            btnExcluir.Location = new Point(153, 225);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(106, 40);
            btnExcluir.TabIndex = 4;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.Silver;
            btnCadastrar.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrar.ForeColor = Color.White;
            btnCadastrar.Location = new Point(18, 225);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(106, 40);
            btnCadastrar.TabIndex = 3;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(18, 130);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(241, 25);
            txtTelefone.TabIndex = 1;
            // 
            // txtContato
            // 
            txtContato.Location = new Point(18, 80);
            txtContato.Name = "txtContato";
            txtContato.Size = new Size(241, 25);
            txtContato.TabIndex = 0;
            // 
            // dgvContato
            // 
            dgvContato.BackgroundColor = Color.SkyBlue;
            dgvContato.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContato.Location = new Point(324, 43);
            dgvContato.Name = "dgvContato";
            dgvContato.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvContato.Size = new Size(328, 322);
            dgvContato.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.Red;
            groupBox2.Location = new Point(24, 383);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(422, 67);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "AVISOS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 34);
            label2.Name = "label2";
            label2.Size = new Size(350, 15);
            label2.TabIndex = 4;
            label2.Text = "Para alterar o contato, deixe o campo do telefone em branco";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 19);
            label1.Name = "label1";
            label1.Size = new Size(244, 15);
            label1.TabIndex = 3;
            label1.Text = "O telefone deve conter apenas 8 números";
            label1.Click += label1_Click;
            // 
            // frmContato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(700, 462);
            Controls.Add(groupBox2);
            Controls.Add(dgvContato);
            Controls.Add(groupBox1);
            Name = "frmContato";
            Text = "frmContato";
            Load += frmContato_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvContato).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnAlterar;
        private Button btnExcluir;
        private Button btnCadastrar;
        private TextBox txtCategoria;
        private TextBox txtTelefone;
        private TextBox txtContato;
        private Label lblCategoria;
        private Label lblTelefone;
        private Label lblContato;
        private DataGridView dgvContato;
        private ComboBox cbCategoria;
        private GroupBox groupBox2;
        private Label label1;
        private Label label2;
    }
}