using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace TextEditor
{
    public partial class frmChooseColumns : Form
    {
        frmMain parent;
        
        public frmChooseColumns(frmMain parent, ArrayList listLanguages)
        {
            InitializeComponent();

            this.parent = parent;

            for (int i = 0; i < listLanguages.Count; ++i )
            {
                string name = (string)listLanguages[i];

                int idx = checkedListMain.Items.IndexOf(name);
                
                checkedListMain.SetItemChecked(idx, true);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            ArrayList listLanguages = new ArrayList();

            for (int i = 0; i < checkedListMain.CheckedItems.Count; ++i )
            {
                listLanguages.Add(checkedListMain.CheckedItems[i].ToString());
            }

            parent.refreshColumns(listLanguages);
            this.Close();
        }
    }
}
