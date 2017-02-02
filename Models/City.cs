using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AspnetLab3.Models
{
    [MetadataType(typeof(CityMetaData))]
    public partial class City
    {
        public int CityId { get; set; }

        public string CityName { get; set; }

        public int Population { get; set; }

        public string ProvinceCode { get; set; }

        [ForeignKey("ProvinceCode")]
        public virtual Province Province { get; set; }
    }

    public class CityMetaData
    {
        [Required]
        [Display(Name = "City")]
        public object CityName { get; set; }
    }
}