using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicalLayer;
using PresentationLayer.Prefabs;
using LogicalLayer.Enums;

namespace PresentationLayer
{
    public partial class Manager: Form, MoneyManager
    {
        private Singleton singleton;


        public Manager(Singleton singleton)
        {
            InitializeComponent();
            this.singleton = singleton;
        }
        
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            
            if ((txtboxAdd.Text.Trim() == "")) //if is empty
            {
                MessageBox.Show("No se ha insertado ningún dato", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int numero = Convert.ToInt32(txtboxAdd.ToString());
            if (radiobtnBillete.Checked == true) //it's bill
            {
                //num, typeCurrency, currency
                Money mon = new Money(numero, TypeCurrency.Bill, singleton.getCurrency());
                this.singleton.getMoney().Add(mon);
                return;
            }

        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Manager_Load(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void BtnBefore_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Close();
        }

        private void RadiobtnBillete_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TxtboxAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            { //only numbers
                e.Handled = true;
            }
        }

        private void TxtboxEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            { //only numbers
                e.Handled = true;
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {

        }

        public void addMoney(float value)
        {
            throw new NotImplementedException();
        }
    }
}
