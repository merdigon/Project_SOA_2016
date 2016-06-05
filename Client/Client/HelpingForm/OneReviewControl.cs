using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.Models;

namespace Client.HelpingForm
{
    public partial class OneReviewControl : UserControl
    {
        Review Review { get; set; }

        public OneReviewControl(Review review)
        {
            InitializeComponent();
            Review = review;
            tbMessage.ReadOnly = true;
            FillForm();
        }

        private void FillForm()
        {
            if (Review != null)
            {
                tbMessage.Text = Review.Content;
                if (Review.User == null)
                    lbUserName.Text = string.Empty;
                else
                    lbUserName.Text = Review.User.ToString();

                SizeF MessageSize = tbMessage.CreateGraphics()
                                .MeasureString(tbMessage.Text,
                                                tbMessage.Font,
                                                tbMessage.Width,
                                                new StringFormat(0));

                tbMessage.Height = (int)MessageSize.Height + 10;
            }
        }
    }
}
