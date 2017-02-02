using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AspnetLab3.Models
{
    [MetadataType(typeof(ProvinceMetaData))]
    public partial class Province
    {
        [Key]
        public string ProvinceCode { get; set; }

        public string ProvinceName { get; set; }

        public virtual List<City> Cities { get; set; }
    }

    public class ProvinceMetaData
    {
        [Required]
        [Display(Name = "Province Code")]
        public object ProvinceCode { get; set; }

        [Required]
        [Display(Name = "Province")]
        public object ProvinceName { get; set; }
    }
}