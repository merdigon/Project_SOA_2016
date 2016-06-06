using Client.Models;
using Client.ProcessObjects;
using Client.ResourceForms.Base;
using Client.ViewModel;
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
            LoadData();
            FillForm();
        }

        private void LoadData()
        {
            if (InputData.DirectorID != 0)
                InputData.Director = ProcessObject.PeopleClient.GetDirector(InputData.DirectorID);
            if (InputData.ActorsID != null)
                InputData.ActorsList = InputData.ActorsID.Select(p => ProcessObject.PeopleClient.GetActor(p)).ToList();
        }

        private void FillForm()
        {
            tbTitle.Text = InputData.Title;
            tbDescription.Text = InputData.Description;
            tbCountry.Text = InputData.Country;
            tbImageUri.Text = InputData.CoverURI;
            tbYear.Text = InputData.Year.ToString();
            tbDirector.Text = (InputData.Director != null ? InputData.Director.ToString() : string.Empty);
            actorGridView.DataSource = (InputData.ActorsList ?? new List<Actor>()).Select(p => new ActorViewModel(p)).ToList();
            cbGenre.DataSource = ProcessObject.MovieClient.GetAllGenres();
            if (InputData.Genre != null)
                cbGenre.SelectedItem = InputData.Genre;
            else
                cbGenre.SelectedIndex = -1;
            btnRefreshImage_Click(null, null);
            Text = (FormType == FormType.ADD ? "Add movie" : (FormType == FormType.EDIT ? "Edit movie" : "Info"));
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
                double averageNode = ProcessObject.ReviewClient.GetAverageNoteForMovie(InputData.Id);
                lbAver.Text = averageNode.ToString("F1");
                base.btnCommit_ChangeVisibility(false);
                base.btnCancel_ChangeImage(Properties.Resources.Actions_dialog_ok_apply_icon);
                base.btnCancel_ChangeName("Ok");
                pbStars.Width = (int)((averageNode / 5) * 200);
            }
            else
            {
                btnShowReviews.Visible = false;
                label10.Visible = false;
                lbAver.Visible = false;
                panel1.Visible = false;
                pbStars.Visible = false;
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

            InputData.ActorsList = ((List<ActorViewModel>)actorGridView.DataSource).Select(p => p.Source).ToList();

            if (InputData.Director != null)
                InputData.DirectorID = InputData.Director.Id;
            else
                InputData.DirectorID = 0;

            if (InputData.ActorsList != null)
                InputData.ActorsID = InputData.ActorsList.Select(p => p.Id).ToList();

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
            using (ResourceChooserForm chooser = new ResourceChooserForm(typeof(Actor), ProcessObject))
            {
                chooser.Text = "Wybierz aktorów";
                chooser.ShowDialog();
                ResourceBase result = chooser.ResultObject;
                if (result != null && result is ActorViewModel)
                {
                    List<ActorViewModel> currentList = (List<ActorViewModel>)actorGridView.DataSource ?? new List<ActorViewModel>();
                    currentList.Add((ActorViewModel)result);
                    actorGridView.DataSource = null;
                    actorGridView.DataSource = currentList;
                    actorGridView.Refresh();
                }
            }
        }

        private void btnDeleteDirector_Click(object sender, EventArgs e)
        {
            InputData.Director = null;
            tbDirector.Text = string.Empty;
        }

        private void btnSetDirector_Click(object sender, EventArgs e)
        {
            using (ResourceChooserForm chooser = new ResourceChooserForm(typeof(Director), ProcessObject))
            {
                chooser.Text = "Wybierz reżysera";
                chooser.ShowDialog();
                ResourceBase result = chooser.ResultObject;
                if (result != null && result is DirectorViewModel)
                {
                    InputData.Director = ((DirectorViewModel)result).Source;
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

        private void btnDeleteActor_Click(object sender, EventArgs e)
        {
            Actor actorToDelete = null;
            if (actorGridView.SelectedCells.Count > 0)
                actorToDelete = ((ActorViewModel)actorGridView.Rows[actorGridView.SelectedCells[0].RowIndex].DataBoundItem).Source;
            if (actorToDelete != null)
            {
                InputData.ActorsList = InputData.ActorsList.Where(p => p.Id != actorToDelete.Id).ToList();
                actorGridView.DataSource = InputData.ActorsList;
                actorGridView.Refresh();
            }
        }
    }
}
