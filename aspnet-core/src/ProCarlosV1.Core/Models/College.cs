using System;
using System.Collections;
using System.Collections.Generic;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

namespace ProCarlosV1.Models
{
    public class College : FullAuditedEntity<int>, IPassivable
    {
        public College()
        {
            this.IsActive = true;
            this.CreationTime = DateTime.Now;
        }

        public string Name { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string GpsLatitude { get; set; }
        public string Longitude { get; set; }
        public string Email { get; set; }
        public string Director { get; set; }
        public bool IsActive { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}