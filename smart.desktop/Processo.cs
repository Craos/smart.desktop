using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Metro;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
namespace smart.desktop
{
    public class Processo : Process
    {
        private string _productName;
        private string _company;
        private string _productVersion;
        private Icon _icon;
        private Image _image;

        public ButtonItem BotaoBarraComandos { get; internal set; }
        public MetroTileItem IconeMenuIniciar { get; internal set; }
        public MetroTileItem IconeAreadeTrabalho { get; internal set; }

        public Processo(string Caminho)
        {
            try
            {

                StartInfo.FileName = Caminho;
                _icon = Icon.ExtractAssociatedIcon(StartInfo.FileName);
                _image = _icon.ToBitmap();

                FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(StartInfo.FileName);
                _company = fvi.CompanyName;
                _productName = fvi.FileDescription;
                _productVersion = fvi.ProductVersion;

                EnableRaisingEvents = true;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        public ButtonItem MontaBotaoBarradeComandos()
        {
            BotaoBarraComandos = new ButtonItem();
            BotaoBarraComandos.ButtonStyle = eButtonStyle.ImageAndText;
            BotaoBarraComandos.Icon = _icon;
            BotaoBarraComandos.Text = _productName;
            BotaoBarraComandos.ForeColor = Color.White;
            BotaoBarraComandos.ThemeAware = true;
            BotaoBarraComandos.Tag = this;
            return BotaoBarraComandos;
        }

        public MetroTileItem MontaIconeAreadeTrabalho()
        {
            IconeAreadeTrabalho = new MetroTileItem();
            IconeAreadeTrabalho.SymbolColor = Color.Empty;
            IconeAreadeTrabalho.Text = _productName;
            IconeAreadeTrabalho.TileColor = eMetroTileColor.Default;
            IconeAreadeTrabalho.TileSize = new Size(100, 90);
            IconeAreadeTrabalho.TileStyle.BackColor = Color.Transparent;
            IconeAreadeTrabalho.TileStyle.BackColor2 = Color.Transparent;
            IconeAreadeTrabalho.TileStyle.BackgroundImage = _image;
            IconeAreadeTrabalho.TileStyle.BackgroundImagePosition = eStyleBackgroundImage.Center;
            IconeAreadeTrabalho.TileStyle.BorderBottom = eStyleBorderType.Solid;
            IconeAreadeTrabalho.TileStyle.BorderColor = Color.Transparent;
            IconeAreadeTrabalho.TileStyle.BorderLeft = eStyleBorderType.Solid;
            IconeAreadeTrabalho.TileStyle.BorderRight = eStyleBorderType.Solid;
            IconeAreadeTrabalho.TileStyle.BorderTop = eStyleBorderType.Solid;
            IconeAreadeTrabalho.TileStyle.CornerType = eCornerType.Square;
            IconeAreadeTrabalho.TileStyle.TextAlignment = eStyleTextAlignment.Center;
            IconeAreadeTrabalho.TileStyle.TextLineAlignment = eStyleTextAlignment.Far;
            IconeAreadeTrabalho.TileStyle.WordWrap = true;
            IconeAreadeTrabalho.Tag = this;
            return IconeAreadeTrabalho;
        }

        public MetroTileItem MontaItemMenuIniciar()
        {
            IconeMenuIniciar = new MetroTileItem();
            IconeMenuIniciar.SymbolColor = System.Drawing.Color.Empty;
            IconeMenuIniciar.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Default;
            IconeMenuIniciar.TileSize = new System.Drawing.Size(100, 100);
            IconeMenuIniciar.TileStyle.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            IconeMenuIniciar.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(0, 120, 215);
            IconeMenuIniciar.TileStyle.BackgroundImage = _image;
            IconeMenuIniciar.TileStyle.BackgroundImagePosition = DevComponents.DotNetBar.eStyleBackgroundImage.Center;
            IconeMenuIniciar.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            IconeMenuIniciar.TitleText = _productName;
            IconeMenuIniciar.TileStyle.WordWrap = true;
            IconeMenuIniciar.Tag = this;
            IconeMenuIniciar.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter;

            /*IconeMenuIniciar = new ButtonItem();
            IconeMenuIniciar.ButtonStyle = eButtonStyle.ImageAndText;
            IconeMenuIniciar.Image = _image;
            IconeMenuIniciar.Text = _productName;
            IconeMenuIniciar.ThemeAware = true;
            IconeMenuIniciar.Tag = this;
            IconeMenuIniciar.ImagePaddingHorizontal = 20;
            IconeMenuIniciar.ImagePaddingVertical = 28;*/
            return IconeMenuIniciar;
        }
    }
}
