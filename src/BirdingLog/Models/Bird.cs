using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BirdingLog.Models
{
    public class Bird
    {
        public int Id { get; set; }
        public string Family { get; set; }
        public string Species { get; set; }
        public List<string> States;
        public enum ConservationStatus
        {
            Extinct,
            ExtinctInWild,
            CritEndangered,
            Endangered,
            Vulnerable,
            NearThreatened,
            LeastConcern,
            DataDeficient
        }

        public ICollection<Photo> Photos { get; set; }
    }
}
