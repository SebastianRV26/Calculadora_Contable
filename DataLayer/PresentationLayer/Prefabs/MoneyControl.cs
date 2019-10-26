using System;
using LogicalLayer.Interfaces;
using System.Windows.Forms;
using LogicalLayer;

namespace PresentationLayer.Prefabs
{
    public partial class MoneyControl : UserControl
    {
        private TotalValue manager;
        private MoneyManager editor;
        private Money money;
        private bool editing;

        public MoneyControl(TotalValue manager, Money money)
        {
            this.editing = false;
            this.manager = manager;
            InitializeComponent();
            lblValue.Text = money.Value.ToString();
        }

        public MoneyControl(MoneyManager editor, Money money)
        {
            this.editing = true;
            this.editor = editor;
            InitializeComponent();

            this.lblEditing.Visible = true;
            lblValue.Visible = false;
            btnDelete.Visible = true;
            this.inputQuantity.DecimalPlaces = 2;
            inputQuantity.Value = (decimal) money.Value;
            this.btnAction.Text = "Guardar";
        }

        private void removeCurrency(object sender, EventArgs e)
        {
            this.editor.deleteCurrency(this.money);
            this.Dispose();
        }

        private void action(object sender, EventArgs e)
        {
            if (editing)
            {
                this.editor.editCurrency(this.money);

                return;
            }
            manager.addMoney((int)inputQuantity.Value * this.money.Value);
            inputQuantity.Value = 0;
        }
    }
}
