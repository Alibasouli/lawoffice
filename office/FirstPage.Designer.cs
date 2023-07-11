namespace office
{
    partial class FirstPage
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
            this.Customer_BT = new System.Windows.Forms.Button();
            this.Lawyer_BT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Customer_BT
            // 
            this.Customer_BT.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Customer_BT.Location = new System.Drawing.Point(124, 68);
            this.Customer_BT.Name = "Customer_BT";
            this.Customer_BT.Size = new System.Drawing.Size(242, 153);
            this.Customer_BT.TabIndex = 0;
            this.Customer_BT.Text = "Customers";
            this.Customer_BT.UseVisualStyleBackColor = true;
            this.Customer_BT.Click += new System.EventHandler(this.Customer_BT_Click);
            // 
            // Lawyer_BT
            // 
            this.Lawyer_BT.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Lawyer_BT.Location = new System.Drawing.Point(124, 276);
            this.Lawyer_BT.Name = "Lawyer_BT";
            this.Lawyer_BT.Size = new System.Drawing.Size(242, 153);
            this.Lawyer_BT.TabIndex = 1;
            this.Lawyer_BT.Text = "Lawyers";
            this.Lawyer_BT.UseVisualStyleBackColor = true;
            this.Lawyer_BT.Click += new System.EventHandler(this.Lawyer_BT_Click);
            // 
            // FirstPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.Lawyer_BT);
            this.Controls.Add(this.Customer_BT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FirstPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FirstPage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Customer_BT;
        private System.Windows.Forms.Button Lawyer_BT;
    }
}