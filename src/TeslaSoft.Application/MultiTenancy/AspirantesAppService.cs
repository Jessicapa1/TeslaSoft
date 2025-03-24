using Abp.Application.Services;
using Abp.Domain.Repositories;
using TeslaSoft.MultiTenancy.Dto;
using TeslaSoft.Entities;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;

namespace TeslaSoft.MultiTenancy
{
    public class AspirantesAppService : AsyncCrudAppService<Aspirantes, AspiranteDto, long, PagedTenantResultRequestDto, CreateAspiranteDto, AspiranteDto>
    {
        public AspirantesAppService(IRepository<Aspirantes, long> repository) : base (repository)
        {
            
        }
    }

    [AutoMapFrom(typeof(Aspirantes))]
    public class AspiranteDto : EntityDto<long>
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public DateTime FechaDeNacimiento { get; set; }
        public long DocumentNumber { get; set; }
    }

    [AutoMapTo(typeof(Aspirantes))]
    public class CreateAspiranteDto
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public DateTime FechaDeNacimiento { get; set; }
        public long DocumentNumber { get; set; }
    }
}

