using Domain.Interfaces.Generics;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.InterfaceProducts
{
    public interface IProduct : IGenerics<Products>
    {
        Task AddProduct(Products product);

        Task UpdateProduct(Products product);

        Task DeleteProduct(Products product);
    }
}
