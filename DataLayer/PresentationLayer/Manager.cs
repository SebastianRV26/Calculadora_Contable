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
using LogicalLayer.Interfaces;

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

        public bool editMoney(int number, int newValue, TypeCurrency typeCurrency)
        {
            foreach (Money m in this.singleton.getMoney())
            {
                if ((m.getValue() == number) && (m.getValue().Equals(typeCurrency)))
                {
                    m.setValue(newValue);
                    return true;
                }
            }
            return false;
        }

        public bool deleteMoney(int number, TypeCurrency typeCurrency)
        {
            foreach (Money m in this.singleton.getMoney()) 
            { 
                if ((m.getValue() == number) && (m.getValue().Equals(typeCurrency)))
                {
                    (this.singleton.getMoney()).Remove(m);
                    return true;
                }
            }
            return false;
        }


        private void back(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Close();
        }

        private void addMoney(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtboxAdd.Text)) //if is empty
            {
                MessageBox.Show("No se ha insertado ningún dato", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int number = Convert.ToInt32((txtboxAdd.Text));
            Money mon;
            if (radiobtnBillete.Checked == true) //it's bill
            {
                foreach (Money m in this.singleton.getMoney()) //validate that it is not repeated 
                {
                    if ((m.getValue() == number) && (m.GetTypeCurrency().Equals(TypeCurrency.Bill)))
                    {
                        MessageBox.Show("Ya existe un billete con este valor", "Valor repetido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
    
                mon = new Money(number, TypeCurrency.Bill, singleton.getCurrency());
                MessageBox.Show("Billete agregado correctamente!", "Mensaje informativo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            { //it's a coin
                foreach (Money m in this.singleton.getMoney())
                {
                    if ((m.getValue() == number) && (m.GetTypeCurrency().Equals(TypeCurrency.Coin)))
                    {
                        MessageBox.Show("Ya existe una moneda con este valor", "Valor repetido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                mon = new Money(number, TypeCurrency.Coin, singleton.getCurrency());
                MessageBox.Show("Moneda agregada correctamente!", "Mensaje informativo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            this.singleton.getMoney().Add(mon); 
        }

    }
}
