using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Adicionar a biblioteca da WebCam
using AForge.Video.DirectShow;

namespace ProjetoBiblioteca
{
    public static class ConectaWebCam
    {
        public static VideoCaptureDevice videoSource;
        public static System.Windows.Forms.PictureBox pcbFoto;
        public static byte[] imagem = null;

        // Procurar o dispositivo
        public static void ProcurarDispositivo()
        {
            var videoSources = new
                FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (videoSources != null && videoSources.Count > 0)
            {
                videoSource = new
                    VideoCaptureDevice(videoSources[0].MonikerString);
                videoSource.NewFrame += VideoSource_NewFrame;
            }
        }

        public static void VideoSource_NewFrame(object sender, 
            AForge.Video.NewFrameEventArgs eventArgs)
        {
            if (pcbFoto.Image != null)
                pcbFoto.Image.Dispose();
            pcbFoto.Image = (System.Drawing.Bitmap)eventArgs.Frame.Clone();
        }

        public static void VerificaWebCamLigada()
        {
            if (videoSource.IsRunning)
            {
                videoSource.Stop();
                pcbFoto.Image = null;
            }
            else
            {
                videoSource.Start();
            }
        }

        public static void TiraFoto()
        {
            try
            {
                videoSource.NewFrame -= VideoSource_NewFrame;

                using (var dialog = new System.Windows.Forms.SaveFileDialog())
                {
                    dialog.DefaultExt = "png";
                    dialog.AddExtension = true;

                    if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        pcbFoto.Image.Save(dialog.FileName, ImageFormat.Png);
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Erro: " + ex.Message);
            }
        }

        public static void TiraFotoSalvaBanco()
        {
            videoSource.NewFrame -= VideoSource_NewFrame;

            Bitmap bmp = new Bitmap(pcbFoto.Image);
            MemoryStream memory = new MemoryStream();
            bmp.Save(memory, ImageFormat.Bmp);
            imagem = memory.ToArray();
        }
    }
}
