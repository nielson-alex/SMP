using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMP.Models
{
    public class Meeting
    {
        public int ID { get; set; }

        public string Bishopric { get; set; }

        public string OpeningPrayer { get; set; }

        public DateTime DateUpdated { get; set; }

        public DateTime MeetingDate { get; set; }

        public string OpeningSong { get; set; }

        public string SacramentSong { get; set; }

        // don't know how yet but this need be an array asap
        public string Speaker1 { get; set; }
        // so does this
        public string Subject1 { get; set; }

        // don't know how yet but this need be an array asap
        public string Speaker2 { get; set; }

        // so does this
        public string Subject2 { get; set; }

        public string IntermediateSong { get; set; }

        // don't know how yet but this need be an array asap
        public string Speaker3 { get; set; }

        // so does this
        public string Subject3 { get; set; }

        public string ClosingSong { get; set; }

        public string ClosingPrayer { get; set; }
    }
}
