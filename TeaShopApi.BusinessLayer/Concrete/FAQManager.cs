using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShopApi.BusinessLayer.Abstract;
using TeaShopApi.DataAccessLayer.Abstract;
using TeaShopApi.EntityLayer.Concrete;

namespace TeaShopApi.BusinessLayer.Concrete
{
    public class FAQManager : IFAQService
    {
        private readonly IFQADal _fqaDal;

        public FAQManager(IFQADal fqaDal)
        {
            _fqaDal = fqaDal;
        }

        public void TDelete(FQA entity)
        {
            _fqaDal.Delete(entity);
        }

        public List<FQA> TGetAll()
        {
            return _fqaDal.GetAll();
        }

        public FQA TGetById(int id)
        {
            return _fqaDal.GetById(id);
        }

        public void TInsert(FQA entity)
        {
            _fqaDal.Insert(entity); 
        }

        public void TUpdate(FQA entity)
        {
            _fqaDal.Update(entity);
        }
    }
}
