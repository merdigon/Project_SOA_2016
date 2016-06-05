using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using WcfServiceLibrary1.Models;

namespace WcfServiceLibrary1.DAL
{
    class PersonInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<PersonContext>
    {
        protected override void Seed(PersonContext context)
        {
            var actors = new List<Actor>
            {
                new Actor()
                {
                    Name = "First Actor",
                    Gender = "Male",
                    RealName = "Qwer Tyuiop",
                    MaritalStatus = "Married",
                    Height = 186,
                    PlaceOfBirth = "Krakow",
                    DateOfBirth = new DateTime(1990, 1, 11),
                    Alive = true
                },
                new Actor()
                {
                    Name = "Second Actor",
                    Gender = "Female",
                    RealName = "Asdf Ghjkl",
                    MaritalStatus = "",
                    Height = 150,
                    PlaceOfBirth = "Paris",
                    DateOfBirth = new DateTime(1920, 12, 15),
                    Alive = false
                },
                new Actor()
                {
                    Name = "Third Actor",
                    Gender = "Male",
                    RealName = "Zxcv Bnm",
                    MaritalStatus = "Single",
                    Height = 177,
                    PlaceOfBirth = "Los Angeles",
                    DateOfBirth = new DateTime(1920, 03, 30),
                    Alive = true
                }
            };

            actors.ForEach(i => context.Actors.Add(i));
            context.SaveChanges();

            var directors = new List<Director>
            {
                new Director()
                {
                    Name = "First Director",
                    Gender = "Male",
                    RealName = "Aaa Bbb",
                    MaritalStatus = "Widowed",
                    Height = 200,
                    PlaceOfBirth = "Sydney",
                    DateOfBirth = new DateTime(1976, 10, 10),
                    Alive = true,
                },
                new Director()
                {
                    Name = "Second Director",
                    Gender = "Female",
                    RealName = "Ccccc Ddddd",
                    MaritalStatus = "Married",
                    Height = 186,
                    PlaceOfBirth = "Cape Town",
                    DateOfBirth = new DateTime(1902, 2, 23),
                    Alive = false,
                }
            };

            directors.ForEach(i => context.Directors.Add(i));
            context.SaveChanges();
        }
    }
}
