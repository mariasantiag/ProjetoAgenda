namespace ProjetoAgenda
{
    partial class frmcadastro
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
            txtNome = new TextBox();
            txtUsuario = new TextBox();
            txtTelefone = new TextBox();
            txtSenha = new TextBox();
            txtRepitaaSenha = new TextBox();
            lblNome = new Label();
            lblUsuario = new Label();
            lblTelefone = new Label();
            lblSenha = new Label();
            lblRepitaaSenha = new Label();
            btnCadastrar = new Button();
            btnCancelar = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(38, 42);
            txtNome.Margin = new Padding(3, 2, 3, 2);
            txtNome.Multiline = true;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(359, 30);
            txtNome.TabIndex = 0;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(38, 95);
            txtUsuario.Margin = new Padding(3, 2, 3, 2);
            txtUsuario.Multiline = true;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(359, 30);
            txtUsuario.TabIndex = 1;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            // 
            // txtTelefone
            // 
            txtTelefone.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTelefone.Location = new Point(38, 145);
            txtTelefone.Margin = new Padding(3, 2, 3, 2);
            txtTelefone.Multiline = true;
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(359, 30);
            txtTelefone.TabIndex = 2;
            txtTelefone.TextChanged += txtTelefone_TextChanged;
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSenha.Location = new Point(38, 196);
            txtSenha.Margin = new Padding(3, 2, 3, 2);
            txtSenha.Multiline = true;
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(191, 30);
            txtSenha.TabIndex = 3;
            txtSenha.TextChanged += txtSenha_TextChanged;
            // 
            // txtRepitaaSenha
            // 
            txtRepitaaSenha.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRepitaaSenha.Location = new Point(38, 254);
            txtRepitaaSenha.Margin = new Padding(3, 2, 3, 2);
            txtRepitaaSenha.Multiline = true;
            txtRepitaaSenha.Name = "txtRepitaaSenha";
            txtRepitaaSenha.Size = new Size(191, 30);
            txtRepitaaSenha.TabIndex = 4;
            txtRepitaaSenha.TextChanged += txtRepitaaSenha_TextChanged;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNome.ForeColor = Color.White;
            lblNome.Location = new Point(38, 25);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(47, 16);
            lblNome.TabIndex = 5;
            lblNome.Text = "Nome";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.ForeColor = Color.White;
            lblUsuario.Location = new Point(38, 79);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(61, 16);
            lblUsuario.TabIndex = 6;
            lblUsuario.Text = "Usuário";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTelefone.ForeColor = Color.White;
            lblTelefone.Location = new Point(38, 128);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(68, 16);
            lblTelefone.TabIndex = 7;
            lblTelefone.Text = "Telefone";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSenha.ForeColor = Color.White;
            lblSenha.Location = new Point(38, 180);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(51, 16);
            lblSenha.TabIndex = 8;
            lblSenha.Text = "Senha";
            // 
            // lblRepitaaSenha
            // 
            lblRepitaaSenha.AutoSize = true;
            lblRepitaaSenha.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRepitaaSenha.ForeColor = Color.White;
            lblRepitaaSenha.Location = new Point(38, 237);
            lblRepitaaSenha.Name = "lblRepitaaSenha";
            lblRepitaaSenha.Size = new Size(111, 16);
            lblRepitaaSenha.TabIndex = 9;
            lblRepitaaSenha.Text = "Repita a senha";
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.Silver;
            btnCadastrar.Enabled = false;
            btnCadastrar.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrar.ForeColor = Color.White;
            btnCadastrar.Location = new Point(38, 304);
            btnCadastrar.Margin = new Padding(3, 2, 3, 2);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(123, 39);
            btnCadastrar.TabIndex = 10;
            btnCadastrar.Text = "CADASTRAR";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Silver;
            btnCancelar.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(178, 304);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(123, 39);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.tartaruga;
            pictureBox1.Location = new Point(316, 284);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // frmcadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(440, 365);
            Controls.Add(pictureBox1);
            Controls.Add(btnCancelar);
            Controls.Add(btnCadastrar);
            Controls.Add(lblRepitaaSenha);
            Controls.Add(lblSenha);
            Controls.Add(lblTelefone);
            Controls.Add(lblUsuario);
            Controls.Add(lblNome);
            Controls.Add(txtRepitaaSenha);
            Controls.Add(txtSenha);
            Controls.Add(txtTelefone);
            Controls.Add(txtUsuario);
            Controls.Add(txtNome);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmcadastro";
            Text = "frmcadastro";
            Load += frmcadastro_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtUsuario;
        private TextBox txtTelefone;
        private TextBox txtSenha;
        private TextBox txtRepitaaSenha;
        private Label lblNome;
        private Label lblUsuario;
        private Label lblTelefone;
        private Label lblSenha;
        private Label lblRepitaaSenha;
        private Button btnCadastrar;
        private Button btnCancelar;
        private PictureBox pictureBox1;
    }
}