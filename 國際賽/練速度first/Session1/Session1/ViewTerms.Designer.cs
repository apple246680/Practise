namespace Session1
{
    partial class ViewTerms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewTerms));
            this.TermsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // TermsRichTextBox
            // 
            this.TermsRichTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.TermsRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TermsRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TermsRichTextBox.Location = new System.Drawing.Point(0, 0);
            this.TermsRichTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.TermsRichTextBox.Name = "TermsRichTextBox";
            this.TermsRichTextBox.Size = new System.Drawing.Size(782, 453);
            this.TermsRichTextBox.TabIndex = 0;
            this.TermsRichTextBox.Text = resources.GetString("TermsRichTextBox.Text");
            // 
            // ViewTerms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.TermsRichTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ViewTerms";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seoul Stay - ViewTerms";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox TermsRichTextBox;
    }
}