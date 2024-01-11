using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.InterfaceServices
{
    /// <summary>
    /// Colocaremos aqui as regras de negócio para a interação dos CRUD'S
    /// com os produtos na base de dados
    /// </summary>
    public interface IServiceProduct
    {
        Task AddProduct(Products product);

        Task UpdateProduct(Products product);
    }
}
