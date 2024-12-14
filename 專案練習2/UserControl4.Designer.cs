namespace 專案練習2
{
    partial class UserControl4
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
            this.btn客服開啟 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl回覆狀態 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl會員名稱 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl會員ID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn客服開啟);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lbl回覆狀態);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbl會員名稱);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbl會員ID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(13, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(431, 90);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btn客服開啟
            // 
            this.btn客服開啟.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.btn客服開啟.Location = new System.Drawing.Point(351, 48);
            this.btn客服開啟.Margin = new System.Windows.Forms.Padding(2);
            this.btn客服開啟.Name = "btn客服開啟";
            this.btn客服開啟.Size = new System.Drawing.Size(51, 30);
            this.btn客服開啟.TabIndex = 1;
            this.btn客服開啟.Text = "開啟";
            this.btn客服開啟.UseVisualStyleBackColor = true;
            this.btn客服開啟.Click += new System.EventHandler(this.btn客服開啟_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(352, 22);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "客服";
            // 
            // lbl回覆狀態
            // 
            this.lbl回覆狀態.AutoSize = true;
            this.lbl回覆狀態.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.lbl回覆狀態.Location = new System.Drawing.Point(238, 54);
            this.lbl回覆狀態.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl回覆狀態.Name = "lbl回覆狀態";
            this.lbl回覆狀態.Size = new System.Drawing.Size(49, 24);
            this.lbl回覆狀態.TabIndex = 0;
            this.lbl回覆狀態.Text = "XXX";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(236, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "回覆狀態";
            // 
            // lbl會員名稱
            // 
            this.lbl會員名稱.AutoSize = true;
            this.lbl會員名稱.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.lbl會員名稱.Location = new System.Drawing.Point(119, 54);
            this.lbl會員名稱.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl會員名稱.Name = "lbl會員名稱";
            this.lbl會員名稱.Size = new System.Drawing.Size(49, 24);
            this.lbl會員名稱.TabIndex = 0;
            this.lbl會員名稱.Text = "XXX";
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
            this.label2.Text = "會員名稱";
            // 
            // lbl會員ID
            // 
            this.lbl會員ID.AutoSize = true;
            this.lbl會員ID.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.lbl會員ID.Location = new System.Drawing.Point(7, 54);
            this.lbl會員ID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl會員ID.Name = "lbl會員ID";
            this.lbl會員ID.Size = new System.Drawing.Size(49, 24);
            this.lbl會員ID.TabIndex = 0;
            this.lbl會員ID.Text = "XXX";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "會員ID";
            // 
            // UserControl4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "UserControl4";
            this.Size = new System.Drawing.Size(469, 122);
            this.Load += new System.EventHandler(this.UserControl4_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button btn客服開啟;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label lbl回覆狀態;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label lbl會員名稱;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lbl會員ID;
        public System.Windows.Forms.Label label1;
    }
}
