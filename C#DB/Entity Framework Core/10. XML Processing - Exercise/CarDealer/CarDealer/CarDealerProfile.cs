using AutoMapper;
using CarDealer.DTOs.Export;
using CarDealer.DTOs.Import;
using CarDealer.Models;

namespace CarDealer
{
    public class CarDealerProfile : Profile
    {
        public CarDealerProfile()
        {

            CreateMap<SupplierDTO, Supplier>();
            CreateMap<PartDTO, Part>();
            CreateMap<CarDTOExport, Car>();
            CreateMap<CustomerDTO, Customer>()
                .ForMember(c => c.BirthDate, opt => opt.MapFrom(src => src.BirthDay.ToString("yyyy-MM-ddTHH:mm:ss")));
            CreateMap<SaleDto, Sale>();
            CreateMap<Car, CarsWithDistance>();
            CreateMap<Car, CarBmw>();
            CreateMap<Car, CarsWithPartsDTO>();
            CreateMap<PartCar, PartCarDTO>();

        }
    }
}


