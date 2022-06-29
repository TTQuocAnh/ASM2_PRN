using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Reponsity
{
    public class ProductReponsity : IProductReponsity
    {
        void IProductReponsity.Add(Product product)
        {
            throw new NotImplementedException();
        }

        void IProductReponsity.Delete(Product product)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Product> IProductReponsity.GetAll()
        {
            throw new NotImplementedException();
        }

        void IProductReponsity.Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
