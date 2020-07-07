namespace BankSystem
{
    partial class Product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product));
            this.buttonProductBack = new System.Windows.Forms.Button();
            this.ProductTitle = new System.Windows.Forms.Label();
            this.labelProductAccount = new System.Windows.Forms.Label();
            this.comboBoxProduct = new System.Windows.Forms.ComboBox();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            this.buttonProductGold = new System.Windows.Forms.Button();
            this.buttonProductSilver = new System.Windows.Forms.Button();
            this.buttonProductDollars = new System.Windows.Forms.Button();
            this.buttonProductOil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxProductNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelProductBuyMoney = new System.Windows.Forms.Label();
            this.buttonProductBuy = new System.Windows.Forms.Button();
            this.labelProductHaveNumber = new System.Windows.Forms.Label();
            this.labelProductHaveMoney = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lable7 = new System.Windows.Forms.Label();
            this.productcoast = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvProductStatus = new System.Windows.Forms.DataGridView();
            this.labelACCOUNT = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonProductBack
            // 
            this.buttonProductBack.Font = new System.Drawing.Font("SimSun", 12F);
            this.buttonProductBack.Location = new System.Drawing.Point(522, 328);
            this.buttonProductBack.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonProductBack.Name = "buttonProductBack";
            this.buttonProductBack.Size = new System.Drawing.Size(68, 32);
            this.buttonProductBack.TabIndex = 3;
            this.buttonProductBack.Text = "返回";
            this.buttonProductBack.UseVisualStyleBackColor = true;
            this.buttonProductBack.Click += new System.EventHandler(this.buttonProductBack_Click);
            // 
            // ProductTitle
            // 
            this.ProductTitle.AutoSize = true;
            this.ProductTitle.Font = new System.Drawing.Font("SimSun", 8F);
            this.ProductTitle.Location = new System.Drawing.Point(9, 8);
            this.ProductTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProductTitle.Name = "ProductTitle";
            this.ProductTitle.Size = new System.Drawing.Size(49, 11);
            this.ProductTitle.TabIndex = 6;
            this.ProductTitle.Text = "当前账户";
            // 
            // labelProductAccount
            // 
            this.labelProductAccount.AutoSize = true;
            this.labelProductAccount.Font = new System.Drawing.Font("SimSun", 12F);
            this.labelProductAccount.Location = new System.Drawing.Point(140, 27);
            this.labelProductAccount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProductAccount.Name = "labelProductAccount";
            this.labelProductAccount.Size = new System.Drawing.Size(104, 16);
            this.labelProductAccount.TabIndex = 7;
            this.labelProductAccount.Text = "选择银行卡：";
            // 
            // comboBoxProduct
            // 
            this.comboBoxProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProduct.FormattingEnabled = true;
            this.comboBoxProduct.Location = new System.Drawing.Point(241, 28);
            this.comboBoxProduct.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBoxProduct.Name = "comboBoxProduct";
            this.comboBoxProduct.Size = new System.Drawing.Size(171, 21);
            this.comboBoxProduct.TabIndex = 8;
            // 
            // skinEngine1
            // 
            this.skinEngine1.@__DrawButtonFocusRectangle = true;
            this.skinEngine1.DisabledButtonTextColor = System.Drawing.Color.Gray;
            this.skinEngine1.DisabledMenuFontColor = System.Drawing.SystemColors.GrayText;
            this.skinEngine1.InactiveCaptionColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = null;
            // 
            // buttonProductGold
            // 
            this.buttonProductGold.Font = new System.Drawing.Font("SimSun", 12F);
            this.buttonProductGold.Location = new System.Drawing.Point(45, 64);
            this.buttonProductGold.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonProductGold.Name = "buttonProductGold";
            this.buttonProductGold.Size = new System.Drawing.Size(56, 36);
            this.buttonProductGold.TabIndex = 9;
            this.buttonProductGold.Text = "美元";
            this.buttonProductGold.UseVisualStyleBackColor = true;
            this.buttonProductGold.Click += new System.EventHandler(this.buttonProductGold_Click);
            // 
            // buttonProductSilver
            // 
            this.buttonProductSilver.Font = new System.Drawing.Font("SimSun", 12F);
            this.buttonProductSilver.Location = new System.Drawing.Point(170, 64);
            this.buttonProductSilver.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonProductSilver.Name = "buttonProductSilver";
            this.buttonProductSilver.Size = new System.Drawing.Size(56, 36);
            this.buttonProductSilver.TabIndex = 10;
            this.buttonProductSilver.Text = "欧元";
            this.buttonProductSilver.UseVisualStyleBackColor = true;
            this.buttonProductSilver.Click += new System.EventHandler(this.buttonProductSilver_Click);
            // 
            // buttonProductDollars
            // 
            this.buttonProductDollars.Font = new System.Drawing.Font("SimSun", 12F);
            this.buttonProductDollars.Location = new System.Drawing.Point(297, 64);
            this.buttonProductDollars.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonProductDollars.Name = "buttonProductDollars";
            this.buttonProductDollars.Size = new System.Drawing.Size(56, 36);
            this.buttonProductDollars.TabIndex = 11;
            this.buttonProductDollars.Text = "日元";
            this.buttonProductDollars.UseVisualStyleBackColor = true;
            this.buttonProductDollars.Click += new System.EventHandler(this.buttonProductDollars_Click);
            // 
            // buttonProductOil
            // 
            this.buttonProductOil.Font = new System.Drawing.Font("SimSun", 12F);
            this.buttonProductOil.Location = new System.Drawing.Point(430, 64);
            this.buttonProductOil.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonProductOil.Name = "buttonProductOil";
            this.buttonProductOil.Size = new System.Drawing.Size(56, 36);
            this.buttonProductOil.TabIndex = 12;
            this.buttonProductOil.Text = "英镑";
            this.buttonProductOil.UseVisualStyleBackColor = true;
            this.buttonProductOil.Click += new System.EventHandler(this.buttonProductOil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 12F);
            this.label1.Location = new System.Drawing.Point(8, 266);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "已拥有：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 12F);
            this.label2.Location = new System.Drawing.Point(8, 326);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "总价值：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SimSun", 12F);
            this.label3.Location = new System.Drawing.Point(221, 287);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "购入数量：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SimSun", 12F);
            this.label4.Location = new System.Drawing.Point(364, 287);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 17;
            // 
            // textBoxProductNumber
            // 
            this.textBoxProductNumber.Font = new System.Drawing.Font("SimSun", 12F);
            this.textBoxProductNumber.Location = new System.Drawing.Point(300, 284);
            this.textBoxProductNumber.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxProductNumber.Name = "textBoxProductNumber";
            this.textBoxProductNumber.Size = new System.Drawing.Size(76, 26);
            this.textBoxProductNumber.TabIndex = 18;
            this.textBoxProductNumber.TextChanged += new System.EventHandler(this.textBoxProductNumber_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("SimSun", 12F);
            this.label5.Location = new System.Drawing.Point(253, 326);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "总价：";
            // 
            // labelProductBuyMoney
            // 
            this.labelProductBuyMoney.Font = new System.Drawing.Font("SimSun", 12F);
            this.labelProductBuyMoney.Location = new System.Drawing.Point(294, 326);
            this.labelProductBuyMoney.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProductBuyMoney.Name = "labelProductBuyMoney";
            this.labelProductBuyMoney.Size = new System.Drawing.Size(79, 16);
            this.labelProductBuyMoney.TabIndex = 20;
            this.labelProductBuyMoney.Text = "0";
            this.labelProductBuyMoney.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonProductBuy
            // 
            this.buttonProductBuy.Font = new System.Drawing.Font("SimSun", 12F);
            this.buttonProductBuy.Location = new System.Drawing.Point(423, 328);
            this.buttonProductBuy.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonProductBuy.Name = "buttonProductBuy";
            this.buttonProductBuy.Size = new System.Drawing.Size(82, 32);
            this.buttonProductBuy.TabIndex = 21;
            this.buttonProductBuy.Text = "购买";
            this.buttonProductBuy.UseVisualStyleBackColor = true;
            this.buttonProductBuy.Click += new System.EventHandler(this.buttonProductBuy_Click);
            // 
            // labelProductHaveNumber
            // 
            this.labelProductHaveNumber.Font = new System.Drawing.Font("SimSun", 12F);
            this.labelProductHaveNumber.Location = new System.Drawing.Point(72, 266);
            this.labelProductHaveNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProductHaveNumber.Name = "labelProductHaveNumber";
            this.labelProductHaveNumber.Size = new System.Drawing.Size(75, 16);
            this.labelProductHaveNumber.TabIndex = 23;
            this.labelProductHaveNumber.Text = "0";
            this.labelProductHaveNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelProductHaveMoney
            // 
            this.labelProductHaveMoney.Font = new System.Drawing.Font("SimSun", 12F);
            this.labelProductHaveMoney.Location = new System.Drawing.Point(72, 326);
            this.labelProductHaveMoney.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProductHaveMoney.Name = "labelProductHaveMoney";
            this.labelProductHaveMoney.Size = new System.Drawing.Size(75, 16);
            this.labelProductHaveMoney.TabIndex = 24;
            this.labelProductHaveMoney.Text = "0";
            this.labelProductHaveMoney.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("SimSun", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(151, 331);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 11);
            this.label10.TabIndex = 26;
            this.label10.Text = "人民币/百份";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("SimSun", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(381, 331);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 11);
            this.label6.TabIndex = 27;
            this.label6.Text = "人民币";
            // 
            // lable7
            // 
            this.lable7.AutoSize = true;
            this.lable7.Font = new System.Drawing.Font("SimSun", 12F);
            this.lable7.Location = new System.Drawing.Point(8, 296);
            this.lable7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lable7.Name = "lable7";
            this.lable7.Size = new System.Drawing.Size(72, 16);
            this.lable7.TabIndex = 28;
            this.lable7.Text = "单  价：";
            // 
            // productcoast
            // 
            this.productcoast.Font = new System.Drawing.Font("SimSun", 12F);
            this.productcoast.Location = new System.Drawing.Point(72, 294);
            this.productcoast.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.productcoast.Name = "productcoast";
            this.productcoast.Size = new System.Drawing.Size(75, 16);
            this.productcoast.TabIndex = 29;
            this.productcoast.Text = "0";
            this.productcoast.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("SimSun", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(151, 301);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 11);
            this.label11.TabIndex = 30;
            this.label11.Text = "人民币/百份";
            // 
            // dgvProductStatus
            // 
            this.dgvProductStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductStatus.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgvProductStatus.Location = new System.Drawing.Point(32, 121);
            this.dgvProductStatus.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvProductStatus.Name = "dgvProductStatus";
            this.dgvProductStatus.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProductStatus.RowHeadersVisible = false;
            this.dgvProductStatus.RowTemplate.Height = 27;
            this.dgvProductStatus.Size = new System.Drawing.Size(212, 122);
            this.dgvProductStatus.TabIndex = 31;
            // 
            // labelACCOUNT
            // 
            this.labelACCOUNT.AutoSize = true;
            this.labelACCOUNT.Font = new System.Drawing.Font("SimSun", 12F);
            this.labelACCOUNT.Location = new System.Drawing.Point(40, 30);
            this.labelACCOUNT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelACCOUNT.Name = "labelACCOUNT";
            this.labelACCOUNT.Size = new System.Drawing.Size(64, 16);
            this.labelACCOUNT.TabIndex = 32;
            this.labelACCOUNT.Text = "ACCOUNT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(379, 287);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 16);
            this.label7.TabIndex = 33;
            this.label7.Text = "百份";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(297, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(277, 122);
            this.dataGridView1.TabIndex = 34;
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 390);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelACCOUNT);
            this.Controls.Add(this.dgvProductStatus);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.productcoast);
            this.Controls.Add(this.lable7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.labelProductHaveMoney);
            this.Controls.Add(this.labelProductHaveNumber);
            this.Controls.Add(this.buttonProductBuy);
            this.Controls.Add(this.labelProductBuyMoney);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxProductNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonProductOil);
            this.Controls.Add(this.buttonProductDollars);
            this.Controls.Add(this.buttonProductSilver);
            this.Controls.Add(this.buttonProductGold);
            this.Controls.Add(this.comboBoxProduct);
            this.Controls.Add(this.labelProductAccount);
            this.Controls.Add(this.ProductTitle);
            this.Controls.Add(this.buttonProductBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Product";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "理财外汇";
            this.Load += new System.EventHandler(this.Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonProductBack;
        private System.Windows.Forms.Label ProductTitle;
        private System.Windows.Forms.Label labelProductAccount;
        private System.Windows.Forms.ComboBox comboBoxProduct;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private System.Windows.Forms.Button buttonProductGold;
        private System.Windows.Forms.Button buttonProductSilver;
        private System.Windows.Forms.Button buttonProductDollars;
        private System.Windows.Forms.Button buttonProductOil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxProductNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelProductBuyMoney;
        private System.Windows.Forms.Button buttonProductBuy;
        private System.Windows.Forms.Label labelProductHaveNumber;
        private System.Windows.Forms.Label labelProductHaveMoney;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lable7;
        private System.Windows.Forms.Label productcoast;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvProductStatus;
        private System.Windows.Forms.Label labelACCOUNT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}