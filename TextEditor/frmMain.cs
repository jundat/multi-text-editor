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
        string[] droppedFiles;
        string currentFile;

        public void savePlist(string fileName)
        {
            string data = "";

            //begin file
            data += "<plist>\n";
            data += "<dict>\n\n";

            for (int i = 0; i < drgMain.ColumnCount; ++i)
            {
                data += "\t<key>" + drgMain.Columns[i].Name + "</key>\n";
                data += "\t<dict>\n";
                for (int j = 0; j < drgMain.RowCount - 1; ++j)
                {
                    DataGridViewRow row = drgMain.Rows[j];
                    DataGridViewCell cell = row.Cells[i];

                    //key
                    DataGridViewRow nameRow = drgMain.Rows[j];
                    data += "\t\t<key>" + nameRow.Cells[0].Value + "</key>\n";

                    //string
                    data += "\t\t<string>" + (string)cell.Value + "</string>\n";
                }
                data += "\t</dict>\n\n";
            }

            //end file
            data += "</dict>\n";
            data += "</plist>\n";

            //write to file
            StreamWriter sw = new StreamWriter(fileName);
            sw.Write(data);
            sw.Flush();
            sw.Close();
        }

        public void saveJson(string fileName)
        {
            string data = "";

            //begin file
            data += "[\n";

            for (int i = 0; i < drgMain.ColumnCount; ++i)
            {
                data += "\t{\n"; //language pack
                data += "\t\t\"language\": \"" + drgMain.Columns[i].Name + "\",\n";
                data += "\t\t\"text\":\n";
                data += "\t\t{\n"; //text
                for (int j = 0; j < drgMain.RowCount - 1; ++j)
                {
                    DataGridViewRow row = drgMain.Rows[j];
                    DataGridViewCell cell = row.Cells[i];

                    //key
                    DataGridViewRow nameRow = drgMain.Rows[j];
                    data += "\t\t\t\"" + nameRow.Cells[0].Value + "\":";

                    //string
                    data += " \"" + (string)cell.Value + "\",\n";
                }
                data += "\t\t}\n"; //text
                data += "\t}"; //language pack
                if (i < drgMain.ColumnCount - 1)
                {
                    data += ",\n"; //language pack
                }
                else
                {
                    data += "\n"; //language pack
                }
            }

            //end file
            data += "]";

            //write to file
            StreamWriter sw = new StreamWriter(fileName);
            sw.Write(data);
            sw.Flush();
            sw.Close();
        }

        public void newFile()
        {
            currentFile = null;

            drgMain.DataSource = null;
            drgMain.Columns.Clear();
            drgMain.Rows.Clear();
            drgMain.Refresh();

            listLanguages = new ArrayList();
            listLanguages.Add("English");
            listLanguages.Add("Vietnamese");

            DataTable tb = new DataTable();
            tb.Columns.Add("Id");
            tb.Columns.Add("English");
            tb.Columns.Add("Vietnamese");
            drgMain.DataSource = tb;
        }

        public void openPlistFile(string file)
        {
            try
            {
                drgMain.Columns.Clear();
                drgMain.DataSource = Plist.Load(file);
                drgMain.Refresh();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Can not open file!");
                newFile();
            }
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

        /// <summary>
        /// 
        /// </summary>

        public frmMain()
        {
            InitializeComponent();

            currentFile = null;

            listLanguages = new ArrayList();
            listLanguages.Add("English");
            listLanguages.Add("Vietnamese");
        }

        private void itemNew_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Check!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                newFile();
            }            
        }

        private void itemOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Plist files (*.plist)|*.plist";
            openDialog.FilterIndex = 2;
            openDialog.RestoreDirectory = true;
            openDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openDialog.Title = "Open Plist";

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openDialog.FileName;
                openPlistFile(fileName);
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

        private void itemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void itemSave_Click(object sender, EventArgs e)
        {
            if (currentFile == null || currentFile.Length == 0)
            {
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Plist file (*.plist)|*.plist|Json file (*.json)|*.json";
                saveDialog.RestoreDirectory = true;
                saveDialog.FileName = "language";
                saveDialog.Title = "Save File";
                
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {                    
                    currentFile = saveDialog.FileName;
                }
            }

            if (currentFile != null)
            {
                if (currentFile.EndsWith(".plist"))
                {
                    savePlist(currentFile);
                }
                else if (currentFile.EndsWith(".json"))
                {
                    saveJson(currentFile);
                }
                else
                {
                    MessageBox.Show("Choose Plist or Json");
                }
            }            
        }

        private void itemSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Plist file (*.plist)|*.plist|Json file (*.json)|*.json";
            saveDialog.RestoreDirectory = true;
            saveDialog.FileName = "language";
            saveDialog.Title = "Save File";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                currentFile = saveDialog.FileName;

                if (currentFile.EndsWith(".plist"))
                {
                    savePlist(currentFile);
                }
                else if (currentFile.EndsWith(".json"))
                {
                    saveJson(currentFile);
                }
                else
                {
                    MessageBox.Show("Choose Plist or Json");
                }
            }
        }

        private void drgMain_DragEnter(object sender, DragEventArgs e)
        {
            Console.WriteLine("drgmain enter");

            droppedFiles = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in droppedFiles) Console.WriteLine(file);
        }

        private void drgMain_DragLeave(object sender, EventArgs e)
        {
            Console.WriteLine("drgmain leave");

            string file = droppedFiles[0];
            if (file.EndsWith(".plist"))
            {
                openPlistFile(file);
            } 
            else
            {
                MessageBox.Show("Invalid file name. It must be a .plist file!");
            }
        }

    }
}
