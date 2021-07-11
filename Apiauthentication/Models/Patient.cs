using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Apiauthentication.Models
{
    public class Patient
    {
        [Key]
        public int Id { get; set; }
        public string UserId { get; set; }
        public string RoleId { get; set; }
        public string PUUId { get; set; }
        public string EmergencyName { get; set; }
        public string EmergencyContact { get; set; }
        public string EmergencyRelation { get; set; }
        public int EmergencyNumber { get; set; }
        public int LocationCoordinates { get; set; }
       

    }
}
