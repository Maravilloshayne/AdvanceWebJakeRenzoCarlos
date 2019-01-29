using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvanceWebJakeRenzoCarlos.Web.ViewModels.Products
{
    public class CreateProductViewModel
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime PostExpiry { get; set; }
    }
}