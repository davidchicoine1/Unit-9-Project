
namespace NorthwindApp
{
    partial class frmMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(119, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 418);
            this.panel1.TabIndex = 0;
            // 
            // btnCustomers
            // 
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCustomers.Location = new System.Drawing.Point(12, 25);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(101, 31);
            this.btnCustomers.TabIndex = 9;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEmployees.Location = new System.Drawing.Point(12, 62);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(101, 31);
            this.btnEmployees.TabIndex = 10;
            this.btnEmployees.Text = "Employees";
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOrders.Location = new System.Drawing.Point(12, 99);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(101, 31);
            this.btnOrders.TabIndex = 10;
            this.btnOrders.Text = "Orders";
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 457);
            this.Controls.Add(this.btnOrders);
            this.Controls.Add(this.btnEmployees);
            this.Controls.Add(this.btnCustomers);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Northwind App - Main Screen";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnOrders;
    }
}