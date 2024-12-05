namespace WindowsMicrosoftHashingDB
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
            button1 = new Button();
            PCA2011 = new Label();
            CA20101 = new Label();
            CA2023 = new Label();
            CA20102 = new Label();
            CA2011 = new Label();
            CA201102 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(237, 369);
            button1.Name = "button1";
            button1.Size = new Size(308, 29);
            button1.TabIndex = 0;
            button1.Text = "Press to Upload File for DB file checking";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // PCA2011
            // 
            PCA2011.AutoSize = true;
            PCA2011.Location = new Point(12, 67);
            PCA2011.Name = "PCA2011";
            PCA2011.Size = new Size(54, 20);
            PCA2011.TabIndex = 1;
            PCA2011.Text = "Temp1";
            // 
            // CA20101
            // 
            CA20101.AutoSize = true;
            CA20101.Location = new Point(12, 107);
            CA20101.Name = "CA20101";
            CA20101.Size = new Size(54, 20);
            CA20101.TabIndex = 2;
            CA20101.Text = "Temp2";
            // 
            // CA2023
            // 
            CA2023.AutoSize = true;
            CA2023.Location = new Point(12, 233);
            CA2023.Name = "CA2023";
            CA2023.Size = new Size(54, 20);
            CA2023.TabIndex = 3;
            CA2023.Text = "Temp1";
            // 
            // CA20102
            // 
            CA20102.AutoSize = true;
            CA20102.Location = new Point(16, 270);
            CA20102.Name = "CA20102";
            CA20102.Size = new Size(54, 20);
            CA20102.TabIndex = 4;
            CA20102.Text = "Temp2";
            // 
            // CA2011
            // 
            CA2011.AutoSize = true;
            CA2011.Location = new Point(12, 153);
            CA2011.Name = "CA2011";
            CA2011.Size = new Size(54, 20);
            CA2011.TabIndex = 5;
            CA2011.Text = "Temp1";
            // 
            // CA201102
            // 
            CA201102.AutoSize = true;
            CA201102.Location = new Point(16, 185);
            CA201102.Name = "CA201102";
            CA201102.Size = new Size(54, 20);
            CA201102.TabIndex = 6;
            CA201102.Text = "Temp2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CA201102);
            Controls.Add(CA2011);
            Controls.Add(CA20102);
            Controls.Add(CA2023);
            Controls.Add(CA20101);
            Controls.Add(PCA2011);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label PCA2011;
        private Label CA20101;
        private Label CA2023;
        private Label CA20102;
        private Label CA2011;
        private Label CA201102;
    }
}