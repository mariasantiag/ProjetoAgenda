namespace ProjetoAgenda.Views
{
    partial class frmUsuario
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
            dvgUsuario = new DataGridView();
            btnExcluir = new Button();
            txtSenha = new TextBox();
            label1 = new Label();
            btnAlterar = new Button();
            txtUsuario = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dvgUsuario).BeginInit();
            SuspendLayout();
            // 
            // dvgUsuario
            // 
            dvgUsuario.BackgroundColor = Color.SkyBlue;
            dvgUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgUsuario.Location = new Point(217, 12);
            dvgUsuario.Name = "dvgUsuario";
            dvgUsuario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvgUsuario.Size = new Size(236, 164);
            dvgUsuario.TabIndex = 0;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(368, 182);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(85, 33);
            btnExcluir.TabIndex = 1;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(12, 124);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(182, 23);
            txtSenha.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 105);
            label1.Name = "label1";
            label1.Size = new Size(151, 16);
            label1.TabIndex = 3;
            label1.Text = "Digite sua nova senha:";
            label1.Click += label1_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(119, 153);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(75, 23);
            btnAlterar.TabIndex = 4;
            btnAlterar.Text = "alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(12, 68);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(182, 23);
            txtUsuario.TabIndex = 5;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 49);
            label2.Name = "label2";
            label2.Size = new Size(55, 16);
            label2.TabIndex = 6;
            label2.Text = "Usuario";
            // 
            // frmUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(518, 240);
            Controls.Add(label2);
            Controls.Add(txtUsuario);
            Controls.Add(btnAlterar);
            Controls.Add(label1);
            Controls.Add(txtSenha);
            Controls.Add(btnExcluir);
            Controls.Add(dvgUsuario);
            Name = "frmUsuario";
            Text = "Usuario";
            Load += frmUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)dvgUsuario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dvgUsuario;
        private Button btnExcluir;
        private TextBox txtSenha;
        private Label label1;
        private Button btnAlterar;
        private TextBox txtUsuario;
        private Label label2;
    }
}