using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RAEFC.Domain.Core.Data;
using RAEFC.Domain.Interafaces.Repository;
using RAEFC.Domain.Models;
using RAEFC.Service.Api.ViewModel;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RAEFC.Service.Api.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class CustomerController : MainController
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public CustomerController(ICustomerRepository customerRepository, IUnitOfWork uow, IMapper mapper)
        {
            _customerRepository = customerRepository;
            _uow = uow;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<CustomerViewModel>> Get()
        {
            return _mapper.Map<IEnumerable<CustomerViewModel>>(await _customerRepository.GetAll());
        }

        [HttpGet("{id:guid}")]
        public async Task<CustomerViewModel> Get(Guid id)
        {
            return _mapper.Map<CustomerViewModel>(await _customerRepository.GetById(id));
        }

        [HttpGet("{email}")]
        public async Task<CustomerViewModel> Get(string email)
        {
            return _mapper.Map<CustomerViewModel>(await _customerRepository.GetByEmail(email));
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CustomerViewModel customerViewModel)
        {
            if (!ModelState.IsValid)
                return CustomResponse(ModelState);

            _customerRepository.Add(_mapper.Map<Customer>(customerViewModel));
            await _uow.Commit();
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] CustomerViewModel customerViewModel)
        {
            if (!ModelState.IsValid)
                return CustomResponse(ModelState);

            _customerRepository.Update(_mapper.Map<Customer>(customerViewModel));
            await _uow.Commit();

            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(Guid id)
        {
            var customer = await _customerRepository.GetById(id);

            if (customer == null)
                return NotFound();

            _customerRepository.Remove(customer);
            await _uow.Commit();

            return Ok();
        }
    }
}
