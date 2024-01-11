using Domain.Interfaces.InterfaceProducts;
using Domain.Interfaces.InterfaceServices;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class ServiceProduct : IServiceProduct
    {
        private readonly IProduct _IProduct;
        public ServiceProduct(IProduct IProduct) 
        {
            _IProduct = IProduct;
        }

        public async Task AddProduct(Products product)
        {
            var validateName = product.ValidatePropartiesString(product.Name, "Name");

            var validateValue = product.ValidatePropertiesDecimal(product.Value, "Value");

            if (validateName && validateValue) 
            {
                product.Status = true;
                await _IProduct.Add(product);
            }
        }

        public async Task UpdateProduct(Products product)
        {
            var validateName = product.ValidatePropartiesString(product.Name, "Name");

            var validateValue = product.ValidatePropertiesDecimal(product.Value, "Value");

            if (validateName && validateValue)
            {
                await _IProduct.Update(product);
            }
        }
    }
}
