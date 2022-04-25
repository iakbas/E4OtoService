
namespace E4Oto.Main.Pages
{
    partial class Musteriler
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            this.GRC = new DevExpress.XtraGrid.GridControl();
            this.GRW = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.GRC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRW)).BeginInit();
            this.SuspendLayout();
            // 
            // GRC
            // 
            this.GRC.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode2.RelationName = "Level1";
            this.GRC.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2});
            this.GRC.Location = new System.Drawing.Point(0, 0);
            this.GRC.MainView = this.GRW;
            this.GRC.Name = "GRC";
            this.GRC.Size = new System.Drawing.Size(679, 466);
            this.GRC.TabIndex = 0;
            this.GRC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GRW});
            // 
            // GRW
            // 
            this.GRW.GridControl = this.GRC;
            this.GRW.Name = "GRW";
            // 
            // Musteriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 466);
            this.Controls.Add(this.GRC);
            this.Name = "Musteriler";
            this.Text = "Musteriler";
            this.Load += new System.EventHandler(this.Musteriler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GRC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRW)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl GRC;
        private DevExpress.XtraGrid.Views.Grid.GridView GRW;
    }
}