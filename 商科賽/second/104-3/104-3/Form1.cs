namespace _104_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Enumerable.Range(0,100).OrderBy(x=>Guid.NewGuid()).Take(10).Average();
            List<double> list = new List<double>();
            for (int i = 0; i < 10; i++)
            {
                Random a=new Random();
                double b=a.Next(100);
                if (b>=0&&b<=100)
                {
                    list.Add(b);
                }
            }
            double n= list.Average();
            InitializeComponent();
        }
        string imagePath = "";
        public bool[] GetSurroundingPixels(Bitmap image, int x, int y)
        {
            bool[] surrounding = new bool[8];
            Color pixel;
            int index = 0;
            for (int xOffset = -1; xOffset <= 1; xOffset++)
            {
                for (int yOffset = -1; yOffset <= 1; yOffset++)
                {
                    pixel = image.GetPixel(x + xOffset, y + yOffset);
                    if (xOffset != 0 || yOffset != 0)
                    {
                        if (pixel.G == 255)
                        {
                            surrounding[index] = false;
                            index++;
                        }
                        else if (pixel.G == 0)
                        {
                            surrounding[index] = true;
                            index++;
                        }
                    }
                }
            }
            return surrounding;
        }
        private void OpenImageBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog()
            {
                FileName = ".bmp",
                Filter = "BMP Files (*.bmp)|*.bmp"
            };
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                imagePath = dlg.FileName;
                ShowPictureBox.ImageLocation = imagePath;
                ClearBtn.Enabled = true;
            }
        }
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            Bitmap original = new Bitmap(ShowPictureBox.Image);
            Bitmap processed = new Bitmap(ShowPictureBox.Image);
            bool[] surrounding;
            for (int x = 1; x < ShowPictureBox.Image.Width - 1; x++)
            {
                for (int y = 1; y < ShowPictureBox.Image.Height - 1; y++)
                {
                    if (original.GetPixel(x, y).R == 0)
                    {
                        surrounding = GetSurroundingPixels(original, x, y);
                        for (int index = 0; index < surrounding.Length; index++)
                        {
                            if (!surrounding[index])
                            {
                                processed.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                                break;
                            }
                        }
                    }
                }
            }
            ShowPictureBox.Image = processed;
        }
    }
}