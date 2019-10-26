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


        public Manager()
        {
            InitializeComponent();
            this.singleton = Singleton.getInstance();
        }

        

        public bool editMoney(int number, int newValue, TypeCurrency typeCurrency)
        {
            foreach (Money m in this.singleton.getMoney())
            {
                if ((m.Value == number) && (m.Value.Equals(typeCurrency)))
                {
                    m.Value = newValue;
                    return true;
                }
            }
            return false;
        }

        public bool deleteMoney(int number, TypeCurrency typeCurrency)
        {
            foreach (Money m in this.singleton.getMoney()) 
            { 
                if ((m.Value == number) && (m.Value.Equals(typeCurrency)))
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
            this.Dispose();
        }

        private void addMoney(object sender, EventArgs e)
        {
            if (txtboxAdd.Value > 0)
            {
                TypeCurrency typeCurrency;
                float value = (float) txtboxAdd.Value;

                if (radiobtnBillete.Checked)
                    typeCurrency = TypeCurrency.Bill;
                else
                    typeCurrency = TypeCurrency.Coin;

                foreach (Money money in this.singleton.getMoney())
                {
                    if ( money.Value == value  && money.TypeCurrency.Equals(typeCurrency) )
                    {
                        MessageBox.Show("Ya existe un billete con este valor", "Valor repetido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                this.singleton.getMoney().Add( new Money(value, typeCurrency, singleton.getCurrency() ) );
                MessageBox.Show("Moneda agregada correctamente!", "Mensaje informativo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            MessageBox.Show("Valor en cero", "Valor nulo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
