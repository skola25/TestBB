using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestBB
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //EnableTexBox();
            
            // TODO: This line of code loads data into the 'appData_Sales.SALES' table. You can move, or remove it, as needed.
            this.sALESTableAdapter.Fill(this.appData_Sales.SALES);
            // TODO: This line of code loads data into the 'appData_Disc.DISCOUNT' table. You can move, or remove it, as needed.
           // this.dISCOUNTTableAdapter.Fill(this.appData_Disc.DISCOUNT);
            // TODO: This line of code loads data into the 'appData_Cust.CUSTOMER' table. You can move, or remove it, as needed.
            this.cUSTOMERTableAdapter.Fill(this.appData_Cust.CUSTOMER);
            // TODO: This line of code loads data into the 'appData_Prod.PRODUCTS' table. You can move, or remove it, as needed.
            this.pRODUCTSTableAdapter1.Fill(this.appData_Prod.PRODUCTS);
            // TODO: This line of code loads data into the 'appData_SP.SALESPERSON' table. You can move, or remove it, as needed.
            this.sALESPERSONTableAdapter.Fill(this.appData_SP.SALESPERSON);
            // TODO: This line of code loads data into the 'addData.PRODUCTS' table. You can move, or remove it, as needed.
            //this.pRODUCTSTableAdapter.Fill(this.addData.PRODUCTS);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Are you sure want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    pRODUCTSBindingSource1.RemoveCurrent();
            }
        }

        private void btnAddProd_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                pRODUCTSBindingSource1.EndEdit();
                pRODUCTSTableAdapter1.Update(this.appData_Prod);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnAddSalesPerson_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                sALESPERSONBindingSource.EndEdit();
                sALESPERSONTableAdapter.Update(this.appData_SP);            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Cursor.Current = Cursors.Default;
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.sALESTableAdapter.FillBy(this.appData_Sales.SALES);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        //private void ResetTextbox()
        //{
        //    Action<Control.controlcollection> func = null;
        //    func = (controls) =>
        //    {
        //        for each(Control control in controls)
        //            if (Control is textbox)
        //                (Control is textbox).text = "0";
        //            else
        //                func(Control.controls);
        //    };
        //    func(controls);

        //}

        //private void EnableTextbox()
        //{

        //    Action<Control.controlcollection> func = null;
        //    func = (controls) =>
        //    {
        //        for each(Control control in controls)

        //            if (Control is textbox)
        //                (Control is textbox).enabled = false;
        //            else
        //                func(Control.controls);
        //    };
        //    func(controls);

        //}
        }
}
