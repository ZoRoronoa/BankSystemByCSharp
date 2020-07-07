namespace BankSystem
{
    partial class Take
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Take));
            this.buttonTakeBack = new System.Windows.Forms.Button();
            this.textBoxTakeMoney = new System.Windows.Forms.TextBox();
            this.comboBoxTake = new System.Windows.Forms.ComboBox();
            this.dgvTakeOperation = new System.Windows.Forms.DataGridView();
            this.dgvTakeStatus = new System.Windows.Forms.DataGridView();
            this.buttonTakeTake = new System.Windows.Forms.Button();
            this.TakeMoney = new System.Windows.Forms.Label();
            this.TakeAccount = new System.Windows.Forms.Label();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTakeOperation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTakeStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonTakeBack
            // 
            this.buttonTakeBack.Font = new System.Drawing.Font("宋体", 12F);
            this.buttonTakeBack.Location = new System.Drawing.Point(697, 401);
            this.buttonTakeBack.Name = "buttonTakeBack";
            this.buttonTakeBack.Size = new System.Drawing.Size(91, 37);
            this.buttonTakeBack.TabIndex = 2;
            this.buttonTakeBack.Text = "返回";
            this.buttonTakeBack.UseVisualStyleBackColor = true;
            this.buttonTakeBack.Click += new System.EventHandler(this.buttonTakeBack_Click);
            // 
            // textBoxTakeMoney
            // 
            this.textBoxTakeMoney.Font = new System.Drawing.Font("宋体", 12F);
            this.textBoxTakeMoney.Location = new System.Drawing.Point(552, 89);
            this.textBoxTakeMoney.Name = "textBoxTakeMoney";
            this.textBoxTakeMoney.Size = new System.Drawing.Size(148, 30);
            this.textBoxTakeMoney.TabIndex = 20;
            // 
            // comboBoxTake
            // 
            this.comboBoxTake.Font = new System.Drawing.Font("宋体", 12F);
            this.comboBoxTake.FormattingEnabled = true;
            this.comboBoxTake.Location = new System.Drawing.Point(190, 86);
            this.comboBoxTake.Name = "comboBoxTake";
            this.comboBoxTake.Size = new System.Drawing.Size(196, 28);
            this.comboBoxTake.TabIndex = 19;
            // 
            // dgvTakeOperation
            // 
            this.dgvTakeOperation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTakeOperation.GridColor = System.Drawing.Color.Teal;
            this.dgvTakeOperation.Location = new System.Drawing.Point(441, 203);
            this.dgvTakeOperation.Name = "dgvTakeOperation";
            this.dgvTakeOperation.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTakeOperation.RowHeadersVisible = false;
            this.dgvTakeOperation.RowTemplate.Height = 27;
            this.dgvTakeOperation.Size = new System.Drawing.Size(310, 165);
            this.dgvTakeOperation.TabIndex = 18;
            // 
            // dgvTakeStatus
            // 
            this.dgvTakeStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTakeStatus.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgvTakeStatus.Location = new System.Drawing.Point(58, 203);
            this.dgvTakeStatus.Name = "dgvTakeStatus";
            this.dgvTakeStatus.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTakeStatus.RowHeadersVisible = false;
            this.dgvTakeStatus.RowTemplate.Height = 27;
            this.dgvTakeStatus.Size = new System.Drawing.Size(268, 165);
            this.dgvTakeStatus.TabIndex = 17;
            // 
            // buttonTakeTake
            // 
            this.buttonTakeTake.Font = new System.Drawing.Font("宋体", 12F);
            this.buttonTakeTake.Location = new System.Drawing.Point(593, 137);
            this.buttonTakeTake.Name = "buttonTakeTake";
            this.buttonTakeTake.Size = new System.Drawing.Size(107, 37);
            this.buttonTakeTake.TabIndex = 16;
            this.buttonTakeTake.Text = "取出";
            this.buttonTakeTake.UseVisualStyleBackColor = true;
            this.buttonTakeTake.Click += new System.EventHandler(this.buttonTakeTake_Click);
            // 
            // TakeMoney
            // 
            this.TakeMoney.AutoSize = true;
            this.TakeMoney.Font = new System.Drawing.Font("宋体", 12F);
            this.TakeMoney.Location = new System.Drawing.Point(437, 93);
            this.TakeMoney.Name = "TakeMoney";
            this.TakeMoney.Size = new System.Drawing.Size(109, 20);
            this.TakeMoney.TabIndex = 15;
            this.TakeMoney.Text = "取款金额：";
            // 
            // TakeAccount
            // 
            this.TakeAccount.AutoSize = true;
            this.TakeAccount.Font = new System.Drawing.Font("宋体", 12F);
            this.TakeAccount.Location = new System.Drawing.Point(131, 89);
            this.TakeAccount.Name = "TakeAccount";
            this.TakeAccount.Size = new System.Drawing.Size(69, 20);
            this.TakeAccount.TabIndex = 13;
            this.TakeAccount.Text = "卡号：";
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
            // Take
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxTakeMoney);
            this.Controls.Add(this.comboBoxTake);
            this.Controls.Add(this.dgvTakeOperation);
            this.Controls.Add(this.dgvTakeStatus);
            this.Controls.Add(this.buttonTakeTake);
            this.Controls.Add(this.TakeMoney);
            this.Controls.Add(this.TakeAccount);
            this.Controls.Add(this.buttonTakeBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Take";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "取钱";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTakeOperation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTakeStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonTakeBack;
        private System.Windows.Forms.TextBox textBoxTakeMoney;
        private System.Windows.Forms.ComboBox comboBoxTake;
        private System.Windows.Forms.DataGridView dgvTakeOperation;
        private System.Windows.Forms.DataGridView dgvTakeStatus;
        private System.Windows.Forms.Button buttonTakeTake;
        private System.Windows.Forms.Label TakeMoney;
        private System.Windows.Forms.Label TakeAccount;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}