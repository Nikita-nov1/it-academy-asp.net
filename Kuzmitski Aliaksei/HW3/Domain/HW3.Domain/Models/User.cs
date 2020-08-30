﻿using System;

namespace HW3.Domain.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Title Title { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Comments { get; set; }
    }
}
