﻿using AutoMapper;
using IdentityServer4.Models;

namespace IdentityServer4.Postgresql.Mappers
{
    public static class ClientMapper
    {
        static ClientMapper()
        {
            Mapper = new MapperConfiguration(config =>
            {
                config.CreateMap<Entities.Client, Client>(MemberList.Destination).ReverseMap();
                    
            }).CreateMapper();
        }
        public static IMapper Mapper { get; }
        public static Client ToModel(this Entities.Client client)
        {
            return Mapper.Map<Entities.Client, Client>(client);
        }

        public static Entities.Client ToEntity(this Client client)
        {
            return Mapper.Map<Client, Entities.Client>(client);
        }
    }
}
