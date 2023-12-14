using Business.Dtos.Response;
using Business.Messages;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Core.DataAccess.Paging;
using DataAccess.Abstract;
using Entitites.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Rules
{
    public class CustomerBusinessRules :BaseBusinessRules
    {
        private readonly ICustomerDal _customerDal;
        public CustomerBusinessRules(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public async Task EachCityCanContainMax10Customers(string city)
        {
            var result = await _customerDal.GetListAsync(c => c.City == city);
            if (result.Count>=10)
            {
                throw new BusinessException(BusinessMessages.CityLimit);
            }
        }

        public async Task  SameName (string contactName)
        {
            var result = await _customerDal.GetAsync(c => c.ContactName==contactName);

            if (result!=null)
            {
                throw new BusinessException(BusinessMessages.SameContactName);
            }
           
        }
    }
}
