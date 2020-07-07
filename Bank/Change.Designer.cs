namespace BankSystem
{
    partial class Change
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Change));
            this.textBoxChangePhoneNumber = new System.Windows.Forms.TextBox();
            this.LogonPhoneNumber = new System.Windows.Forms.Label();
            this.textBoxChangePassword = new System.Windows.Forms.TextBox();
            this.LogonPassword = new System.Windows.Forms.Label();
            this.buttonChangeBack = new System.Windows.Forms.Button();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            this.buttonChangeChangePa = new System.Windows.Forms.Button();
            this.buttonChangeChangePH = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelChangeAccount = new System.Windows.Forms.Label();
            this.labelChangeSex = new System.Windows.Forms.Label();
            this.labelChangeIdentity = new System.Windows.Forms.Label();
            this.labelChangePhone = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxChangePhoneNumber
            // 
            this.textBoxChangePhoneNumber.Font = new System.Drawing.Font("宋体", 12F);
            this.textBoxChangePhoneNumber.Location = new System.Drawing.Point(455, 227);
            this.textBoxChangePhoneNumber.MaxLength = 11;
            this.textBoxChangePhoneNumber.Name = "textBoxChangePhoneNumber";
            this.textBoxChangePhoneNumber.Size = new System.Drawing.Size(250, 30);
            this.textBoxChangePhoneNumber.TabIndex = 9;
            // 
            // LogonPhoneNumber
            // 
            this.LogonPhoneNumber.AutoSize = true;
            this.LogonPhoneNumber.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LogonPhoneNumber.Location = new System.Drawing.Point(339, 230);
            this.LogonPhoneNumber.Name = "LogonPhoneNumber";
            this.LogonPhoneNumber.Size = new System.Drawing.Size(109, 20);
            this.LogonPhoneNumber.TabIndex = 8;
            this.LogonPhoneNumber.Text = "修改号码：";
            // 
            // textBoxChangePassword
            // 
            this.textBoxChangePassword.Font = new System.Drawing.Font("宋体", 12F);
            this.textBoxChangePassword.Location = new System.Drawing.Point(454, 108);
            this.textBoxChangePassword.MaxLength = 25;
            this.textBoxChangePassword.Name = "textBoxChangePassword";
            this.textBoxChangePassword.PasswordChar = '*';
            this.textBoxChangePassword.Size = new System.Drawing.Size(250, 30);
            this.textBoxChangePassword.TabIndex = 11;
            // 
            // LogonPassword
            // 
            this.LogonPassword.AutoSize = true;
            this.LogonPassword.Font = new System.Drawing.Font("宋体", 12F);
            this.LogonPassword.Location = new System.Drawing.Point(339, 111);
            this.LogonPassword.Name = "LogonPassword";
            this.LogonPassword.Size = new System.Drawing.Size(109, 20);
            this.LogonPassword.TabIndex = 10;
            this.LogonPassword.Text = "修改密码：";
            // 
            // buttonChangeBack
            // 
            this.buttonChangeBack.Font = new System.Drawing.Font("宋体", 12F);
            this.buttonChangeBack.Location = new System.Drawing.Point(682, 389);
            this.buttonChangeBack.Name = "buttonChangeBack";
            this.buttonChangeBack.Size = new System.Drawing.Size(91, 37);
            this.buttonChangeBack.TabIndex = 12;
            this.buttonChangeBack.Text = "返回";
            this.buttonChangeBack.UseVisualStyleBackColor = true;
            this.buttonChangeBack.Click += new System.EventHandler(this.buttonChangeBack_Click);
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
            // buttonChangeChangePa
            // 
            this.buttonChangeChangePa.Font = new System.Drawing.Font("宋体", 12F);
            this.buttonChangeChangePa.Location = new System.Drawing.Point(584, 158);
            this.buttonChangeChangePa.Name = "buttonChangeChangePa";
            this.buttonChangeChangePa.Size = new System.Drawing.Size(120, 37);
            this.buttonChangeChangePa.TabIndex = 13;
            this.buttonChangeChangePa.Text = "确认修改";
            this.buttonChangeChangePa.UseVisualStyleBackColor = true;
            this.buttonChangeChangePa.Click += new System.EventHandler(this.buttonChangeChange_Click);
            // 
            // buttonChangeChangePH
            // 
            this.buttonChangeChangePH.Font = new System.Drawing.Font("宋体", 12F);
            this.buttonChangeChangePH.Location = new System.Drawing.Point(584, 287);
            this.buttonChangeChangePH.Name = "buttonChangeChangePH";
            this.buttonChangeChangePH.Size = new System.Drawing.Size(120, 37);
            this.buttonChangeChangePH.TabIndex = 14;
            this.buttonChangeChangePH.Text = "确认修改";
            this.buttonChangeChangePH.UseVisualStyleBackColor = true;
            this.buttonChangeChangePH.Click += new System.EventHandler(this.buttonChangeChangePH_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(12, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "当前用户:";
            // 
            // labelChangeAccount
            // 
            this.labelChangeAccount.AutoSize = true;
            this.labelChangeAccount.Font = new System.Drawing.Font("宋体", 12F);
            this.labelChangeAccount.Location = new System.Drawing.Point(125, 111);
            this.labelChangeAccount.Name = "labelChangeAccount";
            this.labelChangeAccount.Size = new System.Drawing.Size(189, 20);
            this.labelChangeAccount.TabIndex = 16;
            this.labelChangeAccount.Text = "labelChangeAccount";
            // 
            // labelChangeSex
            // 
            this.labelChangeSex.AutoSize = true;
            this.labelChangeSex.Font = new System.Drawing.Font("宋体", 12F);
            this.labelChangeSex.Location = new System.Drawing.Point(125, 295);
            this.labelChangeSex.Name = "labelChangeSex";
            this.labelChangeSex.Size = new System.Drawing.Size(149, 20);
            this.labelChangeSex.TabIndex = 24;
            this.labelChangeSex.Text = "labelChangeSex";
            // 
            // labelChangeIdentity
            // 
            this.labelChangeIdentity.AutoSize = true;
            this.labelChangeIdentity.Font = new System.Drawing.Font("宋体", 12F);
            this.labelChangeIdentity.Location = new System.Drawing.Point(125, 166);
            this.labelChangeIdentity.Name = "labelChangeIdentity";
            this.labelChangeIdentity.Size = new System.Drawing.Size(199, 20);
            this.labelChangeIdentity.TabIndex = 23;
            this.labelChangeIdentity.Text = "labelChangeIdentity";
            // 
            // labelChangePhone
            // 
            this.labelChangePhone.AutoSize = true;
            this.labelChangePhone.Font = new System.Drawing.Font("宋体", 12F);
            this.labelChangePhone.Location = new System.Drawing.Point(125, 230);
            this.labelChangePhone.Name = "labelChangePhone";
            this.labelChangePhone.Size = new System.Drawing.Size(169, 20);
            this.labelChangePhone.TabIndex = 22;
            this.labelChangePhone.Text = "labelChangePhone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F);
            this.label5.Location = new System.Drawing.Point(52, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "性别:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F);
            this.label4.Location = new System.Drawing.Point(32, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "手机号:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F);
            this.label3.Location = new System.Drawing.Point(12, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "身份证号:";
            // 
            // Change
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelChangeSex);
            this.Controls.Add(this.labelChangeIdentity);
            this.Controls.Add(this.labelChangePhone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelChangeAccount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonChangeChangePH);
            this.Controls.Add(this.buttonChangeChangePa);
            this.Controls.Add(this.buttonChangeBack);
            this.Controls.Add(this.textBoxChangePassword);
            this.Controls.Add(this.LogonPassword);
            this.Controls.Add(this.textBoxChangePhoneNumber);
            this.Controls.Add(this.LogonPhoneNumber);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Change";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改";
            this.Load += new System.EventHandler(this.Change_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxChangePhoneNumber;
        private System.Windows.Forms.Label LogonPhoneNumber;
        private System.Windows.Forms.TextBox textBoxChangePassword;
        private System.Windows.Forms.Label LogonPassword;
        private System.Windows.Forms.Button buttonChangeBack;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private System.Windows.Forms.Button buttonChangeChangePa;
        private System.Windows.Forms.Button buttonChangeChangePH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelChangeAccount;
        private System.Windows.Forms.Label labelChangeSex;
        private System.Windows.Forms.Label labelChangeIdentity;
        private System.Windows.Forms.Label labelChangePhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}