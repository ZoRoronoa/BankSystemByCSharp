namespace BankSystem
{
    partial class AdminAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminAccount));
            this.buttonAdminAccountAccount = new System.Windows.Forms.Button();
            this.buttonAdminAccountCard = new System.Windows.Forms.Button();
            this.buttonAdminAccountOperation = new System.Windows.Forms.Button();
            this.dgvAdminAccount = new System.Windows.Forms.DataGridView();
            this.adminTitle = new System.Windows.Forms.Label();
            this.buttonApplyBack = new System.Windows.Forms.Button();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            this.buttonAdminChange = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdminAccountAccount
            // 
            this.buttonAdminAccountAccount.Font = new System.Drawing.Font("宋体", 12F);
            this.buttonAdminAccountAccount.Location = new System.Drawing.Point(107, 92);
            this.buttonAdminAccountAccount.Name = "buttonAdminAccountAccount";
            this.buttonAdminAccountAccount.Size = new System.Drawing.Size(160, 34);
            this.buttonAdminAccountAccount.TabIndex = 0;
            this.buttonAdminAccountAccount.Text = "用户信息";
            this.buttonAdminAccountAccount.UseVisualStyleBackColor = true;
            this.buttonAdminAccountAccount.Click += new System.EventHandler(this.buttonAdminAccountAccount_Click);
            // 
            // buttonAdminAccountCard
            // 
            this.buttonAdminAccountCard.Font = new System.Drawing.Font("宋体", 12F);
            this.buttonAdminAccountCard.Location = new System.Drawing.Point(327, 92);
            this.buttonAdminAccountCard.Name = "buttonAdminAccountCard";
            this.buttonAdminAccountCard.Size = new System.Drawing.Size(154, 34);
            this.buttonAdminAccountCard.TabIndex = 1;
            this.buttonAdminAccountCard.Text = "银行卡信息";
            this.buttonAdminAccountCard.UseVisualStyleBackColor = true;
            this.buttonAdminAccountCard.Click += new System.EventHandler(this.buttonAdminAccountCard_Click);
            // 
            // buttonAdminAccountOperation
            // 
            this.buttonAdminAccountOperation.Font = new System.Drawing.Font("宋体", 12F);
            this.buttonAdminAccountOperation.Location = new System.Drawing.Point(549, 92);
            this.buttonAdminAccountOperation.Name = "buttonAdminAccountOperation";
            this.buttonAdminAccountOperation.Size = new System.Drawing.Size(147, 34);
            this.buttonAdminAccountOperation.TabIndex = 2;
            this.buttonAdminAccountOperation.Text = "操作信息";
            this.buttonAdminAccountOperation.UseVisualStyleBackColor = true;
            this.buttonAdminAccountOperation.Click += new System.EventHandler(this.buttonAdminAccountOperation_Click);
            // 
            // dgvAdminAccount
            // 
            this.dgvAdminAccount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvAdminAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdminAccount.GridColor = System.Drawing.Color.Cyan;
            this.dgvAdminAccount.Location = new System.Drawing.Point(107, 169);
            this.dgvAdminAccount.Name = "dgvAdminAccount";
            this.dgvAdminAccount.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAdminAccount.RowHeadersVisible = false;
            this.dgvAdminAccount.RowTemplate.Height = 27;
            this.dgvAdminAccount.Size = new System.Drawing.Size(550, 186);
            this.dgvAdminAccount.TabIndex = 3;
            // 
            // adminTitle
            // 
            this.adminTitle.AutoSize = true;
            this.adminTitle.Font = new System.Drawing.Font("宋体", 15F);
            this.adminTitle.Location = new System.Drawing.Point(25, 28);
            this.adminTitle.Name = "adminTitle";
            this.adminTitle.Size = new System.Drawing.Size(137, 25);
            this.adminTitle.TabIndex = 4;
            this.adminTitle.Text = "管理员后台";
            // 
            // buttonApplyBack
            // 
            this.buttonApplyBack.Font = new System.Drawing.Font("宋体", 12F);
            this.buttonApplyBack.Location = new System.Drawing.Point(676, 392);
            this.buttonApplyBack.Name = "buttonApplyBack";
            this.buttonApplyBack.Size = new System.Drawing.Size(91, 37);
            this.buttonApplyBack.TabIndex = 5;
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
            // buttonAdminChange
            // 
            this.buttonAdminChange.Font = new System.Drawing.Font("宋体", 12F);
            this.buttonAdminChange.Location = new System.Drawing.Point(103, 392);
            this.buttonAdminChange.Name = "buttonAdminChange";
            this.buttonAdminChange.Size = new System.Drawing.Size(164, 39);
            this.buttonAdminChange.TabIndex = 13;
            this.buttonAdminChange.Text = "修改管理员信息";
            this.buttonAdminChange.UseVisualStyleBackColor = true;
            this.buttonAdminChange.Click += new System.EventHandler(this.buttonAdminChange_Click);
            // 
            // AdminAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAdminChange);
            this.Controls.Add(this.buttonApplyBack);
            this.Controls.Add(this.adminTitle);
            this.Controls.Add(this.dgvAdminAccount);
            this.Controls.Add(this.buttonAdminAccountOperation);
            this.Controls.Add(this.buttonAdminAccountCard);
            this.Controls.Add(this.buttonAdminAccountAccount);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "管理员-账户信息";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdminAccount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdminAccountAccount;
        private System.Windows.Forms.Button buttonAdminAccountCard;
        private System.Windows.Forms.Button buttonAdminAccountOperation;
        private System.Windows.Forms.DataGridView dgvAdminAccount;
        private System.Windows.Forms.Label adminTitle;
        private System.Windows.Forms.Button buttonApplyBack;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private System.Windows.Forms.Button buttonAdminChange;
    }
}