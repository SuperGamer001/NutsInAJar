namespace NutsInAJar
{
    partial class HardGame
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
            enterBTN = new Button();
            label2 = new Label();
            MyGuessTXT = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // enterBTN
            // 
            enterBTN.Location = new Point(70, 240);
            enterBTN.Name = "enterBTN";
            enterBTN.Size = new Size(75, 23);
            enterBTN.TabIndex = 7;
            enterBTN.Text = "Guess";
            enterBTN.UseVisualStyleBackColor = true;
            enterBTN.Click += enterBTN_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 94);
            label2.Name = "label2";
            label2.Size = new Size(195, 75);
            label2.TabIndex = 6;
            label2.Text = "There are 0-80 nuts. \r\nHow many nuts did I put in the jar? \r\n\r\nIn Hard mode, I will not be giving\r\n you any guesses.\r\n";
            // 
            // MyGuessTXT
            // 
            MyGuessTXT.Location = new Point(55, 199);
            MyGuessTXT.Name = "MyGuessTXT";
            MyGuessTXT.Size = new Size(110, 23);
            MyGuessTXT.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(44, 16);
            label1.Name = "label1";
            label1.Size = new Size(101, 42);
            label1.TabIndex = 4;
            label1.Text = "Nuts in a Jar!\r\n(Hard Mode)";
            // 
            // HardGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(220, 278);
            Controls.Add(enterBTN);
            Controls.Add(label2);
            Controls.Add(MyGuessTXT);
            Controls.Add(label1);
            Name = "HardGame";
            Text = "HardGame";
            Load += HardGame_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button enterBTN;
        private Label label2;
        private TextBox MyGuessTXT;
        private Label label1;
    }
}