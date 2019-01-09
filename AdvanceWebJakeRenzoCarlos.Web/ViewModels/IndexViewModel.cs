using AdvanceWebJakeRenzoCarlos.Web.Infrastructures.Data.Helpers;
using AdvanceWebJakeRenzoCarlos.Web.Infrastructures.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvanceWebJakeRenzoCarlos.Web.ViewModels
{
    public class IndexViewModel
    {
        public Page<User> Users { get; set; }
    }
}
