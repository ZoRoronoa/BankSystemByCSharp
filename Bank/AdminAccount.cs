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
    public partial class AdminAccount : Form
    {
        private login anotherFormL;
        private AdminCard anotherFormC;
        private AdminOperation anotherFormO;
        private Change anotherFormCh;
       // private login anotherFormL;
        public AdminAccount()
        {
            InitializeComponent();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//Emerald.ssk";
            ShowUser();
        }

        private void buttonApplyBack_Click(object sender, EventArgs e)
        {
            anotherFormL = new login();
            this.Close();
            anotherFormL.Show();//ShowDialog();
                               //Application.ExitThread()
        }

        private void buttonAdminAccountCard_Click(object sender, EventArgs e)
        {
            /*anotherFormC = new AdminCard();
            this.Close();
            anotherFormC.Show();//ShowDialog();
                                //Application.ExitThread()*/
            ShowCard();
        }

        private void buttonAdminAccountAccount_Click(object sender, EventArgs e)
        {
            ShowUser();
        }

        private void buttonAdminAccountOperation_Click(object sender, EventArgs e)
        {
            /*anotherFormO = new AdminOperation();
            this.Close();
            anotherFormO.Show();//ShowDialog();
                                //Application.ExitThread()*/
            ShowOperations();
        }

        //用户信息渲染；
        public void ShowUser()
        {
            MySqlConnection dbon = new MySqlConnection(Bank.ConnectStr);
            try
            {
                dbon.Open();
                //string text = "select account_id, balance, 



                _time, state from account where name = '" + CurBank.CurUser.Name + "';";
                string text = "select name as '用户', id_card as '身份证', gender as '性别', phone_number as '手机号' from custom;";
                //string text = "select name, id_card, gender, phone_number from custom;";
                //MySqlCommand cmd = new MySqlCommand(text, dbon);
                MySqlDataAdapter da = new MySqlDataAdapter(text, dbon);
                DataTable tmp = new DataTable();
                da.Fill(tmp);
                //this.dgvUsersStatus.DataSource = tmp;
                this.dgvAdminAccount.DataSource = tmp;
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

        //最近操作渲染, 待进行操作，包括列表数量的限制等
        public void ShowOperations()
        {
            MySqlConnection dbon = new MySqlConnection(Bank.ConnectStr);
            try
            {
                dbon.Open();
                string text = "select account_id as '卡号', transtime as '交易时间', transtype as '交易类型', transmoney as '交易金额' from transinfo;";
                //MySqlCommand cmd = new MySqlCommand(text, dbon);
                MySqlDataAdapter da = new MySqlDataAdapter(text, dbon);
                DataTable tmp = new DataTable();
                da.Fill(tmp);
                this.dgvAdminAccount.DataSource = tmp;
                //this.dgvSaveOperation.DataSource = tmp;
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

        //银行卡信息渲染
        public void ShowCard()
        {
            MySqlConnection dbon = new MySqlConnection(Bank.ConnectStr);
            try
            {
                dbon.Open();
                
                string text = "select account_id as '卡号', balance as '余额', create_time as '创建时间', name as '用户' from account;";
                //MySqlCommand cmd = new MySqlCommand(text, dbon);
                MySqlDataAdapter da = new MySqlDataAdapter(text, dbon);
                DataTable tmp = new DataTable();
                da.Fill(tmp);
                this.dgvAdminAccount.DataSource = tmp;
                //this.dgvSaveOperation.DataSource = tmp;
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

        private void buttonAdminChange_Click(object sender, EventArgs e)
        {
            anotherFormCh = new Change("admin");
            this.Close();
            anotherFormCh.Show();//ShowDialog();
                                //Application.ExitThread()
        }
    }
}
