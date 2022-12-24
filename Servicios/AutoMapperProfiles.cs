using AutoMapper;
using Tareas1MVC.Entidades;
using Tareas1MVC.Models;

namespace Tareas1MVC.Servicios
{
    public class AutoMapperProfiles: Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Tarea, TareaDTO>();
        }
    }
}
