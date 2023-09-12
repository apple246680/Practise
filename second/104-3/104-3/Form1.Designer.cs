namespace _104_3
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
            ShowPictureBox = new PictureBox();
            OpenImageBtn = new Button();
            ClearBtn = new Button();
            openFileDialog = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)ShowPictureBox).BeginInit();
            SuspendLayout();
            // 
            // ShowPictureBox
            // 
            ShowPictureBox.Location = new Point(12, 12);
            ShowPictureBox.Name = "ShowPictureBox";
            ShowPictureBox.Size = new Size(776, 272);
            ShowPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            ShowPictureBox.TabIndex = 0;
            ShowPictureBox.TabStop = false;
            // 
            // OpenImageBtn
            // 
            OpenImageBtn.Location = new Point(169, 340);
            OpenImageBtn.Name = "OpenImageBtn";
            OpenImageBtn.Size = new Size(94, 29);
            OpenImageBtn.TabIndex = 1;
            OpenImageBtn.Text = "開啟圖檔...";
            OpenImageBtn.UseVisualStyleBackColor = true;
            OpenImageBtn.Click += OpenImageBtn_Click;
            // 
            // ClearBtn
            // 
            ClearBtn.Enabled = false;
            ClearBtn.Location = new Point(362, 340);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(94, 29);
            ClearBtn.TabIndex = 2;
            ClearBtn.Text = "侵蝕處理";
            ClearBtn.UseVisualStyleBackColor = true;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = ".bmp";
            openFileDialog.Filter = "BMP檔案(*.bmp)|*.bmp";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ClearBtn);
            Controls.Add(OpenImageBtn);
            Controls.Add(ShowPictureBox);
            Name = "Form1";
            Text = " 侵蝕處理";
            ((System.ComponentModel.ISupportInitialize)ShowPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox ShowPictureBox;
        private Button OpenImageBtn;
        private Button ClearBtn;
        private OpenFileDialog openFileDialog;
    }
}