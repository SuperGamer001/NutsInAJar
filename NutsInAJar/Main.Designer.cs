namespace NutsInAJar
{
    partial class Main
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
            label1 = new Label();
            IGuessBTN = new Button();
            label2 = new Label();
            AIGuessBTN = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 9);
            label1.Name = "label1";
            label1.Size = new Size(206, 15);
            label1.TabIndex = 0;
            label1.Text = "Welcome to the NUTS IN A JAR Game";
            // 
            // IGuessBTN
            // 
            IGuessBTN.Location = new Point(90, 134);
            IGuessBTN.Name = "IGuessBTN";
            IGuessBTN.Size = new Size(146, 61);
            IGuessBTN.TabIndex = 1;
            IGuessBTN.Text = "I will guess";
            IGuessBTN.UseVisualStyleBackColor = true;
            IGuessBTN.Click += IGuessBTN_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 44);
            label2.Name = "label2";
            label2.Size = new Size(312, 30);
            label2.TabIndex = 2;
            label2.Text = "In this game, either you or the AI has to guess the number\r\nof nuts in a jar the other provides. Good luck!\r\n";
            // 
            // AIGuessBTN
            // 
            AIGuessBTN.Location = new Point(90, 221);
            AIGuessBTN.Name = "AIGuessBTN";
            AIGuessBTN.Size = new Size(146, 61);
            AIGuessBTN.TabIndex = 3;
            AIGuessBTN.Text = "The AI will guess";
            AIGuessBTN.UseVisualStyleBackColor = true;
            AIGuessBTN.Click += AIGuessBTN_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(332, 366);
            Controls.Add(AIGuessBTN);
            Controls.Add(label2);
            Controls.Add(IGuessBTN);
            Controls.Add(label1);
            Name = "Main";
            Text = "Nuts In a Jar Game";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button IGuessBTN;
        private Label label2;
        private Button AIGuessBTN;
    }
}
