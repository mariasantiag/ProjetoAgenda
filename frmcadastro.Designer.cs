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
            txtNome.Location = new Point(43, 56);
            txtNome.Multiline = true;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(410, 39);
            txtNome.TabIndex = 0;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(43, 127);
            txtUsuario.Multiline = true;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(410, 39);
            txtUsuario.TabIndex = 1;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(43, 193);
            txtTelefone.Multiline = true;
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(410, 39);
            txtTelefone.TabIndex = 2;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(43, 262);
            txtSenha.Multiline = true;
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(218, 39);
            txtSenha.TabIndex = 3;
            // 
            // txtRepitaaSenha
            // 
            txtRepitaaSenha.Location = new Point(43, 338);
            txtRepitaaSenha.Multiline = true;
            txtRepitaaSenha.Name = "txtRepitaaSenha";
            txtRepitaaSenha.Size = new Size(218, 39);
            txtRepitaaSenha.TabIndex = 4;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNome.ForeColor = Color.White;
            lblNome.Location = new Point(43, 33);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(54, 19);
            lblNome.TabIndex = 5;
            lblNome.Text = "Nome";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.ForeColor = Color.White;
            lblUsuario.Location = new Point(43, 105);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(70, 19);
            lblUsuario.TabIndex = 6;
            lblUsuario.Text = "Usuário";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTelefone.ForeColor = Color.White;
            lblTelefone.Location = new Point(43, 171);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(74, 19);
            lblTelefone.TabIndex = 7;
            lblTelefone.Text = "Telefone";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSenha.ForeColor = Color.White;
            lblSenha.Location = new Point(43, 240);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(58, 19);
            lblSenha.TabIndex = 8;
            lblSenha.Text = "Senha";
            // 
            // lblRepitaaSenha
            // 
            lblRepitaaSenha.AutoSize = true;
            lblRepitaaSenha.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRepitaaSenha.ForeColor = Color.White;
            lblRepitaaSenha.Location = new Point(43, 316);
            lblRepitaaSenha.Name = "lblRepitaaSenha";
            lblRepitaaSenha.Size = new Size(125, 19);
            lblRepitaaSenha.TabIndex = 9;
            lblRepitaaSenha.Text = "Repita a senha";
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.Silver;
            btnCadastrar.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrar.ForeColor = Color.White;
            btnCadastrar.Location = new Point(43, 406);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(141, 52);
            btnCadastrar.TabIndex = 10;
            btnCadastrar.Text = "CADASTRAR";
            btnCadastrar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Silver;
            btnCancelar.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(203, 406);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(141, 52);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.tartaruga;
            pictureBox1.Location = new Point(361, 378);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(143, 113);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // frmcadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(503, 487);
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
            Name = "frmcadastro";
            Text = "frmcadastro";
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