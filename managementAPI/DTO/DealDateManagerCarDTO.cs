using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace managementAPI
{
    public class DealDateManagerCatrDTO
    {
        public DateTime date { get; set; }
        public int managerId { get; set; }
        public int carId { get; set; }
    }
}