using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicalLayer;
using System.Windows.Forms;

namespace PresentationLayer.Prefabs
{
    public partial class Money : UserControl
    {
        private MoneyManager manager;
        private int Value { get { return Value; } set { Value = value; } }

        public Money(MoneyManager manager,int value)
        {
            this.manager = manager;
            this.Value = value;
            InitializeComponent();
            lblValue.Text = value.ToString();
        }

        public Money()
        {
            InitializeComponent();
        }

        private void addMoney(object sender, EventArgs e)
        {
            manager.addMoney( (int)inputQuantity.Value * this.Value );
            btnAdd.Enabled = !btnAdd.Enabled;
        }
    }
}
