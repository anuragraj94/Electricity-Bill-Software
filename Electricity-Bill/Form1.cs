using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electricity_Bill
{
    public partial class frm : Form
    {
        public frm()
        {
            InitializeComponent();
        }
        int iPrevious;
        int iCurrent;
        int iUnits;
        int iSubUnits;
        private void btnShow_Click(object sender, EventArgs e)
        {
            string sConString = "Data Source=AETELELINK-PC;Initial Catalog=Electricity_Bill;Persist Security Info=True;User ID=sa;Password=sa";
            SqlCommand cmd;
            string sQuery;

            try
            {
                iPrevious = Convert.ToInt32(txtPrevious.Text);
                iCurrent = Convert.ToInt32(txtCurrent.Text);
                iUnits = Convert.ToInt32(txtUnit.Text);
                iSubUnits = iCurrent - iPrevious;
                txtAmount.Text = (iSubUnits * iUnits).ToString();
                using (SqlConnection con = new SqlConnection(sConString))
                {
                    con.Open();
                    sQuery = "insert into tbl_Bill_Details(Previous_Reading,Current_Reading,Per_Unit,Payable_Amount,Payable_Units,Check_DateTime) values(" + txtPrevious.Text + "," + txtCurrent.Text + "," + txtUnit.Text + "," + txtAmount.Text + ","+iSubUnits+","+DateTime.Now.ToString("MM/dd/yyyy") + ")";
                    cmd = new SqlCommand(sQuery, con);
                    cmd.ExecuteNonQuery();
                }
                txtPrevious.Enabled = false;
                txtCurrent.Enabled = false;
                txtUnit.Enabled = false;
                btnShow.Enabled = false;
                btnContinue.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Enter The Value");
            }           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnContinue.Enabled = false;
            txtAmount.Enabled = false;
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            txtPrevious.Enabled = true;
            txtCurrent.Enabled = true;
            txtUnit.Enabled = true;
            txtAmount.Text = "";
            txtCurrent.Text = "";
            txtPrevious.Text = "";
            txtUnit.Text = "";
            btnContinue.Enabled = false;
            btnShow.Enabled = true;
        }
    }
}
