using MyBlog.BusinessLayer.Abstract;
using MyBlog.DataAccessLayer.Abstract;
using MyBlog.DataAccessLayer.EntityFramework;
using MyBlog.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public void TDelete(int id)
        {
            _categoryDal.Delete(id);
        }
        public Category TGetById(int id)
        {
            return _categoryDal.GetById(id);    
        }
        public List<Category> TGetListAll()
        {
           return _categoryDal.GetListAll();
        }
        public void TInsert(Category entity)
        {
            if (entity.CategoryName != "" && entity.CategoryName.Length > 3 && entity.CategoryName.Length < 30)
            {
                _categoryDal.Insert(entity);
            }
            else
            {
                //hata mesajı
            }
        }
        public void TUpdate(Category entity)
        {
            _categoryDal.Update(entity);
        }
    }
}
