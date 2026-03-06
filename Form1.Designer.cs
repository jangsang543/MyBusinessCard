namespace MyBusinessCard
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(37, 83);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(433, 566);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            pictureBox1.MouseEnter += pictureBox1_MouseEnter_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 55F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.Location = new Point(549, 132);
            label1.Name = "label1";
            label1.Size = new Size(282, 146);
            label1.TabIndex = 1;
            label1.Text = "장상";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 16F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(549, 301);
            label2.Name = "label2";
            label2.Size = new Size(402, 45);
            label2.TabIndex = 2;
            label2.Text = "수원대학교(컴퓨터sw학과)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 16F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label3.ForeColor = Color.DarkViolet;
            label3.Location = new Point(549, 355);
            label3.Name = "label3";
            label3.Size = new Size(403, 45);
            label3.TabIndex = 3;
            label3.Text = "jangsang527@gmail.com";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(224, 224, 224);
            button1.FlatAppearance.BorderColor = Color.Blue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("한컴 고딕", 20F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button1.Location = new Point(549, 494);
            button1.Name = "button1";
            button1.Size = new Size(535, 155);
            button1.TabIndex = 4;
            button1.Text = "배경색 랜덤 변경";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 255, 192);
            button2.Font = new Font("맑은 고딕", 14F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button2.Location = new Point(827, 159);
            button2.Name = "button2";
            button2.Size = new Size(124, 106);
            button2.TabIndex = 5;
            button2.Text = "GitHub";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 255, 128);
            button3.Font = new Font("맑은 고딕", 24F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button3.ForeColor = Color.Fuchsia;
            button3.Location = new Point(65, 668);
            button3.Name = "button3";
            button3.Size = new Size(367, 90);
            button3.TabIndex = 6;
            button3.Text = "사진 변경";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1220, 781);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
