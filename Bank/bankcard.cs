using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
namespace BankSystem
{
    class Bankcard
    {
        private string cName;//持卡人姓名
        private int cid;//持卡人用户id
        private int cNum;//卡账户

        private string cPwd;//卡密码

        private double cMoney;//卡余额

        private int idCard;//身份证号

        private string state;
        //属性

        public int cID
        {
            get { return cid; }
            set { cid = value; }
        }

        public int IdCard

        {

            get { return idCard; }

            set { idCard = value; }

        }

        public double CardMoney

        {

            get { return cMoney; }

            set { cMoney = value; }

        }

        public string CardPwd

        {

            get { return cPwd; }

            set { cPwd = value; }

        }

        public int CardNumber

        {

            get { return cNum; }

            set { cNum = value; }

        }

        public string CardName

        {

            get { return cName; }

            set { cName = value; }

        }

        public string State
        {
            get { return state; }
            set { state = value; }
        }

        //返回银行卡余额
        //1. 正常：返回balance的string版
        //2. 空值， 即该银行卡不存在， 返回字符串 "NULL"
        //3. 
        public static string GetBalance(string card_id)
        {
            MySqlConnection dbon = new MySqlConnection(Bank.ConnectStr);
            string res = "";
            try
            {
                dbon.Open();
                string text = "select * from account where account_id = '" + card_id + "';";
                MySqlCommand cmd_login = new MySqlCommand(text, dbon);
                MySqlDataReader dr;
                dr = cmd_login.ExecuteReader();
                bool null_flag = true;
                while (dr.Read())
                {
                    null_flag = false;
                    res = dr["balance"].ToString();

                }
                dr.Close();
                //用户不存在！
                if (null_flag) res = "NULL";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally { dbon.Close(); }
            return res;
        }

    }
}

