using System;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using ProCarlosV1.Models;

namespace ProCarlosV1.Colleges.Dto
{
    [AutoMapTo(typeof(College))]
    public class UpdateCollegeDto : EntityDto<int>
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string GpsLatitude { get; set; }
        public string Longitude { get; set; }
        public string Email { get; set; }
        public string Director { get; set; }
        public bool IsActive { get; set; }
    }
}
