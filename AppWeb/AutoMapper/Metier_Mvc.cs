using AppWeb.ViewModels;
using AutoMapper;
using ClassLibrary;

namespace AppWeb.AutoMapper
{
    public class Metier_Mvc : Profile
    {

        protected override void Configure()
        {
            Mapper.CreateMap<ClientViewModel, Client>();
            Mapper.CreateMap<EmployeViewModel, Employe>();
            Mapper.CreateMap<NatureColisViewModel, NatureColis>();
            Mapper.CreateMap<ColisViewModel, Colis>();
            Mapper.CreateMap<UserViewModel, User>();
            Mapper.CreateMap<TypeColisViewModel, TypeColis>();
            Mapper.CreateMap<TypeEmployeViewModel, TypeEmploye>();
            Mapper.CreateMap<VoieTransmissionViewModel, VoieTransmission>();
            Mapper.CreateMap<VilleViewModel, Ville>();
        }
    }
}