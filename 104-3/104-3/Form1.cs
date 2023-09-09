namespace _104_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string imagePath = "";
        public bool[] GetSurroundingPixels(Bitmap image, int x, int y)
        {
            bool[] surroundingPixels = new bool[8];
            Color pixelColor;
            int pixelIndex = 0;
            for (int xOffset = -1; xOffset <= 1; xOffset++)
            {
                for (int yOffset = -1; yOffset <= 1; yOffset++)
                {
                    pixelColor = image.GetPixel(x + xOffset, y + yOffset);
                    if (xOffset != 0 || yOffset != 0)
                    {
                        if (pixelColor.G == 255)
                        {
                            surroundingPixels[pixelIndex] = false;
                            pixelIndex++;
                        }
                        else if (pixelColor.G == 0)
                        {
                            surroundingPixels[pixelIndex] = true;
                            pixelIndex++;
                        }
                    }
                }
            }
            return surroundingPixels;
        }
        private void OpenImageBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imagePath = openFileDialog.FileName;
                ShowPictureBox.ImageLocation = imagePath;
                ClearBtn.Enabled = true;
            }
        }
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            Bitmap originalImage = new Bitmap(ShowPictureBox.Image);
            Bitmap corrodedImage = new Bitmap(ShowPictureBox.Image);
            bool[] surroundingPixels;
            for (int x = 1; x < ShowPictureBox.Image.Width - 1; x++)
            {
                for (int y = 1; y < ShowPictureBox.Image.Height - 1; y++)
                {
                    if (originalImage.GetPixel(x, y).R == 0)
                    {
                        surroundingPixels = GetSurroundingPixels(originalImage, x, y);
                        for (int index = 0; index < surroundingPixels.Length; index++)
                        {
                            if (!surroundingPixels[index])
                            {
                                corrodedImage.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                                break;
                            }
                        }
                    }
                }
            }
            ShowPictureBox.Image = corrodedImage;
        }
    }
}