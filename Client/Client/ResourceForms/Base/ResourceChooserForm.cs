using Client.Models;
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
        private Type ResourceType { get; set; }

        public ResourceChooserForm(Type dateType)
        {
            InitializeComponent();
            ResourceType = dateType;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetResource(tbName.Text).Select(p => Convert.ChangeType(p, ResourceType)).ToList();
        }

        private List<ResourceBase> GetResource(string name)
        {
            return new List<Actor>(){ new Actor() { Id = 1, Name ="Johny", Surname="Deep" }, 
                new Actor(){ Id = 2, Name="Morgan", Surname="Freeman"}}.Select(p => (ResourceBase)p).ToList();
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
