using QRCoder;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GeradorQrCodes
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnGerarQrCode_Click(object sender, EventArgs e)
        {
            string urlRede = TxtUrlRede.Text != null ? TxtUrlRede.Text : "";

            QRCodeGenerator gerador = new ();
            QRCodeData infoQrCode = gerador.CreateQrCode(urlRede, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new(infoQrCode);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);

            SaveFileDialog saveFileDialog = new ();
            saveFileDialog.Filter = "Imagens PNG (*.png)|*.png";
            saveFileDialog.FileName = "New_QrCode.png";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog.FileName;
                
                qrCodeImage.Save(path);
                TxtUrlRede.Text = "";
            }

        }
    }
}