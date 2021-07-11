using System;
using IdGen;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Apiauthentication.Models
{
    public class Doctor
    {
        [Key]
        public int Id { get; set; }
        public string UserId { get; set; }
        public string RoleId { get; set; }

        [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public string DUUId { get; set; }
        public int BMDCRegNo { get; set; }

  
    }
}
