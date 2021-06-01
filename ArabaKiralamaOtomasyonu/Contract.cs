using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ArabaKiralamaOtomasyonu
{
    public partial class Contract : Form
    {
        public Contract()
        {
            InitializeComponent();
        }
        CarRentalDatabase carRentalDatabase = new CarRentalDatabase();

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }


        private void Contract_Load(object sender, EventArgs e)
        {
            EmptyCars();

            Updated();
        }

        private void EmptyCars()
        {
            string queryStatus = "select * from cars where status='Bos'";
            carRentalDatabase.NullCars(carNameCombo, queryStatus);

        }

        private void Updated()
        {
            string queryGetallContract = "select* from Contracts";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            dataGridView1.DataSource = carRentalDatabase.Listed(sqlDataAdapter, queryGetallContract);
        }

        private void tcTxt_TextChanged(object sender, EventArgs e)
        {
            if (tcTxt.Text == "") foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
            string query = "select * from customers where TcNo like '" + tcTxt.Text + "'";
            carRentalDatabase.GetCustomer(tcTxt, firstNameTxt, lastNameTxt, phoneTxt, query);
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void carNameCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "select * from Cars where CarName like '" + carNameCombo.SelectedItem + "'";
            carRentalDatabase.GetAllCar(carNameCombo, plateNoTxt, brandTxt, colorTxt, serialNoTxt, modelYılTxt,dailyPriceTxt, query);

        }

    

        private void dayTxt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DateTime.Parse(returnDateTimePicker.Text) < DateTime.Parse(rentDateTimePicker.Text))
            {
           
                MessageBox.Show("Dönüş tarihi çıkış tarihinden küçük olamaz", "Dikkat!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (DateTime.Parse(returnDateTimePicker.Text) != DateTime.Parse(rentDateTimePicker.Text))
            {
                TimeSpan day = DateTime.Parse(returnDateTimePicker.Text) - DateTime.Parse(rentDateTimePicker.Text);

                int days = day.Days;

                dayTxt.Text = days.ToString();

                priceTxt.Text = (days * int.Parse(dailyPriceTxt.Text)).ToString();
               
                MessageBox.Show("Fiyat hesaplandı", "Başarılı.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                MessageBox.Show("Çıkış tarihi ile Dönüş tarihi aynı olamaz", "Dikkat!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            rentDateTimePicker.Text = DateTime.Now.ToShortDateString();
            returnDateTimePicker.Text = DateTime.Now.ToShortDateString();
            priceTxt.Text = "";
            dayTxt.Text = "";
            dailyPriceTxt.Text = "";

        }

        private void dailyPriceTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string queryAddContract = "insert into contracts (TcNo,FirstName,LastName,Phone,LicenseNO,LicenseDate,LicenseLocation,PlateNo,BrandName,ColorName,SerialNumber,DailyPrice,Day,RentPrice,RentDate,ReturnDate,ModelYear,CarName) values(@TcNo,@FirstName,@LastName,@Phone,@LicenseNO,@LicenseDate,@LicenseLocation,@PlateNo,@BrandName,@ColorName,@SerialNumber,@DailyPrice,@Day,@RentPrice,@RentDate,@ReturnDate,@ModelYear,@CarName)";
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Parameters.AddWithValue("@TcNo", tcTxt.Text);
            sqlCommand.Parameters.AddWithValue("@FirstName", firstNameTxt.Text);
            sqlCommand.Parameters.AddWithValue("@LastName", lastNameTxt.Text);
            sqlCommand.Parameters.AddWithValue("@Phone", phoneTxt.Text);
            sqlCommand.Parameters.AddWithValue("@LicenseNO", licenseNoTxt.Text);
            sqlCommand.Parameters.AddWithValue("@LicenseDate", licenseDateTxt.Text);
            sqlCommand.Parameters.AddWithValue("@LicenseLocation", licenseLocationTxt.Text);
            sqlCommand.Parameters.AddWithValue("@PlateNo", plateNoTxt.Text);
            sqlCommand.Parameters.AddWithValue("@BrandName", brandTxt.Text);
            sqlCommand.Parameters.AddWithValue("@ColorName", carNameCombo.Text);
            sqlCommand.Parameters.AddWithValue("@SerialNumber", serialNoTxt.Text);          
            sqlCommand.Parameters.AddWithValue("@DailyPrice", int.Parse(dailyPriceTxt.Text));
            sqlCommand.Parameters.AddWithValue("@ModelYear", modelYılTxt.Text);
            sqlCommand.Parameters.AddWithValue("@Day", int.Parse(dayTxt.Text));
            sqlCommand.Parameters.AddWithValue("@RentPrice", int.Parse(priceTxt.Text));
            sqlCommand.Parameters.AddWithValue("@RentDate", rentDateTimePicker.Text);
            sqlCommand.Parameters.AddWithValue("@ReturnDate", returnDateTimePicker.Text);
            sqlCommand.Parameters.AddWithValue("@CarName", carNameCombo.Text);

            carRentalDatabase.Crud(sqlCommand, queryAddContract);

            string queryUpdateContract = "update cars set status='Dolu' where PlateNo ='"+plateNoTxt.Text+"'";
            SqlCommand sqlCommand1 = new SqlCommand();
            carRentalDatabase.Crud(sqlCommand1, queryUpdateContract);
            carNameCombo.Items.Clear();
            EmptyCars();
            foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in groupBox2.Controls) if (item is TextBox) item.Text = "";
            Updated();
            rentDateTimePicker.Text = DateTime.Now.ToShortDateString();
            returnDateTimePicker.Text = DateTime.Now.ToShortDateString();

            MessageBox.Show("Kiralama işlemi tamamlandı ","Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void updatedBtn_Click(object sender, EventArgs e)
        {

            string queryAddContract = "update  contracts set TcNo=@TcNo,FirstName=@FirstName,LastName=@LastName,Phone=@Phone,LicenseNO=@LicenseNO,LicenseDate=@LicenseDate,LicenseLocation=@LicenseLocation,BrandName=@BrandName,ColorName=@ColorName,SerialNumber=@SerialNumber,DailyPrice=@DailyPrice,Day=@Day,RentPrice=@RentPrice,RentDate=@RentDate,ReturnDate=@ReturnDate,ModelYear=@ModelYear,CarName=@CarName where PlateNo=PlateNo";
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Parameters.AddWithValue("@TcNo", tcTxt.Text);
            sqlCommand.Parameters.AddWithValue("@FirstName", firstNameTxt.Text);
            sqlCommand.Parameters.AddWithValue("@LastName", lastNameTxt.Text);
            sqlCommand.Parameters.AddWithValue("@Phone", phoneTxt.Text);
            sqlCommand.Parameters.AddWithValue("@LicenseNO", licenseNoTxt.Text);
            sqlCommand.Parameters.AddWithValue("@LicenseDate", licenseDateTxt.Text);
            sqlCommand.Parameters.AddWithValue("@LicenseLocation", licenseLocationTxt.Text);
            sqlCommand.Parameters.AddWithValue("@PlateNo", plateNoTxt.Text);
            sqlCommand.Parameters.AddWithValue("@BrandName", brandTxt.Text);
            sqlCommand.Parameters.AddWithValue("@ColorName", colorTxt.Text);
            sqlCommand.Parameters.AddWithValue("@SerialNumber", serialNoTxt.Text);
            sqlCommand.Parameters.AddWithValue("@DailyPrice", int.Parse(dailyPriceTxt.Text));
            sqlCommand.Parameters.AddWithValue("@ModelYear", modelYılTxt.Text);
            sqlCommand.Parameters.AddWithValue("@Day", int.Parse(dayTxt.Text));
            sqlCommand.Parameters.AddWithValue("@RentPrice", int.Parse(priceTxt.Text));
            sqlCommand.Parameters.AddWithValue("@RentDate", rentDateTimePicker.Text);
            sqlCommand.Parameters.AddWithValue("@ReturnDate", returnDateTimePicker.Text);
            sqlCommand.Parameters.AddWithValue("@CarName", carNameCombo.Text);

            carRentalDatabase.Crud(sqlCommand, queryAddContract);
            carNameCombo.Items.Clear();
            EmptyCars();
            foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in groupBox2.Controls) if (item is TextBox) item.Text = "";
            Updated();
            rentDateTimePicker.Text = DateTime.Now.ToShortDateString();
            returnDateTimePicker.Text = DateTime.Now.ToShortDateString();
          
            MessageBox.Show("Kiralama işlemi güncellendi ", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dataGridViewRow = dataGridView1.CurrentRow;
            tcTxt.Text = dataGridViewRow.Cells[1].Value.ToString();
            firstNameTxt.Text = dataGridViewRow.Cells[2].Value.ToString();
            lastNameTxt.Text = dataGridViewRow.Cells[3].Value.ToString();
            phoneTxt.Text = dataGridViewRow.Cells[4].Value.ToString();
            licenseNoTxt.Text = dataGridViewRow.Cells[5].Value.ToString();
            licenseDateTxt.Text = dataGridViewRow.Cells[6].Value.ToString();
            licenseLocationTxt.Text = dataGridViewRow.Cells[7].Value.ToString();
            plateNoTxt.Text = dataGridViewRow.Cells[8].Value.ToString();
            brandTxt.Text = dataGridViewRow.Cells[9].Value.ToString();
            colorTxt.Text = dataGridViewRow.Cells[10].Value.ToString();
            serialNoTxt.Text = dataGridViewRow.Cells[11].Value.ToString();
            dailyPriceTxt.Text = dataGridViewRow.Cells[12].Value.ToString();
            dayTxt.Text = dataGridViewRow.Cells[13].Value.ToString();
            priceTxt.Text = dataGridViewRow.Cells[14].Value.ToString();
            rentDateTimePicker.Text = dataGridViewRow.Cells[15].Value.ToString();
            returnDateTimePicker.Text = dataGridViewRow.Cells[16].Value.ToString();
            modelYılTxt.Text = dataGridViewRow.Cells[17].Value.ToString();
            carNameCombo.Text = dataGridViewRow.Cells[18].Value.ToString();

            tcTxt.Enabled = false;
        }

        private void carReturnBtn_Click(object sender, EventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            if (satır!=null)
            {
               string sorgu1 = "delete from contracts where PlateNo ='" + satır.Cells["PlateNo"].Value.ToString() + "'";
            SqlCommand sqlCommand1 = new SqlCommand();
            carRentalDatabase.Crud(sqlCommand1, sorgu1);

            string sorgu2 ="update cars set status ='Bos' where PlateNo='"+satır.Cells["PlateNo"].Value.ToString()+"'";
            SqlCommand sqlCommand2 = new SqlCommand();
            carRentalDatabase.Crud(sqlCommand2, sorgu2);


            string sorgu3 = "insert into Sales (Tc,LastFirstName,PlateNo,CarName,BrandName,ColorName,ModelYear,SerialNumber,Day,DailyPrice,Price,RentDate,ReturnDate) values(@TcNo,@LastFirstName,@PlateNo,@CarName,@BrandName,@ColorName,@ModelYear,@SerialNumber,@Day,@DailyPrice,@Price,@RentDate,@ReturnDate)";
            SqlCommand sqlCommand3 = new SqlCommand();

            sqlCommand3.Parameters.AddWithValue("@TcNo", satır.Cells["TcNo"].Value.ToString());
            sqlCommand3.Parameters.AddWithValue("@LastFirstName", satır.Cells["FirstName"].Value.ToString()+" "+ satır.Cells["LastName"].Value.ToString());
            sqlCommand3.Parameters.AddWithValue("@PlateNo", satır.Cells["PlateNo"].Value.ToString());
            sqlCommand3.Parameters.AddWithValue("@CarName", satır.Cells["CarName"].Value.ToString());
            sqlCommand3.Parameters.AddWithValue("@BrandName", satır.Cells["BrandName"].Value.ToString());
            sqlCommand3.Parameters.AddWithValue("@ColorName", satır.Cells["ColorName"].Value.ToString());
            sqlCommand3.Parameters.AddWithValue("@ModelYear", satır.Cells["ModelYear"].Value.ToString());
            sqlCommand3.Parameters.AddWithValue("@SerialNumber", satır.Cells["SerialNumber"].Value.ToString());
            sqlCommand3.Parameters.AddWithValue("@Day", satır.Cells["Day"].Value.ToString());
            sqlCommand3.Parameters.AddWithValue("@DailyPrice", satır.Cells["DailyPrice"].Value.ToString());
            sqlCommand3.Parameters.AddWithValue("@Price", satır.Cells["RentPrice"].Value.ToString());
            sqlCommand3.Parameters.AddWithValue("@RentDate", satır.Cells["RentDate"].Value.ToString());
            sqlCommand3.Parameters.AddWithValue("@ReturnDate", satır.Cells["ReturnDate"].Value.ToString());
   
          
            carRentalDatabase.Crud(sqlCommand3, sorgu3);
            carNameCombo.Items.Clear();
            EmptyCars();
            foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in groupBox2.Controls) if (item is TextBox) item.Text = "";
          
                 MessageBox.Show("Araç Teslim Edildi","Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Updated();
            }
            else
            {
                MessageBox.Show("Araç teslim etmek için kiralık araç seçmelisiniz", "Dikkat !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void licenseNoTxt_TextChanged(object sender, EventArgs e)
        {
            if (licenseNoTxt.Text == "") foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";

            string query = "select * from contracts where LicenseNo like '" + licenseNoTxt.Text + "'";
            carRentalDatabase.GetLicense(licenseNoTxt, licenseDateTxt, licenseLocationTxt, query);
        }

        private void rentDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
