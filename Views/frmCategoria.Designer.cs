namespace ProjetoAgenda.Views
{
    partial class frmCategoria
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
            btnExcluir = new Button();
            btnAlterar = new Button();
            btnCadastrar = new Button();
            txtCategoria = new TextBox();
            dgvCategoria = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategoria).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnExcluir);
            groupBox1.Controls.Add(btnAlterar);
            groupBox1.Controls.Add(btnCadastrar);
            groupBox1.Controls.Add(txtCategoria);
            groupBox1.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(29, 39);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(253, 184);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Insira o nome da nova categoria";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.Silver;
            btnExcluir.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcluir.Location = new Point(16, 141);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(222, 33);
            btnExcluir.TabIndex = 2;
            btnExcluir.Text = "EXCLUIR";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.BackColor = Color.Silver;
            btnAlterar.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAlterar.Location = new Point(16, 102);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(222, 33);
            btnAlterar.TabIndex = 3;
            btnAlterar.Text = "ALTERAR";
            btnAlterar.UseVisualStyleBackColor = false;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.Silver;
            btnCadastrar.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrar.ForeColor = Color.White;
            btnCadastrar.Location = new Point(16, 63);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(222, 33);
            btnCadastrar.TabIndex = 1;
            btnCadastrar.Text = "CADASTRAR";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // txtCategoria
            // 
            txtCategoria.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCategoria.Location = new Point(16, 36);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(222, 21);
            txtCategoria.TabIndex = 1;
            // 
            // dgvCategoria
            // 
            dgvCategoria.BackgroundColor = Color.SkyBlue;
            dgvCategoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategoria.Location = new Point(353, 63);
            dgvCategoria.Name = "dgvCategoria";
            dgvCategoria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategoria.Size = new Size(247, 129);
            dgvCategoria.TabIndex = 1;
            dgvCategoria.CellContentClick += dgvCategoria_CellContentClick;
            // 
            // frmCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(653, 232);
            Controls.Add(dgvCategoria);
            Controls.Add(groupBox1);
            Name = "frmCategoria";
            Text = "frmCategoria";
            Load += frmCategoria_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategoria).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtCategoria;
        private Button btnCadastrar;
        private DataGridView dgvCategoria;
        private Button btnExcluir;
        private Button btnAlterar;
    }
}