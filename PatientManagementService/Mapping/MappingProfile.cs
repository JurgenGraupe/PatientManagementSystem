using AutoMapper;
using PatientManagementService.ViewModels;
using PatientManagementSystem.Data;

namespace PatientManagementService.Mapping {
    public class MappingProfile : Profile {
        public MappingProfile() {
            CreateMap<DebtorViewModel, DebtorDto>().ReverseMap();
        }
    }
}
