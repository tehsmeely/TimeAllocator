using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeAllocator
{
    public partial class EntryForm : Form
    {
        public EntryForm()
        {
            InitializeComponent();
        }

        private void EntryForm_Load(object sender, EventArgs e)
        {

        }

        private void menuBar_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void newActivity_Click(object sender, EventArgs e)
        {
            var popupForm = new ActivityEntryForm();
            var dialogResponse = popupForm.ShowDialog(this);
            if (dialogResponse == DialogResult.OK)
            {
                string[] row = { popupForm.GetEnteredText(), "0", "0" };
                var listViewItem = new ListViewItem(row);
                listView1.Items.Add(listViewItem);
            }
            System.Diagnostics.Debug.Write(popupForm.GetEnteredText());
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
