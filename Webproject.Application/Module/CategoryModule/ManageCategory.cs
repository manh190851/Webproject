using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webproject.Application.Module.Category.CategoryModel;
using Webproject.Application.Module.Category.CategoryRequest;
using Webproject.Application.Module.Dtos;
using Webproject.Data.EF;

namespace Webproject.Application.Module.Category
{
    public class ManageCategory : IManageCategory
    {
        private WebprojectDbContext db;
        public ManageCategory(WebprojectDbContext context)
        {
            db = context;
        }

        public Task<int> Create(CategoryCreateRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(int CateId)
        {
            throw new NotImplementedException();
        }

        public Task<PageViewModel<CategoryViewModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(int CateId, CategoryEditRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
