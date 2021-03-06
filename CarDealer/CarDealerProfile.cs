﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using AutoMapper;
using CarDealer.DTO;
using CarDealer.Models;

namespace CarDealer
{
    public class CarDealerProfile : Profile
    {
        public CarDealerProfile()
        {
            CreateMap<Car,CarDto>();
            CreateMap<Customer, CustomerDto>().ForMember(x=>x.BirthDate,y=>y.MapFrom(x=>x.BirthDate.ToString("dd/MM/yyyy",CultureInfo.InvariantCulture)));
        }
    }
}
