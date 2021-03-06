﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using GSF.Data.Model;

namespace MiPlan.Models
{
    public class ThemeFields
    {
        [PrimaryKey(true)]
        public int ID { get; set; }
        public int ThemeID { get; set; }
        public int FieldNumber { get; set; }

        [Required]
        [StringLength(32)]
        public string FieldName { get; set; }
        public string Description { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}