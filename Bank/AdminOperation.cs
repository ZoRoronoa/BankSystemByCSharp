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
    public partial class AdminOperation : Form
    {
        private login anotherFormL;
        private AdminCard anotherFormC;
       // private AdminOperation anotherFormO;
        private AdminAccount anotherFormA;
        public AdminOperation()
        {
            InitializeComponent();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//EmeraldColor2.ssk";
        }

        private void buttonApplyBack_Click(object sender, EventArgs e)
        {
            anotherFormL = new login();
            this.Close();
            anotherFormL.Show();//ShowDialog();
                                //Application.ExitThread()
        }

        private void buttonAdminOperationAccount_Click(object sender, EventArgs e)
        {
            anotherFormA = new AdminAccount();
            this.Close();
            anotherFormA.Show();//ShowDialog();
                                //Application.ExitThread()
        }

        private void buttonAdminOperationCard_Click(object sender, EventArgs e)
        {
            anotherFormC = new AdminCard();
            this.Close();
            anotherFormC.Show();//ShowDialog();
                                //Application.ExitThread()
        }

        private void buttonAdminOperationOperation_Click(object sender, EventArgs e)
        {

        }
    }
}
