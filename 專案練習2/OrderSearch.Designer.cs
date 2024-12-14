namespace 專案練習2
{
    partial class OrderSearch
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp開始 = new System.Windows.Forms.DateTimePicker();
            this.dtp結束 = new System.Windows.Forms.DateTimePicker();
            this.btn商品查詢 = new System.Windows.Forms.Button();
            this.btn清除查詢 = new System.Windows.Forms.Button();
            this.btn客服 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Joey傢俱行 > 訂單查詢";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(16, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "訂單查詢";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(322, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "到";
            // 
            // dtp開始
            // 
            this.dtp開始.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp開始.Location = new System.Drawing.Point(130, 71);
            this.dtp開始.Name = "dtp開始";
            this.dtp開始.Size = new System.Drawing.Size(178, 29);
            this.dtp開始.TabIndex = 3;
            this.dtp開始.Value = new System.DateTime(2024, 1, 1, 21, 56, 0, 0);
            // 
            // dtp結束
            // 
            this.dtp結束.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp結束.Location = new System.Drawing.Point(362, 71);
            this.dtp結束.Name = "dtp結束";
            this.dtp結束.Size = new System.Drawing.Size(178, 29);
            this.dtp結束.TabIndex = 3;
            // 
            // btn商品查詢
            // 
            this.btn商品查詢.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.btn商品查詢.Location = new System.Drawing.Point(553, 68);
            this.btn商品查詢.Name = "btn商品查詢";
            this.btn商品查詢.Size = new System.Drawing.Size(94, 36);
            this.btn商品查詢.TabIndex = 5;
            this.btn商品查詢.Text = "查詢";
            this.btn商品查詢.UseVisualStyleBackColor = true;
            this.btn商品查詢.Click += new System.EventHandler(this.btn商品查詢_Click);
            // 
            // btn清除查詢
            // 
            this.btn清除查詢.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.btn清除查詢.Location = new System.Drawing.Point(553, 18);
            this.btn清除查詢.Name = "btn清除查詢";
            this.btn清除查詢.Size = new System.Drawing.Size(94, 31);
            this.btn清除查詢.TabIndex = 5;
            this.btn清除查詢.Text = "清除查詢";
            this.btn清除查詢.UseVisualStyleBackColor = true;
            this.btn清除查詢.Click += new System.EventHandler(this.btn清除查詢_Click);
            // 
            // btn客服
            // 
            this.btn客服.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.btn客服.Location = new System.Drawing.Point(446, 18);
            this.btn客服.Name = "btn客服";
            this.btn客服.Size = new System.Drawing.Size(94, 31);
            this.btn客服.TabIndex = 5;
            this.btn客服.Text = "線上客服";
            this.btn客服.UseVisualStyleBackColor = true;
            this.btn客服.Click += new System.EventHandler(this.btn客服_Click);
            // 
            // OrderSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(668, 629);
            this.Controls.Add(this.btn客服);
            this.Controls.Add(this.btn清除查詢);
            this.Controls.Add(this.btn商品查詢);
            this.Controls.Add(this.dtp結束);
            this.Controls.Add(this.dtp開始);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "OrderSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderSearch";
            this.Load += new System.EventHandler(this.OrderSearch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp開始;
        private System.Windows.Forms.DateTimePicker dtp結束;
        private System.Windows.Forms.Button btn商品查詢;
        private System.Windows.Forms.Button btn清除查詢;
        private System.Windows.Forms.Button btn客服;
    }
}