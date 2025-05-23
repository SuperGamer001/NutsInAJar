namespace NutsInAJar
{
    partial class DifficultyForm
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
            easyBTN = new Button();
            NormalBTN = new Button();
            HardBTN = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(258, 15);
            label1.TabIndex = 0;
            label1.Text = "Before the game begins, please pick a difficulty.\r\n";
            // 
            // easyBTN
            // 
            easyBTN.Location = new Point(80, 76);
            easyBTN.Name = "easyBTN";
            easyBTN.Size = new Size(113, 23);
            easyBTN.TabIndex = 1;
            easyBTN.Text = "Easy (0 - 10)";
            easyBTN.UseVisualStyleBackColor = true;
            easyBTN.Click += easyBTN_Click;
            // 
            // NormalBTN
            // 
            NormalBTN.Location = new Point(80, 141);
            NormalBTN.Name = "NormalBTN";
            NormalBTN.Size = new Size(113, 23);
            NormalBTN.TabIndex = 2;
            NormalBTN.Text = "Normal (0 - 30)";
            NormalBTN.UseVisualStyleBackColor = true;
            NormalBTN.Click += NormalBTN_Click;
            // 
            // HardBTN
            // 
            HardBTN.Location = new Point(80, 207);
            HardBTN.Name = "HardBTN";
            HardBTN.Size = new Size(113, 23);
            HardBTN.TabIndex = 3;
            HardBTN.Text = "Hard (0 - 80)";
            HardBTN.UseVisualStyleBackColor = true;
            HardBTN.Click += HardBTN_Click;
            // 
            // DifficultyForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(285, 306);
            Controls.Add(HardBTN);
            Controls.Add(NormalBTN);
            Controls.Add(easyBTN);
            Controls.Add(label1);
            Name = "DifficultyForm";
            Text = "DifficultyForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button easyBTN;
        private Button NormalBTN;
        private Button HardBTN;
    }
}