using AutoMapper;
using EfCoreRelation.DTOs;
using EfCoreRelation.Entity;

namespace EfCoreRelation
{//inherit profile thats using automapper
    public class AppMapperProfile :Profile
    {
        public AppMapperProfile()

        {//here is destination and destination
            CreateMap<CustomerDto, Customer>();
        
            CreateMap<CustomerAddressDTO, CustomerAddress>();
           
        }
    }
}
