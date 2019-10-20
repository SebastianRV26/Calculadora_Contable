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

namespace PresentationLayer
{
    public partial class Main : Form, MoneyManager
    {
        private Singleton singleton;
        private int total;
        private bool isDollar;

        public Main()
        {
            this.singleton = Singleton.getInstance();
            InitializeComponent();
            fillContainer(this.singleton.getColones());
        }

        public void fillContainer(JArray array)
        {
            moneyContainer.Controls.Clear();
            foreach (int cash in array)
            {
                moneyContainer.Controls.Add(new Money(this, cash));
            }
        }

        public void addMoney(int value)
        {
            this.total += value;
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void BtnManager_Click(object sender, EventArgs e)
        {
            Manager manager = new Manager();
            
            manager.Show();
            this.Close();

        }

        private void complete(object sender, EventArgs e)
        {
            lblMoney.Text = this.total.ToString();

            if (this.isDollar)
                this.fillContainer(this.singleton.getDollars());
            else
                this.fillContainer(this.singleton.getColones());
        }
    }
}
