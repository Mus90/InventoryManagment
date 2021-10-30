using AutoMapper;
using InventoryManagement.Models.Dtos;
using InventoryManagement.Models.Entities;

namespace InventoryManagement.Services
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductQueryResponseDto>();
            CreateMap<Invoice, InvoiceQueryResponseDto>();

            CreateMap<CreateProductDto, Product>();
            CreateMap<UpdateProductDto, Product>();
            CreateMap<CreateInvoiceDto, Invoice>();
            CreateMap<Invoice, InvoiceToPrintDto>();


            #region Frontend Mapping
            CreateMap<ProductQueryResponseDto, CreateProductDto>();
            CreateMap<ProductQueryResponseDto, UpdateProductDto>();
            CreateMap<ProductQueryResponseDto, ReStockProductRequestDto>();
            CreateMap<InvoiceQueryResponseDto, UpdateInvoiceDto>();
            #endregion

        }
    }
}
