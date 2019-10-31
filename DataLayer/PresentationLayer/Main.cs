using LogicalLayer;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PresentationLayer.Prefabs;
using LogicalLayer.Enums;
using LogicalLayer.Interfaces;

namespace PresentationLayer
{

    public partial class Main : Form, TotalValue,ContainerUpdater
    {
        private Singleton singleton;
        private float total;


        public Main()
        {
            InitializeComponent();
            this.singleton = Singleton.getInstance();
            this.fillContainer( this.singleton.getMoney());          
        }

        public void fillContainer(List<Money> list)
        {    
            foreach(Money money in list)
            {
                MoneyControl temp = new MoneyControl(this, money);
                if (money.TypeCurrency == TypeCurrency.Bill)
                    billContainer.Controls.Add(temp);
                else
                    coinContainer.Controls.Add(temp);

            }
        }

        public void addMoney(float value)
        {
            this.total += value;
            lblMoney.Text = this.total.ToString();
        }


        private void openManager(object sender, EventArgs e)
        {
            Manager form =  new Manager(this.singleton);
            form.ShowDialog();
            this.containerUpdate();
            
        }

        private void finish(object sender, EventArgs e)
        {
            this.total = 0;
            lblMoney.Text = "0.0";
            Closing form = new Closing();
            form.fillinClosing(); //function that fills the listbox of the form to be displayed
            form.ShowDialog(); 
        }

        private void close(object sender, FormClosedEventArgs e)
        {
            
            Application.Exit(); //the program ends
        }

        private void back(object sender, EventArgs e)
        { //choose the type of currency again
            Form form = new Preload();
            form.Show();
            this.Dispose();
        }

        public void containerUpdate()
        {
            this.coinContainer.Controls.Clear();
            this.billContainer.Controls.Clear();
            this.fillContainer(this.singleton.getMoney());
        }
    }
}
