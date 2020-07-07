namespace BankSystem
{
    partial class Save
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Save));
            this.buttonSaveBack = new System.Windows.Forms.Button();
            this.SaveAccount = new System.Windows.Forms.Label();
            this.SaveTitle = new System.Windows.Forms.Label();
            this.SaveMoney = new System.Windows.Forms.Label();
            this.buttonSaveSave = new System.Windows.Forms.Button();
            this.dgvSaveStatus = new System.Windows.Forms.DataGridView();
            this.dgvSaveOperation = new System.Windows.Forms.DataGridView();
            this.comboBoxSave = new System.Windows.Forms.ComboBox();
            this.textBoxSaveMoney = new System.Windows.Forms.TextBox();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaveStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaveOperation)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSaveBack
            // 
            this.buttonSaveBack.Font = new System.Drawing.Font("宋体", 12F);
            this.buttonSaveBack.Location = new System.Drawing.Point(697, 401);
            this.buttonSaveBack.Name = "buttonSaveBack";
            this.buttonSaveBack.Size = new System.Drawing.Size(91, 37);
            this.buttonSaveBack.TabIndex = 2;
            this.buttonSaveBack.Text = "返回";
            this.buttonSaveBack.UseVisualStyleBackColor = true;
            this.buttonSaveBack.Click += new System.EventHandler(this.buttonSaveBack_Click);
            // 
            // SaveAccount
            // 
            this.SaveAccount.AutoSize = true;
            this.SaveAccount.Font = new System.Drawing.Font("宋体", 12F);
            this.SaveAccount.Location = new System.Drawing.Point(116, 92);
            this.SaveAccount.Name = "SaveAccount";
            this.SaveAccount.Size = new System.Drawing.Size(69, 20);
            this.SaveAccount.TabIndex = 3;
            this.SaveAccount.Text = "卡号：";
            // 
            // SaveTitle
            // 
            this.SaveTitle.AutoSize = true;
            this.SaveTitle.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SaveTitle.Location = new System.Drawing.Point(38, 28);
            this.SaveTitle.Name = "SaveTitle";
            this.SaveTitle.Size = new System.Drawing.Size(68, 28);
            this.SaveTitle.TabIndex = 5;
            this.SaveTitle.Text = "存钱";
            // 
            // SaveMoney
            // 
            this.SaveMoney.AutoSize = true;
            this.SaveMoney.Font = new System.Drawing.Font("宋体", 12F);
            this.SaveMoney.Location = new System.Drawing.Point(422, 96);
            this.SaveMoney.Name = "SaveMoney";
            this.SaveMoney.Size = new System.Drawing.Size(109, 20);
            this.SaveMoney.TabIndex = 6;
            this.SaveMoney.Text = "存款金额：";
            // 
            // buttonSaveSave
            // 
            this.buttonSaveSave.Font = new System.Drawing.Font("宋体", 12F);
            this.buttonSaveSave.Location = new System.Drawing.Point(578, 140);
            this.buttonSaveSave.Name = "buttonSaveSave";
            this.buttonSaveSave.Size = new System.Drawing.Size(107, 37);
            this.buttonSaveSave.TabIndex = 8;
            this.buttonSaveSave.Text = "存入";
            this.buttonSaveSave.UseVisualStyleBackColor = true;
            this.buttonSaveSave.Click += new System.EventHandler(this.buttonSaveSave_Click);
            // 
            // dgvSaveStatus
            // 
            this.dgvSaveStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaveStatus.GridColor = System.Drawing.Color.Yellow;
            this.dgvSaveStatus.Location = new System.Drawing.Point(43, 206);
            this.dgvSaveStatus.Name = "dgvSaveStatus";
            this.dgvSaveStatus.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSaveStatus.RowHeadersVisible = false;
            this.dgvSaveStatus.RowTemplate.Height = 27;
            this.dgvSaveStatus.Size = new System.Drawing.Size(271, 165);
            this.dgvSaveStatus.TabIndex = 9;
            // 
            // dgvSaveOperation
            // 
            this.dgvSaveOperation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaveOperation.GridColor = System.Drawing.Color.Blue;
            this.dgvSaveOperation.Location = new System.Drawing.Point(426, 206);
            this.dgvSaveOperation.Name = "dgvSaveOperation";
            this.dgvSaveOperation.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSaveOperation.RowHeadersVisible = false;
            this.dgvSaveOperation.RowTemplate.Height = 27;
            this.dgvSaveOperation.Size = new System.Drawing.Size(310, 165);
            this.dgvSaveOperation.TabIndex = 10;
            this.dgvSaveOperation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSaveOperation_CellContentClick);
            // 
            // comboBoxSave
            // 
            this.comboBoxSave.Font = new System.Drawing.Font("宋体", 12F);
            this.comboBoxSave.FormattingEnabled = true;
            this.comboBoxSave.Location = new System.Drawing.Point(175, 89);
            this.comboBoxSave.Name = "comboBoxSave";
            this.comboBoxSave.Size = new System.Drawing.Size(196, 28);
            this.comboBoxSave.TabIndex = 11;
            // 
            // textBoxSaveMoney
            // 
            this.textBoxSaveMoney.Font = new System.Drawing.Font("宋体", 12F);
            this.textBoxSaveMoney.Location = new System.Drawing.Point(537, 92);
            this.textBoxSaveMoney.Name = "textBoxSaveMoney";
            this.textBoxSaveMoney.Size = new System.Drawing.Size(148, 30);
            this.textBoxSaveMoney.TabIndex = 12;
            this.textBoxSaveMoney.TextChanged += new System.EventHandler(this.textBoxSaveMoney_TextChanged);
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
            // Save
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxSaveMoney);
            this.Controls.Add(this.comboBoxSave);
            this.Controls.Add(this.dgvSaveOperation);
            this.Controls.Add(this.dgvSaveStatus);
            this.Controls.Add(this.buttonSaveSave);
            this.Controls.Add(this.SaveMoney);
            this.Controls.Add(this.SaveTitle);
            this.Controls.Add(this.SaveAccount);
            this.Controls.Add(this.buttonSaveBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Save";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "存钱";
            this.Load += new System.EventHandler(this.Save_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaveStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaveOperation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSaveBack;
        private System.Windows.Forms.Label SaveAccount;
        private System.Windows.Forms.Label SaveTitle;
        private System.Windows.Forms.Label SaveMoney;
        private System.Windows.Forms.Button buttonSaveSave;
        private System.Windows.Forms.DataGridView dgvSaveStatus;
        private System.Windows.Forms.DataGridView dgvSaveOperation;
        private System.Windows.Forms.ComboBox comboBoxSave;
        private System.Windows.Forms.TextBox textBoxSaveMoney;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}