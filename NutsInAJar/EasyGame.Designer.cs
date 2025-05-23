namespace NutsInAJar
{
    partial class EasyGame
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
            label1 = new Label();
            MyGuessTXT = new TextBox();
            label2 = new Label();
            enterBTN = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(54, 9);
            label1.Name = "label1";
            label1.Size = new Size(101, 63);
            label1.TabIndex = 0;
            label1.Text = "Nuts in a Jar!\r\n(Easy Mode\r\n)";
            // 
            // MyGuessTXT
            // 
            MyGuessTXT.Location = new Point(54, 192);
            MyGuessTXT.Name = "MyGuessTXT";
            MyGuessTXT.Size = new Size(110, 23);
            MyGuessTXT.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 87);
            label2.Name = "label2";
            label2.Size = new Size(195, 75);
            label2.TabIndex = 2;
            label2.Text = "There are 0-10 nuts. \r\nHow many nuts did I put in the jar? \r\n\r\nI will tell you if your guess\r\nis too high or too low\r\n";
            // 
            // enterBTN
            // 
            enterBTN.Location = new Point(69, 233);
            enterBTN.Name = "enterBTN";
            enterBTN.Size = new Size(75, 23);
            enterBTN.TabIndex = 3;
            enterBTN.Text = "Guess";
            enterBTN.UseVisualStyleBackColor = true;
            enterBTN.Click += enterBTN_Click;
            // 
            // EasyGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(220, 278);
            Controls.Add(enterBTN);
            Controls.Add(label2);
            Controls.Add(MyGuessTXT);
            Controls.Add(label1);
            Name = "EasyGame";
            Text = "EasyGame";
            Load += EasyGame_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox MyGuessTXT;
        private Label label2;
        private Button enterBTN;
    }
}