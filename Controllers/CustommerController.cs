﻿using AutoMapper;
using EfCoreRelation.Data;
using EfCoreRelation.DTOs;
using EfCoreRelation.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EfCoreRelation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustommerController : ControllerBase
    {
        private readonly AppDBContext appDBContext;

      
        private readonly IMapper mapper;

        public CustommerController(AppDBContext appDBContext,IMapper mapper)
        {
            this.appDBContext = appDBContext;
            this.mapper = mapper;
        }


        [HttpGet]
        public async Task<IActionResult> GetCustomer()
        {
            var customers = await appDBContext.Customers.Include(_ => _.customerAddresses).ToListAsync();
            return Ok(customers);
        }
        //Map custommet obj
   /*     private Customer MapCustomerObj(CustomerDto tempCustomerDto)
        {
            var result = new Customer();
            result.FirstName = tempCustomerDto.FirstName;
            result.LastName = tempCustomerDto.LastName;
            result.PhoneNumber = tempCustomerDto.PhoneNumber;
            result.customerAddresses = new List<CustomerAddress>();
            tempCustomerDto.customerAddresses.ForEach(_ =>
            {
                var newAdderss = new CustomerAddress();
                newAdderss.City = _.City;
                newAdderss.Country = _.Country;
                result.customerAddresses.Add(newAdderss);
            });
            return result;
        }*/


        [HttpPost]
        public async Task<IActionResult> PostAllCustomer(CustomerDto tempCustommer)
        {
            var newCustomer = mapper.Map<Customer>(tempCustommer);
            appDBContext.Customers.Add(newCustomer);
            await appDBContext.SaveChangesAsync();
            return Created($"/customer/${newCustomer.Id}", newCustomer);
        }
    }
}
