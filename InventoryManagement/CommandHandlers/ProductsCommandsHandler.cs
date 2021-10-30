using AutoMapper;
using InventoryManagement.Models;
using InventoryManagement.Models.Dtos;
using InventoryManagement.Models.Entities;
using InventoryManagement.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagement.CommandHandlers
{
    public class ProductsCommandsHandler : IProductsCommandsHandler
    {
        private readonly ProductRepository _productRepo;
        private IMapper _mapper;
        public ProductsCommandsHandler(ProductRepository ProductRepo, IMapper mapper)
        {
            _productRepo = ProductRepo;
            _mapper = mapper;
        }

        public async Task<ActionResponseDto> CreateProduct(CreateProductDto input)
        {
            var product = _mapper.Map<Product>(input);
            var result = await _productRepo.CreateAsync(product);
            return result;
        }

        public async Task<ActionResponseDto> UpdateProduct(UpdateProductDto input)
        {
            var product = _productRepo.Find(input.Id);
            var mapped = _mapper.Map(input, product);
            var result = await _productRepo.UpdateAsync(mapped);
            return result;
        }

        public async Task<ActionResponseDto> RestockProduct(int productId, int quantity)
        {
            var product = _productRepo.Find(productId);
            product.UnitsInStock += quantity; ;
            var result = await _productRepo.UpdateAsync(product);
            return result;
        }

        public async Task<ActionResponseDto> DeleteProduct(int Id)
        {
            var product = _productRepo.Find(Id);
            var result = await _productRepo.RemoveAsync(product);
            return result;
        }
    }
}
