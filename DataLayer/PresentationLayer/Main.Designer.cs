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
            this.btnRealiceCierre = new System.Windows.Forms.Button();
            this.moneyContainer = new System.Windows.Forms.FlowLayoutPanel();
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
            this.btnManager.Click += new System.EventHandler(this.BtnManager_Click);
            // 
            // s
            // 
            this.s.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.s.Controls.Add(this.radbtnDollar);
            this.s.Controls.Add(this.radiobtncolon);
            this.s.Controls.Add(this.lblMoney);
            this.s.Controls.Add(this.lblTotal);
            this.s.Controls.Add(this.btnRealiceCierre);
            this.s.Controls.Add(this.btnManager);
            this.s.Location = new System.Drawing.Point(599, 1);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(200, 449);
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
            // btnRealiceCierre
            // 
            this.btnRealiceCierre.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnRealiceCierre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRealiceCierre.Location = new System.Drawing.Point(3, 56);
            this.btnRealiceCierre.Name = "btnRealiceCierre";
            this.btnRealiceCierre.Size = new System.Drawing.Size(194, 39);
            this.btnRealiceCierre.TabIndex = 1;
            this.btnRealiceCierre.Text = "Realizar cierre";
            this.btnRealiceCierre.UseVisualStyleBackColor = false;
            // 
            // moneyContainer
            // 
            this.moneyContainer.Location = new System.Drawing.Point(0, 1);
            this.moneyContainer.Name = "moneyContainer";
            this.moneyContainer.Size = new System.Drawing.Size(593, 449);
            this.moneyContainer.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.moneyContainer);
            this.Controls.Add(this.s);
            this.Name = "Main";
            this.Text = "Main";
            this.s.ResumeLayout(false);
            this.s.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnManager;
        private System.Windows.Forms.Panel s;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnRealiceCierre;
        private System.Windows.Forms.RadioButton radbtnDollar;
        private System.Windows.Forms.RadioButton radiobtncolon;
        private System.Windows.Forms.FlowLayoutPanel moneyContainer;
    }
}