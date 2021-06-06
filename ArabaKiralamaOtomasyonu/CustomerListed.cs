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
    public partial class CustomerListed : Form
    {
        CarRentalDatabase carRentalDatabase = new CarRentalDatabase();
        public CustomerListed()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CustomerListed_Load(object sender, EventArgs e)
        {
            NewListed();
        }

        private void NewListed()
        {
            string CustomerListed = "select TcNo,FirstName,LastName,BirthDate,Phone,Email,Address  from Customers";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            dataGridView1.DataSource = carRentalDatabase.Listed(sqlDataAdapter, CustomerListed);
            dataGridView1.Columns[0].HeaderText = "T.C.";
            dataGridView1.Columns[1].HeaderText = "Ad";
            dataGridView1.Columns[2].HeaderText = "Soyad";
            dataGridView1.Columns[3].HeaderText = "Doğum Tarih";
            dataGridView1.Columns[4].HeaderText = "Telefon";
            dataGridView1.Columns[5].HeaderText = "E-Posta";
            dataGridView1.Columns[6].HeaderText = "Adres";
        }

        private void tc_search_TextChanged(object sender, EventArgs e)
        {
            string CustomerListed = "select TcNo,FirstName,LastName,BirthDate,Phone,Email,Address from customers where TcNo like'" + tc_search.Text+"%'";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();          
            dataGridView1.DataSource = carRentalDatabase.Listed(sqlDataAdapter, CustomerListed);
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dataGridViewRow = dataGridView1.CurrentRow;
            txttc.Text = dataGridViewRow.Cells[0].Value.ToString();
            txtfirstname.Text = dataGridViewRow.Cells[1].Value.ToString();
            txtlastname.Text = dataGridViewRow.Cells[2].Value.ToString();
            txtphone.Text = dataGridViewRow.Cells[4].Value.ToString();
            txtaddress.Text = dataGridViewRow.Cells[6].Value.ToString();
            txtbirthday.Text = dataGridViewRow.Cells[3].Value.ToString();
            txteposta.Text = dataGridViewRow.Cells[5].Value.ToString();

        }

        private void btnUpdated_Click(object sender, EventArgs e)
        {
            string CustomerUpdate = "update customers set FirstName=@FirstName,LastName=@LastName,Phone=@Phone,Address=@Address,Email=@Email where TcNo=@TcNo";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Parameters.AddWithValue("@TcNo", txttc.Text);
            sqlCommand.Parameters.AddWithValue("@FirstName", txtfirstname.Text);
            sqlCommand.Parameters.AddWithValue("@LastName", txtlastname.Text);
            sqlCommand.Parameters.AddWithValue("@BirthDate", txtbirthday.Text);
            sqlCommand.Parameters.AddWithValue("@Phone", txtphone.Text);
            sqlCommand.Parameters.AddWithValue("@Email", txteposta.Text);
            sqlCommand.Parameters.AddWithValue("@Address", txtaddress.Text);
            carRentalDatabase.Crud(sqlCommand, CustomerUpdate);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            NewListed();
            MessageBox.Show("Müşteri güncellendi", "Başarılı.");


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow dataGridViewRow = dataGridView1.CurrentRow;
            string CustomerDelete = "delete from customers where TcNo='"+dataGridViewRow.Cells["TcNo"].Value.ToString()+  "'";
            SqlCommand Delete = new SqlCommand();
            carRentalDatabase.Crud(Delete, CustomerDelete);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            NewListed();

            MessageBox.Show("Müşteri silindi", "Başarılı.");
        }

        private void tc_search_Click(object sender, EventArgs e)
        {
           tc_search.Clear();
        }
    }
}
