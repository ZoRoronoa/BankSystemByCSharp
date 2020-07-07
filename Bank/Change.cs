using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BankSystem
{
    public partial class Change : Form
    {

        private Users anotherFormU;
        private AdminAccount anotherFormA;
        public string CurUserName;
        bool flag=false;
        public Change(string anotherName)
        {
            InitializeComponent();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//mp10.ssk";
            this.CurUserName = anotherName;
            labelChangeAccount.Text = this.CurUserName;
            ShowMessage();
            if (anotherName == "admin")
            {
                flag = true;
            }

        }

        private void buttonChangeBack_Click(object sender, EventArgs e)
        {
            if (flag == false)
            {
                anotherFormU = new Users(CurUserName);

                anotherFormU.Show();//ShowDialog();
                this.Hide();                   //Application.ExitThread();
            }
            else
            {
                anotherFormA = new AdminAccount();
                anotherFormA.Show();//ShowDialog();
                this.Hide();                   //Application.ExitThread();
            }
        }

        private void buttonChangeChange_Click(object sender, EventArgs e)
        {
            string this_user_psw = textBoxChangePassword.Text;
            if(this_user_psw.Length == 0) { MessageBox.Show("请输入密码！"); return; }
            try
            {
                int flag1 = User.Update(CurUserName, this_user_psw, 1);//false改密码
                if (flag1 == 0)
                {
                    MessageBox.Show("密码修改成功！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void buttonChangeChangePH_Click(object sender, EventArgs e)
        {
            string this_user_phone_number = textBoxChangePhoneNumber.Text;
            if (this_user_phone_number.Length != 11)
            {
                MessageBox.Show("手机号码不合法，请重新输入！");
                return;
            }
            try
            {
                int flag1 = User.Update(CurUserName, this_user_phone_number, 2);//false改密码
                if (flag1 == 0)
                {
                    MessageBox.Show("手机号码修改成功！");
                    ShowMessage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        void ShowMessage()
        {
            MySqlConnection dbon = new MySqlConnection(Bank.ConnectStr);
            try
            {
                dbon.Open();
                string text = "select * from custom where name = '" + CurUserName + "';";

                MySqlCommand cmd_login = new MySqlCommand(text, dbon);
                MySqlDataReader dr;
                dr = cmd_login.ExecuteReader();
                while (dr.Read())
                {
                    this.labelChangeAccount.Text = dr["name"].ToString();
                    //this.labelApplyAccount.Text = "testtesteststestest";
                    this.labelChangeIdentity.Text = dr["id_card"].ToString();
                    this.labelChangePhone.Text = dr["phone_number"].ToString();
                    this.labelChangeSex.Text = dr["gender"].ToString();
                    //{ CurUserName = user_name; CurUser = new User(dr["name"].ToString(), dr["id_card"].ToString(), dr["psw"].ToString(), dr["gender"].ToString(), dr["phone_number"].ToString()); }

                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                dbon.Close();
            }

        }

        private void Change_Load(object sender, EventArgs e)
        {

        }
    }
}
