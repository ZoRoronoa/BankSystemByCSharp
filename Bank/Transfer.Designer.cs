namespace BankSystem
{
    partial class Transfer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transfer));
            this.buttonTransferBack = new System.Windows.Forms.Button();
            this.textBoxTransferMoney = new System.Windows.Forms.TextBox();
            this.comboBoxTransferOut = new System.Windows.Forms.ComboBox();
            this.dgvTransferOperation = new System.Windows.Forms.DataGridView();
            this.dgvTransferStatus = new System.Windows.Forms.DataGridView();
            this.buttonTransferTransfer = new System.Windows.Forms.Button();
            this.TransferMoney = new System.Windows.Forms.Label();
            this.TransferTitle = new System.Windows.Forms.Label();
            this.TransferAccount = new System.Windows.Forms.Label();
            this.labelCardbe = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransferOperation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransferStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonTransferBack
            // 
            this.buttonTransferBack.Font = new System.Drawing.Font("宋体", 12F);
            this.buttonTransferBack.Location = new System.Drawing.Point(697, 401);
            this.buttonTransferBack.Name = "buttonTransferBack";
            this.buttonTransferBack.Size = new System.Drawing.Size(91, 37);
            this.buttonTransferBack.TabIndex = 3;
            this.buttonTransferBack.Text = "返回";
            this.buttonTransferBack.UseVisualStyleBackColor = true;
            this.buttonTransferBack.Click += new System.EventHandler(this.buttonTransferBack_Click);
            // 
            // textBoxTransferMoney
            // 
            this.textBoxTransferMoney.Font = new System.Drawing.Font("宋体", 12F);
            this.textBoxTransferMoney.Location = new System.Drawing.Point(561, 100);
            this.textBoxTransferMoney.Name = "textBoxTransferMoney";
            this.textBoxTransferMoney.Size = new System.Drawing.Size(148, 30);
            this.textBoxTransferMoney.TabIndex = 28;
            // 
            // comboBoxTransferOut
            // 
            this.comboBoxTransferOut.Font = new System.Drawing.Font("宋体", 12F);
            this.comboBoxTransferOut.FormattingEnabled = true;
            this.comboBoxTransferOut.Location = new System.Drawing.Point(199, 97);
            this.comboBoxTransferOut.Name = "comboBoxTransferOut";
            this.comboBoxTransferOut.Size = new System.Drawing.Size(196, 28);
            this.comboBoxTransferOut.TabIndex = 27;
            // 
            // dgvTransferOperation
            // 
            this.dgvTransferOperation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransferOperation.GridColor = System.Drawing.Color.Chartreuse;
            this.dgvTransferOperation.Location = new System.Drawing.Point(450, 214);
            this.dgvTransferOperation.Name = "dgvTransferOperation";
            this.dgvTransferOperation.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTransferOperation.RowHeadersVisible = false;
            this.dgvTransferOperation.RowTemplate.Height = 27;
            this.dgvTransferOperation.Size = new System.Drawing.Size(310, 165);
            this.dgvTransferOperation.TabIndex = 26;
            // 
            // dgvTransferStatus
            // 
            this.dgvTransferStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransferStatus.GridColor = System.Drawing.Color.Coral;
            this.dgvTransferStatus.Location = new System.Drawing.Point(67, 214);
            this.dgvTransferStatus.Name = "dgvTransferStatus";
            this.dgvTransferStatus.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTransferStatus.RowHeadersVisible = false;
            this.dgvTransferStatus.RowTemplate.Height = 27;
            this.dgvTransferStatus.Size = new System.Drawing.Size(269, 165);
            this.dgvTransferStatus.TabIndex = 25;
            // 
            // buttonTransferTransfer
            // 
            this.buttonTransferTransfer.Font = new System.Drawing.Font("宋体", 12F);
            this.buttonTransferTransfer.Location = new System.Drawing.Point(602, 148);
            this.buttonTransferTransfer.Name = "buttonTransferTransfer";
            this.buttonTransferTransfer.Size = new System.Drawing.Size(107, 37);
            this.buttonTransferTransfer.TabIndex = 24;
            this.buttonTransferTransfer.Text = "转入";
            this.buttonTransferTransfer.UseVisualStyleBackColor = true;
            this.buttonTransferTransfer.Click += new System.EventHandler(this.buttonTransferTransfer_Click);
            // 
            // TransferMoney
            // 
            this.TransferMoney.AutoSize = true;
            this.TransferMoney.Font = new System.Drawing.Font("宋体", 12F);
            this.TransferMoney.Location = new System.Drawing.Point(446, 104);
            this.TransferMoney.Name = "TransferMoney";
            this.TransferMoney.Size = new System.Drawing.Size(109, 20);
            this.TransferMoney.TabIndex = 23;
            this.TransferMoney.Text = "转账金额：";
            // 
            // TransferTitle
            // 
            this.TransferTitle.AutoSize = true;
            this.TransferTitle.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TransferTitle.Location = new System.Drawing.Point(62, 36);
            this.TransferTitle.Name = "TransferTitle";
            this.TransferTitle.Size = new System.Drawing.Size(68, 28);
            this.TransferTitle.TabIndex = 22;
            this.TransferTitle.Text = "转账";
            // 
            // TransferAccount
            // 
            this.TransferAccount.AutoSize = true;
            this.TransferAccount.Font = new System.Drawing.Font("宋体", 12F);
            this.TransferAccount.Location = new System.Drawing.Point(140, 100);
            this.TransferAccount.Name = "TransferAccount";
            this.TransferAccount.Size = new System.Drawing.Size(69, 20);
            this.TransferAccount.TabIndex = 21;
            this.TransferAccount.Text = "卡号：";
            // 
            // labelCardbe
            // 
            this.labelCardbe.AutoSize = true;
            this.labelCardbe.Font = new System.Drawing.Font("宋体", 12F);
            this.labelCardbe.Location = new System.Drawing.Point(100, 156);
            this.labelCardbe.Name = "labelCardbe";
            this.labelCardbe.Size = new System.Drawing.Size(109, 20);
            this.labelCardbe.TabIndex = 29;
            this.labelCardbe.Text = "转入卡号：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(199, 157);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(196, 25);
            this.textBox1.TabIndex = 31;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            // Transfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelCardbe);
            this.Controls.Add(this.textBoxTransferMoney);
            this.Controls.Add(this.comboBoxTransferOut);
            this.Controls.Add(this.dgvTransferOperation);
            this.Controls.Add(this.dgvTransferStatus);
            this.Controls.Add(this.buttonTransferTransfer);
            this.Controls.Add(this.TransferMoney);
            this.Controls.Add(this.TransferTitle);
            this.Controls.Add(this.TransferAccount);
            this.Controls.Add(this.buttonTransferBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Transfer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "转账";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransferOperation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransferStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonTransferBack;
        private System.Windows.Forms.TextBox textBoxTransferMoney;
        private System.Windows.Forms.ComboBox comboBoxTransferOut;
        private System.Windows.Forms.DataGridView dgvTransferOperation;
        private System.Windows.Forms.DataGridView dgvTransferStatus;
        private System.Windows.Forms.Button buttonTransferTransfer;
        private System.Windows.Forms.Label TransferMoney;
        private System.Windows.Forms.Label TransferTitle;
        private System.Windows.Forms.Label TransferAccount;
        private System.Windows.Forms.Label labelCardbe;
        private System.Windows.Forms.TextBox textBox1;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}