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
    public partial class CarAdd : Form
    {
        CarRentalDatabase carRentalDatabaseLocal = new CarRentalDatabase();
        SqlConnection sqlConnection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CarRentalAutomation;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        CarRentalDatabase carRentalDatabase = new CarRentalDatabase();
        public CarAdd()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnImageAdd_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void btnCarCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
           
        }
        bool plateNoFinds;
        bool serialNoFinds;
        void plateNoFind()
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("select * from cars where PlateNo=@PlateNo ", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@PlateNo", platetext.Text);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            if (sqlDataReader.Read())
            {
                plateNoFinds = false;

            }
            else
            {
                plateNoFinds = true;
            }
            sqlConnection.Close();
        }

        void serialNoFind()
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("select * from cars where SerialNumber =@SerialNumber ", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@SerialNumber", platetext.Text);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            if (sqlDataReader.Read())
            {
                serialNoFinds = false;

            }
            else
            {
                serialNoFinds = true;
            }
            sqlConnection.Close();
        }
        private void btnCarAdd_Click(object sender, EventArgs e)
        {
            plateNoFind();
            serialNoFind();
            if (plateNoFinds == true)
            {

                string sentence = "insert into cars(PlateNo,BrandName,CarName,SerialNumber,ModelYear,ColorName,Km,Fuel,DailyPrice,Description,Image,Date,Status) values(@PlateNo,@BrandName,@CarName,@SerialNumber,@ModelYear,@ColorName,@Km,@Fuel,@DailyPrice,@Description,@Image,@Date,@Status)";
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
                sqlCommand.Parameters.AddWithValue("@Status", "Bos");


                carRentalDatabase.Crud(sqlCommand, sentence);
                foreach (Control item in Controls) if (item is TextBox) item.Text = "";
                foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
                pictureBox1.ImageLocation = "";
                MessageBox.Show("Araba eklendi ", "Başarılı.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (serialNoFinds == false)
            {
                MessageBox.Show(serialnumbertext.Text+" numarasına ait araba zaten var ", "Bilgi.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Bu kayıt zaten var ", "Bilgi.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                foreach (Control control in Controls) if (control is TextBox) control.Text = "";
            }
        }

        private void CarAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
