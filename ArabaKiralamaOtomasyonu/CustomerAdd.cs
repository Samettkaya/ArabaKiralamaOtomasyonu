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
    public partial class CustomerAdd : Form
    {
        CarRentalDatabase carRentalDatabase = new CarRentalDatabase();
        SqlConnection sqlConnection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CarRentalAutomation;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public CustomerAdd()
        {
            InitializeComponent();
        }

        private void CustomerAdd_Load(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        bool durum;
       void bul()
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("select * from customers where TcNo=@TcNo ", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@TcNo", txttc.Text);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            if (sqlDataReader.Read())
            {
                durum = false;

            }
            else
            {
                durum = true;
            }
            sqlConnection.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bul();
            if (durum == true)
            {
                string sentence = "insert into customers(FirstName,LastName,TcNo,BirthDate,Phone,Email,Address) values(@FirstName,@LastName,@TcNo,@BirthDate,@Phone,@Email,@Address)";
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Parameters.AddWithValue("@TcNo", txttc.Text);
                sqlCommand.Parameters.AddWithValue("@FirstName", txtfirstname.Text);
                sqlCommand.Parameters.AddWithValue("@LastName", txtlastname.Text);
                sqlCommand.Parameters.AddWithValue("@BirthDate", txtbirthday.Text);
                sqlCommand.Parameters.AddWithValue("@Phone", txtphone.Text);
                sqlCommand.Parameters.AddWithValue("@Email", txteposta.Text);
                sqlCommand.Parameters.AddWithValue("@Address", txtaddress.Text);

                carRentalDatabase.Crud(sqlCommand, sentence);
                foreach (Control control in Controls) if (control is TextBox) control.Text = "";

                MessageBox.Show("Müşteri Eklendi", "Başarılı.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Bu kayıt zaten var ", "Bilgi.",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                foreach (Control control in Controls) if (control is TextBox) control.Text = "";
            }

                      
                   
               
            
           
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtlastname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
