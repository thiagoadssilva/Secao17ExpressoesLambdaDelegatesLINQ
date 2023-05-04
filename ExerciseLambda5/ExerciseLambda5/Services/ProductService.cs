using ExerciseLambda5.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseLambda5.Services
{
    class ProductService
    {
        public double FilteredSum(List<Product> list, Func<Product, bool> criteria)
        {
            double sum = 0.0;
            foreach (Product p in list)
            {
                if (criteria.Invoke(p))
                {
                    sum += p.Price;
                }
            }
            return sum;
        }
    }
}
