namespace TipCalculator
{
    partial class Form1
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
            this.calcTip = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tipPercent = new System.Windows.Forms.MaskedTextBox();
            this.totalBox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // calcTip
            // 
            this.calcTip.Location = new System.Drawing.Point(62, 124);
            this.calcTip.Name = "calcTip";
            this.calcTip.Size = new System.Drawing.Size(175, 30);
            this.calcTip.TabIndex = 0;
            this.calcTip.Text = "Get tip";
            this.calcTip.UseVisualStyleBackColor = true;
            this.calcTip.Click += new System.EventHandler(this.calcTip_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter the price of your meal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter your tip percent";
            // 
            // tipPercent
            // 
            this.tipPercent.Location = new System.Drawing.Point(64, 98);
            this.tipPercent.Mask = "0.00";
            this.tipPercent.Name = "tipPercent";
            this.tipPercent.Size = new System.Drawing.Size(168, 20);
            this.tipPercent.TabIndex = 4;
            // 
            // totalBox
            // 
            this.totalBox.Location = new System.Drawing.Point(67, 50);
            this.totalBox.Mask = "000.00";
            this.totalBox.Name = "totalBox";
            this.totalBox.Size = new System.Drawing.Size(164, 20);
            this.totalBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 175);
            this.Controls.Add(this.totalBox);
            this.Controls.Add(this.tipPercent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calcTip);
            this.Name = "Form1";
            this.Text = "Tip Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button calcTip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox tipPercent;
        private System.Windows.Forms.MaskedTextBox totalBox;
    }
}

