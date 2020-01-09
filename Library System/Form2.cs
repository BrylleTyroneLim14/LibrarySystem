using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_System
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {   
            int yrs = Convert.ToInt32(txtYrsOfService.Text);
            double totalSales = Convert.ToDouble(txtTotalSales.Text);
            double basicpay = Convert.ToDouble(txtBasicPay.Text);
            double netpay,commision;
            if (yrs <10)
            {
                commision = totalSales*0.2;
                netpay = basicpay + commision;

                txtCommision.Text = Convert.ToString(commision);
                //txtBasicPay.Text = Convert.ToString(basicpay);
                txtNetPay.Text = Convert.ToString(netpay);
       
                

            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
