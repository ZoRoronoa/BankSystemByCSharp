namespace BankSystem
{
    partial class Users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users));
            this.UsersAccount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelUsersAccount = new System.Windows.Forms.Label();
            this.dgvUsersStatus = new System.Windows.Forms.DataGridView();
            this.dgvUsersOperation = new System.Windows.Forms.DataGridView();
            this.buttonUsersSave = new System.Windows.Forms.Button();
            this.buttonUsersTake = new System.Windows.Forms.Button();
            this.buttonUsersTransfer = new System.Windows.Forms.Button();
            this.buttonUsersProduct = new System.Windows.Forms.Button();
            this.Userslabel = new System.Windows.Forms.Label();
            this.buttonUsersApply = new System.Windows.Forms.Button();
            this.buttonUsersBack = new System.Windows.Forms.Button();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            this.buttonUsersChange = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersOperation)).BeginInit();
            this.SuspendLayout();
            // 
            // UsersAccount
            // 
            this.UsersAccount.AutoSize = true;
            this.UsersAccount.Font = new System.Drawing.Font("宋体", 12F);
            this.UsersAccount.Location = new System.Drawing.Point(12, 31);
            this.UsersAccount.Name = "UsersAccount";
            this.UsersAccount.Size = new System.Drawing.Size(109, 20);
            this.UsersAccount.TabIndex = 0;
            this.UsersAccount.Text = "当前账户：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 1;
            // 
            // labelUsersAccount
            // 
            this.labelUsersAccount.AutoSize = true;
            this.labelUsersAccount.Font = new System.Drawing.Font("宋体", 12F);
            this.labelUsersAccount.Location = new System.Drawing.Point(127, 32);
            this.labelUsersAccount.Name = "labelUsersAccount";
            this.labelUsersAccount.Size = new System.Drawing.Size(79, 20);
            this.labelUsersAccount.TabIndex = 2;
            this.labelUsersAccount.Text = "account";
            // 
            // dgvUsersStatus
            // 
            this.dgvUsersStatus.BackgroundColor = System.Drawing.Color.Fuchsia;
            this.dgvUsersStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvUsersStatus.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvUsersStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsersStatus.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dgvUsersStatus.Location = new System.Drawing.Point(55, 185);
            this.dgvUsersStatus.Name = "dgvUsersStatus";
            this.dgvUsersStatus.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvUsersStatus.RowHeadersVisible = false;
            this.dgvUsersStatus.RowTemplate.Height = 27;
            this.dgvUsersStatus.Size = new System.Drawing.Size(263, 185);
            this.dgvUsersStatus.TabIndex = 3;
            // 
            // dgvUsersOperation
            // 
            this.dgvUsersOperation.BackgroundColor = System.Drawing.Color.Aqua;
            this.dgvUsersOperation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsersOperation.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvUsersOperation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsersOperation.GridColor = System.Drawing.Color.Red;
            this.dgvUsersOperation.Location = new System.Drawing.Point(398, 185);
            this.dgvUsersOperation.Name = "dgvUsersOperation";
            this.dgvUsersOperation.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvUsersOperation.RowHeadersVisible = false;
            this.dgvUsersOperation.RowTemplate.Height = 27;
            this.dgvUsersOperation.Size = new System.Drawing.Size(307, 185);
            this.dgvUsersOperation.TabIndex = 4;
            // 
            // buttonUsersSave
            // 
            this.buttonUsersSave.Font = new System.Drawing.Font("宋体", 12F);
            this.buttonUsersSave.Location = new System.Drawing.Point(166, 89);
            this.buttonUsersSave.Name = "buttonUsersSave";
            this.buttonUsersSave.Size = new System.Drawing.Size(75, 51);
            this.buttonUsersSave.TabIndex = 5;
            this.buttonUsersSave.Text = "存钱";
            this.buttonUsersSave.UseVisualStyleBackColor = true;
            this.buttonUsersSave.Click += new System.EventHandler(this.buttonUsersSave_Click);
            // 
            // buttonUsersTake
            // 
            this.buttonUsersTake.Font = new System.Drawing.Font("宋体", 12F);
            this.buttonUsersTake.Location = new System.Drawing.Point(268, 89);
            this.buttonUsersTake.Name = "buttonUsersTake";
            this.buttonUsersTake.Size = new System.Drawing.Size(75, 51);
            this.buttonUsersTake.TabIndex = 6;
            this.buttonUsersTake.Text = "取钱";
            this.buttonUsersTake.UseVisualStyleBackColor = true;
            this.buttonUsersTake.Click += new System.EventHandler(this.buttonUsersTake_Click);
            // 
            // buttonUsersTransfer
            // 
            this.buttonUsersTransfer.Font = new System.Drawing.Font("宋体", 12F);
            this.buttonUsersTransfer.Location = new System.Drawing.Point(373, 89);
            this.buttonUsersTransfer.Name = "buttonUsersTransfer";
            this.buttonUsersTransfer.Size = new System.Drawing.Size(75, 51);
            this.buttonUsersTransfer.TabIndex = 7;
            this.buttonUsersTransfer.Text = "转账";
            this.buttonUsersTransfer.UseVisualStyleBackColor = true;
            this.buttonUsersTransfer.Click += new System.EventHandler(this.buttonUsersTransfer_Click);
            // 
            // buttonUsersProduct
            // 
            this.buttonUsersProduct.Font = new System.Drawing.Font("宋体", 12F);
            this.buttonUsersProduct.Location = new System.Drawing.Point(471, 89);
            this.buttonUsersProduct.Name = "buttonUsersProduct";
            this.buttonUsersProduct.Size = new System.Drawing.Size(122, 51);
            this.buttonUsersProduct.TabIndex = 8;
            this.buttonUsersProduct.Text = "理财产品";
            this.buttonUsersProduct.UseVisualStyleBackColor = true;
            this.buttonUsersProduct.Click += new System.EventHandler(this.buttonUsersProduct_Click);
            // 
            // Userslabel
            // 
            this.Userslabel.AutoSize = true;
            this.Userslabel.Font = new System.Drawing.Font("宋体", 12F);
            this.Userslabel.Location = new System.Drawing.Point(12, 104);
            this.Userslabel.Name = "Userslabel";
            this.Userslabel.Size = new System.Drawing.Size(129, 20);
            this.Userslabel.TabIndex = 9;
            this.Userslabel.Text = "请选择操作：";
            // 
            // buttonUsersApply
            // 
            this.buttonUsersApply.Font = new System.Drawing.Font("宋体", 12F);
            this.buttonUsersApply.Location = new System.Drawing.Point(614, 89);
            this.buttonUsersApply.Name = "buttonUsersApply";
            this.buttonUsersApply.Size = new System.Drawing.Size(131, 51);
            this.buttonUsersApply.TabIndex = 10;
            this.buttonUsersApply.Text = "信用卡开户";
            this.buttonUsersApply.UseVisualStyleBackColor = true;
            this.buttonUsersApply.Click += new System.EventHandler(this.buttonUsersApply_Click);
            // 
            // buttonUsersBack
            // 
            this.buttonUsersBack.Font = new System.Drawing.Font("宋体", 12F);
            this.buttonUsersBack.Location = new System.Drawing.Point(630, 399);
            this.buttonUsersBack.Name = "buttonUsersBack";
            this.buttonUsersBack.Size = new System.Drawing.Size(158, 39);
            this.buttonUsersBack.TabIndex = 11;
            this.buttonUsersBack.Text = "返回登录界面";
            this.buttonUsersBack.UseVisualStyleBackColor = true;
            this.buttonUsersBack.Click += new System.EventHandler(this.buttonUsersBack_Click);
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
            // buttonUsersChange
            // 
            this.buttonUsersChange.Font = new System.Drawing.Font("宋体", 12F);
            this.buttonUsersChange.Location = new System.Drawing.Point(55, 399);
            this.buttonUsersChange.Name = "buttonUsersChange";
            this.buttonUsersChange.Size = new System.Drawing.Size(164, 39);
            this.buttonUsersChange.TabIndex = 12;
            this.buttonUsersChange.Text = "修改个人信息";
            this.buttonUsersChange.UseVisualStyleBackColor = true;
            this.buttonUsersChange.Click += new System.EventHandler(this.buttonUsersChange_Click);
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonUsersChange);
            this.Controls.Add(this.buttonUsersBack);
            this.Controls.Add(this.buttonUsersApply);
            this.Controls.Add(this.Userslabel);
            this.Controls.Add(this.buttonUsersProduct);
            this.Controls.Add(this.buttonUsersTransfer);
            this.Controls.Add(this.buttonUsersTake);
            this.Controls.Add(this.buttonUsersSave);
            this.Controls.Add(this.dgvUsersOperation);
            this.Controls.Add(this.dgvUsersStatus);
            this.Controls.Add(this.labelUsersAccount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UsersAccount);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Users";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersOperation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UsersAccount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelUsersAccount;
        private System.Windows.Forms.DataGridView dgvUsersStatus;
        private System.Windows.Forms.DataGridView dgvUsersOperation;
        private System.Windows.Forms.Button buttonUsersSave;
        private System.Windows.Forms.Button buttonUsersTake;
        private System.Windows.Forms.Button buttonUsersTransfer;
        private System.Windows.Forms.Button buttonUsersProduct;
        private System.Windows.Forms.Label Userslabel;
        private System.Windows.Forms.Button buttonUsersApply;
        private System.Windows.Forms.Button buttonUsersBack;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private System.Windows.Forms.Button buttonUsersChange;
    }
}