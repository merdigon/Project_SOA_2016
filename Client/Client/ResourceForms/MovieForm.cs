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

        public Movie ResultObject { get; set; }

        FormType FormType { get; set; }

        public MovieForm(Movie input, FormType formType, ProcessObject processObject)
        {
            InitializeComponent();
            ProcessObject = processObject;
            InputData = input ?? new Movie();
            FormType = formType;
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
            cbGenre.DataSource = ProcessObject.MovieClient.GetAllGenres();
            if (InputData.Genre != null)
                cbGenre.SelectedItem = InputData.Genre;
            else
                cbGenre.SelectedIndex = -1;
            btnRefreshImage_Click(null, null);
            Text = (FormType == FormType.ADD ? "Dodaj film" : (FormType == FormType.EDIT ? "Edytuj film" : "Info"));
            if (FormType == FormType.INFO)
            {
                tbCountry.ReadOnly = true;
                tbDescription.ReadOnly = true;
                tbImageUri.ReadOnly = true;
                tbTitle.ReadOnly = true;
                tbYear.ReadOnly = true;
                btnAddActor.Visible = false;
                btnDeleteActor.Visible = false;
                btnSetDirector.Visible = false;
                btnDeleteDirector.Visible = false;
                btnRefreshImage.Visible = false;
                cbGenre.Enabled = false;
                base.btnCommit_ChangeVisibility(false);
                base.btnCancel_ChangeImage(Properties.Resources.Actions_dialog_ok_apply_icon);
                base.btnCancel_ChangeName("Ok");
            }
            else
            {
                btnShowReviews.Visible = false;
            }
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

            if (FormType == FormType.ADD)
            {
                ProcessObject.MovieClient.AddMovie(InputData);
                ResultObject = InputData;
            }
            else if (FormType == FormType.EDIT)
            {
                ProcessObject.MovieClient.UpdateMovie(InputData);
                ResultObject = InputData;
            }

            this.Close();
        }

        private void btnAddActor_Click(object sender, EventArgs e)
        {
            using (ResourceChooserForm chooser = new ResourceChooserForm(typeof(Actor)))
            {
                chooser.Text = "Wybierz aktorów";
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
                chooser.Text = "Wybierz reżysera";
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
            if (!string.IsNullOrEmpty(tbImageUri.Text))
            {
                var wc = new WebClient();
                Image x = Image.FromStream(wc.OpenRead(tbImageUri.Text));
                pbMoviePicture.Image = x;
            }
        }

        private void btnShowReviews_Click(object sender, EventArgs e)
        {
            List<Review> reviewList = ProcessObject.ReviewClient.GetReviewsForMovie(InputData.Id);
            using (ReviewForm reviewForm = new ReviewForm(reviewList, InputData, ProcessObject))
            {
                reviewForm.ShowDialog();
            }
        }
    }
}
