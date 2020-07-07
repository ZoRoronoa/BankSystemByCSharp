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
    public partial class Transfer : Form
    {
        private Users anotherForm;
        public string CurUserName;
        //public Bank CurBank;
        public Transfer(string anotherName)
        {
            InitializeComponent();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//mp10mulberry.ssk";
            //this.CurBank = anotherBank;
            this.CurUserName = anotherName;
            ShowSelectedCard();
            ShowCardInfo();
            ShowOperations();
        }

        private void buttonTransferBack_Click(object sender, EventArgs e)
        {
            anotherForm = new Users(CurUserName);
            this.Close();
            anotherForm.Show();//ShowDialog();
                               //Application.ExitThread();
        }

        private void buttonTransferTransfer_Click(object sender, EventArgs e)
        {
            string card_from = this.comboBoxTransferOut.SelectedItem.ToString();
            if (card_from.Length == 0) { MessageBox.Show("请选择卡号！"); return; }
            string card_from_balance = Bankcard.GetBalance(card_from);
            string money = this.textBoxTransferMoney.Text;
            //输入金额格式非法
            if (!User.IsMoney(money)) { MessageBox.Show("请注意金额格式!"); this.textBoxTransferMoney.Text = ""; return; }
            decimal money_number = Convert.ToDecimal(money);
            //余额不足
            if (Convert.ToDecimal(card_from_balance) < money_number) { MessageBox.Show("余额不足！"); return; }
            string card_to = this.textBox1.Text;
            //目的卡片不存在
            if (Bankcard.GetBalance(card_to) == "NULL") { MessageBox.Show("目的卡号不存在，请检查并重试！"); return; }
            //一般情况
            try
            {
                int flag = User.Transfer(CurUserName, card_from, card_to, money_number);
                if (flag == 0)
                {
                    MessageBox.Show("转账成功！");
                }
            }
            //其他非法情况
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            ShowCardInfo();
            ShowOperations();
        }

        public void ShowSelectedCard()
        {
            MySqlConnection dbon = new MySqlConnection(Bank.ConnectStr);
            try
            {
                dbon.Open();
                string text = "select account_id from account where name = '" + CurUserName + "';";
                //MySqlCommand cmd = new MySqlCommand(text, dbon);
                MySqlCommand cmd = new MySqlCommand(text, dbon);
                MySqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    //if (dr["psw"].ToString() == user_psw) { CurUserName = user_name; CurUser = new User(dr["name"].ToString(), dr["id_card"].ToString(), dr["psw"].ToString(), dr["gender"].ToString(), dr["phone_number"].ToString()); }
                    //else res = 2;
                    this.comboBoxTransferOut.Items.Add(dr[0].ToString());
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
            if(this.comboBoxTransferOut.Items.Count > 0)
            {
                this.comboBoxTransferOut.SelectedIndex = 0;
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //用户名下银行卡渲染；
        public void ShowCardInfo()
        {
            MySqlConnection dbon = new MySqlConnection(Bank.ConnectStr);
            try
            {
                dbon.Open();
                string text = "select account_id as '卡号', balance as '余额' from account where name = '" + CurUserName + "';";
                //MySqlCommand cmd = new MySqlCommand(text, dbon);
                MySqlDataAdapter da = new MySqlDataAdapter(text, dbon);
                DataTable tmp = new DataTable();
                da.Fill(tmp);
                //this.dgvUsersStatus.DataSource = tmp;
                //this.dgvSaveStatus.DataSource = tmp;
                this.dgvTransferStatus.DataSource = tmp;
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
        //用户最近操作渲染, 待进行操作，包括列表数量的限制等
        public void ShowOperations()
        {
            MySqlConnection dbon = new MySqlConnection(Bank.ConnectStr);
            try
            {
                dbon.Open();
                string text = "select account_id as '卡号', transtime as '操作时间', transtype as '操作类型', transmoney as '金额' from transinfo where name = '" + CurUserName + "';";
                //MySqlCommand cmd = new MySqlCommand(text, dbon);
                MySqlDataAdapter da = new MySqlDataAdapter(text, dbon);
                DataTable tmp = new DataTable();
                da.Fill(tmp);
                this.dgvTransferOperation.DataSource = tmp;
               
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
    }
}
