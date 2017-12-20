using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Data.Entity;
using System.Web.Http;
using AutoMapper;
using DVD_Shop.Dtos;
using DVD_Shop.Models;


namespace DVD_Shop.Controllers.Api
{
    public class CustomersController : ApiController
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context=new ApplicationDbContext();
        }
        // GET /api/customers
        public IHttpActionResult GetCustomers(string query =null)
        {   
                                               //delegate
            var customersQuery = _context.Customers
                .Include(c => c.MembershipType);

            if (!String.IsNullOrWhiteSpace(query))
                customersQuery = customersQuery.Where(c => c.Name.Contains(query));//filtering the names that get from query

                var customerDtos = customersQuery
                .ToList()
                .Select(Mapper.Map<Customer,CustomerDto>);

            return Ok(customerDtos);
        }

        // GET /api/customers/1
        [Authorize(Roles = RoleName.CanManageCustomers)]
        public IHttpActionResult GetCustomer(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customer==null)
            {
                return NotFound();
            }

            return Ok(Mapper.Map<Customer, CustomerDto>(customer));
        }

        // POST /api/customers
        [HttpPost]/* beacuase we create a resource and we can delete this if we
                  rename the action like this PostCustomer()*/
        [Authorize(Roles = RoleName.CanManageCustomers)]
        public IHttpActionResult CreateCustomer(CustomerDto customerDto)// by RESTful convention CustoemrDto--> IHttpActionResult (201) {created}
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var customer = Mapper.Map<CustomerDto, Customer>(customerDto);//new object to add it
            _context.Customers.Add(customer);
            _context.SaveChanges();


            customerDto.Id = customer.Id;/*the id is generated in DB so we need to add id
                                            to customerDto and return to the client*/

            return Created(new Uri(Request.RequestUri+"/"+customer.Id),customerDto/*actual object that created*/ );
        }

        // PUT /api/customers/1
                                // from URL         from request body
        [HttpPut]
        [Authorize(Roles = RoleName.CanManageCustomers)]
        public IHttpActionResult UpdateCustomer(int id,CustomerDto customerDto)
        {
            if (!ModelState.IsValid)
            {
                BadRequest();
            }

            var customerInDb = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customerInDb==null)
            {
                NotFound();
            }
             //can delete it,can delete it // source        target
            Mapper.Map<CustomerDto, Customer>(customerDto, customerInDb);// customer is exist {custoemrInDb}

            //customerInDb.Name = customerDto.Name;
            //customerInDb.Birthdate = customerDto.Birthdate;
            //customerInDb.IsSubscribedToNewsletter = customerDto.IsSubscribedToNewsletter;
            //customerInDb.MembershipTypeId = customerDto.MembershipTypeId;

            _context.SaveChanges();

            return Ok();
        }

        //Delete /api/customers/1
        [HttpDelete]
        [Authorize(Roles = RoleName.CanManageCustomers)]
        public IHttpActionResult DeleteCustomer(int id)
        {
            var customerInDb = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customerInDb == null)
            {
                NotFound();
            }

            _context.Customers.Remove(customerInDb);

            _context.SaveChanges();

            return Ok();
        }
    }
}
