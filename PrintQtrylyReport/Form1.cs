using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintQtrylyReport
{
    public partial class QtrlyReport: Form
    {
        public QtrlyReport()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appDataQtrSalReport.qtrly_sales_comm_earned_v' table. You can move, or remove it, as needed.
            this.qtrly_sales_comm_earned_vTableAdapter1.Fill(this.appDataQtrSalReport.qtrly_sales_comm_earned_v);
          

        }

    }
}
