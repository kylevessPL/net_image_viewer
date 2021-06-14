using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using AForge.Imaging.Filters;
using ImageEditor.Forms.Utils;
using Image = AForge.Imaging.Image;

namespace ImageEditor.Forms
{
    public partial class MainForm : Form
    {
        private const string Filter = "JPEG|*.jpg; *.jpeg; *.jpe; *.jfif|PNG|*.png";
        private string _fileName;

        private Bitmap _image;
        private int _imageHeight;
        private int _imageWidth;
        private float _zoom = 1;

        public MainForm()
        {
            InitializeComponent();
        }

        private void LoadImage()
        {
            using var openFileDialog = new OpenFileDialog
            {
                Title = @"Open Image",
                Filter = Filter,
                RestoreDirectory = true
            };

            if (openFileDialog.ShowDialog() != DialogResult.OK) return;
            _fileName = openFileDialog.FileName;
            SetImage(new Bitmap(_fileName));
        }

        private void SetImage(Bitmap image)
        {
            var source = image;
            image = Image.Clone(source, PixelFormat.Format24bppRgb);
            _image = image;
            pictureBox.Image = _image;
            source.Dispose();
            UpdateSize();
            AdjustToWindow();
        }

        private void AdjustToWindow()
        {
            var parent = pictureBox.Parent;
            _zoom = Math.Min((float) parent.Width / _imageWidth, (float) parent.Height / _imageHeight);
            UpdateZoom();
        }

        private void UpdateSize()
        {
            _imageWidth = pictureBox.Image.Width;
            _imageHeight = pictureBox.Image.Height;
        }

        private void UpdateZoom()
        {
            var parent = pictureBox.Parent;
            var width = (int) (_imageWidth * _zoom);
            var height = (int) (_imageHeight * _zoom);
            var x = (parent.Width - width) / 2;
            var y = (parent.Height - height) / 2;
            pictureBox.Location = new Point(x, y);
            pictureBox.Width = width;
            pictureBox.Height = height;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.BorderStyle = BorderStyle.FixedSingle;
        }

        private void SaveImage()
        {
            if (pictureBox.Image == null) return;
            if (_fileName == null)
            {
                SaveImageAs();
                return;
            }

            var image = new Bitmap(pictureBox.Image);
            pictureBox.Image.Dispose();
            image.Save(_fileName);
            SetImage(image);
        }

        private void SaveImageAs()
        {
            if (pictureBox.Image == null) return;
            using var saveFileDialog = new SaveFileDialog
            {
                Filter = Filter,
                RestoreDirectory = true,
                FileName = Path.GetFileName(_fileName)
            };
            if (saveFileDialog.ShowDialog() != DialogResult.OK) return;
            _fileName = saveFileDialog.FileName;
            SaveImage();
        }

        private void ApplyFilter(IFilter filter)
        {
            try
            {
                pictureBox.Image = filter.Apply((Bitmap) pictureBox.Image);
            }
            catch (ArgumentException)
            {
                MessageBox.Show(@"Selected filter can not be applied to the image", @"Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadImage();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveImage();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveImageAs();
        }

        private void zoomInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZoomIn();
        }

        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZoomOut();
        }

        private void ConvertToGrayscale()
        {
            if (pictureBox.Image.PixelFormat != PixelFormat.Format8bppIndexed)
                ApplyFilter(Grayscale.CommonAlgorithms.BT709);
        }

        private void ConvertToRgb()
        {
            if (pictureBox.Image.PixelFormat != PixelFormat.Format24bppRgb)
                ApplyFilter(new GrayscaleToRGB());
        }

        private void ZoomIn()
        {
            var z = _zoom * 1.5f;
            if (!(z <= 10)) return;
            _zoom = z;
            UpdateZoom();
        }

        private void ZoomOut()
        {
            var z = _zoom / 1.5f;
            if (!(z >= 0.05)) return;
            _zoom = z;
            UpdateZoom();
        }

        private void grayscaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image == null) return;
            ConvertToGrayscale();
        }

        private void sepiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image == null) return;
            ConvertToRgb();
            ApplyFilter(new Sepia());
        }

        private void homogenityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image == null) return;
            ConvertToGrayscale();
            ApplyFilter(new HomogenityEdgeDetector());
        }

        private void differenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image == null) return;
            ConvertToGrayscale();
            ApplyFilter(new DifferenceEdgeDetector());
        }

        private void sobelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image == null) return;
            ConvertToGrayscale();
            ApplyFilter(new SobelEdgeDetector());
        }

        private void erosionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image == null) return;
            ConvertToGrayscale();
            ApplyFilter(new Erosion());
        }

        private void dilatationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image == null) return;
            ConvertToGrayscale();
            ApplyFilter(new Dilatation());
        }

        private void openingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image == null) return;
            ConvertToGrayscale();
            ApplyFilter(new Opening());
        }

        private void closingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image == null) return;
            ConvertToGrayscale();
            ApplyFilter(new Closing());
        }

        private void openImageToolbarButton_Click(object sender, EventArgs e)
        {
            LoadImage();
        }

        private void saveImageToolbarButton_Click(object sender, EventArgs e)
        {
            SaveImage();
        }

        private void zoomInToolbarButton_Click(object sender, EventArgs e)
        {
            ZoomIn();
        }

        private void zoomOutToolbarButton_Click(object sender, EventArgs e)
        {
            ZoomOut();
        }

        private void copyToClipboardToolbarButton_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image != null) Clipboard.SetDataObject(pictureBox.Image, true);
        }

        private void pasteFromClipboardToolbarButton_Click(object sender, EventArgs e)
        {
            if (!Clipboard.GetDataObject().GetDataPresent(DataFormats.Bitmap)) return;
            var image = (Bitmap) Clipboard.GetDataObject().GetData(DataFormats.Bitmap);
            if (image == null ||
                pictureBox.Image != null && BitmapUtils.Compare((Bitmap) pictureBox.Image, image)) return;
            pictureBox.Image?.Dispose();
            SetImage(image);
            _fileName = null;
        }

        private void adjustToWindow_Click(object sender, EventArgs e)
        {
            AdjustToWindow();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            AdjustToWindow();
        }
    }
}