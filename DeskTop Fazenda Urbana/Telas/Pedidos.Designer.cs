namespace DeskTop_Fazenda_Urbana.Telas
{
    partial class Pedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pedidos));
            label1 = new Label();
            checkedListBox1 = new CheckedListBox();
            checkedListBox2 = new CheckedListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(62, 20);
            label1.Name = "label1";
            label1.Size = new Size(318, 50);
            label1.TabIndex = 0;
            label1.Text = "Pedido pendentes";
            // 
            // checkedListBox1
            // 
            checkedListBox1.BackColor = Color.LimeGreen;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(62, 99);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(409, 256);
            checkedListBox1.TabIndex = 1;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // checkedListBox2
            // 
            checkedListBox2.BackColor = Color.LimeGreen;
            checkedListBox2.FormattingEnabled = true;
            checkedListBox2.Location = new Point(493, 99);
            checkedListBox2.Name = "checkedListBox2";
            checkedListBox2.Size = new Size(295, 256);
            checkedListBox2.TabIndex = 2;
            // 
            // Pedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(checkedListBox2);
            Controls.Add(checkedListBox1);
            Controls.Add(label1);
            Name = "Pedidos";
            Text = "Pedidos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private CheckedListBox checkedListBox1;
        private CheckedListBox checkedListBox2;
    }
}