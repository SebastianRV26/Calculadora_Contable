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

namespace PresentationLayer
{
    public partial class Main : Form, MoneyManager
    {


        public Main()
        {
            InitializeComponent();

            Singleton sing = Singleton.getInstance();
        }

       public void addMoney(int value)
       {

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
    }
}
