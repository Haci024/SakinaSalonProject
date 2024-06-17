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
    public class LazerMapper:Profile
    {
        public LazerMapper()
        {
            CreateMap<AddReservationDTO, LazerAppointment>();
            CreateMap<LazerAppointment, AddReservationDTO>();
            CreateMap<LazerReservationDTO, LazerAppointment>();
            CreateMap<AddReservationDTO, LazerReservationDTO>();
         

        }
    }
}
