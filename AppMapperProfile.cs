using AutoMapper;
using EfCoreRelation.DTOs;
using EfCoreRelation.Entity;

namespace EfCoreRelation
{//inherit profile thats using automapper
    public class AppMapperProfile :Profile
    {
        public AppMapperProfile()
        {
            CreateMap<CustomerDto, Customer>();
            CreateMap<CustomerAddressDTO, CustomerAddress>();
        }
    }
}
