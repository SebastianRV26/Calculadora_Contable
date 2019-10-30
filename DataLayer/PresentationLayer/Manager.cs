using System;
using System.Collections.Generic;
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
            //the singleton containing the list of currencies belonging to the file is revived
            InitializeComponent();
            this.singleton = singleton;
            this.fillContainer(this.singleton.getMoney());
        }
       

        

        public void deleteCurrency(Money money)
        {
            //function call that removes the selected money instance
            this.singleton.getMoney().Remove(money);
            
        }

        private void addMoney(object sender, EventArgs e)
        {
            /*
             * Function that runs through the singleton list, and if the ticket or 
             * coin of the same value is not repeated, add the object to that list
             */
            if (txtboxAdd.Value > 0)
            {
                TypeCurrency typeCurrency;
                float value = (float) txtboxAdd.Value;

                if (radiobtnBillete.Checked)
                    typeCurrency = TypeCurrency.Bill;
                else
                    typeCurrency = TypeCurrency.Coin;

                if (!this.isEqual(value,typeCurrency))
                {
                    Money temp = new Money(value, typeCurrency, singleton.getCurrency());
                    this.singleton.getMoney().Add(temp);
                    this.singleton.saveMoney();
                    this.moneyContainer.Controls.Add(new MoneyControl(this, temp));
                    MessageBox.Show("Agregado correctamente!", "Mensaje informativo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                
            }else
                MessageBox.Show("Valor en cero", "Valor nulo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void SaveData(object sender, FormClosingEventArgs e)
        {//function call that edits the value of the selected money instance
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
        { //if you press the "Atrás" button, close the form
            this.Close(); //
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="typeCurrency"></param>
        /// <returns></returns>
        public bool isEqual(float value,TypeCurrency typeCurrency)
        {
            foreach (Money money in this.singleton.getMoney())
            {
                if (money.Value == value && money.TypeCurrency.Equals(typeCurrency))
                {
                    MessageBox.Show("Ya existe un billete con este valor", "Valor repetido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true;
                }
            }
            return false;
        }
    }
}
