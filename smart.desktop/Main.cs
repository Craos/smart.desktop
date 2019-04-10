using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Metro;
using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace smart.desktop
{
    public partial class Main : Form
    {
        [DllImport("user32.dll")]
        [return: System.Runtime.InteropServices.MarshalAs(UnmanagedType.Bool)]
        private static extern bool ShowWindow(IntPtr hWnd, ShowWindowEnum flags);

        [DllImport("user32.dll")]
        private static extern int SetForegroundWindow(IntPtr hwnd);

        private enum ShowWindowEnum
        {
            Hide = 0,
            ShowNormal = 1, ShowMinimized = 2, ShowMaximized = 3,
            Maximize = 3, ShowNormalNoActivate = 4, Show = 5,
            Minimize = 6, ShowMinNoActivate = 7, ShowNoActivate = 8,
            Restore = 9, ShowDefault = 10, ForceMinimized = 11
        };

        List<Processo> processosExecutando = new List<Processo>();
        public Main()
        {
            InitializeComponent();

            SuspendLayout();
            BackgroundImage = Properties.Resources.fundo;
            MontaAplicativo(@"C:\Windows\System32\notepad.exe");
            MontaAplicativo(@"C:\Windows\System32\calc.exe");
            MontaAplicativo(@"C:\Program Files\Mozilla Firefox\firefox.exe");
            MontaAplicativo(@"C:\Program Files\iSpy\iSpy.exe");
            MontaAplicativo(@"C:\Program Files (x86)\Foxit Software\Foxit Reader\FoxitReader.exe");
            MontaAplicativo(@"C:\Teamviewer\TeamViewer.exe");
            BaseMenuIniciar.Control = menuIniciar1;
            BaseAreadeTrabalho.Dock = DockStyle.Fill;
            ResumeLayout(true);


            NetworkChange.NetworkAvailabilityChanged += NetworkChange_NetworkAvailabilityChanged;

            Shown += Main_Shown;

        }

        private void NetworkChange_NetworkAvailabilityChanged(object sender, NetworkAvailabilityEventArgs e)
        {
            NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface n in adapters)
            {
                Console.WriteLine("   {0} is {1}", n.Name, n.OperationalStatus);
                barraDireita1.BotaoRede.Image = Properties.Resources.rede_ok;
                if (n.OperationalStatus != OperationalStatus.Up)
                    barraDireita1.BotaoRede.Image = Properties.Resources.rede_erro;

            }
        }

        private void Main_Shown(object sender, EventArgs e)
        {
            RelogioSistema.Start();
        }

        private void MontaAplicativo(string Caminho)
        {
            Processo processo = new Processo(Caminho);
            MetroTileItem iconeAreadeTrabalho = processo.MontaIconeAreadeTrabalho();
            iconeAreadeTrabalho.DoubleClick += MetroTileItemItemClick;
            ContainerAreadeTrabalho.SubItems.Add(iconeAreadeTrabalho);

            MetroTileItem iconeMenuIniciar = processo.MontaItemMenuIniciar();
            iconeMenuIniciar.Click += IconeMenuIniciar_Click;
            menuIniciar1.ContainerAplicativos.SubItems.Add(iconeMenuIniciar);
        }

        private void IconeMenuIniciar_Click(object sender, EventArgs e)
        {
            ButtonItem tileItem = ((ButtonItem)sender);
            Processo itemproc = (Processo)tileItem.Tag;
            ExecutarAplicativo(itemproc);
        }

        private void MetroTileItemItemClick(object sender, EventArgs e)
        {
            MetroTileItem tileItem = ((MetroTileItem)sender);
            Processo itemproc = (Processo)tileItem.Tag;
            ExecutarAplicativo(itemproc);
        }


        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);
        private void ExecutarAplicativo(Processo Item)
        {
            int nbActiveProcesses = 0;
            AutoResetEvent waitEvent = new AutoResetEvent(false);

            if (nbActiveProcesses == 8) waitEvent.WaitOne();

            Interlocked.Increment(ref nbActiveProcesses);

            if (Item.Start() == true)
            {
                ButtonItem buttonItem = Item.MontaBotaoBarradeComandos();
                buttonItem.Click += ButtonItem_Click;
                BarradeComandos.Items.Add(Item.BotaoBarraComandos);
                Item.Exited += ExternalProcess_Exited;
                processosExecutando.Add(Item);

                Item.WaitForInputIdle(10000);
                IntPtr pt = Item.MainWindowHandle;

                if (InvokeRequired)
                {
                    SetParent(pt, this.Handle);
                }
                else
                {
                    SetParent(pt, this.Handle);
                }

                Interlocked.Decrement(ref nbActiveProcesses);
                waitEvent.Set();
            }
        }



        private void ButtonItem_Click(object sender, EventArgs e)
        {
            ButtonItem tileItem = ((ButtonItem)sender);
            Processo itemproc = (Processo)tileItem.Tag;

            // check if the window is hidden / minimized
            if (itemproc.MainWindowHandle == IntPtr.Zero)
            {
                // the window is hidden so try to restore it before setting focus.
                ShowWindow(itemproc.Handle, ShowWindowEnum.Restore);
            }

            // set user the focus to the window
            SetForegroundWindow(itemproc.MainWindowHandle);
        }
        private void ExternalProcess_Exited(object sender, EventArgs e)
        {
            try
            {
                Processo item = processosExecutando.Find(x => x.Handle == ((Processo)sender).Handle);
                processosExecutando.Remove(item);
                BarradeComandos.Items.Remove(item.BotaoBarraComandos);
            }
            catch
            {
            }
        }

        private void RelogioSistema_Tick(object sender, EventArgs e)
        {
            barraDireita1.ControleHorario.Text = DateTime.Now.ToString("T");

        }
    }


}
