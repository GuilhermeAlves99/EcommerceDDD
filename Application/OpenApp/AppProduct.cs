using ApplicationApp.Interfaces;
using Domain.Interfaces.InterfaceProducts;
using Domain.Interfaces.InterfaceServices;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationApp.OpenApp
{
    public class AppProduct : InterfaceProductApp
    {
        IProduct _IProduct;
        IServiceProduct _IServiceProduct;
        public AppProduct(IProduct IProduct, IServiceProduct IServiceProduct) 
        {
            _IProduct = IProduct;
            _IServiceProduct = IServiceProduct;
        }
        public async Task AddProduct(Products product)
        {
            await _IServiceProduct.AddProduct(product);
        }
        public async Task UpdateProduct(Products product)
        {
            await _IServiceProduct.UpdateProduct(product);
        }
        public async Task Add(Products product)
        {
            await _IProduct.Add(product);
        }
        public async Task<Products> GetEntityById(int Id)
        {
           return await _IProduct.GetEntityById(Id);
        }

        public Task<List<Products>> List() 
        {
            throw new NotImplementedException();
        }

        public async Task Delete(Products product)
        {
            await _IProduct.Delete(product);
        }

        public async Task Update(Products product)
        {
            await _IProduct.Update(product);
        }

        public Task Remove(Products Object)
        {
            throw new NotImplementedException();
        }
    }
}
