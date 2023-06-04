namespace WinFormsApp2
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
            button1 = new Button();
            label1 = new Label();
            numericUpDown1 = new NumericUpDown();
            button2 = new Button();
            label2 = new Label();
            label3 = new Label();
            button3 = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(128, 31);
            button1.Name = "button1";
            button1.Size = new Size(124, 50);
            button1.TabIndex = 0;
            button1.Text = "kiritish";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 36);
            label1.Name = "label1";
            label1.Size = new Size(55, 31);
            label1.TabIndex = 1;
            label1.Text = "n = ";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown1.Location = new Point(61, 34);
            numericUpDown1.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(47, 38);
            numericUpDown1.TabIndex = 2;
            numericUpDown1.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(128, 31);
            button2.Name = "button2";
            button2.Size = new Size(124, 50);
            button2.TabIndex = 3;
            button2.Text = "Hisobla";
            button2.UseVisualStyleBackColor = true;
            button2.Visible = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(291, 41);
            label2.Name = "label2";
            label2.Size = new Size(78, 33);
            label2.TabIndex = 4;
            label2.Text = "label2";
            label2.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(756, 43);
            label3.Name = "label3";
            label3.Size = new Size(78, 33);
            label3.TabIndex = 5;
            label3.Text = "label3";
            label3.Visible = false;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(1604, 12);
            button3.Name = "button3";
            button3.Size = new Size(119, 55);
            button3.TabIndex = 6;
            button3.Text = "Tozalash";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 518);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(844, 525);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            pictureBox1.Paint += PictureBox1_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(881, 518);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(842, 525);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            pictureBox2.Paint += PictureBox2_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(19, 534);
            label4.Name = "label4";
            label4.Size = new Size(89, 31);
            label4.TabIndex = 9;
            label4.Text = "Chiziqli";
            label4.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(897, 534);
            label5.Name = "label5";
            label5.Size = new Size(108, 31);
            label5.TabIndex = 10;
            label5.Text = "Kvadratik";
            label5.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(442, 9);
            label6.Name = "label6";
            label6.Size = new Size(897, 28);
            label6.TabIndex = 11;
            label6.Text = "Approksimatsiya masalasini yechishda eng kichik kvadratlar usuli(dasturning ilk demo holati)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1732, 1055);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(numericUpDown1);
            Controls.Add(label1);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(1750, 2000);
            MinimumSize = new Size(1750, 800);
            Name = "Form1";
            Text = "Math";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private NumericUpDown numericUpDown1;
        private Button button2;
        private Label label2;
        private Label label3;
        private Button button3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}