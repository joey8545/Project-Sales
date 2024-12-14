namespace 專案練習2
{
    partial class Customer_service
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
            this.txt對話框 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt訊息 = new System.Windows.Forms.TextBox();
            this.btn發送 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt對話框
            // 
            this.txt對話框.Location = new System.Drawing.Point(15, 41);
            this.txt對話框.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt對話框.Multiline = true;
            this.txt對話框.Name = "txt對話框";
            this.txt對話框.ReadOnly = true;
            this.txt對話框.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt對話框.Size = new System.Drawing.Size(649, 360);
            this.txt對話框.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(15, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "線上客服";
            // 
            // txt訊息
            // 
            this.txt訊息.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt訊息.Location = new System.Drawing.Point(15, 408);
            this.txt訊息.Multiline = true;
            this.txt訊息.Name = "txt訊息";
            this.txt訊息.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txt訊息.Size = new System.Drawing.Size(557, 47);
            this.txt訊息.TabIndex = 2;
            // 
            // btn發送
            // 
            this.btn發送.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.btn發送.Location = new System.Drawing.Point(579, 408);
            this.btn發送.Name = "btn發送";
            this.btn發送.Size = new System.Drawing.Size(85, 47);
            this.btn發送.TabIndex = 3;
            this.btn發送.Text = "發送";
            this.btn發送.UseVisualStyleBackColor = true;
            this.btn發送.Click += new System.EventHandler(this.btn發送_Click);
            // 
            // Customer_service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 472);
            this.Controls.Add(this.btn發送);
            this.Controls.Add(this.txt訊息);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt對話框);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Customer_service";
            this.Text = "Customer_service";
            this.Load += new System.EventHandler(this.Customer_service_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt對話框;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt訊息;
        private System.Windows.Forms.Button btn發送;
    }
}