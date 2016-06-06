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
    public partial class DirectorForm : BaseForm
    {
        Director InputDirector { get; set; }
        ProcessObject ProcessObject { get; set; }
        public Actor ResultObject { get; set; }
        FormType FormType { get; set; }

        public DirectorForm(Director director, FormType formType, ProcessObject processObject)
        {
            InitializeComponent();
            InputDirector = director;
            this.ProcessObject = processObject;
            FormType = formType;
            FillForm();
        }

        private void FillForm()
        {
            tbBirthPlace.Text = InputDirector.PlaceOfBirth;
            tbDateBirth.Text = InputDirector.DateOfBirth;
            tbHeight.Text = InputDirector.Height.ToString();
            tbName.Text = InputDirector.Name;
            tbSurname.Text = InputDirector.RealName;
            chBAlive.Checked = InputDirector.Alive;
            cbGender.DataSource = Genders();
            cbMStatus.DataSource = MaritalStatuses();
            lbDirectorName.Text = InputDirector.ToString();
            Text = (FormType == FormType.ADD ? "Add director" : (FormType == FormType.EDIT ? "Edit director" : "Info"));
            if (InputDirector.Gender != null)
                cbGender.SelectedItem = InputDirector.Gender;
            else
                cbGender.SelectedIndex = -1;

            if (InputDirector.MaritalStatus != null)
                cbMStatus.SelectedItem = InputDirector.MaritalStatus;
            else
                cbMStatus.SelectedIndex = -1;

            if (FormType == FormType.INFO)
            {
                tbBirthPlace.ReadOnly = true;
                tbDateBirth.ReadOnly = true;
                tbHeight.ReadOnly = true;
                tbName.ReadOnly = true;
                tbSurname.ReadOnly = true;
                chBAlive.Enabled = false;
                cbGender.Enabled = false;
                cbMStatus.Enabled = false;
                base.btnCommit_ChangeVisibility(false);
                base.btnCancel_ChangeImage(Properties.Resources.Actions_dialog_ok_apply_icon);
                base.btnCancel_ChangeName("Ok");
            }

            lbDirectorName.Location = new Point((this.Size.Width / 2) - (lbDirectorName.Size.Width / 2), lbDirectorName.Location.Y);
            lbDirectorName.Refresh();
        }
        
        public override void CommitClick()
        {
            InputDirector.PlaceOfBirth = tbBirthPlace.Text;
            InputDirector.DateOfBirth = tbDateBirth.Text;
            int height;
            if (Int32.TryParse(tbHeight.Text, out height))
                InputDirector.Height = height;
            InputDirector.Name = tbName.Text;
            InputDirector.RealName = tbSurname.Text;
            InputDirector.Alive = chBAlive.Checked;
            InputDirector.Gender = cbGender.SelectedItem.ToString();
            InputDirector.MaritalStatus = cbMStatus.SelectedItem.ToString();

            if (FormType == FormType.ADD)
                ProcessObject.PeopleClient.AddDirector(InputDirector);
            else if (FormType == FormType.EDIT)
                ProcessObject.PeopleClient.UpdateDirector(InputDirector);

            base.CommitClick();
        }

        private string[] Genders()
        {
            return new string[] { "Man", "Woman" };
        }

        private string[] MaritalStatuses()
        {
            return new string[] { "Single", "Married", "Widow/Widower" };
        }
    }
}
