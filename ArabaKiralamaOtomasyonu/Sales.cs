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
            string CustomerListed = "select Tc,LastFirstName,PlateNo,CarName,BrandName,ColorName,ModelYear,SerialNumber,Day,DailyPrice,Price,RentDate,ReturnDate from sales";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            dataGridView1.DataSource = carRentalDatabase.Listed(sqlDataAdapter, CustomerListed);
            dataGridView1.Columns[0].HeaderText = "T.C.";
            dataGridView1.Columns[1].HeaderText = "Ad Soyad";
            dataGridView1.Columns[2].HeaderText = "Plaka";
            dataGridView1.Columns[3].HeaderText = "Model";
            dataGridView1.Columns[4].HeaderText = "Marka";
            dataGridView1.Columns[5].HeaderText = "Renk";
            dataGridView1.Columns[6].HeaderText = "Model Yıl";
            dataGridView1.Columns[7].HeaderText = "Seri No";
            dataGridView1.Columns[8].HeaderText = "Gün";
            dataGridView1.Columns[9].HeaderText = "Günlük Ücret";
            dataGridView1.Columns[10].HeaderText = "Kira Ücreti";
            dataGridView1.Columns[11].HeaderText = "Çıkış Tarih";
            dataGridView1.Columns[12].HeaderText = "Dönüş Tarihi";
       

           
         

            carRentalDatabase.SaleCalcurate(label1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    
}
