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
    public partial class CarsListed : Form
    {
        CarRentalDatabase carRentalDatabase = new CarRentalDatabase();
        public CarsListed()
        {
            InitializeComponent();
        }

        private void btnImageAdd_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dataGridViewRow = dataGridView1.CurrentRow;
            platetext.Text = dataGridViewRow.Cells["PlateNo"].Value.ToString();
            brandtext.Text = dataGridViewRow.Cells["BrandName"].Value.ToString();
            carnametext.Text = dataGridViewRow.Cells["CarName"].Value.ToString();
            serialnumbertext.Text = dataGridViewRow.Cells["SerialNumber"].Value.ToString();
            modelyeartext.Text = dataGridViewRow.Cells["ModelYear"].Value.ToString();
            colortxt.Text = dataGridViewRow.Cells["ColorName"].Value.ToString();
            kmtext.Text = dataGridViewRow.Cells["Km"].Value.ToString();
            fluetext.Text = dataGridViewRow.Cells["Fuel"].Value.ToString();
            pricetext.Text = dataGridViewRow.Cells["DailyPrice"].Value.ToString();
            descriptiontxt.Text = dataGridViewRow.Cells["Description"].Value.ToString();
            pictureBox1.ImageLocation = dataGridViewRow.Cells["Image"].Value.ToString();
           
        }

        private void CarsListed_Load(object sender, EventArgs e)
        {
            CarNewListed();
             comboCar.SelectedIndex = 0;
           
        }

        private void CarNewListed()
        {
            string CarListed = "select PlateNo,BrandName,CarName,SerialNumber,ModelYear,ColorName,Km,Fuel,DailyPrice,Description,Image,Date,Status from cars";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            dataGridView1.DataSource= carRentalDatabase.Listed(sqlDataAdapter, CarListed);
            dataGridView1.Columns[0].HeaderText = "Plaka";
            dataGridView1.Columns[1].HeaderText = "Marka";
            dataGridView1.Columns[2].HeaderText = "Araba İsmi";
            dataGridView1.Columns[3].HeaderText = "Seri No";
            dataGridView1.Columns[4].HeaderText = "Model Yıl";
            dataGridView1.Columns[5].HeaderText = "Renk";
            dataGridView1.Columns[6].HeaderText = "Km";
            dataGridView1.Columns[7].HeaderText = "Yakıt";
            dataGridView1.Columns[8].HeaderText = "Günlük Fiyat";
            dataGridView1.Columns[9].HeaderText = "Açıklama";
            dataGridView1.Columns[10].HeaderText = "Resim";
            dataGridView1.Columns[11].HeaderText = "Tarih";
            dataGridView1.Columns[12].HeaderText = "Durum";
        }

        private void btnCarAdd_Click(object sender, EventArgs e)
        {
            string CarUpdate = "update cars set BrandName=@BrandName,CarName=@CarName,ColorName=@ColorName,SerialNumber=@SerialNumber,ModelYear=@ModelYear,Km=@Km,Fuel=@Fuel,DailyPrice=@DailyPrice,Description=@Description,Image=@Image,Date=@Date where PlateNo=@PlateNo ";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Parameters.AddWithValue("@PlateNo", platetext.Text);
            sqlCommand.Parameters.AddWithValue("@BrandName", brandtext.Text);
            sqlCommand.Parameters.AddWithValue("@CarName", carnametext.Text);
            sqlCommand.Parameters.AddWithValue("@SerialNumber", serialnumbertext.Text);
            sqlCommand.Parameters.AddWithValue("@ModelYear", modelyeartext.Text);
            sqlCommand.Parameters.AddWithValue("@ColorName", colortxt.Text);
            sqlCommand.Parameters.AddWithValue("@Km", kmtext.Text);
            sqlCommand.Parameters.AddWithValue("@Fuel", fluetext.Text);
            sqlCommand.Parameters.AddWithValue("@DailyPrice", int.Parse(pricetext.Text));
            sqlCommand.Parameters.AddWithValue("@Description", descriptiontxt.Text);
            sqlCommand.Parameters.AddWithValue("@Image", pictureBox1.ImageLocation);
            sqlCommand.Parameters.AddWithValue("@Date", DateTime.Now.ToString());


            carRentalDatabase.Crud(sqlCommand, CarUpdate);
           
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
            CarNewListed();
            pictureBox1.ImageLocation = "";
            MessageBox.Show("Araba güncellendi", "Başarılı.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCarDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow dataGridViewRow = dataGridView1.CurrentRow;
            string CarDelete = "delete from Cars where PlateNo='" + dataGridViewRow.Cells["PlateNo"].Value.ToString() + "'";
            SqlCommand sqlCommand = new SqlCommand();

            carRentalDatabase.Crud(sqlCommand, CarDelete);
            CarNewListed();
            pictureBox1.ImageLocation = "";
     
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is ComboBox) item.Text = "";

            MessageBox.Show("Araba silindi", "Başarılı.");
        }

        private void brandtext_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboCar.SelectedIndex==0)
                {
                    CarNewListed();
                }       
else if( comboCar.SelectedIndex == 1)
                {
                    string CarListed = "select PlateNo,BrandName,CarName,SerialNumber,ModelYear,ColorName,Km,Fuel,DailyPrice,Description,Image,Date,Status from cars  where Status='Bos'";
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                    dataGridView1.DataSource = carRentalDatabase.Listed(sqlDataAdapter, CarListed);
                }
                else if (comboCar.SelectedIndex ==2)
                {
                    string CarListed = "select PlateNo,BrandName,CarName,SerialNumber,ModelYear,ColorName,Km,Fuel,DailyPrice,Description,Image,Date,Status from cars  where Status='Dolu'";
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                    dataGridView1.DataSource = carRentalDatabase.Listed(sqlDataAdapter, CarListed);
                }
             
            }
            catch 
            {

            
            }
        }

        private void btnCarCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

