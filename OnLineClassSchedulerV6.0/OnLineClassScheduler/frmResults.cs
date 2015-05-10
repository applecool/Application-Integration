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

        //
        // source code 
        // Code Snippet
        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        } 
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
            if (term != null)
                groupBox1.Text += " " + term.Quarter + " " + term.Year;
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOnlineScheduler frmScheduler = new frmOnlineScheduler();
            frmScheduler.Show();
            frmScheduler.Activate();
            this.Hide();
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dataGridView1.Columns.Contains("View Books"))
            {
                foreach (DataGridViewRow r in dataGridView1.Rows)
                {

                    if (System.Uri.IsWellFormedUriString(r.Cells["View Books"].Value.ToString(), UriKind.Absolute))
                    {
                        r.Cells["View Books"] = new DataGridViewLinkCell();
                        DataGridViewLinkCell c = r.Cells["View Books"] as DataGridViewLinkCell;
                    }
                    
                }

            }
            else
                dataGridView1.RowTemplate.Height = 80;
                dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        // And handle the click too
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
			if (e.RowIndex != -1)
			{
				if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex] is DataGridViewLinkCell)
				{
					frmUrlViewer urlViewr = new frmUrlViewer(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value as string);
					urlViewr.ShowDialog();
				}
			}
        }

        


    }
}
