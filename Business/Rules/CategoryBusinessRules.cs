using Core.Business.Rules;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Rules
{
    public class CategoryBusinessRules : BaseBusinessRules
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryBusinessRules(ICategoryDal categorDal)
        {
            _categoryDal = categorDal;
        }
        public async Task MaximumCategoryCountIsTen()
        {
            var result= await _categoryDal.GetListAsync();
            if (result.Count >=10)
            {
                throw new Exception("kategori sayısı maximum 10 olabilir");
            }
        }

    }
}
