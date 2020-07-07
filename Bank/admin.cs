using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace BankSystem
{
    class Admin:User
    {
        public static String connetStr = Bank.ConnectStr;
        private int uid = 123;
        private string pwd = "123admin";

        public void query(string item)//查询语句，输入参数为查询对象,user,bankcard,log
        {
            MySqlConnection dbon = new MySqlConnection(connetStr);
            dbon.Open();
            string updateDB = "select * from '" + item + "';";
            MySqlCommand cmd = new MySqlCommand(updateDB, dbon);
            cmd.ExecuteNonQuery();
            dbon.Close();
        }

        public void exam(string stat,int uid)//审核银行卡
        {
            MySqlConnection dbon = new MySqlConnection(connetStr);
            dbon.Open();
            string updateDB = "UPDATE bankcard SET BST" + stat + "WHERE UID ="+ uid +";";
            MySqlCommand cmd = new MySqlCommand(updateDB, dbon);
            cmd.ExecuteNonQuery();
            dbon.Close();
        }

        public void logupdate(int uid, string opr, string dat)//更新日志。
        {
            MySqlConnection dbon = new MySqlConnection(connetStr);
            dbon.Open();
            string updateDB = "INSERT INSERT INTO log VALUE(" + uid + ",'" + opr + "','" + dat + "');";
            MySqlCommand cmd = new MySqlCommand(updateDB, dbon);
            cmd.ExecuteNonQuery();
            dbon.Close();
        }
    }
}
