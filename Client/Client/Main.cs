using Client.Models;
using Client.ProcessObjects;
using Client.ResourceForms;
using Client.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Main : Form
    {
        GridViewManager gridManager = new GridViewManager();
        GridDataFilter filterForMainGrid = null;
        List<ResourceBase> downloadedData = null;

        public Main()
        {
            InitializeComponent();
            FillForm();
            gridManager.RefresingMainView = SetFilterAndRefreshGridView;
        }

        public void FillForm()
        {
            toolStripComboBox1.ComboBox.DataSource = new List<SoaResourceModel>()
            {
                new SoaResourceModel() {ShowableName = "Film", DataBindedType = typeof(Movie)},
                new SoaResourceModel() {ShowableName = "Review", DataBindedType = typeof(Review)},
                new SoaResourceModel() {ShowableName = "Actor", DataBindedType = typeof(Actor)},
                new SoaResourceModel() {ShowableName = "Director", DataBindedType = typeof(Director)},
            };

            downloadedData = (new List<Movie>() { new Movie() { Name = "7", ProductionYear = 2001 } }).Select(p => (ResourceBase)p).ToList();
            dataGridView1.DataSource = downloadedData.Select(p => Convert.ChangeType(p, ((SoaResourceModel)toolStripComboBox1.ComboBox.SelectedItem).DataBindedType)).ToList();

            if (filterForMainGrid == null)
            {
                toolStripButton4.Visible = false;
                toolStripLabel3.Visible = false;
                toolStripLabel4.Visible = false;
            }
            else
            {
                toolStripButton4.Visible = true;
                toolStripLabel3.Visible = true;
                toolStripLabel4.Visible = true;
                toolStripLabel4.Text = GetFilterDescription();
            }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            gridManager.ShowCustomMenu(sender, e, (SoaResourceModel)toolStripComboBox1.ComboBox.SelectedItem);
        }

        public void SetFilterAndRefreshGridView(GridDataFilter filter)
        {
            filterForMainGrid = filter;
            RefreshData();
        }

        public void RefreshData()
        {
            Type currentlyBindedType = ((SoaResourceModel)toolStripComboBox1.ComboBox.SelectedItem).DataBindedType;
            dataGridView1.DataSource = ApplyFilter().Select(p => Convert.ChangeType(p, ((SoaResourceModel)toolStripComboBox1.ComboBox.SelectedItem).DataBindedType)).ToList();
        }

        private List<ResourceBase> ApplyFilter()
        {
            if (filterForMainGrid == null)
                return downloadedData;

            toolStripButton4.Visible = true;
            toolStripLabel3.Visible = true;
            toolStripLabel4.Visible = true;
            toolStripLabel4.Text = GetFilterDescription();

            List<ResourceBase> newDataList = new List<ResourceBase>();
            foreach (ResourceBase data in downloadedData)
            {
                bool takeThisData = false;
                PropertyInfo pinf = data.GetType().GetProperty(filterForMainGrid.PropertyName);
                object value = pinf.GetValue(data);
                if (value is string)
                {
                    string text = (string)value;
                    switch (filterForMainGrid.FilterType)
                    {
                        case FilterType.STARTS: takeThisData = text.StartsWith(filterForMainGrid.Value); break;
                        case FilterType.ENDS: takeThisData = text.EndsWith(filterForMainGrid.Value); break;
                        case FilterType.CONTAINS: takeThisData = text.Contains(filterForMainGrid.Value); break;
                        case FilterType.EQUAL: takeThisData = text.Equals(filterForMainGrid.Value); break;
                    }
                }
                else if (value is int)
                {
                    int numeric = (int)value;
                    int dataValue;
                    if (Int32.TryParse(filterForMainGrid.Value, out dataValue))
                    {
                        switch (filterForMainGrid.FilterType)
                        {
                            case FilterType.MORE: takeThisData = numeric > dataValue; break;
                            case FilterType.MOREOREQUAL: takeThisData = numeric >= dataValue; break;
                            case FilterType.LESS: takeThisData = numeric < dataValue; break;
                            case FilterType.LESSOREQUAL: takeThisData = numeric <= dataValue; break;
                            case FilterType.EQUAL: takeThisData = numeric == dataValue; break;
                        }
                    }
                }
                else if (value is decimal)
                {
                    decimal numeric = (decimal)value;
                    decimal dataValue;
                    if (Decimal.TryParse(filterForMainGrid.Value, out dataValue))
                    {
                        switch (filterForMainGrid.FilterType)
                        {
                            case FilterType.MORE: takeThisData = numeric > dataValue; break;
                            case FilterType.MOREOREQUAL: takeThisData = numeric >= dataValue; break;
                            case FilterType.LESS: takeThisData = numeric < dataValue; break;
                            case FilterType.LESSOREQUAL: takeThisData = numeric <= dataValue; break;
                            case FilterType.EQUAL: takeThisData = numeric == dataValue; break;
                        }
                    }
                }
                else
                    throw new Exception("Unknown type in filter value");

                if (takeThisData)
                    newDataList.Add(data);
            }

            return newDataList;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            filterForMainGrid = null;
            RefreshData();
            toolStripButton4.Visible = false;
            toolStripLabel3.Visible = false;
            toolStripLabel4.Visible = false;
        }

        private string GetFilterDescription()
        {
            return string.Format("{0} {1} {2}",
                ResourceBase.GetPropertyDisplayName(filterForMainGrid.PropertyName, ((SoaResourceModel)toolStripComboBox1.ComboBox.SelectedItem).DataBindedType),
                filterForMainGrid.ToString(), filterForMainGrid.Value);
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            downloadedData = null;
            filterForMainGrid = null;
            dataGridView1.DataSource = null;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (((SoaResourceModel)toolStripComboBox1.ComboBox.SelectedItem).DataBindedType == typeof(Movie))
            {
                using (AddEditMovieForm movieForm = new AddEditMovieForm(new Movie(), ResourceForms.Base.FormType.ADD))
                {
                    movieForm.ShowDialog();
                }
            }
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            if (((SoaResourceModel)toolStripComboBox1.ComboBox.SelectedItem).DataBindedType == typeof(Movie))
            {
                Movie selected = (Movie)dataGridView1.SelectedRows[0].DataBoundItem;
                using (AddEditMovieForm movieForm = new AddEditMovieForm(new Movie(), ResourceForms.Base.FormType.EDIT))
                {
                    movieForm.ShowDialog();
                }
            }

        }
    }
}
