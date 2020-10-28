using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace United_Youth_Orchestra_with_API.Models
{
    public class Member
    {
        // This is the key
        public int Id { get; set; }
        // Name, Telephone, email, DOB, SchoolYear, Music Instrument of the member
        public string Name { get; set; }
        public int Telephone { get; set; } = 0;
        public string email { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime DOB { get; set; }
        
        public int Schoolyear { get; set; }

        public string MusicInst { get; set; }



    }
}
