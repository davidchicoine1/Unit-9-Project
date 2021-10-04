
namespace NorthwindApp
{
    partial class frmCustomers
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
            this.btnGetCustomersData = new System.Windows.Forms.Button();
            this.lbxNames = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGetCustomersData
            // 
            this.btnGetCustomersData.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGetCustomersData.Location = new System.Drawing.Point(105, 21);
            this.btnGetCustomersData.Name = "btnGetCustomersData";
            this.btnGetCustomersData.Size = new System.Drawing.Size(135, 38);
            this.btnGetCustomersData.TabIndex = 2;
            this.btnGetCustomersData.Text = "Get Customers Data";
            this.btnGetCustomersData.UseVisualStyleBackColor = true;
            this.btnGetCustomersData.Click += new System.EventHandler(this.btnGetCustomersData_Click);
            // 
            // lbxNames
            // 
            this.lbxNames.FormattingEnabled = true;
            this.lbxNames.Location = new System.Drawing.Point(83, 156);
            this.lbxNames.Name = "lbxNames";
            this.lbxNames.Size = new System.Drawing.Size(181, 186);
            this.lbxNames.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Customer Last Names:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Number of Customers:";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(83, 101);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.ReadOnly = true;
            this.txtNumber.Size = new System.Drawing.Size(179, 20);
            this.txtNumber.TabIndex = 3;
            this.txtNumber.TabStop = false;
            this.txtNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 362);
            this.Controls.Add(this.btnGetCustomersData);
            this.Controls.Add(this.lbxNames);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCustomers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customers Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetCustomersData;
        private System.Windows.Forms.ListBox lbxNames;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumber;
    }
}

