using System;
using System.Windows.Forms;
using LogicalLayer;
using LogicalLayer.Enums;

namespace PresentationLayer
{
    public partial class Preload : Form
    {
        private Singleton singleton;

        // Constructor
        public Preload()
        {
            this.singleton = Singleton.getInstance();
            InitializeComponent();
            comboCurrency.DataSource = Enum.GetValues(typeof(Currency));
        }



        private void clickEnter(object sender, EventArgs e)
        {
            this.singleton.setCurrency((Currency)comboCurrency.SelectedItem);
            Main form = new Main();
            form.Show();
            this.Dispose();
            
        }

        private void close(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.Save();
        
            Application.Exit();
        }
    }
}
