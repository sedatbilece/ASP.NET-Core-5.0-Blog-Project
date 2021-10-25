using ProgrammersBlog.Data.Abstract;
using ProgrammersBlog.Entities.Concrete;
using ProgrammersBlog.Entities.Dtos;
using ProgrammersBlog.Shared.Utilities.Results.Abstract;
using ProgrammersBlog.Shared.Utilities.Results.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgrammersBlog.Shared.Utilities.Results.ComplexTypes;
namespace ProgrammersBlog.Services.Abstract.Concrete
{
    public class CategoryManager : ICategoryService//we need unit of work in there
    {

        private readonly IUnitOfWork _unitOfWork;

        public CategoryManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        public  Task<IResult> Add(CategoryAddDto categoryAddDto, string createdByName)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> Delete(int categoryId)
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<Category>> Get(int categoryId)
        {                                                        //predicate      // category has more article we give that
            var category = await _unitOfWork.Categories.GetAsync(c=> c.Id == categoryId,c=> c.Articles);
            if (category != null)
            {
                return new DataResult<Category>(ResultStatus.Success, category);
            }
            return new DataResult<Category>(ResultStatus.Error,message:"Böyle bir kategori bulunamadı",data:null);
        }



        public async Task<IDataResult<IList<Category>>> GetAll()
        {
            var categories = await _unitOfWork.Categories.GetAllAsync(predicate: null, includeProperties: c => c.Articles);

            if (categories.Count > -1)
            {
                return new DataResult<IList<Category>>(ResultStatus.Success, categories);

            }
            return new DataResult<IList<Category>>(ResultStatus.Error,message:"Hiçbir kategori bulunamadı",data:null);
        }

        public async Task<IDataResult<IList<Category>>> GetAllByNoneDeleted()
        {
            var categories = await _unitOfWork.Categories.GetAllAsync(predicate: c => !c.IsDeleted, includeProperties: c => c.Articles);
            if (categories.Count > -1)
            {
                return new DataResult<IList<Category>>(ResultStatus.Success, categories);

            }
            return new DataResult<IList<Category>>(ResultStatus.Error, message: "Hiçbir kategori bulunamadı", data: null);

        }

        public Task<IResult> HardDelete(int categoryId)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> Update(CategoryAddDto categoryUpdateDto, string modifiedByName)
        {
            throw new NotImplementedException();
        }
    }
}
