using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem
{
    public partial class logon : Form
    {
        private login anotherForm;
        private login anotherFormL;

        public logon()
        {
            //this.comboBox1.SelectedIndex = 0;
            this.SuspendLayout();
            //this.SuspendLayout();
            InitializeComponent();
            //anotherForm = new login();
            //this.panel1.SuspendLayout();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//mp10green.ssk";
            this.ResumeLayout(false);
            this.PerformLayout();
            if(this.comboBox1.Items.Count > 0)
            {
                this.comboBox1.SelectedIndex = 0;
            }
        }

        private void buttonLogonOver_Click(object sender, EventArgs e)
        {
            string this_user_name = this.textBoxLogonName.Text;
            string this_user_psw = this.textBoxLogonPassword.Text;
            string this_user_id_card = this.textBoxLogonIdentity.Text;
            string this_user_phone_number = this.textBoxLogonPhoneNumber.Text;
            //string this_user_gender = this.textBoxLogonSex.Text;
            string this_user_gender = this.comboBox1.SelectedItem.ToString();
            if (this_user_name == "" || this_user_psw == "" || this_user_gender == "")
            {
                MessageBox.Show("请完善信息！");
                return;
            }
            if (!is_right(this_user_id_card))
            {
                MessageBox.Show("身份证不合法，请检查并重新输入！");
                return;
            }
            if (this_user_phone_number.Length != 11)
            {
                MessageBox.Show("手机号码不合法，请重新输入！");
                return;
            }

            try
            {
                int res = Bank.Register(this_user_name, this_user_psw, this_user_id_card, this_user_phone_number, this_user_gender);
                if (res == 1) MessageBox.Show("账户已经存在，请重试！");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            anotherForm = new login();
            anotherForm.Show();//ShowDialog();
            this.Close();      //Application.ExitThread();
        }

        private void textBoxLogonName_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonLogonBack_Click(object sender, EventArgs e)
        {
            anotherFormL = new login();
            this.Close();
            anotherFormL.Show();//ShowDialog();
                                //Application.ExitThread()
        }


        //身份证检验
        public bool is_right(string id)
        {
            if (id.Length != 18) return false;
            int res = 0;
            res += (id[0] - '0') * 7;
            res += (id[1] - '0') * 9;
            res += (id[2] - '0') * 10;
            res += (id[3] - '0') * 5;
            res += (id[4] - '0') * 8;
            res += (id[5] - '0') * 4;
            res += (id[6] - '0') * 2;
            res += (id[7] - '0') * 1;
            res += (id[8] - '0') * 6;
            res += (id[9] - '0') * 3;
            res += (id[10] - '0') * 7;
            res += (id[11] - '0') * 9;
            res += (id[12] - '0') * 10;
            res += (id[13] - '0') * 5;
            res += (id[14] - '0') * 8;
            res += (id[15] - '0') * 4;
            res += (id[16] - '0') * 2;
            if (res % 11 == 2 && id[17] == 'X') return true;
            if (res % 11 == 1 && id[17] == '0') return true;
            if (res % 11 == 3 && id[17] == '9') return true;
            if (res % 11 == 4 && id[17] == '8') return true;
            if (res % 11 == 5 && id[17] == '7') return true;
            if (res % 11 == 6 && id[17] == '6') return true;
            if (res % 11 == 7 && id[17] == '5') return true;
            if (res % 11 == 8 && id[17] == '4') return true;
            if (res % 11 == 9 && id[17] == '3') return true;
            if (res % 11 == 10 && id[17] == '2') return true;
            if (res % 11 == 0 && id[17] == '1') return true;
            //if (res % 11 == 2 && id[17] == 'X') return true;
            return false;
        }
    }
}
