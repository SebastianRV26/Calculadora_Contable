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
    public partial class Manager: Form, MoneyManager, ContainerUpdater
    {
        private Singleton singleton;
  


        public Manager(Singleton singleton)
        {
   
            InitializeComponent();
            this.singleton = singleton;
            this.fillContainer(this.singleton.getMoney());
        }
       

        

        public void deleteCurrency(Money money)
        {
            
            this.singleton.getMoney().Remove(money);
            
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

                Money temp = new Money(value, typeCurrency, singleton.getCurrency());
                this.singleton.getMoney().Add(temp);
                this.singleton.saveMoney();
                this.moneyContainer.Controls.Add(new MoneyControl(this, temp));
                MessageBox.Show("Moneda agregada correctamente!", "Mensaje informativo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            MessageBox.Show("Valor en cero", "Valor nulo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void SaveData(object sender, FormClosingEventArgs e)
        {
            this.singleton.saveMoney();
        }

        public void containerUpdate()
        {
            this.moneyContainer.Controls.Clear();
            this.fillContainer(this.singleton.getMoney());
        }

        public void fillContainer(List<Money> list)
        {
           
            foreach (Money money in list)
            {
                moneyContainer.Controls.Add(new MoneyControl(this, money));
            }
        }

        private void BtnBefore_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
