using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
namespace ArabaKiralamaOtomasyonu
{
    class CarRentalDatabase
    {
        SqlConnection sqlConnection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CarRentalAutomation;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
       
        DataTable datatable ;

        public void Crud(SqlCommand command, string query )
        {
            sqlConnection.Open();
            command.Connection = sqlConnection;
            command.CommandText = query;
            
                command.ExecuteNonQuery();
            sqlConnection.Close();

        }
        public DataTable Listed(SqlDataAdapter sqlDataAdapter,string query)
        {
            datatable = new DataTable();
            sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
            sqlDataAdapter.Fill(datatable);
            sqlConnection.Close();
            return datatable;
        }

        public void NullCars(ComboBox comboBox,string query)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand =new SqlCommand(query,sqlConnection);
            SqlDataReader sqlDataAdapter = sqlCommand.ExecuteReader();
            while (sqlDataAdapter.Read())
            {
                comboBox.Items.Add(sqlDataAdapter["CarName"].ToString());
            }

            sqlConnection.Close();
         }

        public void GetCustomer(TextBox TcNo, TextBox FirstName, TextBox LastName, TextBox Phone,  string query)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataReader sqlDataAdapter = sqlCommand.ExecuteReader();
            while (sqlDataAdapter.Read())
            {
                FirstName.Text = sqlDataAdapter["FirstName"].ToString();
                LastName.Text = sqlDataAdapter["LastName"].ToString();
                Phone.Text = sqlDataAdapter["Phone"].ToString();
            }

            sqlConnection.Close();
        }

        public void GetLicense(TextBox LicenseNO, TextBox LicenseDate, TextBox LicenseLocation, string query)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataReader sqlDataAdapter = sqlCommand.ExecuteReader();
            while (sqlDataAdapter.Read())
            {
                LicenseNO.Text = sqlDataAdapter["LicenseNO"].ToString();
                LicenseDate.Text = sqlDataAdapter["LicenseDate"].ToString();
                LicenseLocation.Text = sqlDataAdapter["LicenseLocation"].ToString();
            }

            sqlConnection.Close();
        }

        public void GetAllCar(ComboBox Cars, TextBox PlateNo, TextBox BrandName, TextBox ColorName, TextBox SerialNumber, TextBox ModelYear, TextBox DailyPrice, string query)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataReader sqlDataAdapter = sqlCommand.ExecuteReader();
            while (sqlDataAdapter.Read())
            {
                PlateNo.Text = sqlDataAdapter["PlateNo"].ToString();
                BrandName.Text = sqlDataAdapter["BrandName"].ToString();
                ColorName.Text = sqlDataAdapter["ColorName"].ToString();
                SerialNumber.Text = sqlDataAdapter["SerialNumber"].ToString();
                ModelYear.Text = sqlDataAdapter["ModelYear"].ToString();
                DailyPrice.Text = sqlDataAdapter["DailyPrice"].ToString();
            }

            sqlConnection.Close();
        }

        public void SaleCalcurate(  Label label)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("select  sum(Price) from sales",sqlConnection);
            label.Text = "Toplam Tutar =" + sqlCommand.ExecuteScalar() + " TL";
            sqlConnection.Close();

        }


       
    }
}
 