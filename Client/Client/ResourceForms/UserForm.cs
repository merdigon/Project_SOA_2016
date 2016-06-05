using Client.Models;
using Client.ProcessObjects;
using Client.ResourceForms.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.ResourceForms
{
    public partial class UserForm : BaseForm
    {
        User InputUser { get; set; }
        ProcessObject ProcessObject { get; set; }
        public User ResultObject { get; set; }
        FormType FormType { get; set; }

        public UserForm(User user, FormType formType, ProcessObject processObject)
        {
            InitializeComponent();
            InputUser = user;
            ProcessObject = ProcessObject;
            FormType = formType;
            FillForm();
        }

        private void FillForm()
        {
            btnSave.Location = new Point(287, 241);
            btnCancel.Location = new Point(376,241);

            tbEmail.Text = InputUser.Email;
            tbCity.Text = InputUser.City;
            tbName.Text = InputUser.Name;
            tbNick.Text = InputUser.Nick;
            tbPassword.Text = InputUser.Password;
            lbUserName.Text = InputUser.ToString();
            Text = (FormType == FormType.ADD ? "Add user" : (FormType == FormType.EDIT ? "Edit user" : "Info"));
            
            if (FormType == FormType.INFO)
            {
                tbEmail.ReadOnly = true;
                tbCity.ReadOnly = true;
                tbName.ReadOnly = true;
                tbNick.ReadOnly = true;
                tbPassword.ReadOnly = true;
                tbPassword.UseSystemPasswordChar = true;
                tbPassword.PasswordChar = '*';
                base.btnCommit_ChangeVisibility(false);
                base.btnCancel_ChangeImage(Properties.Resources.Actions_dialog_ok_apply_icon);
                base.btnCancel_ChangeName("Ok");
            }

            lbUserName.Location = new Point((this.Size.Width / 2) - (lbUserName.Size.Width / 2), lbUserName.Location.Y);
            lbUserName.Refresh();
        }
    }
}
