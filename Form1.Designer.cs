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
            DB_Value_Holder = new ListBox();
            label1 = new Label();
            CA_Holders = new ListBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(421, 264);
            button1.Name = "button1";
            button1.Size = new Size(308, 29);
            button1.TabIndex = 0;
            button1.Text = "Press to Upload File for DB file checking";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // DB_Value_Holder
            // 
            DB_Value_Holder.FormattingEnabled = true;
            DB_Value_Holder.Location = new Point(12, 68);
            DB_Value_Holder.Name = "DB_Value_Holder";
            DB_Value_Holder.Size = new Size(477, 144);
            DB_Value_Holder.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 46);
            label1.Name = "label1";
            label1.Size = new Size(422, 20);
            label1.TabIndex = 8;
            label1.Text = "The DB Values will populate here once DAT files are uploaded.";
            // 
            // CA_Holders
            // 
            CA_Holders.FormattingEnabled = true;
            CA_Holders.Location = new Point(637, 68);
            CA_Holders.Name = "CA_Holders";
            CA_Holders.Size = new Size(477, 144);
            CA_Holders.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(623, 45);
            label2.Name = "label2";
            label2.Size = new Size(550, 20);
            label2.TabIndex = 10;
            label2.Text = "The Certificate Issuing Authority will display here once the DAT files are uploaded.";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1220, 450);
            Controls.Add(label2);
            Controls.Add(CA_Holders);
            Controls.Add(label1);
            Controls.Add(DB_Value_Holder);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ListBox DB_Value_Holder;
        private Label label1;
        private ListBox CA_Holders;
        private Label label2;
    }
}