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
	public partial class frmUrlViewer : Form
	{
		string url;

		public frmUrlViewer(string url)
		{
			InitializeComponent();
			this.url = url;
			
		}

		private void frmUrlViewer_Load(object sender, EventArgs e)
		{
			webBrowser1.Navigate(url);
		}

	}
}
