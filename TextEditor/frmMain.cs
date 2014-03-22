using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Collections;

namespace TextEditor
{
    public partial class frmMain : Form
    {
        ArrayList listLanguages;

        public frmMain()
        {
            InitializeComponent();

            listLanguages = new ArrayList();
            listLanguages.Add("English");
            listLanguages.Add("Vietnamese");
        }

        private void itemNew_Click(object sender, EventArgs e)
        {
            drgMain.DataSource = null;
            drgMain.Rows.Clear();
            drgMain.Refresh();
        }

        private void itemPlist_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Plist files (*.plist)|*.plist";
            saveDialog.FilterIndex = 2;
            saveDialog.RestoreDirectory = true;
            saveDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            saveDialog.FileName = "language";
            saveDialog.Title = "Export Plist";

            string data = "";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveDialog.FileName;

                //begin file
                data += "<plist>\n";
                data += "<dict>\n\n";

                for (int i = 0; i < drgMain.ColumnCount; ++i )
                {
                    data += "\t<key>" + drgMain.Columns[i].Name + "</key>\n";
                    data += "\t<dict>\n";
                    for (int j = 0; j < drgMain.RowCount - 1; ++j )
                    {
                        DataGridViewRow row = drgMain.Rows[j];
                        DataGridViewCell cell =  row.Cells[i];

                        //key
                        DataGridViewRow nameRow = drgMain.Rows[j];
                        data += "\t\t<key>" + nameRow.Cells[0].Value +"</key>\n";

                        //string
                        data += "\t\t<string>" + (string)cell.Value + "</string>\n";
                    }
                    data += "\t</dict>\n\n";
                }

                //end file
                data += "</dict>\n";
                data += "</plist>\n";

                //write to file
                System.IO.File.WriteAllText(fileName, data);
            }
        }

        private void itemOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Plist files (*.plist)|*.plist|All files (*.*)|*.*";
            openDialog.FilterIndex = 2;
            openDialog.RestoreDirectory = true;
            openDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openDialog.Title = "Open Plist";

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openDialog.FileName;

                drgMain.Columns.Clear();
                drgMain.DataSource = Plist.Load(fileName);
                drgMain.Refresh();
            }
        }

        private void itemColumns_Click(object sender, EventArgs e)
        {
            frmChooseColumns fm = new frmChooseColumns(this, listLanguages);
            fm.ShowDialog(this);
        }

        private void itemAbout_Click(object sender, EventArgs e)
        {
            AboutBox1 box = new AboutBox1();
            box.ShowDialog(this);
        }

        public void refreshColumns(ArrayList checkedLanguages)
        {
            //Add
            for (int i = 0; i < checkedLanguages.Count; ++i)
            {
                string name = (string)checkedLanguages[i];
                if (!drgMain.Columns.Contains(name))
                {
                    listLanguages.Add(name);
                    drgMain.Columns.Add(name, name);
                }
            }

            //Remove
            for (int i = 0; i < drgMain.Columns.Count; ++i)
            {
                string name = drgMain.Columns[i].Name;
                if (name == "Id")
                {
                    continue;
                }

                if (!checkedLanguages.Contains(name))
                {
                    drgMain.Columns.Remove(name);
                    listLanguages.Remove(name);
                }
            }
        }
    }
}
