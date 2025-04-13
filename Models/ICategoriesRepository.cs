using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Models
{
    interface CategoriesRepository
    {
        void Add (PayCategoriesModel payCategories);
        void Edit(PayCategoriesModel payCategories);

        void Delete(int id);
        IEnumerable<PayCategoriesModel> GetAll();
        IEnumerable<PayCategoriesModel> GetByValue(string value);
    }
}
