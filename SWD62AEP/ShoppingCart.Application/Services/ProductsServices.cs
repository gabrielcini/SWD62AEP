﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ShoppingCart.Application.Interfaces;
using ShoppingCart.Application.ViewModels;
using ShoppingCart.Domain.Interfaces;

namespace ShoppingCart.Application.Services
{
    public class ProductsServices : IProductsService
    {
        private IProductsRepository _productRepo;
        public ProductsServices(IProductsRepository productRepo)
        {
            _productRepo = productRepo;
        }
        public IQueryable<ProductViewModel> GetProducts()
        {
            var list = from p in _productRepo.GetProducts()
                       select new ProductViewModel()
                       {
                           Id = p.Id,
                           Name = p.Name,
                           Price = p.Price,
                           Description = p.Description,
                           ImageUrl = p.ImageUrl,
                           Category = new CategoryViewModel() { Id = p.Category.Id, Name = p.Category.Name }
                       };
            return list;
        }
    }
}