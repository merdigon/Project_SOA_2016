using Client.Models;
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
    public partial class AddEditMovieForm : AddEditBaseForm
    {
        Movie inputData;

        public AddEditMovieForm(Movie input, FormType formType)
        {
            InitializeComponent();
            inputData = input;
            Text = (formType == FormType.ADD ? "Dodaj film" : "Edytuj film");
        }

        public override void CommitClick()
        {
            this.Close();
        }
    }
}
