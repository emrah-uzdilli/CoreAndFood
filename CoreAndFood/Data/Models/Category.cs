﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAndFood.Data.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        [Required(ErrorMessage ="Category Name not Empty")]
        [StringLength(20,ErrorMessage ="Please Enter Max 20 Characters")]
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }

        public bool Status { get; set; }

        public List<Food> Foods { get; set; }

 

    }
}
