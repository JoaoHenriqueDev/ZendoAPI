using AutoMapper;
using ZendoAPI.Models.Domain;
using ZendoAPI.Models.Dto;

namespace ZendoAPI.Mapper
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Usuario, UsuarioDto>().ReverseMap();
            CreateMap<Ticket, TicketDto>().ReverseMap();
            CreateMap<Comentario, ComentarioDto>().ReverseMap();
        }
    }
}
