using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ReferenceManager : IReferenceService
    {
        IReferenceDal _referenceDal;

        public ReferenceManager(IReferenceDal referenceDal)
        {
            _referenceDal = referenceDal;
        }

        public void TAdd(Reference t)
        {
            _referenceDal.Insert(t);
        }

        public void TDelete(Reference t)
        {
            _referenceDal.Delete(t);
        }

        public Reference TGetById(int id)
        {
            return _referenceDal.GetById(id);
        }

        public List<Reference> TGetList()
        {
            return _referenceDal.GetList();
        }

        public void TUpdate(Reference t)
        {
            _referenceDal.Update(t);
        }
    }
}
