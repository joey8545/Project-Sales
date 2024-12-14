namespace 專案練習2
{
    partial class CheckList
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
            this.lbox購物車 = new System.Windows.Forms.ListBox();
            this.btn移除選項 = new System.Windows.Forms.Button();
            this.btn移除全部 = new System.Windows.Forms.Button();
            this.btn結帳 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt配送地址 = new System.Windows.Forms.TextBox();
            this.rdb貨運配送 = new System.Windows.Forms.RadioButton();
            this.rdb自行取貨 = new System.Windows.Forms.RadioButton();
            this.lbl配送地址 = new System.Windows.Forms.Label();
            this.lbl商品總額 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl總額 = new System.Windows.Forms.Label();
            this.lbl運費 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt訂購人 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt電話 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdbLinePay = new System.Windows.Forms.RadioButton();
            this.rdb信用卡 = new System.Windows.Forms.RadioButton();
            this.rdb現金付款 = new System.Windows.Forms.RadioButton();
            this.lbl會員折扣 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbox購物車
            // 
            this.lbox購物車.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbox購物車.FormattingEnabled = true;
            this.lbox購物車.ItemHeight = 24;
            this.lbox購物車.Location = new System.Drawing.Point(17, 49);
            this.lbox購物車.Name = "lbox購物車";
            this.lbox購物車.ScrollAlwaysVisible = true;
            this.lbox購物車.Size = new System.Drawing.Size(702, 196);
            this.lbox購物車.TabIndex = 11;
            // 
            // btn移除選項
            // 
            this.btn移除選項.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn移除選項.Location = new System.Drawing.Point(725, 49);
            this.btn移除選項.Name = "btn移除選項";
            this.btn移除選項.Size = new System.Drawing.Size(128, 42);
            this.btn移除選項.TabIndex = 12;
            this.btn移除選項.Text = "移除商品";
            this.btn移除選項.UseVisualStyleBackColor = true;
            this.btn移除選項.Click += new System.EventHandler(this.btn移除選項_Click);
            // 
            // btn移除全部
            // 
            this.btn移除全部.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn移除全部.Location = new System.Drawing.Point(725, 97);
            this.btn移除全部.Name = "btn移除全部";
            this.btn移除全部.Size = new System.Drawing.Size(128, 42);
            this.btn移除全部.TabIndex = 13;
            this.btn移除全部.Text = "移除全部";
            this.btn移除全部.UseVisualStyleBackColor = true;
            this.btn移除全部.Click += new System.EventHandler(this.btn移除全部_Click);
            // 
            // btn結帳
            // 
            this.btn結帳.Font = new System.Drawing.Font("微軟正黑體", 16.25F, System.Drawing.FontStyle.Bold);
            this.btn結帳.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn結帳.Location = new System.Drawing.Point(725, 403);
            this.btn結帳.Name = "btn結帳";
            this.btn結帳.Size = new System.Drawing.Size(128, 42);
            this.btn結帳.TabIndex = 13;
            this.btn結帳.Text = "結帳";
            this.btn結帳.UseVisualStyleBackColor = true;
            this.btn結帳.Click += new System.EventHandler(this.btn結帳_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt配送地址);
            this.groupBox1.Controls.Add(this.rdb貨運配送);
            this.groupBox1.Controls.Add(this.rdb自行取貨);
            this.groupBox1.Controls.Add(this.lbl配送地址);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(17, 251);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 194);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "選擇運送方式";
            // 
            // txt配送地址
            // 
            this.txt配送地址.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.txt配送地址.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt配送地址.Location = new System.Drawing.Point(29, 148);
            this.txt配送地址.Name = "txt配送地址";
            this.txt配送地址.Size = new System.Drawing.Size(357, 32);
            this.txt配送地址.TabIndex = 1;
            // 
            // rdb貨運配送
            // 
            this.rdb貨運配送.AutoSize = true;
            this.rdb貨運配送.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.rdb貨運配送.Location = new System.Drawing.Point(12, 78);
            this.rdb貨運配送.Name = "rdb貨運配送";
            this.rdb貨運配送.Size = new System.Drawing.Size(104, 28);
            this.rdb貨運配送.TabIndex = 0;
            this.rdb貨運配送.TabStop = true;
            this.rdb貨運配送.Text = "貨運配送";
            this.rdb貨運配送.UseVisualStyleBackColor = true;
            this.rdb貨運配送.CheckedChanged += new System.EventHandler(this.rdb貨運配送_CheckedChanged);
            // 
            // rdb自行取貨
            // 
            this.rdb自行取貨.AutoSize = true;
            this.rdb自行取貨.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.rdb自行取貨.Location = new System.Drawing.Point(12, 40);
            this.rdb自行取貨.Name = "rdb自行取貨";
            this.rdb自行取貨.Size = new System.Drawing.Size(104, 28);
            this.rdb自行取貨.TabIndex = 0;
            this.rdb自行取貨.TabStop = true;
            this.rdb自行取貨.Text = "自行取貨";
            this.rdb自行取貨.UseVisualStyleBackColor = true;
            this.rdb自行取貨.CheckedChanged += new System.EventHandler(this.rdb自行取貨_CheckedChanged);
            // 
            // lbl配送地址
            // 
            this.lbl配送地址.AutoSize = true;
            this.lbl配送地址.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.lbl配送地址.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl配送地址.Location = new System.Drawing.Point(28, 115);
            this.lbl配送地址.Name = "lbl配送地址";
            this.lbl配送地址.Size = new System.Drawing.Size(91, 24);
            this.lbl配送地址.TabIndex = 10;
            this.lbl配送地址.Text = "配送地址:";
            // 
            // lbl商品總額
            // 
            this.lbl商品總額.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.lbl商品總額.ForeColor = System.Drawing.Color.Brown;
            this.lbl商品總額.Location = new System.Drawing.Point(145, 40);
            this.lbl商品總額.Name = "lbl商品總額";
            this.lbl商品總額.Size = new System.Drawing.Size(125, 28);
            this.lbl商品總額.TabIndex = 10;
            this.lbl商品總額.Text = " NT$0";
            this.lbl商品總額.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lbl總額);
            this.groupBox2.Controls.Add(this.lbl會員折扣);
            this.groupBox2.Controls.Add(this.lbl運費);
            this.groupBox2.Controls.Add(this.lbl商品總額);
            this.groupBox2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(440, 251);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(279, 194);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "總覽";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(11, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(266, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "--------------------------------";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(11, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "項目總計";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(11, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "運費";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(11, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "商品";
            // 
            // lbl總額
            // 
            this.lbl總額.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.lbl總額.ForeColor = System.Drawing.Color.Brown;
            this.lbl總額.Location = new System.Drawing.Point(145, 155);
            this.lbl總額.Name = "lbl總額";
            this.lbl總額.Size = new System.Drawing.Size(125, 28);
            this.lbl總額.TabIndex = 10;
            this.lbl總額.Text = " NT$0";
            this.lbl總額.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl運費
            // 
            this.lbl運費.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.lbl運費.ForeColor = System.Drawing.Color.Brown;
            this.lbl運費.Location = new System.Drawing.Point(145, 72);
            this.lbl運費.Name = "lbl運費";
            this.lbl運費.Size = new System.Drawing.Size(125, 28);
            this.lbl運費.TabIndex = 10;
            this.lbl運費.Text = " NT$0";
            this.lbl運費.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(536, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 28);
            this.label6.TabIndex = 10;
            this.label6.Text = " 滿$10,000免運費";
            // 
            // txt訂購人
            // 
            this.txt訂購人.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.txt訂購人.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt訂購人.Location = new System.Drawing.Point(90, 12);
            this.txt訂購人.Name = "txt訂購人";
            this.txt訂購人.Size = new System.Drawing.Size(133, 32);
            this.txt訂購人.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 28);
            this.label1.TabIndex = 10;
            this.label1.Text = "訂購人";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(244, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 28);
            this.label7.TabIndex = 10;
            this.label7.Text = "電話";
            // 
            // txt電話
            // 
            this.txt電話.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.txt電話.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt電話.Location = new System.Drawing.Point(301, 11);
            this.txt電話.Name = "txt電話";
            this.txt電話.Size = new System.Drawing.Size(160, 32);
            this.txt電話.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdbLinePay);
            this.groupBox3.Controls.Add(this.rdb信用卡);
            this.groupBox3.Controls.Add(this.rdb現金付款);
            this.groupBox3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox3.Location = new System.Drawing.Point(725, 251);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(128, 138);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "付費方式";
            // 
            // rdbLinePay
            // 
            this.rdbLinePay.AutoSize = true;
            this.rdbLinePay.Location = new System.Drawing.Point(6, 98);
            this.rdbLinePay.Name = "rdbLinePay";
            this.rdbLinePay.Size = new System.Drawing.Size(104, 28);
            this.rdbLinePay.TabIndex = 0;
            this.rdbLinePay.TabStop = true;
            this.rdbLinePay.Text = "Line Pay";
            this.rdbLinePay.UseVisualStyleBackColor = true;
            this.rdbLinePay.CheckedChanged += new System.EventHandler(this.rdbLinePay_CheckedChanged);
            // 
            // rdb信用卡
            // 
            this.rdb信用卡.AutoSize = true;
            this.rdb信用卡.Location = new System.Drawing.Point(6, 65);
            this.rdb信用卡.Name = "rdb信用卡";
            this.rdb信用卡.Size = new System.Drawing.Size(85, 28);
            this.rdb信用卡.TabIndex = 0;
            this.rdb信用卡.TabStop = true;
            this.rdb信用卡.Text = "信用卡";
            this.rdb信用卡.UseVisualStyleBackColor = true;
            this.rdb信用卡.CheckedChanged += new System.EventHandler(this.rdb信用卡_CheckedChanged);
            // 
            // rdb現金付款
            // 
            this.rdb現金付款.AutoSize = true;
            this.rdb現金付款.Location = new System.Drawing.Point(6, 32);
            this.rdb現金付款.Name = "rdb現金付款";
            this.rdb現金付款.Size = new System.Drawing.Size(104, 28);
            this.rdb現金付款.TabIndex = 0;
            this.rdb現金付款.TabStop = true;
            this.rdb現金付款.Text = "現金付款";
            this.rdb現金付款.UseVisualStyleBackColor = true;
            this.rdb現金付款.CheckedChanged += new System.EventHandler(this.rdb現金付款_CheckedChanged);
            // 
            // lbl會員折扣
            // 
            this.lbl會員折扣.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.lbl會員折扣.ForeColor = System.Drawing.Color.Brown;
            this.lbl會員折扣.Location = new System.Drawing.Point(145, 106);
            this.lbl會員折扣.Name = "lbl會員折扣";
            this.lbl會員折扣.Size = new System.Drawing.Size(125, 28);
            this.lbl會員折扣.TabIndex = 10;
            this.lbl會員折扣.Text = " NT$0";
            this.lbl會員折扣.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(11, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 24);
            this.label9.TabIndex = 10;
            this.label9.Text = "會員折扣";
            // 
            // CheckList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 457);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txt電話);
            this.Controls.Add(this.txt訂購人);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn結帳);
            this.Controls.Add(this.btn移除全部);
            this.Controls.Add(this.btn移除選項);
            this.Controls.Add(this.lbox購物車);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "CheckList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckList";
            this.Load += new System.EventHandler(this.CheckList_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lbox購物車;
        private System.Windows.Forms.Button btn移除選項;
        private System.Windows.Forms.Button btn移除全部;
        private System.Windows.Forms.Button btn結帳;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt配送地址;
        private System.Windows.Forms.RadioButton rdb貨運配送;
        private System.Windows.Forms.RadioButton rdb自行取貨;
        private System.Windows.Forms.Label lbl商品總額;
        private System.Windows.Forms.Label lbl配送地址;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl總額;
        private System.Windows.Forms.Label lbl運費;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt訂購人;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt電話;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdbLinePay;
        private System.Windows.Forms.RadioButton rdb信用卡;
        private System.Windows.Forms.RadioButton rdb現金付款;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl會員折扣;
    }
}