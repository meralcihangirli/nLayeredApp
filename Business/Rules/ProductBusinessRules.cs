using Business.Messages;
using Core.Business.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using DataAccess.Abstract;
using Entitites.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Rules
{
    public class ProductBusinessRules : BaseBusinessRules
    {
        private readonly IProductDal _productDal;

        public ProductBusinessRules(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public async Task MaximumProductIsTwentyInCategory(int categoryId)
        {
            var result = await _productDal.GetListAsync(predicate:p=>p.CategoryId==categoryId,size:25);
            if (result.Count > 20)
            {
                throw new BusinessException(BusinessMessages.ProductLimitInCategory);
                //kendi hata sınıfımızı olusturduk
            }
        }
    }
}
