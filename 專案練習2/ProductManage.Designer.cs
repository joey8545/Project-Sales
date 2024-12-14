namespace 專案練習2
{
    partial class ProductManage
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
            this.components = new System.ComponentModel.Container();
            this.listView商品展示 = new System.Windows.Forms.ListView();
            this.btn新增商品 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn重新整理 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView商品展示
            // 
            this.listView商品展示.HideSelection = false;
            this.listView商品展示.Location = new System.Drawing.Point(12, 12);
            this.listView商品展示.Name = "listView商品展示";
            this.listView商品展示.Size = new System.Drawing.Size(905, 623);
            this.listView商品展示.TabIndex = 0;
            this.listView商品展示.UseCompatibleStateImageBehavior = false;
            this.listView商品展示.ItemActivate += new System.EventHandler(this.listView商品展示_ItemActivate);
            // 
            // btn新增商品
            // 
            this.btn新增商品.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.btn新增商品.Location = new System.Drawing.Point(938, 516);
            this.btn新增商品.Name = "btn新增商品";
            this.btn新增商品.Size = new System.Drawing.Size(160, 52);
            this.btn新增商品.TabIndex = 1;
            this.btn新增商品.Text = "新增商品";
            this.btn新增商品.UseVisualStyleBackColor = true;
            this.btn新增商品.Click += new System.EventHandler(this.btn新增商品_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(256, 256);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btn重新整理
            // 
            this.btn重新整理.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold);
            this.btn重新整理.Location = new System.Drawing.Point(938, 583);
            this.btn重新整理.Name = "btn重新整理";
            this.btn重新整理.Size = new System.Drawing.Size(160, 52);
            this.btn重新整理.TabIndex = 1;
            this.btn重新整理.Text = "重新整理";
            this.btn重新整理.UseVisualStyleBackColor = true;
            // 
            // ProductManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 647);
            this.Controls.Add(this.btn重新整理);
            this.Controls.Add(this.btn新增商品);
            this.Controls.Add(this.listView商品展示);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ProductManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductManage";
            this.Activated += new System.EventHandler(this.ProductManage_Activated);
            this.Load += new System.EventHandler(this.ProductManage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView商品展示;
        private System.Windows.Forms.Button btn新增商品;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btn重新整理;
    }
}