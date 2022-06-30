using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AgencyTemp.Models
{
    public class Portfolio :BaseEntity
    {

        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Image { get; set; }
        [NotMapped]
        public IFormFile Img { get; set; }

    }
}
