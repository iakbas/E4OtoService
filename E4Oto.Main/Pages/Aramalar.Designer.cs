
namespace E4Oto.Main.Pages
{
    partial class Aramalar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            this.GRC = new DevExpress.XtraGrid.GridControl();
            this.GRW = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.yeniEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaldırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.görünümToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.GRC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRW)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GRC
            // 
            this.GRC.ContextMenuStrip = this.contextMenuStrip1;
            this.GRC.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode2.RelationName = "Level1";
            this.GRC.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2});
            this.GRC.Location = new System.Drawing.Point(0, 0);
            this.GRC.MainView = this.GRW;
            this.GRC.Name = "GRC";
            this.GRC.Size = new System.Drawing.Size(656, 402);
            this.GRC.TabIndex = 1;
            this.GRC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GRW});
            // 
            // GRW
            // 
            this.GRW.GridControl = this.GRC;
            this.GRW.Name = "GRW";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniEkleToolStripMenuItem,
            this.düzenleToolStripMenuItem,
            this.kaldırToolStripMenuItem,
            this.toolStripSeparator1,
            this.görünümToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(126, 98);
            // 
            // yeniEkleToolStripMenuItem
            // 
            this.yeniEkleToolStripMenuItem.Name = "yeniEkleToolStripMenuItem";
            this.yeniEkleToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.yeniEkleToolStripMenuItem.Text = "Yeni Ekle";
            // 
            // düzenleToolStripMenuItem
            // 
            this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            this.düzenleToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.düzenleToolStripMenuItem.Text = "Düzenle";
            // 
            // kaldırToolStripMenuItem
            // 
            this.kaldırToolStripMenuItem.Name = "kaldırToolStripMenuItem";
            this.kaldırToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.kaldırToolStripMenuItem.Text = "Kaldır";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(122, 6);
            // 
            // görünümToolStripMenuItem
            // 
            this.görünümToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.düzenleToolStripMenuItem1,
            this.kaydetToolStripMenuItem});
            this.görünümToolStripMenuItem.Name = "görünümToolStripMenuItem";
            this.görünümToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.görünümToolStripMenuItem.Text = "Görünüm";
            // 
            // düzenleToolStripMenuItem1
            // 
            this.düzenleToolStripMenuItem1.Name = "düzenleToolStripMenuItem1";
            this.düzenleToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.düzenleToolStripMenuItem1.Text = "Düzenle";
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.kaydetToolStripMenuItem.Text = "Kaydet";
            // 
            // Aramalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 402);
            this.Controls.Add(this.GRC);
            this.Name = "Aramalar";
            this.Text = "Aramalar";
            this.Load += new System.EventHandler(this.Aramalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GRC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRW)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl GRC;
        private DevExpress.XtraGrid.Views.Grid.GridView GRW;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yeniEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaldırToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem görünümToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
    }
}