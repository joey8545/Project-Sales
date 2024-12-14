namespace 專案練習2
{
    partial class UserControl3
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn明細 = new System.Windows.Forms.Button();
            this.lbl訂單狀態 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl金額 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl訂單日期 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl訂單編號 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn明細);
            this.groupBox1.Controls.Add(this.lbl訂單狀態);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lbl金額);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbl訂單日期);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbl訂單編號);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(539, 90);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btn明細
            // 
            this.btn明細.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.btn明細.Location = new System.Drawing.Point(465, 48);
            this.btn明細.Margin = new System.Windows.Forms.Padding(2);
            this.btn明細.Name = "btn明細";
            this.btn明細.Size = new System.Drawing.Size(51, 30);
            this.btn明細.TabIndex = 1;
            this.btn明細.Text = "明細";
            this.btn明細.UseVisualStyleBackColor = true;
            this.btn明細.Click += new System.EventHandler(this.btn明細_Click);
            // 
            // lbl訂單狀態
            // 
            this.lbl訂單狀態.AutoSize = true;
            this.lbl訂單狀態.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.lbl訂單狀態.Location = new System.Drawing.Point(344, 54);
            this.lbl訂單狀態.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl訂單狀態.Name = "lbl訂單狀態";
            this.lbl訂單狀態.Size = new System.Drawing.Size(49, 24);
            this.lbl訂單狀態.TabIndex = 0;
            this.lbl訂單狀態.Text = "XXX";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(469, 22);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "明細";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(342, 22);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "訂單狀態";
            // 
            // lbl金額
            // 
            this.lbl金額.AutoSize = true;
            this.lbl金額.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.lbl金額.Location = new System.Drawing.Point(238, 54);
            this.lbl金額.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl金額.Name = "lbl金額";
            this.lbl金額.Size = new System.Drawing.Size(49, 24);
            this.lbl金額.TabIndex = 0;
            this.lbl金額.Text = "XXX";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(236, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "金額";
            // 
            // lbl訂單日期
            // 
            this.lbl訂單日期.AutoSize = true;
            this.lbl訂單日期.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.lbl訂單日期.Location = new System.Drawing.Point(119, 54);
            this.lbl訂單日期.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl訂單日期.Name = "lbl訂單日期";
            this.lbl訂單日期.Size = new System.Drawing.Size(49, 24);
            this.lbl訂單日期.TabIndex = 0;
            this.lbl訂單日期.Text = "XXX";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(117, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "訂單日期";
            // 
            // lbl訂單編號
            // 
            this.lbl訂單編號.AutoSize = true;
            this.lbl訂單編號.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.lbl訂單編號.Location = new System.Drawing.Point(7, 54);
            this.lbl訂單編號.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl訂單編號.Name = "lbl訂單編號";
            this.lbl訂單編號.Size = new System.Drawing.Size(49, 24);
            this.lbl訂單編號.TabIndex = 0;
            this.lbl訂單編號.Text = "XXX";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "訂單編號";
            // 
            // UserControl3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserControl3";
            this.Size = new System.Drawing.Size(549, 102);
            this.Load += new System.EventHandler(this.UserControl3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lbl訂單編號;
        public System.Windows.Forms.Label lbl訂單日期;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btn明細;
        public System.Windows.Forms.Label lbl訂單狀態;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label lbl金額;
        public System.Windows.Forms.Label label4;
    }
}
