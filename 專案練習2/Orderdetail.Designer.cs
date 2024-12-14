namespace 專案練習2
{
    partial class Orderdetail
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txt訂購人名稱 = new System.Windows.Forms.TextBox();
            this.rdb已送達 = new System.Windows.Forms.RadioButton();
            this.rdb已出貨 = new System.Windows.Forms.RadioButton();
            this.rdb審核中 = new System.Windows.Forms.RadioButton();
            this.rdb全部 = new System.Windows.Forms.RadioButton();
            this.btn訂單查詢 = new System.Windows.Forms.Button();
            this.dtp結束 = new System.Windows.Forms.DateTimePicker();
            this.dtp開始 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txt客人名稱 = new System.Windows.Forms.TextBox();
            this.rdb已回覆 = new System.Windows.Forms.RadioButton();
            this.rdb待回覆 = new System.Windows.Forms.RadioButton();
            this.rdb全部回覆 = new System.Windows.Forms.RadioButton();
            this.txt客服查詢 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn銷量查詢 = new System.Windows.Forms.Button();
            this.dtp結束1 = new System.Windows.Forms.DateTimePicker();
            this.dtp開始1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl營業額 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(990, 583);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.txt訂購人名稱);
            this.tabPage1.Controls.Add(this.rdb已送達);
            this.tabPage1.Controls.Add(this.rdb已出貨);
            this.tabPage1.Controls.Add(this.rdb審核中);
            this.tabPage1.Controls.Add(this.rdb全部);
            this.tabPage1.Controls.Add(this.btn訂單查詢);
            this.tabPage1.Controls.Add(this.dtp結束);
            this.tabPage1.Controls.Add(this.dtp開始);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(982, 546);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "訂單確認";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txt訂購人名稱
            // 
            this.txt訂購人名稱.Location = new System.Drawing.Point(139, 100);
            this.txt訂購人名稱.Name = "txt訂購人名稱";
            this.txt訂購人名稱.Size = new System.Drawing.Size(193, 29);
            this.txt訂購人名稱.TabIndex = 12;
            // 
            // rdb已送達
            // 
            this.rdb已送達.AutoSize = true;
            this.rdb已送達.Font = new System.Drawing.Font("微軟正黑體", 13F, System.Drawing.FontStyle.Bold);
            this.rdb已送達.Location = new System.Drawing.Point(388, 61);
            this.rdb已送達.Name = "rdb已送達";
            this.rdb已送達.Size = new System.Drawing.Size(82, 27);
            this.rdb已送達.TabIndex = 11;
            this.rdb已送達.TabStop = true;
            this.rdb已送達.Text = "已送達";
            this.rdb已送達.UseVisualStyleBackColor = true;
            this.rdb已送達.CheckedChanged += new System.EventHandler(this.rdb已送達_CheckedChanged);
            // 
            // rdb已出貨
            // 
            this.rdb已出貨.AutoSize = true;
            this.rdb已出貨.Font = new System.Drawing.Font("微軟正黑體", 13F, System.Drawing.FontStyle.Bold);
            this.rdb已出貨.Location = new System.Drawing.Point(299, 61);
            this.rdb已出貨.Name = "rdb已出貨";
            this.rdb已出貨.Size = new System.Drawing.Size(82, 27);
            this.rdb已出貨.TabIndex = 11;
            this.rdb已出貨.TabStop = true;
            this.rdb已出貨.Text = "已出貨";
            this.rdb已出貨.UseVisualStyleBackColor = true;
            this.rdb已出貨.CheckedChanged += new System.EventHandler(this.rdb已出貨_CheckedChanged);
            // 
            // rdb審核中
            // 
            this.rdb審核中.AutoSize = true;
            this.rdb審核中.Font = new System.Drawing.Font("微軟正黑體", 13F, System.Drawing.FontStyle.Bold);
            this.rdb審核中.Location = new System.Drawing.Point(210, 61);
            this.rdb審核中.Name = "rdb審核中";
            this.rdb審核中.Size = new System.Drawing.Size(82, 27);
            this.rdb審核中.TabIndex = 11;
            this.rdb審核中.TabStop = true;
            this.rdb審核中.Text = "審核中";
            this.rdb審核中.UseVisualStyleBackColor = true;
            this.rdb審核中.CheckedChanged += new System.EventHandler(this.rdb審核中_CheckedChanged);
            // 
            // rdb全部
            // 
            this.rdb全部.AutoSize = true;
            this.rdb全部.Font = new System.Drawing.Font("微軟正黑體", 13F, System.Drawing.FontStyle.Bold);
            this.rdb全部.Location = new System.Drawing.Point(139, 61);
            this.rdb全部.Name = "rdb全部";
            this.rdb全部.Size = new System.Drawing.Size(64, 27);
            this.rdb全部.TabIndex = 11;
            this.rdb全部.TabStop = true;
            this.rdb全部.Text = "全部";
            this.rdb全部.UseVisualStyleBackColor = true;
            this.rdb全部.CheckedChanged += new System.EventHandler(this.rdb全部_CheckedChanged);
            // 
            // btn訂單查詢
            // 
            this.btn訂單查詢.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.btn訂單查詢.Location = new System.Drawing.Point(579, 95);
            this.btn訂單查詢.Name = "btn訂單查詢";
            this.btn訂單查詢.Size = new System.Drawing.Size(75, 34);
            this.btn訂單查詢.TabIndex = 10;
            this.btn訂單查詢.Text = "查詢";
            this.btn訂單查詢.UseVisualStyleBackColor = true;
            this.btn訂單查詢.Click += new System.EventHandler(this.btn訂單查詢_Click);
            // 
            // dtp結束
            // 
            this.dtp結束.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp結束.Location = new System.Drawing.Point(371, 17);
            this.dtp結束.Name = "dtp結束";
            this.dtp結束.Size = new System.Drawing.Size(178, 29);
            this.dtp結束.TabIndex = 8;
            // 
            // dtp開始
            // 
            this.dtp開始.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp開始.Location = new System.Drawing.Point(139, 17);
            this.dtp開始.Name = "dtp開始";
            this.dtp開始.Size = new System.Drawing.Size(178, 29);
            this.dtp開始.TabIndex = 9;
            this.dtp開始.Value = new System.DateTime(2024, 1, 1, 21, 56, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(331, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "到";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(25, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "訂購人名稱";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(25, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "訂單狀態";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(25, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "訂單查詢";
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.Controls.Add(this.txt客人名稱);
            this.tabPage3.Controls.Add(this.rdb已回覆);
            this.tabPage3.Controls.Add(this.rdb待回覆);
            this.tabPage3.Controls.Add(this.rdb全部回覆);
            this.tabPage3.Controls.Add(this.txt客服查詢);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold);
            this.tabPage3.Location = new System.Drawing.Point(4, 33);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(982, 546);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "線上客服";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txt客人名稱
            // 
            this.txt客人名稱.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.txt客人名稱.Location = new System.Drawing.Point(130, 57);
            this.txt客人名稱.Name = "txt客人名稱";
            this.txt客人名稱.Size = new System.Drawing.Size(193, 29);
            this.txt客人名稱.TabIndex = 20;
            // 
            // rdb已回覆
            // 
            this.rdb已回覆.AutoSize = true;
            this.rdb已回覆.Font = new System.Drawing.Font("微軟正黑體", 13F, System.Drawing.FontStyle.Bold);
            this.rdb已回覆.Location = new System.Drawing.Point(290, 18);
            this.rdb已回覆.Name = "rdb已回覆";
            this.rdb已回覆.Size = new System.Drawing.Size(82, 27);
            this.rdb已回覆.TabIndex = 17;
            this.rdb已回覆.TabStop = true;
            this.rdb已回覆.Text = "已回覆";
            this.rdb已回覆.UseVisualStyleBackColor = true;
            this.rdb已回覆.CheckedChanged += new System.EventHandler(this.rdb已回覆_CheckedChanged);
            // 
            // rdb待回覆
            // 
            this.rdb待回覆.AutoSize = true;
            this.rdb待回覆.Font = new System.Drawing.Font("微軟正黑體", 13F, System.Drawing.FontStyle.Bold);
            this.rdb待回覆.Location = new System.Drawing.Point(201, 18);
            this.rdb待回覆.Name = "rdb待回覆";
            this.rdb待回覆.Size = new System.Drawing.Size(82, 27);
            this.rdb待回覆.TabIndex = 18;
            this.rdb待回覆.TabStop = true;
            this.rdb待回覆.Text = "待回覆";
            this.rdb待回覆.UseVisualStyleBackColor = true;
            this.rdb待回覆.CheckedChanged += new System.EventHandler(this.rdb待回覆_CheckedChanged);
            // 
            // rdb全部回覆
            // 
            this.rdb全部回覆.AutoSize = true;
            this.rdb全部回覆.Font = new System.Drawing.Font("微軟正黑體", 13F, System.Drawing.FontStyle.Bold);
            this.rdb全部回覆.Location = new System.Drawing.Point(130, 18);
            this.rdb全部回覆.Name = "rdb全部回覆";
            this.rdb全部回覆.Size = new System.Drawing.Size(64, 27);
            this.rdb全部回覆.TabIndex = 19;
            this.rdb全部回覆.TabStop = true;
            this.rdb全部回覆.Text = "全部";
            this.rdb全部回覆.UseVisualStyleBackColor = true;
            this.rdb全部回覆.CheckedChanged += new System.EventHandler(this.rdb全部回覆_CheckedChanged);
            // 
            // txt客服查詢
            // 
            this.txt客服查詢.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.txt客服查詢.Location = new System.Drawing.Point(358, 56);
            this.txt客服查詢.Name = "txt客服查詢";
            this.txt客服查詢.Size = new System.Drawing.Size(75, 34);
            this.txt客服查詢.TabIndex = 15;
            this.txt客服查詢.Text = "查詢";
            this.txt客服查詢.UseVisualStyleBackColor = true;
            this.txt客服查詢.Click += new System.EventHandler(this.txt客服查詢_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(16, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 24);
            this.label8.TabIndex = 13;
            this.label8.Text = "客人名稱";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(16, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 24);
            this.label9.TabIndex = 14;
            this.label9.Text = "回覆狀態";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn銷量查詢);
            this.tabPage2.Controls.Add(this.dtp結束1);
            this.tabPage2.Controls.Add(this.dtp開始1);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.lbl營業額);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(982, 546);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "商品銷量";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn銷量查詢
            // 
            this.btn銷量查詢.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.btn銷量查詢.Location = new System.Drawing.Point(569, 13);
            this.btn銷量查詢.Name = "btn銷量查詢";
            this.btn銷量查詢.Size = new System.Drawing.Size(75, 34);
            this.btn銷量查詢.TabIndex = 17;
            this.btn銷量查詢.Text = "查詢";
            this.btn銷量查詢.UseVisualStyleBackColor = true;
            this.btn銷量查詢.Click += new System.EventHandler(this.btn銷量查詢_Click);
            // 
            // dtp結束1
            // 
            this.dtp結束1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp結束1.Location = new System.Drawing.Point(361, 15);
            this.dtp結束1.Name = "dtp結束1";
            this.dtp結束1.Size = new System.Drawing.Size(178, 29);
            this.dtp結束1.TabIndex = 15;
            // 
            // dtp開始1
            // 
            this.dtp開始1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp開始1.Location = new System.Drawing.Point(129, 15);
            this.dtp開始1.Name = "dtp開始1";
            this.dtp開始1.Size = new System.Drawing.Size(178, 29);
            this.dtp開始1.TabIndex = 16;
            this.dtp開始1.Value = new System.DateTime(2024, 1, 1, 21, 56, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(321, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "到";
            // 
            // lbl營業額
            // 
            this.lbl營業額.AutoSize = true;
            this.lbl營業額.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.lbl營業額.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl營業額.Location = new System.Drawing.Point(791, 16);
            this.lbl營業額.Name = "lbl營業額";
            this.lbl營業額.Size = new System.Drawing.Size(72, 24);
            this.lbl營業額.TabIndex = 14;
            this.lbl營業額.Text = "營業額:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(718, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = "營業額:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(15, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "日期查詢";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(982, 496);
            this.dataGridView1.TabIndex = 0;
            // 
            // Orderdetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 607);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Orderdetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orderdetail";
            this.Activated += new System.EventHandler(this.Orderdetail_Activated);
            this.Load += new System.EventHandler(this.Orderdetail_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn訂單查詢;
        private System.Windows.Forms.DateTimePicker dtp結束;
        private System.Windows.Forms.DateTimePicker dtp開始;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdb已送達;
        private System.Windows.Forms.RadioButton rdb已出貨;
        private System.Windows.Forms.RadioButton rdb審核中;
        private System.Windows.Forms.RadioButton rdb全部;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn銷量查詢;
        private System.Windows.Forms.DateTimePicker dtp結束1;
        private System.Windows.Forms.DateTimePicker dtp開始1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt訂購人名稱;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl營業額;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txt客人名稱;
        private System.Windows.Forms.RadioButton rdb已回覆;
        private System.Windows.Forms.RadioButton rdb待回覆;
        private System.Windows.Forms.RadioButton rdb全部回覆;
        private System.Windows.Forms.Button txt客服查詢;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}