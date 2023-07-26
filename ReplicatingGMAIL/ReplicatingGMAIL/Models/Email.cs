using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ReplicatingGMAIL.Models
{
    public class Email
    {
        public string Id { get; set; }
        public string TitleEmail { get; set; }
        public string SousTitreEmail { get; set; }
        public string DescriptionEmail { get; set; }
        public Color ColorImageEmail { get; set; }
        public bool Favoris { get; set; }
        public DateTime Time { get; set; }
    }
}
