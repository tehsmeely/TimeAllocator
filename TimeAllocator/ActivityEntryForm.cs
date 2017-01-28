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
    public partial class ActivityEntryForm : Form
    {
        public ActivityEntryForm()
        {
            InitializeComponent();
        }

        public string GetEnteredText()
        {
            return this.activityEntryText.Text;
        }

        private void entryButton_Click(object sender, EventArgs e)
        {
            if (this.activityEntryText.Text == "")
            {
                MessageBox.Show(this, "Cannot add blank-named Activity");
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
