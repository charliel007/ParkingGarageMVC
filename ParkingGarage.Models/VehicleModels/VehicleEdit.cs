﻿using ParkingGarage.Data.Entities.Enums;
using ParkingGarage.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParkingGarage.Models.VehicleLocationModels;

namespace ParkingGarage.Models.VehicleModels
{
    public class VehicleEdit
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public string? Make { get; set; }
        public string? ModelName { get; set; }
        public Color Color { get; set; }
        public LicensePlateState LicensePlateState { get; set; }
        public string LicensePlateNumber { get; set; }
    }
}
