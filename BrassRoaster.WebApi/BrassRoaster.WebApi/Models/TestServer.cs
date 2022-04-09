﻿using BrassRoaster.WebApi.Utility;

namespace BrassRoaster.WebApi.Models
{
    public class TestServer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Host { get; set; }

        public UsageState UsageState { get; set; }
    }
}