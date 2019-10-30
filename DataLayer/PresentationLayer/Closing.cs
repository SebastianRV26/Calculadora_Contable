﻿using LogicalLayer;
using System;
using System.Windows.Forms;

namespace PresentationLayer
{

    
    public partial class Closing : Form
    {
        private Singleton singleton;


        public Closing()
        {
            singleton = Singleton.getInstance(); 
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        public void fillinClosing()
        {
            listBox1.Items.Add(string.Format("   \t{0}   \t\t{1}   \t\t{2}   \t{3}", "Tipo", "Valor", "Cantidad", "Total"));
            foreach (Money money in singleton.getMoney())
            {
                if (money.getQuantity() != 0)
                {
                    listBox1.Items.Add(string.Format("   \t{0}   \t\t{1}   \t\t{2}   \t\t{3}", money.TypeCurrency, money.Value, money.getQuantity(), money.Value * money.getQuantity()));
                    money.setQuantity(0);
                }
            }
        }

    }
}
