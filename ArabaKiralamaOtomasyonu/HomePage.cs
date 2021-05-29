using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArabaKiralamaOtomasyonu
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Sales sales = new Sales();
            sales.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Contract contract = new Contract();
            contract.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            CarsListed carsListed = new CarsListed();
            carsListed.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CarAdd carAdd = new CarAdd();
            carAdd.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CustomerListed Listed = new CustomerListed();

            Listed.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerAdd add = new CustomerAdd();
            add.ShowDialog();

        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
