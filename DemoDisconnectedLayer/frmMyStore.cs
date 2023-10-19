using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoDisconnectedLayer
{
    public partial class frmMyStore : Form
    {
        public frmMyStore()
        {
            InitializeComponent();
        }
        DataSet dsMyStore = new DataSet();

        private void btnViewProducts_Click(object sender, EventArgs e)
        {
            dgvData.DataSource = dsMyStore.Tables[0];
        }

        private void btnViewCategories_Click(object sender, EventArgs e)
        {
            dgvData.DataSource = dsMyStore.Tables[1];

        }

        private void btnClose_Click(object sender, EventArgs e) => this.Close();

        private void frmMyStore_Load(object sender, EventArgs e)
        {
            string ConnectionStrings = "Server = localhost,uid=sa,pwd=1234;database=MyStoreTrustServerCertificate=true;Trusted_Connection=SSPI;Encrypt=false;";
            string SQL = "Select ProductID,ProductName,UnitsStock From Products ; Select * From Categories";
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(SQL, ConnectionStrings);
                dataAdapter.Fill(dsMyStore);
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "");
            }
            
        }
    }
}
