namespace NutsInAJar
{
    partial class AIGameForm
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
            AIGuessTXT = new Label();
            YesBTN = new Button();
            NoBTN = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(24, 9);
            label1.Name = "label1";
            label1.Size = new Size(160, 21);
            label1.TabIndex = 0;
            label1.Text = "AI is guessing (0 - 50)";
            // 
            // AIGuessTXT
            // 
            AIGuessTXT.AutoSize = true;
            AIGuessTXT.Location = new Point(24, 157);
            AIGuessTXT.Name = "AIGuessTXT";
            AIGuessTXT.Size = new Size(63, 15);
            AIGuessTXT.TabIndex = 1;
            AIGuessTXT.Text = "Thinking...";
            // 
            // YesBTN
            // 
            YesBTN.Location = new Point(12, 243);
            YesBTN.Name = "YesBTN";
            YesBTN.Size = new Size(89, 23);
            YesBTN.TabIndex = 2;
            YesBTN.Text = "Yes";
            YesBTN.UseVisualStyleBackColor = true;
            YesBTN.Click += YesBTN_Click;
            // 
            // NoBTN
            // 
            NoBTN.Location = new Point(119, 243);
            NoBTN.Name = "NoBTN";
            NoBTN.Size = new Size(89, 23);
            NoBTN.TabIndex = 3;
            NoBTN.Text = "No";
            NoBTN.UseVisualStyleBackColor = true;
            NoBTN.Click += NoBTN_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 44);
            label3.Name = "label3";
            label3.Size = new Size(167, 60);
            label3.TabIndex = 4;
            label3.Text = "I have to guess the number of \r\nnuts you put in a jar. \r\n\r\nIt must be within 0 and 50.";
            // 
            // AIGameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(220, 278);
            Controls.Add(label3);
            Controls.Add(NoBTN);
            Controls.Add(YesBTN);
            Controls.Add(AIGuessTXT);
            Controls.Add(label1);
            Name = "AIGameForm";
            Text = "AI is Guessing";
            Load += AIGameForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label AIGuessTXT;
        private Button YesBTN;
        private Button NoBTN;
        private Label label3;
    }
}