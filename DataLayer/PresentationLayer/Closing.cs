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
    public partial class Closing : Form
    {
        private Singleton singleton;
        public Closing(Singleton singleton1)
        {
            singleton = singleton1; 
            InitializeComponent();
        }

        public void fillinClosing()
        {
            foreach (Money money in singleton.getMoney())
            {
                listBox1.Items.Add(money.TypeCurrency);
                listBox2.Items.Add(money.Value); 
                listBox3.Items.Add(money.Quantity); 
                listBox4.Items.Add((money.Value*money.Quantity)); //falta multiplicarlo por la cantidad
            }
        }
    }
}
