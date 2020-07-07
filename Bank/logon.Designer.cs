namespace BankSystem
{
    partial class logon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(logon));
            this.LogonName = new System.Windows.Forms.Label();
            this.LogonPassword = new System.Windows.Forms.Label();
            this.LogonIdentity = new System.Windows.Forms.Label();
            this.LogonPhoneNumber = new System.Windows.Forms.Label();
            this.LogonSex = new System.Windows.Forms.Label();
            this.textBoxLogonName = new System.Windows.Forms.TextBox();
            this.textBoxLogonPhoneNumber = new System.Windows.Forms.TextBox();
            this.textBoxLogonIdentity = new System.Windows.Forms.TextBox();
            this.textBoxLogonPassword = new System.Windows.Forms.TextBox();
            this.buttonLogonOver = new System.Windows.Forms.Button();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            this.buttonLogonBack = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LogonName
            // 
            this.LogonName.AutoSize = true;
            this.LogonName.Font = new System.Drawing.Font("宋体", 12F);
            this.LogonName.Location = new System.Drawing.Point(230, 81);
            this.LogonName.Name = "LogonName";
            this.LogonName.Size = new System.Drawing.Size(69, 20);
            this.LogonName.TabIndex = 0;
            this.LogonName.Text = "用户名";
            // 
            // LogonPassword
            // 
            this.LogonPassword.AutoSize = true;
            this.LogonPassword.Font = new System.Drawing.Font("宋体", 12F);
            this.LogonPassword.Location = new System.Drawing.Point(250, 121);
            this.LogonPassword.Name = "LogonPassword";
            this.LogonPassword.Size = new System.Drawing.Size(49, 20);
            this.LogonPassword.TabIndex = 1;
            this.LogonPassword.Text = "密码";
            // 
            // LogonIdentity
            // 
            this.LogonIdentity.AutoSize = true;
            this.LogonIdentity.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LogonIdentity.Location = new System.Drawing.Point(190, 165);
            this.LogonIdentity.Name = "LogonIdentity";
            this.LogonIdentity.Size = new System.Drawing.Size(109, 20);
            this.LogonIdentity.TabIndex = 2;
            this.LogonIdentity.Text = "身份证号码";
            // 
            // LogonPhoneNumber
            // 
            this.LogonPhoneNumber.AutoSize = true;
            this.LogonPhoneNumber.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LogonPhoneNumber.Location = new System.Drawing.Point(210, 205);
            this.LogonPhoneNumber.Name = "LogonPhoneNumber";
            this.LogonPhoneNumber.Size = new System.Drawing.Size(89, 20);
            this.LogonPhoneNumber.TabIndex = 3;
            this.LogonPhoneNumber.Text = "手机号码";
            // 
            // LogonSex
            // 
            this.LogonSex.AutoSize = true;
            this.LogonSex.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LogonSex.Location = new System.Drawing.Point(250, 244);
            this.LogonSex.Name = "LogonSex";
            this.LogonSex.Size = new System.Drawing.Size(49, 20);
            this.LogonSex.TabIndex = 4;
            this.LogonSex.Text = "性别";
            // 
            // textBoxLogonName
            // 
            this.textBoxLogonName.Location = new System.Drawing.Point(326, 81);
            this.textBoxLogonName.MaxLength = 15;
            this.textBoxLogonName.Name = "textBoxLogonName";
            this.textBoxLogonName.Size = new System.Drawing.Size(250, 25);
            this.textBoxLogonName.TabIndex = 6;
            this.textBoxLogonName.TextChanged += new System.EventHandler(this.textBoxLogonName_TextChanged);
            // 
            // textBoxLogonPhoneNumber
            // 
            this.textBoxLogonPhoneNumber.Location = new System.Drawing.Point(326, 205);
            this.textBoxLogonPhoneNumber.Name = "textBoxLogonPhoneNumber";
            this.textBoxLogonPhoneNumber.Size = new System.Drawing.Size(250, 25);
            this.textBoxLogonPhoneNumber.TabIndex = 7;
            // 
            // textBoxLogonIdentity
            // 
            this.textBoxLogonIdentity.Location = new System.Drawing.Point(326, 165);
            this.textBoxLogonIdentity.Name = "textBoxLogonIdentity";
            this.textBoxLogonIdentity.Size = new System.Drawing.Size(250, 25);
            this.textBoxLogonIdentity.TabIndex = 8;
            // 
            // textBoxLogonPassword
            // 
            this.textBoxLogonPassword.Location = new System.Drawing.Point(326, 122);
            this.textBoxLogonPassword.MaxLength = 25;
            this.textBoxLogonPassword.Name = "textBoxLogonPassword";
            this.textBoxLogonPassword.PasswordChar = '*';
            this.textBoxLogonPassword.Size = new System.Drawing.Size(250, 25);
            this.textBoxLogonPassword.TabIndex = 9;
            // 
            // buttonLogonOver
            // 
            this.buttonLogonOver.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonLogonOver.Location = new System.Drawing.Point(342, 311);
            this.buttonLogonOver.Name = "buttonLogonOver";
            this.buttonLogonOver.Size = new System.Drawing.Size(204, 46);
            this.buttonLogonOver.TabIndex = 11;
            this.buttonLogonOver.Text = "确认注册";
            this.buttonLogonOver.UseVisualStyleBackColor = true;
            this.buttonLogonOver.Click += new System.EventHandler(this.buttonLogonOver_Click);
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
            // buttonLogonBack
            // 
            this.buttonLogonBack.Font = new System.Drawing.Font("宋体", 12F);
            this.buttonLogonBack.Location = new System.Drawing.Point(682, 385);
            this.buttonLogonBack.Name = "buttonLogonBack";
            this.buttonLogonBack.Size = new System.Drawing.Size(91, 37);
            this.buttonLogonBack.TabIndex = 12;
            this.buttonLogonBack.Text = "返回";
            this.buttonLogonBack.UseVisualStyleBackColor = true;
            this.buttonLogonBack.Click += new System.EventHandler(this.buttonLogonBack_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.comboBox1.Items.AddRange(new object[] {
            "男",
            "女"});
            this.comboBox1.Location = new System.Drawing.Point(326, 245);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(250, 23);
            this.comboBox1.TabIndex = 13;
            // 
            // logon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonLogonBack);
            this.Controls.Add(this.buttonLogonOver);
            this.Controls.Add(this.textBoxLogonPassword);
            this.Controls.Add(this.textBoxLogonIdentity);
            this.Controls.Add(this.textBoxLogonPhoneNumber);
            this.Controls.Add(this.textBoxLogonName);
            this.Controls.Add(this.LogonSex);
            this.Controls.Add(this.LogonPhoneNumber);
            this.Controls.Add(this.LogonIdentity);
            this.Controls.Add(this.LogonPassword);
            this.Controls.Add(this.LogonName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "logon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "注册";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LogonName;
        private System.Windows.Forms.Label LogonPassword;
        private System.Windows.Forms.Label LogonIdentity;
        private System.Windows.Forms.Label LogonPhoneNumber;
        private System.Windows.Forms.Label LogonSex;
        private System.Windows.Forms.TextBox textBoxLogonName;
        private System.Windows.Forms.TextBox textBoxLogonPhoneNumber;
        private System.Windows.Forms.TextBox textBoxLogonIdentity;
        private System.Windows.Forms.TextBox textBoxLogonPassword;
        private System.Windows.Forms.Button buttonLogonOver;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private System.Windows.Forms.Button buttonLogonBack;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}