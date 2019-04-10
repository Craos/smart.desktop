namespace smart.desktop
{
    partial class Main
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.DivisorContainerBarradeTarefas = new System.Windows.Forms.SplitContainer();
            this.BarradeComandos = new DevComponents.DotNetBar.Bar();
            this.BotaoIniciar = new DevComponents.DotNetBar.ButtonItem();
            this.BaseMenuIniciar = new DevComponents.DotNetBar.ControlContainerItem();
            this.barraDireita1 = new smart.desktop.BarraDireita();
            this.BaseAreadeTrabalho = new DevComponents.DotNetBar.Metro.MetroTilePanel();
            this.ContainerAreadeTrabalho = new DevComponents.DotNetBar.ItemContainer();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.RelogioSistema = new System.Windows.Forms.Timer(this.components);
            this.menuIniciar1 = new smart.desktop.MenuIniciar();
            ((System.ComponentModel.ISupportInitialize)(this.DivisorContainerBarradeTarefas)).BeginInit();
            this.DivisorContainerBarradeTarefas.Panel1.SuspendLayout();
            this.DivisorContainerBarradeTarefas.Panel2.SuspendLayout();
            this.DivisorContainerBarradeTarefas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarradeComandos)).BeginInit();
            this.SuspendLayout();
            // 
            // DivisorContainerBarradeTarefas
            // 
            this.DivisorContainerBarradeTarefas.BackColor = System.Drawing.Color.Transparent;
            this.DivisorContainerBarradeTarefas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DivisorContainerBarradeTarefas.Location = new System.Drawing.Point(0, 620);
            this.DivisorContainerBarradeTarefas.Name = "DivisorContainerBarradeTarefas";
            // 
            // DivisorContainerBarradeTarefas.Panel1
            // 
            this.DivisorContainerBarradeTarefas.Panel1.Controls.Add(this.BarradeComandos);
            // 
            // DivisorContainerBarradeTarefas.Panel2
            // 
            this.DivisorContainerBarradeTarefas.Panel2.Controls.Add(this.barraDireita1);
            this.DivisorContainerBarradeTarefas.Size = new System.Drawing.Size(1006, 35);
            this.DivisorContainerBarradeTarefas.SplitterDistance = 953;
            this.DivisorContainerBarradeTarefas.SplitterWidth = 1;
            this.DivisorContainerBarradeTarefas.TabIndex = 11;
            // 
            // BarradeComandos
            // 
            this.BarradeComandos.AccessibleDescription = "DotNetBar Bar (BarradeComandos)";
            this.BarradeComandos.AccessibleName = "DotNetBar Bar";
            this.BarradeComandos.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.BarradeComandos.AntiAlias = true;
            this.BarradeComandos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(59)))), ((int)(((byte)(64)))));
            this.BarradeComandos.BarType = DevComponents.DotNetBar.eBarType.MenuBar;
            this.BarradeComandos.CanDockDocument = true;
            this.BarradeComandos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BarradeComandos.DockTabStripHeight = 32;
            this.BarradeComandos.FadeEffect = true;
            this.BarradeComandos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarradeComandos.IsMaximized = false;
            this.BarradeComandos.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.BotaoIniciar});
            this.BarradeComandos.ItemSpacing = 10;
            this.BarradeComandos.Location = new System.Drawing.Point(0, 0);
            this.BarradeComandos.Margin = new System.Windows.Forms.Padding(0);
            this.BarradeComandos.MenuBar = true;
            this.BarradeComandos.Name = "BarradeComandos";
            this.BarradeComandos.PaddingBottom = 0;
            this.BarradeComandos.PaddingLeft = 0;
            this.BarradeComandos.PaddingRight = 0;
            this.BarradeComandos.PaddingTop = 0;
            this.BarradeComandos.Size = new System.Drawing.Size(953, 34);
            this.BarradeComandos.Stretch = true;
            this.BarradeComandos.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BarradeComandos.TabIndex = 11;
            this.BarradeComandos.TabStop = false;
            this.BarradeComandos.ThemeAware = true;
            // 
            // BotaoIniciar
            // 
            this.BotaoIniciar.BeginGroup = true;
            this.BotaoIniciar.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.BotaoIniciar.EnableImageAnimation = true;
            this.BotaoIniciar.FixedSize = new System.Drawing.Size(0, 50);
            this.BotaoIniciar.ForeColor = System.Drawing.Color.White;
            this.BotaoIniciar.Image = global::smart.desktop.Properties.Resources.menuIniciar;
            this.BotaoIniciar.Name = "BotaoIniciar";
            this.BotaoIniciar.PersonalizedMenus = DevComponents.DotNetBar.ePersonalizedMenus.Both;
            this.BotaoIniciar.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.Fade;
            this.BotaoIniciar.PopupSide = DevComponents.DotNetBar.ePopupSide.Top;
            this.BotaoIniciar.PopupType = DevComponents.DotNetBar.ePopupType.ToolBar;
            this.BotaoIniciar.PopupWidth = 800;
            this.BotaoIniciar.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.BaseMenuIniciar});
            this.BotaoIniciar.Text = "  &Iniciar";
            this.BotaoIniciar.ThemeAware = true;
            // 
            // BaseMenuIniciar
            // 
            this.BaseMenuIniciar.AllowItemResize = true;
            this.BaseMenuIniciar.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Center;
            this.BaseMenuIniciar.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.BaseMenuIniciar.Name = "BaseMenuIniciar";
            this.BaseMenuIniciar.Text = "controlContainerItem1";
            this.BaseMenuIniciar.ThemeAware = true;
            // 
            // barraDireita1
            // 
            this.barraDireita1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(59)))), ((int)(((byte)(64)))));
            this.barraDireita1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.barraDireita1.Location = new System.Drawing.Point(0, 0);
            this.barraDireita1.Name = "barraDireita1";
            this.barraDireita1.Size = new System.Drawing.Size(52, 35);
            this.barraDireita1.TabIndex = 0;
            // 
            // BaseAreadeTrabalho
            // 
            this.BaseAreadeTrabalho.BackColor = System.Drawing.Color.Transparent;
            this.BaseAreadeTrabalho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            // 
            // 
            // 
            this.BaseAreadeTrabalho.BackgroundStyle.BackColor = System.Drawing.Color.Transparent;
            this.BaseAreadeTrabalho.BackgroundStyle.Class = "MetroTilePanel";
            this.BaseAreadeTrabalho.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.BaseAreadeTrabalho.ContainerControlProcessDialogKey = true;
            this.BaseAreadeTrabalho.DragDropSupport = true;
            this.BaseAreadeTrabalho.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ContainerAreadeTrabalho});
            this.BaseAreadeTrabalho.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.BaseAreadeTrabalho.Location = new System.Drawing.Point(12, 28);
            this.BaseAreadeTrabalho.MultiLine = true;
            this.BaseAreadeTrabalho.Name = "BaseAreadeTrabalho";
            this.BaseAreadeTrabalho.ReserveLeftSpace = false;
            this.BaseAreadeTrabalho.Size = new System.Drawing.Size(369, 574);
            this.BaseAreadeTrabalho.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BaseAreadeTrabalho.TabIndex = 13;
            this.BaseAreadeTrabalho.Text = "metroTilePanel1";
            // 
            // ContainerAreadeTrabalho
            // 
            // 
            // 
            // 
            this.ContainerAreadeTrabalho.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ContainerAreadeTrabalho.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.ContainerAreadeTrabalho.MultiLine = true;
            this.ContainerAreadeTrabalho.Name = "ContainerAreadeTrabalho";
            // 
            // 
            // 
            this.ContainerAreadeTrabalho.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // RelogioSistema
            // 
            this.RelogioSistema.Interval = 1000;
            this.RelogioSistema.Tick += new System.EventHandler(this.RelogioSistema_Tick);
            // 
            // menuIniciar1
            // 
            this.menuIniciar1.BackColor = System.Drawing.Color.White;
            this.menuIniciar1.Location = new System.Drawing.Point(619, 106);
            this.menuIniciar1.Name = "menuIniciar1";
            this.menuIniciar1.Size = new System.Drawing.Size(340, 485);
            this.menuIniciar1.TabIndex = 14;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1006, 655);
            this.Controls.Add(this.menuIniciar1);
            this.Controls.Add(this.BaseAreadeTrabalho);
            this.Controls.Add(this.DivisorContainerBarradeTarefas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.DivisorContainerBarradeTarefas.Panel1.ResumeLayout(false);
            this.DivisorContainerBarradeTarefas.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DivisorContainerBarradeTarefas)).EndInit();
            this.DivisorContainerBarradeTarefas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BarradeComandos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer DivisorContainerBarradeTarefas;
        private DevComponents.DotNetBar.Bar BarradeComandos;
        private DevComponents.DotNetBar.ButtonItem BotaoIniciar;
        private DevComponents.DotNetBar.Metro.MetroTilePanel BaseAreadeTrabalho;
        private DevComponents.DotNetBar.ItemContainer ContainerAreadeTrabalho;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.ControlContainerItem BaseMenuIniciar;
        public System.Windows.Forms.Timer RelogioSistema;
        private BarraDireita barraDireita1;
        private MenuIniciar menuIniciar1;
    }
}

