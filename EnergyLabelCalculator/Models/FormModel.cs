using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EnergyLabelCalculator.Models
{
    public class FormModel
    {
        [Required]
        public string Street { get; set; }
        [Required]
        [Display(Name = "House Number")]
        public string HouseNumber { get; set; }
        [Required]
        public string ZipCode { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        [Display(Name = "Construction Year Of The Building")]
        public string ConstructionYear { get; set; }
        [Required]
        [Display(Name = "Current Energy Label")]
        public string CurrentEnergyLabel { get; set; }
        [Required]
        [Display(Name = "Desired Energy Label")]
        public string DesiredEnergyLabel { get; set; }
        [Required]
        [Display(Name = "Current Electric Usage (KWH/Year)")]
        public double ElectricUsage { get; set; }
        [Required]
        [Display(Name = "Current Gas Usage  (m3/Year)")]
        public double GasUsage { get; set; }
        [Required]
        [Display(Name = "Office Squared Meter")]
        public double SquaredMetere { get; set; }
    }
}
