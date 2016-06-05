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
        ProcessObject processObject;

        public Main()
        {
            InitializeComponent();
            FillForm();
            gridManager.RefresingMainView = SetFilterAndRefreshGridView;
            processObject = new ProcessObject();
        }

        public void FillForm()
        {
            toolStripComboBox1.ComboBox.DataSource = new List<SoaResourceModel>()
            {
                new SoaResourceModel() {ShowableName = "Movie", DataBindedType = typeof(Movie)},
                new SoaResourceModel() {ShowableName = "User", DataBindedType = typeof(User)},
                new SoaResourceModel() {ShowableName = "Actor", DataBindedType = typeof(Actor)},
                new SoaResourceModel() {ShowableName = "Director", DataBindedType = typeof(Director)},
            };

            downloadedData = new List<ResourceBase>();
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
            var listForGridView = ApplyFilter().Select(p => Convert.ChangeType(p, ((SoaResourceModel)toolStripComboBox1.ComboBox.SelectedItem).DataBindedType)).ToList();
            if (listForGridView != null)
                dataGridView1.DataSource = listForGridView;
            else
                dataGridView1.DataSource = null;
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
            Type typeForOperation = ((SoaResourceModel)toolStripComboBox1.ComboBox.SelectedItem).DataBindedType;
            if (typeForOperation == typeof(Movie))
            {
                using (MovieForm movieForm = new MovieForm(new Movie(), ResourceForms.Base.FormType.ADD, processObject))
                {
                    movieForm.ShowDialog();
                    if (movieForm.ResultObject != null)
                    {
                        downloadedData.Add((ResourceBase)movieForm.ResultObject);
                        RefreshData();
                    }
                }
            }
            else if (typeForOperation == typeof(Actor))
            {
                using (ActorForm movieForm = new ActorForm(new Actor(), ResourceForms.Base.FormType.ADD, processObject))
                {
                    movieForm.ShowDialog();
                    if (movieForm.ResultObject != null)
                    {
                        downloadedData.Add((ResourceBase)movieForm.ResultObject);
                        RefreshData();
                    }
                }
            }
            else if (typeForOperation == typeof(Director))
            {
                using (DirectorForm movieForm = new DirectorForm(new Director(), ResourceForms.Base.FormType.ADD, processObject))
                {
                    movieForm.ShowDialog();
                    if (movieForm.ResultObject != null)
                    {
                        downloadedData.Add((ResourceBase)movieForm.ResultObject);
                        RefreshData();
                    }
                }
            }
            else if (typeForOperation == typeof(User))
            {
                using (UserForm movieForm = new UserForm(new User(), ResourceForms.Base.FormType.ADD, processObject))
                {
                    movieForm.ShowDialog();
                    if (movieForm.ResultObject != null)
                    {
                        downloadedData.Add((ResourceBase)movieForm.ResultObject);
                        RefreshData();
                    }
                }
            }
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            Type typeForOperation = ((SoaResourceModel)toolStripComboBox1.ComboBox.SelectedItem).DataBindedType;
            if (typeForOperation == typeof(Movie))
            {
                if (dataGridView1.SelectedRows != null && dataGridView1.SelectedRows.Count > 0)
                {
                    Movie selected = (Movie)dataGridView1.SelectedRows[0].DataBoundItem;
                    using (MovieForm movieForm = new MovieForm(selected, ResourceForms.Base.FormType.EDIT, processObject))
                    {
                        movieForm.ShowDialog();
                        RefreshData();
                    }
                }
            }
            else if (typeForOperation == typeof(Actor))
            {
                if (dataGridView1.SelectedRows != null && dataGridView1.SelectedRows.Count > 0)
                {
                    Actor selected = (Actor)dataGridView1.SelectedRows[0].DataBoundItem;
                    using (ActorForm movieForm = new ActorForm(selected, ResourceForms.Base.FormType.EDIT, processObject))
                    {
                        movieForm.ShowDialog();
                        RefreshData();
                    }
                }
            }
            else if (typeForOperation == typeof(Director))
            {
                if (dataGridView1.SelectedRows != null && dataGridView1.SelectedRows.Count > 0)
                {
                    Director selected = (Director)dataGridView1.SelectedRows[0].DataBoundItem;
                    using (DirectorForm movieForm = new DirectorForm(selected, ResourceForms.Base.FormType.EDIT, processObject))
                    {
                        movieForm.ShowDialog();
                        RefreshData();
                    }
                }
            }
            else if (typeForOperation == typeof(User))
            {
                if (dataGridView1.SelectedRows != null && dataGridView1.SelectedRows.Count > 0)
                {
                    User selected = (User)dataGridView1.SelectedRows[0].DataBoundItem;
                    using (UserForm movieForm = new UserForm(selected, ResourceForms.Base.FormType.EDIT, processObject))
                    {
                        movieForm.ShowDialog();
                        RefreshData();
                    }
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Type currentType = ((SoaResourceModel)toolStripComboBox1.ComboBox.SelectedItem).DataBindedType;

            if (currentType == typeof(Movie))
            {
                downloadedData = processObject.MovieClient.GetMoviesByTitlePart(toolStripTextBox1.Text).Select(p => (ResourceBase)p).ToList();
                RefreshData();
            }
            else if (currentType == typeof(Actor))
            {
                downloadedData = processObject.PeopleClient.GetActorsByName(toolStripTextBox1.Text).Select(p => (ResourceBase)p).ToList();
                RefreshData();
            }
            else if (currentType == typeof(Director))
            {
                downloadedData = processObject.PeopleClient.GetDirectorsByName(toolStripTextBox1.Text).Select(p => (ResourceBase)p).ToList();
                RefreshData();
            }
            else if (currentType == typeof(User))
            {
                downloadedData = processObject.MovieClient.GetMoviesByTitlePart(toolStripTextBox1.Text).Select(p => (ResourceBase)p).ToList();
                RefreshData();
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Type currentType = ((SoaResourceModel)toolStripComboBox1.ComboBox.SelectedItem).DataBindedType;

            if (dataGridView1.SelectedRows != null && dataGridView1.SelectedRows.Count > 0)
            {
                int idToDelete = ((ResourceBase)dataGridView1.SelectedRows[0].DataBoundItem).Id;
                if (currentType == typeof(Movie))
                {
                    processObject.MovieClient.DeleteMovie(idToDelete);
                }
                else if (currentType == typeof(Actor))
                {
                    processObject.PeopleClient.DeleteActor(idToDelete);
                }
                else if (currentType == typeof(Director))
                {
                    processObject.PeopleClient.DeleteDirector(idToDelete);
                }
                else if (currentType == typeof(User))
                {
                    processObject.MovieClient.DeleteMovie(idToDelete);
                }
                downloadedData = downloadedData.Where(p => p.Id != idToDelete).ToList();
                RefreshData();
            }            
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Type typeForOperation = ((SoaResourceModel)toolStripComboBox1.ComboBox.SelectedItem).DataBindedType;
            if (typeForOperation == typeof(Movie))
            {
                if (dataGridView1.SelectedRows != null && dataGridView1.SelectedRows.Count > 0)
                {
                    Movie selected = (Movie)dataGridView1.SelectedRows[0].DataBoundItem;
                    using (MovieForm movieForm = new MovieForm(selected, ResourceForms.Base.FormType.INFO, processObject))
                    {
                        movieForm.ShowDialog();
                    }
                }
            }
            else if (typeForOperation == typeof(Actor))
            {
                if (dataGridView1.SelectedRows != null && dataGridView1.SelectedRows.Count > 0)
                {
                    Actor selected = (Actor)dataGridView1.SelectedRows[0].DataBoundItem;
                    using (ActorForm movieForm = new ActorForm(selected, ResourceForms.Base.FormType.INFO, processObject))
                    {
                        movieForm.ShowDialog();
                    }
                }
            }
            else if (typeForOperation == typeof(Director))
            {
                if (dataGridView1.SelectedRows != null && dataGridView1.SelectedRows.Count > 0)
                {
                    Director selected = (Director)dataGridView1.SelectedRows[0].DataBoundItem;
                    using (DirectorForm movieForm = new DirectorForm(selected, ResourceForms.Base.FormType.INFO, processObject))
                    {
                        movieForm.ShowDialog();
                    }
                }
            }
            else if (typeForOperation == typeof(User))
            {
                if (dataGridView1.SelectedRows != null && dataGridView1.SelectedRows.Count > 0)
                {
                    User selected = (User)dataGridView1.SelectedRows[0].DataBoundItem;
                    using (UserForm movieForm = new UserForm(selected, ResourceForms.Base.FormType.INFO, processObject))
                    {
                        movieForm.ShowDialog();
                    }
                }
            }
        }
    }
}
