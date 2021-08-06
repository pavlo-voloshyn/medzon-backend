using Api.ViewModels;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Services.DTOs;
using System;

namespace Api.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<FreshUserView, FreshUserDTO>();
            CreateMap<FreshUserDTO, IdentityUser>()
                .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.Phone))
                .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.Email))
                .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.Phone));
            CreateMap<FreshUserDTO, Patient>();
            CreateMap<UserPassView, UserPassDTO>();
            CreateMap<AppointmentView, AppointmentDTO>()
                .ForMember(dest => dest.Date, opt => opt.MapFrom(src => DateTime.Parse(src.Date)))
                .ForMember(dest => dest.ClinicaId, opt => opt.MapFrom(src => Guid.Parse(src.ClinicaId)))
                .ForMember(dest => dest.DoctorId, opt => opt.MapFrom(src => Guid.Parse(src.DoctorId)))
                .ForMember(dest => dest.PatientId, opt => opt.MapFrom(src => Guid.Parse(src.PatientId)));
            CreateMap<UpdateAppointmentView, UpdateAppointmentDTO>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => Guid.Parse(src.Id)))
                .ForMember(dest => dest.Date, opt => opt.MapFrom(src => DateTime.Parse(src.Date)));
            CreateMap<Appointment, AppointmentToFrontDTO>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id.ToString()))
                .ForMember(dest => dest.Clinica, opt => opt.MapFrom(src => src.Clinica.Id.ToString()))
                .ForMember(dest => dest.Patient, opt => opt.MapFrom(src => src.Patient.Id.ToString()))
                .ForMember(dest => dest.Doctor, opt => opt.MapFrom(src => src.Doctor.Id.ToString()))
                .ForMember(dest => dest.Date, opt => opt.MapFrom(src => src.Date.ToString()));
        }
    }
}
