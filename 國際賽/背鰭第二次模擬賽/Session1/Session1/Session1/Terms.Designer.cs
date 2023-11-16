namespace Session1
{
    partial class Terms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Terms));
            this.TermsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // TermsRichTextBox
            // 
            this.TermsRichTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.TermsRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TermsRichTextBox.Font = new System.Drawing.Font("Open Sans Light", 10F);
            this.TermsRichTextBox.Location = new System.Drawing.Point(0, 0);
            this.TermsRichTextBox.Name = "TermsRichTextBox";
            this.TermsRichTextBox.Size = new System.Drawing.Size(800, 519);
            this.TermsRichTextBox.TabIndex = 0;
            this.TermsRichTextBox.Text = resources.GetString("TermsRichTextBox.Text");
            // 
            // Terms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 519);
            this.Controls.Add(this.TermsRichTextBox);
            this.Font = new System.Drawing.Font("Open Sans Light", 8.25F);
            this.Name = "Terms";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seoul Stay - Terms";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox TermsRichTextBox;
    }
}