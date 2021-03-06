﻿using System.ComponentModel.DataAnnotations;

namespace GRA.Domain.Model
{
    public class SchoolDistrict : Abstract.BaseDomainEntity
    {
        public int SiteId { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
