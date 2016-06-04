using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.ResourceForms.Base
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        public virtual void CommitClick()
        {
            this.Close();
        }

        public virtual void CancelClick(){
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CommitClick();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CancelClick();
        }
    }

    public enum FormType
    {
        EDIT,
        ADD,
        INFO
    }
}
