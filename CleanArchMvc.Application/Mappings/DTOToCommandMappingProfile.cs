﻿using AutoMapper;
using CleanArchMvc.Domain.Entities;
using CleanArchMvc.Application.DTOs;
using CleanArchMvc.Application.Products.Commands;
using CleanArchMvc.Application.Products.Queries;

namespace CleanArchMvc.Application.Mappings
{
    public class DTOToCommandMappingProfile : Profile
    {
        public DTOToCommandMappingProfile()
        {
            CreateMap<ProductDTO, ProductCreateCommand>();
            CreateMap<ProductDTO, ProductUpdateCommand>();
            CreateMap<ProductDTO, GetProductsQuery>();
        }
    }
}
