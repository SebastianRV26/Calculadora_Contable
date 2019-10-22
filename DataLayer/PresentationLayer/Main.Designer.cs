namespace PresentationLayer
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnManager = new System.Windows.Forms.Button();
            this.s = new System.Windows.Forms.Panel();
            this.radbtnDollar = new System.Windows.Forms.RadioButton();
            this.radiobtncolon = new System.Windows.Forms.RadioButton();
            this.lblMoney = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnComplete = new System.Windows.Forms.Button();
            this.billContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.coinContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.s.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnManager
            // 
            this.btnManager.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManager.Location = new System.Drawing.Point(3, 11);
            this.btnManager.Name = "btnManager";
            this.btnManager.Size = new System.Drawing.Size(194, 39);
            this.btnManager.TabIndex = 0;
            this.btnManager.Text = "Gestonar de Dinero";
            this.btnManager.UseVisualStyleBackColor = false;
            this.btnManager.Click += new System.EventHandler(this.openManager);
            // 
            // s
            // 
            this.s.AutoSize = true;
            this.s.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.s.Controls.Add(this.radbtnDollar);
            this.s.Controls.Add(this.radiobtncolon);
            this.s.Controls.Add(this.lblMoney);
            this.s.Controls.Add(this.lblTotal);
            this.s.Controls.Add(this.btnComplete);
            this.s.Controls.Add(this.btnManager);
            this.s.Location = new System.Drawing.Point(599, 1);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(200, 458);
            this.s.TabIndex = 1;
            // 
            // radbtnDollar
            // 
            this.radbtnDollar.AutoSize = true;
            this.radbtnDollar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtnDollar.Location = new System.Drawing.Point(100, 101);
            this.radbtnDollar.Name = "radbtnDollar";
            this.radbtnDollar.Size = new System.Drawing.Size(47, 35);
            this.radbtnDollar.TabIndex = 5;
            this.radbtnDollar.Text = "$";
            this.radbtnDollar.UseVisualStyleBackColor = true;
            // 
            // radiobtncolon
            // 
            this.radiobtncolon.AutoSize = true;
            this.radiobtncolon.Checked = true;
            this.radiobtncolon.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobtncolon.Location = new System.Drawing.Point(42, 101);
            this.radiobtncolon.Name = "radiobtncolon";
            this.radiobtncolon.Size = new System.Drawing.Size(52, 35);
            this.radiobtncolon.TabIndex = 4;
            this.radiobtncolon.TabStop = true;
            this.radiobtncolon.Text = "₡";
            this.radiobtncolon.UseVisualStyleBackColor = true;
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoney.Location = new System.Drawing.Point(47, 387);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(118, 31);
            this.lblMoney.TabIndex = 3;
            this.lblMoney.Text = "dinero :v";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(64, 343);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(83, 31);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Total:";
            // 
            // btnComplete
            // 
            this.btnComplete.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnComplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComplete.Location = new System.Drawing.Point(3, 56);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(194, 39);
            this.btnComplete.TabIndex = 1;
            this.btnComplete.Text = "Realizar cierre";
            this.btnComplete.UseVisualStyleBackColor = false;
            // 
            // billContainer
            // 
            this.billContainer.AutoScroll = true;
            this.billContainer.Location = new System.Drawing.Point(0, 24);
            this.billContainer.Name = "billContainer";
            this.billContainer.Size = new System.Drawing.Size(596, 204);
            this.billContainer.TabIndex = 2;
            // 
            // coinContainer
            // 
            this.coinContainer.AutoScroll = true;
            this.coinContainer.Location = new System.Drawing.Point(0, 248);
            this.coinContainer.Name = "coinContainer";
            this.coinContainer.Size = new System.Drawing.Size(596, 202);
            this.coinContainer.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Monedas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Billetes";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 459);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.coinContainer);
            this.Controls.Add(this.billContainer);
            this.Controls.Add(this.s);
            this.Name = "Main";
            this.Text = "Main";
            this.s.ResumeLayout(false);
            this.s.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnManager;
        private System.Windows.Forms.Panel s;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.RadioButton radbtnDollar;
        private System.Windows.Forms.RadioButton radiobtncolon;
        private System.Windows.Forms.FlowLayoutPanel billContainer;
        private System.Windows.Forms.FlowLayoutPanel coinContainer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}