namespace BankSystem
{
    partial class AdminOperation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminOperation));
            this.adminTitle = new System.Windows.Forms.Label();
            this.dgvAdminOperation = new System.Windows.Forms.DataGridView();
            this.buttonAdminOperationOperation = new System.Windows.Forms.Button();
            this.buttonAdminOperationCard = new System.Windows.Forms.Button();
            this.buttonAdminOperationAccount = new System.Windows.Forms.Button();
            this.buttonApplyBack = new System.Windows.Forms.Button();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminOperation)).BeginInit();
            this.SuspendLayout();
            // 
            // adminTitle
            // 
            this.adminTitle.AutoSize = true;
            this.adminTitle.Font = new System.Drawing.Font("宋体", 15F);
            this.adminTitle.Location = new System.Drawing.Point(48, 43);
            this.adminTitle.Name = "adminTitle";
            this.adminTitle.Size = new System.Drawing.Size(137, 25);
            this.adminTitle.TabIndex = 14;
            this.adminTitle.Text = "管理员后台";
            // 
            // dgvAdminOperation
            // 
            this.dgvAdminOperation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdminOperation.Location = new System.Drawing.Point(118, 159);
            this.dgvAdminOperation.Name = "dgvAdminOperation";
            this.dgvAdminOperation.RowTemplate.Height = 27;
            this.dgvAdminOperation.Size = new System.Drawing.Size(548, 186);
            this.dgvAdminOperation.TabIndex = 13;
            // 
            // buttonAdminOperationOperation
            // 
            this.buttonAdminOperationOperation.Font = new System.Drawing.Font("宋体", 12F);
            this.buttonAdminOperationOperation.Location = new System.Drawing.Point(548, 94);
            this.buttonAdminOperationOperation.Name = "buttonAdminOperationOperation";
            this.buttonAdminOperationOperation.Size = new System.Drawing.Size(159, 34);
            this.buttonAdminOperationOperation.TabIndex = 12;
            this.buttonAdminOperationOperation.Text = "操作信息";
            this.buttonAdminOperationOperation.UseVisualStyleBackColor = true;
            this.buttonAdminOperationOperation.Click += new System.EventHandler(this.buttonAdminOperationOperation_Click);
            // 
            // buttonAdminOperationCard
            // 
            this.buttonAdminOperationCard.Font = new System.Drawing.Font("宋体", 12F);
            this.buttonAdminOperationCard.Location = new System.Drawing.Point(332, 94);
            this.buttonAdminOperationCard.Name = "buttonAdminOperationCard";
            this.buttonAdminOperationCard.Size = new System.Drawing.Size(159, 34);
            this.buttonAdminOperationCard.TabIndex = 11;
            this.buttonAdminOperationCard.Text = "银行卡信息";
            this.buttonAdminOperationCard.UseVisualStyleBackColor = true;
            this.buttonAdminOperationCard.Click += new System.EventHandler(this.buttonAdminOperationCard_Click);
            // 
            // buttonAdminOperationAccount
            // 
            this.buttonAdminOperationAccount.Font = new System.Drawing.Font("宋体", 12F);
            this.buttonAdminOperationAccount.Location = new System.Drawing.Point(118, 94);
            this.buttonAdminOperationAccount.Name = "buttonAdminOperationAccount";
            this.buttonAdminOperationAccount.Size = new System.Drawing.Size(158, 34);
            this.buttonAdminOperationAccount.TabIndex = 10;
            this.buttonAdminOperationAccount.Text = "用户信息";
            this.buttonAdminOperationAccount.UseVisualStyleBackColor = true;
            this.buttonAdminOperationAccount.Click += new System.EventHandler(this.buttonAdminOperationAccount_Click);
            // 
            // buttonApplyBack
            // 
            this.buttonApplyBack.Font = new System.Drawing.Font("宋体", 12F);
            this.buttonApplyBack.Location = new System.Drawing.Point(680, 392);
            this.buttonApplyBack.Name = "buttonApplyBack";
            this.buttonApplyBack.Size = new System.Drawing.Size(91, 37);
            this.buttonApplyBack.TabIndex = 15;
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
            // AdminOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonApplyBack);
            this.Controls.Add(this.adminTitle);
            this.Controls.Add(this.dgvAdminOperation);
            this.Controls.Add(this.buttonAdminOperationOperation);
            this.Controls.Add(this.buttonAdminOperationCard);
            this.Controls.Add(this.buttonAdminOperationAccount);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminOperation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "管理员-操作信息";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminOperation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label adminTitle;
        private System.Windows.Forms.DataGridView dgvAdminOperation;
        private System.Windows.Forms.Button buttonAdminOperationOperation;
        private System.Windows.Forms.Button buttonAdminOperationCard;
        private System.Windows.Forms.Button buttonAdminOperationAccount;
        private System.Windows.Forms.Button buttonApplyBack;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}