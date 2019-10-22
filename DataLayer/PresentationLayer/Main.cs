using LogicalLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PresentationLayer.Prefabs;
using Newtonsoft.Json.Linq;
using LogicalLayer.Enums;

namespace PresentationLayer
{
    public partial class Main : Form, MoneyManager
    {
        private Singleton singleton;
        private float total;
        
        public Main()
        {
            InitializeComponent();
            this.singleton = Singleton.getInstance();
            this.fillContainer( (List<Money>) this.singleton.getMoney()[Properties.Settings.Default.Currency] );          
        }

        public void fillContainer(List<Money> list)
        {
            foreach(Money money in list)
            {
                if(money.GetTypeCurrency() == TypeCurrency.Bill)
                    billContainer.Controls.Add(new MoneyControl(this, money.getValue()));
                else
                    coinContainer.Controls.Add(new MoneyControl(this, money.getValue()));
            }
        }

        public void addMoney(float value)
        {
            this.total += value;
        }


        private void openManager(object sender, EventArgs e)
        {
            
            Manager manager = new Manager();

            manager.Show();
            this.Close();
        }
    }
}
