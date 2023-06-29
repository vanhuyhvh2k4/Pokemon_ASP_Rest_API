﻿using AutoMapper;
using PokemonReview.App.Dto;
using PokemonReview.App.Models;

namespace PokemonReview.App.Helper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Pokemon, PokemonDto>();
        }
    }
}