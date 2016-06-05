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
    public partial class ActorForm : BaseForm
    {
        Actor InputActor { get; set; }
        ProcessObject ProcessObject { get; set; }
        public Actor ResultObject { get; set; }
        FormType FormType { get; set; }

        public ActorForm(Actor actor, FormType formType, ProcessObject processObject)
        {
            InitializeComponent();
            InputActor = actor;
            ProcessObject = ProcessObject;
            FormType = formType;
            FillForm();
        }

        private void FillForm()
        {
            tbBirthPlace.Text = InputActor.PlaceOfBirth;
            tbDateBirth.Text = InputActor.DateOfBirth;
            tbHeight.Text = InputActor.Height.ToString();
            tbName.Text = InputActor.Name;
            tbSurname.Text = InputActor.RealName;
            chBAlive.Checked = InputActor.Alive;
            cbGender.DataSource = Genders();
            cbMStatus.DataSource = MaritalStatuses();
            lbActorName.Text = InputActor.ToString();
            Text = (FormType == FormType.ADD ? "Add actor" : (FormType == FormType.EDIT ? "Edit actor" : "Info"));
            if (InputActor.Gender != null)
                cbGender.SelectedItem = InputActor.Gender;
            else
                cbGender.SelectedIndex = -1;

            if (InputActor.MaritalStatus != null)
                cbMStatus.SelectedItem = InputActor.MaritalStatus;
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

            lbActorName.Location = new Point((this.Size.Width / 2) - (lbActorName.Size.Width / 2), lbActorName.Location.Y);
            lbActorName.Refresh();
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
