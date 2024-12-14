namespace 專案練習2
{
    partial class UserControl1
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
            this.lbl_缺貨 = new System.Windows.Forms.Label();
            this.lbl_剩餘數量 = new System.Windows.Forms.Label();
            this.lbl_剩餘 = new System.Windows.Forms.Label();
            this.lbl_金額 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_加入購物車 = new System.Windows.Forms.Button();
            this.lbl_尺寸 = new System.Windows.Forms.Label();
            this.lbl_項目介紹 = new System.Windows.Forms.Label();
            this.lbl_項目名稱 = new System.Windows.Forms.Label();
            this.cbox_數量 = new System.Windows.Forms.ComboBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pic圖片 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic圖片)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_缺貨);
            this.groupBox1.Controls.Add(this.lbl_剩餘數量);
            this.groupBox1.Controls.Add(this.lbl_剩餘);
            this.groupBox1.Controls.Add(this.lbl_金額);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pic圖片);
            this.groupBox1.Controls.Add(this.btn_加入購物車);
            this.groupBox1.Controls.Add(this.lbl_尺寸);
            this.groupBox1.Controls.Add(this.lbl_項目介紹);
            this.groupBox1.Controls.Add(this.lbl_項目名稱);
            this.groupBox1.Controls.Add(this.cbox_數量);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 445);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // lbl_缺貨
            // 
            this.lbl_缺貨.AutoSize = true;
            this.lbl_缺貨.BackColor = System.Drawing.Color.White;
            this.lbl_缺貨.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_缺貨.ForeColor = System.Drawing.Color.Brown;
            this.lbl_缺貨.Location = new System.Drawing.Point(119, 128);
            this.lbl_缺貨.Name = "lbl_缺貨";
            this.lbl_缺貨.Size = new System.Drawing.Size(123, 61);
            this.lbl_缺貨.TabIndex = 1;
            this.lbl_缺貨.Text = "缺貨";
            // 
            // lbl_剩餘數量
            // 
            this.lbl_剩餘數量.AutoSize = true;
            this.lbl_剩餘數量.BackColor = System.Drawing.Color.White;
            this.lbl_剩餘數量.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_剩餘數量.Location = new System.Drawing.Point(126, 37);
            this.lbl_剩餘數量.Name = "lbl_剩餘數量";
            this.lbl_剩餘數量.Size = new System.Drawing.Size(32, 24);
            this.lbl_剩餘數量.TabIndex = 1;
            this.lbl_剩餘數量.Text = "50";
            // 
            // lbl_剩餘
            // 
            this.lbl_剩餘.AutoSize = true;
            this.lbl_剩餘.BackColor = System.Drawing.Color.White;
            this.lbl_剩餘.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_剩餘.Location = new System.Drawing.Point(41, 37);
            this.lbl_剩餘.Name = "lbl_剩餘";
            this.lbl_剩餘.Size = new System.Drawing.Size(91, 24);
            this.lbl_剩餘.TabIndex = 1;
            this.lbl_剩餘.Text = "剩餘數量:";
            // 
            // lbl_金額
            // 
            this.lbl_金額.AutoSize = true;
            this.lbl_金額.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_金額.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_金額.Location = new System.Drawing.Point(242, 313);
            this.lbl_金額.Name = "lbl_金額";
            this.lbl_金額.Size = new System.Drawing.Size(93, 40);
            this.lbl_金額.TabIndex = 1;
            this.lbl_金額.Text = "5000";
            this.lbl_金額.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(217, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "$";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_加入購物車
            // 
            this.btn_加入購物車.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_加入購物車.Location = new System.Drawing.Point(215, 375);
            this.btn_加入購物車.Name = "btn_加入購物車";
            this.btn_加入購物車.Size = new System.Drawing.Size(120, 40);
            this.btn_加入購物車.TabIndex = 3;
            this.btn_加入購物車.Text = "加入購物車";
            this.btn_加入購物車.UseVisualStyleBackColor = true;
            this.btn_加入購物車.Click += new System.EventHandler(this.btn_加入購物車_Click);
            // 
            // lbl_尺寸
            // 
            this.lbl_尺寸.AutoSize = true;
            this.lbl_尺寸.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_尺寸.Location = new System.Drawing.Point(31, 350);
            this.lbl_尺寸.Name = "lbl_尺寸";
            this.lbl_尺寸.Size = new System.Drawing.Size(129, 24);
            this.lbl_尺寸.TabIndex = 1;
            this.lbl_尺寸.Text = "150x200 公分";
            // 
            // lbl_項目介紹
            // 
            this.lbl_項目介紹.AutoSize = true;
            this.lbl_項目介紹.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_項目介紹.Location = new System.Drawing.Point(31, 324);
            this.lbl_項目介紹.Name = "lbl_項目介紹";
            this.lbl_項目介紹.Size = new System.Drawing.Size(103, 24);
            this.lbl_項目介紹.TabIndex = 1;
            this.lbl_項目介紹.Text = "松木/luroy";
            // 
            // lbl_項目名稱
            // 
            this.lbl_項目名稱.AutoSize = true;
            this.lbl_項目名稱.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_項目名稱.Location = new System.Drawing.Point(30, 298);
            this.lbl_項目名稱.Name = "lbl_項目名稱";
            this.lbl_項目名稱.Size = new System.Drawing.Size(86, 24);
            this.lbl_項目名稱.TabIndex = 1;
            this.lbl_項目名稱.Text = "雙人床框";
            // 
            // cbox_數量
            // 
            this.cbox_數量.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbox_數量.FormattingEnabled = true;
            this.cbox_數量.Location = new System.Drawing.Point(31, 381);
            this.cbox_數量.Name = "cbox_數量";
            this.cbox_數量.Size = new System.Drawing.Size(175, 29);
            this.cbox_數量.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn2.HeaderText = "name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "introduce";
            this.dataGridViewTextBoxColumn3.HeaderText = "introduce";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "size";
            this.dataGridViewTextBoxColumn4.HeaderText = "size";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "price";
            this.dataGridViewTextBoxColumn5.HeaderText = "price";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "counts";
            this.dataGridViewTextBoxColumn6.HeaderText = "counts";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "pic_before";
            this.dataGridViewTextBoxColumn7.HeaderText = "pic_before";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "pic_after";
            this.dataGridViewTextBoxColumn8.HeaderText = "pic_after";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // pic圖片
            // 
            this.pic圖片.BackColor = System.Drawing.Color.White;
            this.pic圖片.Location = new System.Drawing.Point(32, 25);
            this.pic圖片.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pic圖片.Name = "pic圖片";
            this.pic圖片.Size = new System.Drawing.Size(301, 260);
            this.pic圖片.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic圖片.TabIndex = 0;
            this.pic圖片.TabStop = false;
            this.pic圖片.MouseEnter += new System.EventHandler(this.pic圖片_MouseEnter);
            this.pic圖片.MouseLeave += new System.EventHandler(this.pic圖片_MouseLeave);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(379, 455);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic圖片)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label lbl_缺貨;
        public System.Windows.Forms.Label lbl_剩餘數量;
        public System.Windows.Forms.Label lbl_剩餘;
        public System.Windows.Forms.Label lbl_金額;
        public System.Windows.Forms.PictureBox pic圖片;
        public System.Windows.Forms.Button btn_加入購物車;
        public System.Windows.Forms.Label lbl_項目介紹;
        public System.Windows.Forms.Label lbl_項目名稱;
        public System.Windows.Forms.ComboBox cbox_數量;
        public System.Windows.Forms.Label lbl_尺寸;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        public System.Windows.Forms.Label label2;
    }
}
