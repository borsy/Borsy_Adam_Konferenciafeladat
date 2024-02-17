namespace Borsy_Adam_Konferenciafeladat
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
            button_bal = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            button_mentes = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button_bal
            // 
            button_bal.BackgroundImage = (Image)resources.GetObject("button_bal.BackgroundImage");
            button_bal.BackgroundImageLayout = ImageLayout.Stretch;
            button_bal.Location = new Point(12, 74);
            button_bal.Name = "button_bal";
            button_bal.Size = new Size(74, 73);
            button_bal.TabIndex = 0;
            button_bal.UseVisualStyleBackColor = true;
            button_bal.Click += button_bal_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Location = new Point(272, 74);
            button2.Name = "button2";
            button2.Size = new Size(75, 73);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(107, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(146, 284);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Location = new Point(375, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(390, 284);
            panel1.TabIndex = 3;
            // 
            // button_mentes
            // 
            button_mentes.BackgroundImage = (Image)resources.GetObject("button_mentes.BackgroundImage");
            button_mentes.BackgroundImageLayout = ImageLayout.Stretch;
            button_mentes.Location = new Point(139, 321);
            button_mentes.Name = "button_mentes";
            button_mentes.Size = new Size(75, 65);
            button_mentes.TabIndex = 4;
            button_mentes.UseVisualStyleBackColor = true;
            button_mentes.Click += button_mentes_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_mentes);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button_bal);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button_bal;
        private Button button2;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button button_mentes;
    }
}
