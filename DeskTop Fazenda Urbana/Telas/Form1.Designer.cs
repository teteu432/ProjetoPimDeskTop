namespace DeskTop_Fazenda_Urbana
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtBoxLogin = new TextBox();
            txtBox = new TextBox();
            btnEntrar = new Button();
            Sair = new Button();
            linkCadastro = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 39F);
            label1.Location = new Point(213, 25);
            label1.Name = "label1";
            label1.Size = new Size(396, 70);
            label1.TabIndex = 0;
            label1.Text = "Fazenda Urbana";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(227, 159);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 1;
            label2.Text = "Login";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(227, 206);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 2;
            label3.Text = "Senha";
            // 
            // txtBoxLogin
            // 
            txtBoxLogin.Location = new Point(273, 160);
            txtBoxLogin.Name = "txtBoxLogin";
            txtBoxLogin.Size = new Size(173, 23);
            txtBoxLogin.TabIndex = 3;
            // 
            // txtBox
            // 
            txtBox.Location = new Point(273, 203);
            txtBox.Name = "txtBox";
            txtBox.Size = new Size(115, 23);
            txtBox.TabIndex = 4;
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(264, 288);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(80, 23);
            btnEntrar.TabIndex = 5;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            // 
            // Sair
            // 
            Sair.Location = new Point(371, 288);
            Sair.Name = "Sair";
            Sair.Size = new Size(75, 23);
            Sair.TabIndex = 6;
            Sair.Text = "Sair";
            Sair.UseVisualStyleBackColor = true;
            // 
            // linkCadastro
            // 
            linkCadastro.AutoSize = true;
            linkCadastro.Location = new Point(319, 336);
            linkCadastro.Name = "linkCadastro";
            linkCadastro.Size = new Size(69, 15);
            linkCadastro.TabIndex = 7;
            linkCadastro.TabStop = true;
            linkCadastro.Text = "Cadastre-se";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 133, 73);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(linkCadastro);
            Controls.Add(Sair);
            Controls.Add(btnEntrar);
            Controls.Add(txtBox);
            Controls.Add(txtBoxLogin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtBoxLogin;
        private TextBox txtBox;
        private Button btnEntrar;
        private Button Sair;
        private LinkLabel linkCadastro;
    }
}
