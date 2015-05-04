using Purdue.OnlineClassScheduler.BAL.BusinessEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnLineClassScheduler
{
    public partial class frmResults : Form
    {
        private DataSet dataSet;

        public frmResults(DataSet dataSet, Term term)
        {
            InitializeComponent();
            this.dataSet = dataSet;
            if (dataSet.Tables[0].Rows.Count != 0)
            {
                dataGridView1.DataSource = dataSet.Tables[0];
            }
            else
            {
                lblMsg.Text = "No Data to Display";
                dataGridView1.Visible = false;
            }
            groupBox1.Text += " "+ term.Quarter + " " + term.Year;
        }


        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmOnlineScheduler frmScheduler = new frmOnlineScheduler();
            frmScheduler.Show();
            frmScheduler.Activate();
            this.Hide();

        }
    }
}
