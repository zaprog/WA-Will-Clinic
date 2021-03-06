﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WillClinic.Models.IntakeFormViewModels
{
    public class IntakeFormViewModel6
    {
        [Required]
        [Display(Name = "Health Care Directive")]
        public bool? HealthCareDirective { get; set; }

        
        [Display(Name = "Hydration Directive")]
        public bool? HydrationDirective { get; set; }

        
        [Display(Name = "Nutrition Directive")]
        public bool? NutritionDirective { get; set; }

        
        [Display(Name = "Artificial Ventilation")]
        public bool? ArtificialVentilation { get; set; }

        
        [Display(Name = "Distress Medication")]
        public bool? DistressMedication { get; set; }

        [Display(Name = "Save & Exit")]
        public string Exit { get; set; }
    }
}
