﻿using ProductsContracts.BindingModels;
using ProductsContracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsContracts.Storage
{
    public interface IProductStorage
    {
        List<ProductViewModel> GetFullList();

        List<ProductViewModel> GetFilteredList(ProductBindingModel model);

        ProductViewModel GetElement(ProductBindingModel model);

        void Insert(ProductBindingModel model);

        void Update(ProductBindingModel model);

        void Delete(ProductBindingModel model);
    }
}
