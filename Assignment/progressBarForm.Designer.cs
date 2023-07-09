namespace Assignment
{
    partial class progressBarForm
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
            progressBar1 = new ProgressBar();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(58, 41);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(241, 28);
            progressBar1.TabIndex = 0;
            // 
            // progressBarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(355, 122);
            Controls.Add(progressBar1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "progressBarForm";
            Text = "progressBarForm";
            ResumeLayout(false);
        }

        #endregion

        private ProgressBar progressBar1;
    }
}