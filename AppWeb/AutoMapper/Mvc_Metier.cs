using AppWeb.ViewModels;
using AutoMapper;
using ClassLibrary;

namespace AppWeb.AutoMapper
{
    public class Mvc_Metier : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<Client,ClientViewModel>();
            Mapper.CreateMap<Employe, EmployeViewModel>();
            Mapper.CreateMap<NatureColis,NatureColisViewModel>();
            Mapper.CreateMap<Colis,ColisViewModel>();
            Mapper.CreateMap<User,UserViewModel>();
            Mapper.CreateMap<TypeColis,TypeColisViewModel>();
            Mapper.CreateMap<TypeEmploye,TypeEmployeViewModel>();
            Mapper.CreateMap<VoieTransmission,VoieTransmissionViewModel>();
            Mapper.CreateMap<Ville, VilleViewModel>();
        }

    }
}