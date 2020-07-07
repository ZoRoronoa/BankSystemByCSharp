using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BankSystem
{
    public class User
    {
        public string Name { get; set; }
        private string Id_card { get; set; }
        private string Psw { get; set; }
        private string Gender { get; set; }
        private string Phone_number { get; set; }

        //构造函数
        public User() { }
        public User(string name, string id_card, string psw, string gender, string phone_number)
        {
            Name = name;
            Id_card = id_card;
            Psw = psw;
            Gender = gender;
            Phone_number = phone_number;
        }
        //申请银行卡，涉及数据库操作
        public static bool Register_Card(string user_name, string allocated_card)
        {
            bool flag = true;
            MySqlConnection dbon = new MySqlConnection(Bank.ConnectStr);
            decimal tmp = 10000.00M;
            try
            {
                dbon.Open();
                string text = "insert into account (account_id, balance, name, state ) values ('" + allocated_card + "', " + tmp + ", '" + user_name  +"', '正常');";
                MySqlCommand cmd_insert = new MySqlCommand(text, dbon);
                cmd_insert.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                flag = false;
            }
            finally
            {
                dbon.Close();
            }
            return flag;
        }
        //分配卡号函数
        string RadCardId()
        {
            Random rd = new Random();
            int a = rd.Next(100000000, 1000000000);
            return "622700" + a.ToString();
        }

        //存钱
        public static bool Save(string user_name, string account_id, decimal money)
        {
            bool flag = true;
            MySqlConnection dbon = new MySqlConnection(Bank.ConnectStr);
            try
            {
                dbon.Open();
               // if()
                string text = "update account set balance = balance + " + money + " where account_id = '" + account_id + "';";
                MySqlCommand cmd_save = new MySqlCommand(text, dbon);
                cmd_save.ExecuteNonQuery();
                string text2 = "insert into transinfo(account_id, transtype, transmoney, name) values ('" + account_id + "', '存钱', " + money + ", '" + user_name + "');";
                cmd_save = new MySqlCommand(text2, dbon);
                cmd_save.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                flag = false;
            }
            finally
            {
                dbon.Close();
            }
            return flag;
        }

        //取钱
        public static int WithDraw(string user_name, string account_id, decimal money)
        {
            int res = 0;
            MySqlConnection dbon = new MySqlConnection(Bank.ConnectStr);
            try
            {
                dbon.Open();
                string text = "update account set balance = balance - " + money + " where account_id = '" + account_id + "';";
                MySqlCommand cmd_withdraw = new MySqlCommand(text, dbon);
                cmd_withdraw.ExecuteNonQuery();
                string text2 = "insert into transinfo(account_id, transtype, transmoney, name) values ('" + account_id + "', '取钱', " + money + ", '" + user_name + "');";
                cmd_withdraw = new MySqlCommand(text2, dbon);
                cmd_withdraw.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                dbon.Close();
            }
            return res;
        }
        
        //转账
        public static int Transfer(string user_name, string card_from, string card_to, decimal money)
        {
            int res = 0;
            MySqlConnection dbon = new MySqlConnection(Bank.ConnectStr);
            try
            {
                dbon.Open();
                string text = "update account set balance = balance - " + money + " where account_id = '" + card_from + "';";
                MySqlCommand cmd_transfer = new MySqlCommand(text, dbon);
                cmd_transfer.ExecuteNonQuery();
                string text2 = "insert into transinfo(account_id, transtype, transmoney, name) values ('" + card_from + "', '转出', " + money + ",'" + user_name + "');";
                cmd_transfer = new MySqlCommand(text2, dbon);
                cmd_transfer.ExecuteNonQuery();
                string text3 = "update account set balance = balance + " + money + " where account_id = '" + card_to + "';";
                cmd_transfer = new MySqlCommand(text3, dbon);
                cmd_transfer.ExecuteNonQuery();
                string text4 = "insert into transinfo(account_id, transtype, transmoney, name) values ('" + card_to + "', '转入', " + money + ",'" + user_name + "');";
                cmd_transfer = new MySqlCommand(text4, dbon);
                cmd_transfer.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                dbon.Close();
            }
            return res;
        }

        //判断金额格式是否标准
        public static bool IsMoney(string input)
        {
            string pattern = @"^([1-9]\d{0,9}|0)(\.\d{1,2})?$";
            //^ ([1 - 9]\d{ 0,9}| 0)([.] ?| (\.\d{ 1,2})?)$
            //^[1-9]([0-9]+)?(\.[0-9]{1,2})?$)|(^(0){1}$)|(^[0-9]\.[0-9]([0-9])?$
            //@"^([1-9]\d{0,9}|0)(\.\d{1,2})?$"
            return System.Text.RegularExpressions.Regex.IsMatch(input, pattern, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
        }

        //修改用户信息
        public static int Update(string user_name, string change_string, int flag)
        {
            int res = 0;
            MySqlConnection dbon = new MySqlConnection(Bank.ConnectStr);
            try
            {
                dbon.Open();
                MySqlCommand cmd_withdraw;//= new MySqlCommand(text, dbon);
                if (flag == 1)// 改密码
                {
                    string text = "update custom set psw =  '" + change_string + "' where name = '" + user_name + "';";
                    cmd_withdraw = new MySqlCommand(text, dbon);
                    cmd_withdraw.ExecuteNonQuery();
                }
                else if (flag == 2)// 改手机
                {
                    string text2 = "update custom set phone_number = " + change_string + " where name = '" + user_name + "';";
                    cmd_withdraw = new MySqlCommand(text2, dbon);
                    cmd_withdraw.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                dbon.Close();
            }
            return res;
        }

       




        /*
        private int u_id;//用户账号

        public int u_id0//用户账号，创建时使用
        {
            get { return u_id; }
            set { u_id = value; }
        }

        private string u_pwd;//用户密码

        public string u_pwd0//用户密码，开户时使用
        {
            get { return u_pwd; }
            set { u_pwd = value; }
        }

        private string u_Nm;//用户姓名

        public string U_NM
        {
            get { return u_Nm; }
            set { u_Nm = value; }
        }
       

        private int idCard;//用户身份证号

        public int IDCard
        {
            get { return idCard; }
            set { idCard = value; }
        }

        private string u_sex;//用户性别

        public string u_Sex
        {
            get { return u_sex; }
            set { u_sex = value; }
        }


        private int u_PN;//用户手机号

        public int U_PN
        {
            get { return u_PN; }
            set { u_PN = value; }
        }

        private int u_bankcard;//银行卡卡号

        public int u_bankcard0
        {
            get { return u_bankcard; }
            set { u_bankcard = value; }
        }

        private double u_money;
        public double u_Money
        {
            get { return u_money; }
            set { u_money = value; }
        }
        */
    }
}
