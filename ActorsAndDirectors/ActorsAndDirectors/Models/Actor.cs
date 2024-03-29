﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ActorsAndDirectors.Models
{
    [DataContract]
    public class Actor
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Gender { get; set; }
        [DataMember]
        public string RealName { get; set; }
        [DataMember]
        public string MaritalStatus { get; set; }
        [DataMember]
        public int Height { get; set; }
        [DataMember]
        public string PlaceOfBirth { get; set; }
        [DataMember]
        public DateTime DateOfBirth { get; set; }
        [DataMember]
        public bool Alive { get; set; }

        [DataMember]
        [ForeignKey("Movie")]
        public List<int> MovieId { get; set; }
    }
}
