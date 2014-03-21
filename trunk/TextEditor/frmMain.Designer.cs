namespace TextEditor
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.drgMain = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.itemHome = new System.Windows.Forms.ToolStripMenuItem();
            this.itemNew = new System.Windows.Forms.ToolStripMenuItem();
            this.itemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.itemExport = new System.Windows.Forms.ToolStripMenuItem();
            this.itemPlist = new System.Windows.Forms.ToolStripMenuItem();
            this.itemJson = new System.Windows.Forms.ToolStripMenuItem();
            this.itemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.itemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.English = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vietnamese = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.drgMain)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // drgMain
            // 
            this.drgMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drgMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.English,
            this.Vietnamese});
            this.drgMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drgMain.Location = new System.Drawing.Point(0, 24);
            this.drgMain.Name = "drgMain";
            this.drgMain.Size = new System.Drawing.Size(851, 393);
            this.drgMain.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemHome,
            this.itemAbout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(851, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuMain";
            // 
            // itemHome
            // 
            this.itemHome.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemNew,
            this.itemSave,
            this.itemExport,
            this.itemExit});
            this.itemHome.Name = "itemHome";
            this.itemHome.Size = new System.Drawing.Size(52, 20);
            this.itemHome.Text = "Home";
            // 
            // itemNew
            // 
            this.itemNew.Name = "itemNew";
            this.itemNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.itemNew.Size = new System.Drawing.Size(152, 22);
            this.itemNew.Text = "New";
            this.itemNew.Click += new System.EventHandler(this.itemNew_Click);
            // 
            // itemSave
            // 
            this.itemSave.Name = "itemSave";
            this.itemSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.itemSave.Size = new System.Drawing.Size(152, 22);
            this.itemSave.Text = "Save";
            // 
            // itemExport
            // 
            this.itemExport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemPlist,
            this.itemJson});
            this.itemExport.Name = "itemExport";
            this.itemExport.Size = new System.Drawing.Size(152, 22);
            this.itemExport.Text = "Export";
            // 
            // itemPlist
            // 
            this.itemPlist.Name = "itemPlist";
            this.itemPlist.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.itemPlist.Size = new System.Drawing.Size(152, 22);
            this.itemPlist.Text = "PLIST";
            this.itemPlist.Click += new System.EventHandler(this.itemPlist_Click);
            // 
            // itemJson
            // 
            this.itemJson.Name = "itemJson";
            this.itemJson.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.J)));
            this.itemJson.Size = new System.Drawing.Size(152, 22);
            this.itemJson.Text = "JSON";
            // 
            // itemExit
            // 
            this.itemExit.Name = "itemExit";
            this.itemExit.Size = new System.Drawing.Size(152, 22);
            this.itemExit.Text = "Exit";
            // 
            // itemAbout
            // 
            this.itemAbout.Name = "itemAbout";
            this.itemAbout.Size = new System.Drawing.Size(52, 20);
            this.itemAbout.Text = "About";
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // English
            // 
            this.English.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.English.HeaderText = "English";
            this.English.Name = "English";
            // 
            // Vietnamese
            // 
            this.Vietnamese.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Vietnamese.HeaderText = "Vietnamese";
            this.Vietnamese.Name = "Vietnamese";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 417);
            this.Controls.Add(this.drgMain);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Text Editor";
            ((System.ComponentModel.ISupportInitialize)(this.drgMain)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView drgMain;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem itemHome;
        private System.Windows.Forms.ToolStripMenuItem itemNew;
        private System.Windows.Forms.ToolStripMenuItem itemSave;
        private System.Windows.Forms.ToolStripMenuItem itemExport;
        private System.Windows.Forms.ToolStripMenuItem itemPlist;
        private System.Windows.Forms.ToolStripMenuItem itemJson;
        private System.Windows.Forms.ToolStripMenuItem itemExit;
        private System.Windows.Forms.ToolStripMenuItem itemAbout;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn English;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vietnamese;
    }
}

