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

namespace Client.HelpingForm
{
    public partial class ChooseFilterForm : Form
    {
        public GridDataFilter ResultFilter { get; set; }

        public ChooseFilterForm(FilterDataType dataType)
        {
            InitializeComponent();

            cbFilters.DataSource = GridDataFilter.GetAll(dataType);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbValue.Text))
                return;

            ResultFilter = (GridDataFilter)cbFilters.SelectedItem;

            if(ResultFilter !=null)
                ResultFilter.Value = tbValue.Text;

            this.Close();
        }
    }
}
