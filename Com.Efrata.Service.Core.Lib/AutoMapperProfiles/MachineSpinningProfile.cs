﻿using AutoMapper;
using Com.Efrata.Service.Core.Lib.Models;
using Com.Efrata.Service.Core.Lib.ViewModels;

namespace Com.Efrata.Service.Core.Lib.AutoMapperProfiles
{
    public class MachineSpinningProfile : Profile
    {
        public MachineSpinningProfile()
        {
            CreateMap<MachineSpinningModel, MachineSpinningViewModel>()
                .ReverseMap();
            CreateMap<MachineSpinningProcessType, MachineSpinningProcessTypeViewModel>()
                .ReverseMap();
        }
    }
}
