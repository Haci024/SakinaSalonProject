using AutoMapper;
using DTO.DTOS.LazerAppointmentDTO;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.AutoMapper.LazerMapper
{
    public class AddReservationMapper:Profile
    {
        public AddReservationMapper()
        {
            CreateMap<AddReservationDTO, LazerAppointment>().ReverseMap();
            CreateMap<StartAppointmentDTO, LazerAppointment>().ReverseMap();
            CreateMap<AddReservationDTO, LazerAppointment>().ReverseMap();
            CreateMap<AddReservationDTO, LazerAppointment>().ReverseMap();
            CreateMap<AddReservationDTO, LazerAppointment>().ReverseMap();
            CreateMap<AddReservationDTO, LazerAppointment>().ReverseMap();

        }
    }
}
