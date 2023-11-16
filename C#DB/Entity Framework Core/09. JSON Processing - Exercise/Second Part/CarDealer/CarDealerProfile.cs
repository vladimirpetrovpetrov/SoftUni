using AutoMapper;
using CarDealer.Models.DTO;
using CarDealer.Models;

namespace CarDealer;


    public class CarDealerProfile : Profile
    {
        public CarDealerProfile()
        {
            CreateMap<ImportCarDto, Car>();
    }
}
