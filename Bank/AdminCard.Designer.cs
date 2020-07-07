namespace BankSystem
{
    partial class AdminCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminCard));
            this.adminTitle = new System.Windows.Forms.Label();
            this.dgvAdminCard = new System.Windows.Forms.DataGridView();
            this.buttonAdminCardOperation = new System.Windows.Forms.Button();
            this.buttonAdminCardCard = new System.Windows.Forms.Button();
            this.buttonAdminCardAccount = new System.Windows.Forms.Button();
            this.buttonApplyBack = new System.Windows.Forms.Button();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminCard)).BeginInit();
            this.SuspendLayout();
            // 
            // adminTitle
            // 
            this.adminTitle.AutoSize = true;
            this.adminTitle.Font = new System.Drawing.Font("宋体", 15F);
            this.adminTitle.Location = new System.Drawing.Point(40, 34);
            this.adminTitle.Name = "adminTitle";
            this.adminTitle.Size = new System.Drawing.Size(137, 25);
            this.adminTitle.TabIndex = 9;
            this.adminTitle.Text = "管理员后台";
            // 
            // dgvAdminCard
            // 
            this.dgvAdminCard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdminCard.Location = new System.Drawing.Point(109, 175);
            this.dgvAdminCard.Name = "dgvAdminCard";
            this.dgvAdminCard.RowTemplate.Height = 27;
            this.dgvAdminCard.Size = new System.Drawing.Size(533, 186);
            this.dgvAdminCard.TabIndex = 8;
            // 
            // buttonAdminCardOperation
            // 
            this.buttonAdminCardOperation.Font = new System.Drawing.Font("宋体", 12F);
            this.buttonAdminCardOperation.Location = new System.Drawing.Point(553, 98);
            this.buttonAdminCardOperation.Name = "buttonAdminCardOperation";
            this.buttonAdminCardOperation.Size = new System.Drawing.Size(158, 34);
            this.buttonAdminCardOperation.TabIndex = 7;
            this.buttonAdminCardOperation.Text = "操作信息";
            this.buttonAdminCardOperation.UseVisualStyleBackColor = true;
            this.buttonAdminCardOperation.Click += new System.EventHandler(this.buttonAdminCardOperation_Click);
            // 
            // buttonAdminCardCard
            // 
            this.buttonAdminCardCard.Font = new System.Drawing.Font("宋体", 12F);
            this.buttonAdminCardCard.Location = new System.Drawing.Point(333, 98);
            this.buttonAdminCardCard.Name = "buttonAdminCardCard";
            this.buttonAdminCardCard.Size = new System.Drawing.Size(157, 34);
            this.buttonAdminCardCard.TabIndex = 6;
            this.buttonAdminCardCard.Text = "银行卡信息";
            this.buttonAdminCardCard.UseVisualStyleBackColor = true;
            this.buttonAdminCardCard.Click += new System.EventHandler(this.buttonAdminCardCard_Click);
            // 
            // buttonAdminCardAccount
            // 
            this.buttonAdminCardAccount.Font = new System.Drawing.Font("宋体", 12F);
            this.buttonAdminCardAccount.Location = new System.Drawing.Point(122, 98);
            this.buttonAdminCardAccount.Name = "buttonAdminCardAccount";
            this.buttonAdminCardAccount.Size = new System.Drawing.Size(144, 34);
            this.buttonAdminCardAccount.TabIndex = 5;
            this.buttonAdminCardAccount.Text = "用户信息";
            this.buttonAdminCardAccount.UseVisualStyleBackColor = true;
            this.buttonAdminCardAccount.Click += new System.EventHandler(this.buttonAdminCardAccount_Click);
            // 
            // buttonApplyBack
            // 
            this.buttonApplyBack.Font = new System.Drawing.Font("宋体", 12F);
            this.buttonApplyBack.Location = new System.Drawing.Point(685, 392);
            this.buttonApplyBack.Name = "buttonApplyBack";
            this.buttonApplyBack.Size = new System.Drawing.Size(91, 37);
            this.buttonApplyBack.TabIndex = 10;
            this.buttonApplyBack.Text = "返回";
            this.buttonApplyBack.UseVisualStyleBackColor = true;
            this.buttonApplyBack.Click += new System.EventHandler(this.buttonApplyBack_Click);
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
            // AdminCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonApplyBack);
            this.Controls.Add(this.adminTitle);
            this.Controls.Add(this.dgvAdminCard);
            this.Controls.Add(this.buttonAdminCardOperation);
            this.Controls.Add(this.buttonAdminCardCard);
            this.Controls.Add(this.buttonAdminCardAccount);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "管理员-银行卡信息";
            this.Load += new System.EventHandler(this.AdminCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminCard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label adminTitle;
        private System.Windows.Forms.DataGridView dgvAdminCard;
        private System.Windows.Forms.Button buttonAdminCardOperation;
        private System.Windows.Forms.Button buttonAdminCardCard;
        private System.Windows.Forms.Button buttonAdminCardAccount;
        private System.Windows.Forms.Button buttonApplyBack;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}