
namespace paw_proiect_tiketing
{
    partial class Form1
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
            this.lvProgrammers = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tvProgrammers = new System.Windows.Forms.TreeView();
            this.btnPopulareLV = new System.Windows.Forms.Button();
            this.btnStergereElemLV = new System.Windows.Forms.Button();
            this.btnPopulareTV = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stergeElementLVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stergeElementTVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvProgrammers
            // 
            this.lvProgrammers.CheckBoxes = true;
            this.lvProgrammers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvProgrammers.GridLines = true;
            this.lvProgrammers.Location = new System.Drawing.Point(36, 54);
            this.lvProgrammers.Name = "lvProgrammers";
            this.lvProgrammers.Size = new System.Drawing.Size(419, 261);
            this.lvProgrammers.TabIndex = 0;
            this.lvProgrammers.UseCompatibleStateImageBehavior = false;
            this.lvProgrammers.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nume";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nivel Experienta";
            this.columnHeader2.Width = 117;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Varsta";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Limbaje";
            // 
            // tvProgrammers
            // 
            this.tvProgrammers.Location = new System.Drawing.Point(504, 54);
            this.tvProgrammers.Name = "tvProgrammers";
            this.tvProgrammers.Size = new System.Drawing.Size(392, 261);
            this.tvProgrammers.TabIndex = 1;
            this.tvProgrammers.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvProgrammers_AfterSelect);
            // 
            // btnPopulareLV
            // 
            this.btnPopulareLV.Location = new System.Drawing.Point(71, 378);
            this.btnPopulareLV.Name = "btnPopulareLV";
            this.btnPopulareLV.Size = new System.Drawing.Size(110, 33);
            this.btnPopulareLV.TabIndex = 3;
            this.btnPopulareLV.Text = "PopulareLV";
            this.btnPopulareLV.UseVisualStyleBackColor = true;
            this.btnPopulareLV.Click += new System.EventHandler(this.btnPopulareLV_Click);
            // 
            // btnStergereElemLV
            // 
            this.btnStergereElemLV.Location = new System.Drawing.Point(299, 378);
            this.btnStergereElemLV.Name = "btnStergereElemLV";
            this.btnStergereElemLV.Size = new System.Drawing.Size(129, 33);
            this.btnStergereElemLV.TabIndex = 4;
            this.btnStergereElemLV.Text = "Sterge element";
            this.btnStergereElemLV.UseVisualStyleBackColor = true;
            this.btnStergereElemLV.Click += new System.EventHandler(this.btnStergereElemLV_Click);
            // 
            // btnPopulareTV
            // 
            this.btnPopulareTV.Location = new System.Drawing.Point(570, 378);
            this.btnPopulareTV.Name = "btnPopulareTV";
            this.btnPopulareTV.Size = new System.Drawing.Size(147, 33);
            this.btnPopulareTV.TabIndex = 5;
            this.btnPopulareTV.Text = "Populare TV";
            this.btnPopulareTV.UseVisualStyleBackColor = true;
            this.btnPopulareTV.Click += new System.EventHandler(this.btnPopulareTV_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stergeElementLVToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(199, 28);
            // 
            // stergeElementLVToolStripMenuItem
            // 
            this.stergeElementLVToolStripMenuItem.Name = "stergeElementLVToolStripMenuItem";
            this.stergeElementLVToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.stergeElementLVToolStripMenuItem.Text = "Sterge element LV";
            this.stergeElementLVToolStripMenuItem.Click += new System.EventHandler(this.stergeElementLVToolStripMenuItem_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stergeElementTVToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(201, 28);
            // 
            // stergeElementTVToolStripMenuItem
            // 
            this.stergeElementTVToolStripMenuItem.Name = "stergeElementTVToolStripMenuItem";
            this.stergeElementTVToolStripMenuItem.Size = new System.Drawing.Size(200, 24);
            this.stergeElementTVToolStripMenuItem.Text = "Sterge element TV";
            this.stergeElementTVToolStripMenuItem.Click += new System.EventHandler(this.stergeElementTVToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1115, 571);
            this.Controls.Add(this.btnPopulareTV);
            this.Controls.Add(this.btnStergereElemLV);
            this.Controls.Add(this.btnPopulareLV);
            this.Controls.Add(this.tvProgrammers);
            this.Controls.Add(this.lvProgrammers);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvProgrammers;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TreeView tvProgrammers;
        private System.Windows.Forms.Button btnPopulareLV;
        private System.Windows.Forms.Button btnStergereElemLV;
        private System.Windows.Forms.Button btnPopulareTV;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stergeElementLVToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem stergeElementTVToolStripMenuItem;
    }
}

