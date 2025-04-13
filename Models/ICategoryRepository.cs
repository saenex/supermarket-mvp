using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket_mvp.Models;

namespace Supermarket_mvp.Models
{
    public interface ICategoryRepository
    {
        void Add (CategoryModel category);
        void Edit(CategoryModel category);

        void Delete(int id);
        IEnumerable<CategoryModel> GetAll();
        IEnumerable<CategoryModel> GetByValue(string value);
    }
}
