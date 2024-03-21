using MyBlog.BusinessLayer.Abstract;
using MyBlog.DataAccessLayer.Abstract;
using MyBlog.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.BusinessLayer.Concrete
{
    public class WriterManager : IWriterService
    {
        private readonly IWriterDal _writerDal;
        public WriterManager(IWriterDal writerDal)
        {
            _writerDal = writerDal;
        }
        public void TDelete(int id)
        {
            _writerDal.Delete(id);
        }
        public Writer TGetById(int id)
        {
           return _writerDal.GetById(id);
        }
        public List<Writer> TGetListAll()
        {
            return _writerDal.GetListAll();
        }
        public void TInsert(Writer entity)
        {
            _writerDal.Insert(entity);
        }
        public void TUpdate(Writer entity)
        {
            _writerDal.Update(entity);
        }
    }
}
