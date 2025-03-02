using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintReport
{
    public partial class Form1: Form
    {
        //int order = 1;
        double total = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            if (!string.IsNullOrEmpty(txtProductName.Text) && !string.IsNullOrEmpty(txtPrice.Text))
            {
                                                
                //clsSales_Report obj = new clsSales_Report() { prod_Id = order++, Prod_name = txtProductName.Text, Price = Convert.ToDouble(txtPrice.Text), Qty = Convert.ToInt32(txtQty.Text) };
                clsSales_Report obj = new clsSales_Report() { prod_Id = txtProdID.Text, Prod_name = txtProductName.Text, Price = Convert.ToDouble(txtPrice.Text), Qty = Convert.ToInt32(txtQty.Text) };
                        
                sALESTableAdapter.Insert(txtProdID.Text, txtSPID.Text, txtCustID.Text, DateTime.Now);


                total += obj.Price * obj.Qty;
                
                clsSalesReportBindingSource.Add(obj);              
                clsSalesReportBindingSource.MoveLast();
                txtProductName.Text = string.Empty;
                txtPrice.Text = string.Empty;
                txtQty.Text = string.Empty;
                txtSPID.Text = string.Empty;
                txtTotal.Text = string.Format("{0}$", total);            
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qAPortalDataSet.SALES' table. You can move, or remove it, as needed.
            this.sALESTableAdapter.Fill(this.qAPortalDataSet.SALES);
            clsSalesReportBindingSource.DataSource = new List<clsSales_Report>();

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            clsSales_Report obj = clsSalesReportBindingSource.Current as clsSales_Report;
            if (obj != null)
            {
                total -= obj.Price * obj.Qty;
                txtTotal.Text = string.Format("{0}$", total);
            }
            clsSalesReportBindingSource.RemoveCurrent();
            txtQty.Text = string.Empty;
            txtTotal.Text = string.Format("{0}$", 0);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            //using (frmReport frm = new frmReport(clsSalesReportBindingSource.DataSource as List<clsSales_Report>, string.Format("{0}$", txtTotal), DateTime.Now.ToString("MM/dd/yyyy")))
            //{
            //    frm.ShowDialog();
            //}

        }
              
    }
}
