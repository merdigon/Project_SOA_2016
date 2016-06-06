using Client.Models;
using Client.ProcessObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.HelpingForm
{
    public partial class LogInForm : Form
    {
        ProcessObject processObject;

        public LogInForm()
        {
            InitializeComponent();
            processObject = new ProcessObject();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            User user = processObject.UserClient.CheckUserNameAndPassword(tbUsername.Text, tbPassword.Text);

            if (user == null)
            {
                lbWarning.Text = "Wrong username or password!";
                return;
            }
            else
            {
                processObject.LoggedUser = user;
                using (Main main = new Main(processObject))
                {
                    this.Visible = false;
                    main.ShowDialog();
                    this.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
