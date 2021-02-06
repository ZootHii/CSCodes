﻿using CSGameCompanyManagement.Entities;

namespace CSGameCompanyManagement.Abstracts
{
    public interface IProductService
    {
        void Add(Product product);
        void Sell(Product product, Customer customer);
    }
}