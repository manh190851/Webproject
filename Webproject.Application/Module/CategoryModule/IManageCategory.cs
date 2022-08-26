using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webproject.Application.Module.Category.CategoryModel;
using Webproject.Application.Module.Category.CategoryRequest;
using Webproject.Application.Module.Dtos;

namespace Webproject.Application.Module.Category
{
    public interface IManageCategory
    {
        Task<int> Create(CategoryCreateRequest request);

        Task<int> Update(int CateId, CategoryEditRequest request);

        Task<int> Delete(int CateId);

        Task<PageViewModel<CategoryViewModel>> GetAll();
    }
}
