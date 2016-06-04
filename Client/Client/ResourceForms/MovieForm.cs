using Client.Models;
using Client.ProcessObjects;
using Client.ResourceForms.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.ResourceForms
{
    public partial class MovieForm : BaseForm
    {
        Movie InputData { get; set; }
        ProcessObject ProcessObject { get; set; }

        public MovieForm(Movie input, FormType formType, ProcessObject processObject)
        {
            InitializeComponent();
            InputData = input ?? new Movie();
            Text = (formType == FormType.ADD ? "Dodaj film" : "Edytuj film");
            FillForm();
        }

        private void FillForm()
        {
            tbTitle.Text = InputData.Title;
            tbDescription.Text = InputData.Description;
            tbCountry.Text = InputData.Country;
            tbImageUri.Text = InputData.CoverURI;
            tbYear.Text = InputData.Year.ToString();
            tbDirector.Text = (InputData.Director != null ? InputData.Director.ToString() : string.Empty);
            actorGridView.DataSource = InputData.Actors ?? new List<Actor>();
            btnRefreshImage_Click(null, null);
        }

        public override void CommitClick()
        {
            InputData.Title = tbTitle.Text;
            InputData.Description = tbDescription.Text;
            InputData.Country = tbCountry.Text;
            InputData.CoverURI = tbImageUri.Text;

            int year;
            if (Int32.TryParse(tbYear.Text, out year))
                InputData.Year = year;
            else
                throw new Exception("Podany rok jest błędny!");

            tbDirector.Text = (InputData.Director != null ? InputData.Director.ToString() : string.Empty);
            InputData.Actors = (List<Actor>)actorGridView.DataSource;  
            this.Close();
        }

        private void btnAddActor_Click(object sender, EventArgs e)
        {
            using (ResourceChooserForm chooser = new ResourceChooserForm(typeof(Actor)))
            {
                chooser.ShowDialog();
                ResourceBase result = chooser.ResultObject;
                if (result != null && result is Actor)
                {
                    List<Actor> currentList = (List<Actor>)actorGridView.DataSource ?? new List<Actor>();
                    currentList.Add((Actor)result);
                    actorGridView.DataSource = currentList;
                }
            }
        }

        private void btnDeleteDirector_Click(object sender, EventArgs e)
        {
            InputData.Director = null;
        }

        private void btnSetDirector_Click(object sender, EventArgs e)
        {
            using (ResourceChooserForm chooser = new ResourceChooserForm(typeof(Director)))
            {
                chooser.ShowDialog();
                ResourceBase result = chooser.ResultObject;
                if (result != null && result is Director)
                {
                    InputData.Director = (Director)result;
                    tbDirector.Text = InputData.Director.ToString();
                }
            }
        }

        private void btnRefreshImage_Click(object sender, EventArgs e)
        {
            var wc = new WebClient();
            Image x = Image.FromStream(wc.OpenRead(tbImageUri.Text));
            pbMoviePicture.Image = x;
        }
    }
}
