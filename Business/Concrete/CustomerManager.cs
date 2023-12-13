using AutoMapper;
using Business.Abstract;
using Business.Dtos.Request;
using Business.Dtos.Response;
using Core.DataAccess.Paging;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entitites.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;
        IMapper _mapper;
        public CustomerManager(ICustomerDal customerDal,IMapper mapper)
        {
            _customerDal = customerDal;
            _mapper = mapper;
        }
        public async Task<CreatedCustomerResponse> Add(CreateCustomerRequest createCustomerRequest)
        {
            Customer customer = _mapper.Map<Customer>(createCustomerRequest);
            var createdCustomer= await _customerDal.AddAsync(customer);
            CreatedCustomerResponse result = _mapper.Map<CreatedCustomerResponse>(createdCustomer);
            return result;
        }

        public async Task<DeletedCustomerResponse> Delete(DeleteCustomerRequest deleteCustomerRequest)
        {
            Customer customer = _mapper.Map<Customer>(deleteCustomerRequest);
            var deletedCustomer = await _customerDal.DeleteAsync(customer);
            DeletedCustomerResponse result = _mapper.Map<DeletedCustomerResponse>(deletedCustomer);
            return result;
        }

        public async Task<IPaginate<GetListCustomerResponse>> GetCustomerListAsync()
        {
            var customer = await _customerDal.GetListAsync();
            var result=_mapper.Map<Paginate<GetListCustomerResponse>>(customer);
            return result;
        }

        public async Task<UpdatedCustomerResponse> Update(UpdateCustomerRequest updateCustomerRequest)
        {
            Customer customer = _mapper.Map<Customer>(updateCustomerRequest);
            var updatedCustomer = await _customerDal.UpdateAsync(customer);
            UpdatedCustomerResponse result = _mapper.Map<UpdatedCustomerResponse>(updatedCustomer);
            return result;
        }
    }
}
