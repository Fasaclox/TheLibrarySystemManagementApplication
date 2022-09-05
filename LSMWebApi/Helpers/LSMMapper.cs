using AutoMapper;
using LSMWebApi.Data;
using LSMWebApi.Model;

namespace LSMWebApi.Helpers
{
    public class LSMMapper : Profile
    {
        public LSMMapper() 
        {
            CreateMap<Staff, StaffModel>().ReverseMap();
            CreateMap<Customer, CustomerModel>().ReverseMap();
            CreateMap<Book, BookModel>().ReverseMap();
        }
    }
}
