using Business.Dtos.Request;
using Business.Dtos.Response;
using Core.DataAccess.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        Task<CreatedCustomerResponse> Add(CreateCustomerRequest createCustomerRequest);
        Task<IPaginate<GetListCustomerResponse>> GetCustomerListAsync();
        Task<UpdatedCustomerResponse> Update(UpdateCustomerRequest updateCustomerRequest);
        Task<DeletedCustomerResponse> Delete(DeleteCustomerRequest deleteCustomerRequest);
    }
}
