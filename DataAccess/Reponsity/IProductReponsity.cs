using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObject.Models;

namespace DataAccess.Reponsity
{
    public interface IProductReponsity
    {
        IEnumerable<Product> GetAll();

        void Add(Product product);
        void Delete(Product product);
        void Update(Product product);

    }
}
