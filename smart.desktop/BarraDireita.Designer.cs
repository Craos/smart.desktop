namespace smart.desktop
{
    partial class BarraDireita
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BarradeComandos = new DevComponents.DotNetBar.Bar();
            this.controlContainerItem3 = new DevComponents.DotNetBar.ControlContainerItem();
            this.BotaoRede = new DevComponents.DotNetBar.ButtonItem();
            this.ControleHorario = new DevComponents.DotNetBar.ButtonItem();
            this.controlContainerItem2 = new DevComponents.DotNetBar.ControlContainerItem();
            this.Calendario = new System.Windows.Forms.MonthCalendar();
            this.controlContainerItem1 = new DevComponents.DotNetBar.ControlContainerItem();
            ((System.ComponentModel.ISupportInitialize)(this.BarradeComandos)).BeginInit();
            this.SuspendLayout();
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
            this.controlContainerItem3,
            this.BotaoRede,
            this.ControleHorario});
            this.BarradeComandos.ItemSpacing = 2;
            this.BarradeComandos.Location = new System.Drawing.Point(0, 0);
            this.BarradeComandos.Margin = new System.Windows.Forms.Padding(0);
            this.BarradeComandos.MenuBar = true;
            this.BarradeComandos.Name = "BarradeComandos";
            this.BarradeComandos.PaddingBottom = 0;
            this.BarradeComandos.PaddingLeft = 0;
            this.BarradeComandos.PaddingRight = 0;
            this.BarradeComandos.PaddingTop = 0;
            this.BarradeComandos.Size = new System.Drawing.Size(105, 38);
            this.BarradeComandos.Stretch = true;
            this.BarradeComandos.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BarradeComandos.TabIndex = 12;
            this.BarradeComandos.TabStop = false;
            this.BarradeComandos.ThemeAware = true;
            // 
            // controlContainerItem3
            // 
            this.controlContainerItem3.AllowItemResize = false;
            this.controlContainerItem3.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem3.Name = "controlContainerItem3";
            this.controlContainerItem3.Text = "   ";
            this.controlContainerItem3.ThemeAware = true;
            // 
            // BotaoRede
            // 
            this.BotaoRede.Image = global::smart.desktop.Properties.Resources.rede_ok;
            this.BotaoRede.Name = "BotaoRede";
            this.BotaoRede.ThemeAware = true;
            // 
            // ControleHorario
            // 
            this.ControleHorario.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.TextOnlyAlways;
            this.ControleHorario.ForeColor = System.Drawing.Color.White;
            this.ControleHorario.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.ControleHorario.Name = "ControleHorario";
            this.ControleHorario.PopupSide = DevComponents.DotNetBar.ePopupSide.Top;
            this.ControleHorario.PopupType = DevComponents.DotNetBar.ePopupType.ToolBar;
            this.ControleHorario.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.controlContainerItem2});
            this.ControleHorario.Text = "00:00:00";
            this.ControleHorario.ThemeAware = true;
            // 
            // controlContainerItem2
            // 
            this.controlContainerItem2.AllowItemResize = true;
            this.controlContainerItem2.Control = this.Calendario;
            this.controlContainerItem2.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem2.Name = "controlContainerItem2";
            this.controlContainerItem2.Text = "controlContainerItem2";
            this.controlContainerItem2.ThemeAware = true;
            // 
            // Calendario
            // 
            this.Calendario.Location = new System.Drawing.Point(202, 204);
            this.Calendario.Name = "Calendario";
            this.Calendario.TabIndex = 19;
            // 
            // controlContainerItem1
            // 
            this.controlContainerItem1.AllowItemResize = false;
            this.controlContainerItem1.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Center;
            this.controlContainerItem1.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem1.Name = "controlContainerItem1";
            this.controlContainerItem1.ThemeAware = true;
            // 
            // BarraDireita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(59)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.BarradeComandos);
            this.Name = "BarraDireita";
            this.Size = new System.Drawing.Size(105, 40);
            ((System.ComponentModel.ISupportInitialize)(this.BarradeComandos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.Bar BarradeComandos;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem1;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem2;
        private System.Windows.Forms.MonthCalendar Calendario;
        public DevComponents.DotNetBar.ButtonItem ControleHorario;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem3;
        public DevComponents.DotNetBar.ButtonItem BotaoRede;
    }
}
