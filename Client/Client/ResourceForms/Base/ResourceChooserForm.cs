using Client.Models;
using Client.ProcessObjects;
using Client.ViewModel;
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
    public partial class ResourceChooserForm : Form
    {
        public ResourceBase ResultObject { get; set; }
        public ProcessObject ProcessObject { get; set; }
        private Type ResourceType { get; set; }
        private Type ResourceViewType { get; set; }

        public ResourceChooserForm(Type dateType, ProcessObject processObject)
        {
            InitializeComponent();
            ProcessObject = processObject;
            ResourceType = dateType;
            if (ResourceType == typeof(Actor))
                ResourceViewType = typeof(ActorViewModel);
            else if (ResourceType == typeof(Director))
                ResourceViewType = typeof(DirectorViewModel);
            else
                ResourceViewType = ResourceType;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetResource(tbName.Text).Select(p => Convert.ChangeType(p, ResourceViewType)).ToList();
        }

        private List<ResourceBase> GetResource(string name)
        {
            if (ResourceType == typeof(Actor))
            {
                return ProcessObject.PeopleClient.GetActorsByName(name).Select(p => new ActorViewModel(p)).Select(p => (ResourceBase)p).ToList();
            }
            else if (ResourceType == typeof(Director))
            {
                return ProcessObject.PeopleClient.GetDirectorsByName(name).Select(p => new DirectorViewModel(p)).Select(p => (ResourceBase)p).ToList();
            }
            else
                return null;
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
                ResultObject = (ResourceBase)dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].DataBoundItem;
            else
                ResultObject = null;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResultObject = null;
            this.Close();
        }
    }
}
