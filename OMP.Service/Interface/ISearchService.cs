﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMP.Service.Interface
{
    public interface ISearchService
    {
        void StoreSearchProduct(int productID, string userName);
    }
}
