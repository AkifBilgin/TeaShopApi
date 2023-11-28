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
    public class TestimonialManager : ITestimonialService
    {
        private readonly ITestimonialDal _testiomonialDal;

        public TestimonialManager(ITestimonialDal testiomonialDal)
        {
            _testiomonialDal = testiomonialDal;
        }

        public void TDelete(Testimonial entity)
        {
            _testiomonialDal.Delete(entity);
        }

        public List<Testimonial> TGetAll()
        {
            return _testiomonialDal.GetAll();
        }

        public Testimonial TGetById(int id)
        {
            return _testiomonialDal.GetById(id);
        }

        public void TInsert(Testimonial entity)
        {
            _testiomonialDal.Insert(entity);
        }

        public void TUpdate(Testimonial entity)
        {
            _testiomonialDal.Update(entity);
        }
    }
}
