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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.drgMain = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.English = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vietnamese = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.itemHome = new System.Windows.Forms.ToolStripMenuItem();
            this.itemNew = new System.Windows.Forms.ToolStripMenuItem();
            this.itemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.itemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.itemExport = new System.Windows.Forms.ToolStripMenuItem();
            this.itemPlist = new System.Windows.Forms.ToolStripMenuItem();
            this.itemJson = new System.Windows.Forms.ToolStripMenuItem();
            this.itemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.itemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.itemColumns = new System.Windows.Forms.ToolStripMenuItem();
            this.itemAbout = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.drgMain)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // drgMain
            // 
            this.drgMain.AllowDrop = true;
            this.drgMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.drgMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.drgMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drgMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.English,
            this.Vietnamese});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.drgMain.DefaultCellStyle = dataGridViewCellStyle2;
            this.drgMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drgMain.Location = new System.Drawing.Point(0, 28);
            this.drgMain.Name = "drgMain";
            this.drgMain.Size = new System.Drawing.Size(895, 424);
            this.drgMain.TabIndex = 0;
            this.drgMain.DragEnter += new System.Windows.Forms.DragEventHandler(this.drgMain_DragEnter);
            this.drgMain.DragLeave += new System.EventHandler(this.drgMain_DragLeave);
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
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemHome,
            this.itemEdit,
            this.itemAbout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(895, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuMain";
            // 
            // itemHome
            // 
            this.itemHome.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemNew,
            this.itemOpen,
            this.itemSave,
            this.itemExport,
            this.itemExit});
            this.itemHome.Name = "itemHome";
            this.itemHome.Size = new System.Drawing.Size(62, 24);
            this.itemHome.Text = "Home";
            // 
            // itemNew
            // 
            this.itemNew.Name = "itemNew";
            this.itemNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.itemNew.Size = new System.Drawing.Size(167, 24);
            this.itemNew.Text = "New";
            this.itemNew.Click += new System.EventHandler(this.itemNew_Click);
            // 
            // itemOpen
            // 
            this.itemOpen.Name = "itemOpen";
            this.itemOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.itemOpen.Size = new System.Drawing.Size(167, 24);
            this.itemOpen.Text = "Open";
            this.itemOpen.Click += new System.EventHandler(this.itemOpen_Click);
            // 
            // itemSave
            // 
            this.itemSave.Name = "itemSave";
            this.itemSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.itemSave.Size = new System.Drawing.Size(167, 24);
            this.itemSave.Text = "Save";
            this.itemSave.Click += new System.EventHandler(this.itemSave_Click);
            // 
            // itemExport
            // 
            this.itemExport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemPlist,
            this.itemJson});
            this.itemExport.Name = "itemExport";
            this.itemExport.Size = new System.Drawing.Size(167, 24);
            this.itemExport.Text = "Export";
            // 
            // itemPlist
            // 
            this.itemPlist.Name = "itemPlist";
            this.itemPlist.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.itemPlist.Size = new System.Drawing.Size(163, 24);
            this.itemPlist.Text = "PLIST";
            this.itemPlist.Click += new System.EventHandler(this.itemPlist_Click);
            // 
            // itemJson
            // 
            this.itemJson.Name = "itemJson";
            this.itemJson.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.J)));
            this.itemJson.Size = new System.Drawing.Size(163, 24);
            this.itemJson.Text = "JSON";
            this.itemJson.Click += new System.EventHandler(this.itemJson_Click);
            // 
            // itemExit
            // 
            this.itemExit.Name = "itemExit";
            this.itemExit.Size = new System.Drawing.Size(167, 24);
            this.itemExit.Text = "Exit";
            this.itemExit.Click += new System.EventHandler(this.itemExit_Click);
            // 
            // itemEdit
            // 
            this.itemEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemColumns});
            this.itemEdit.Name = "itemEdit";
            this.itemEdit.Size = new System.Drawing.Size(47, 24);
            this.itemEdit.Text = "Edit";
            // 
            // itemColumns
            // 
            this.itemColumns.Name = "itemColumns";
            this.itemColumns.ShortcutKeys = System.Windows.Forms.Keys.F10;
            this.itemColumns.Size = new System.Drawing.Size(167, 24);
            this.itemColumns.Text = "Columns";
            this.itemColumns.Click += new System.EventHandler(this.itemColumns_Click);
            // 
            // itemAbout
            // 
            this.itemAbout.Name = "itemAbout";
            this.itemAbout.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.itemAbout.Size = new System.Drawing.Size(62, 24);
            this.itemAbout.Text = "About";
            this.itemAbout.Click += new System.EventHandler(this.itemAbout_Click);
            // 
            // frmMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 452);
            this.Controls.Add(this.drgMain);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.ToolStripMenuItem itemOpen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn English;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vietnamese;
        private System.Windows.Forms.ToolStripMenuItem itemEdit;
        private System.Windows.Forms.ToolStripMenuItem itemColumns;
    }
}

