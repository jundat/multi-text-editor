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

namespace TextEditor
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
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
            saveDialog.Filter = "Xml files (*.xml)|*.xml";
            saveDialog.FilterIndex = 2;
            saveDialog.RestoreDirectory = true;
            saveDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            saveDialog.FileName = "XML File";
            saveDialog.Title = "XML Export";

            string data = "";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveDialog.FileName;

                //begin file
                data += "<plist version=\"1.0\">\n";
                data += "<dict>\n\n";

                for (int i = 1; i < drgMain.ColumnCount; ++i )
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
    }
}
