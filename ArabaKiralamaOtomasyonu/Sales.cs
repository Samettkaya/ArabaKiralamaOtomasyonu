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

namespace ArabaKiralamaOtomasyonu
{
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();
        }

        CarRentalDatabase carRentalDatabase = new CarRentalDatabase();

        private void Sales_Load(object sender, EventArgs e)
        {
            string Query = "select * from sales";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            dataGridView1.DataSource = carRentalDatabase.Listed(sqlDataAdapter,Query);

            carRentalDatabase.SaleCalcurate(label1);
        }
    }
    
}
