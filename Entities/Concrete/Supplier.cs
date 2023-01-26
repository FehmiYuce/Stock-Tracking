﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Supplier:IEntity
    {
        [Key]
        public int SupplierId { get; set; }
        public string? CompanyName { get; set;}
        public string? ContactName { get; set;}
        public string? PhoneNumber { get; set;}
        public string? Address { get; set;}
        public string? Region { get; set;}
        public string? City { get; set;}
        public string? Country { get; set;}
        public int PostalCode { get; set;} 
    }
}
