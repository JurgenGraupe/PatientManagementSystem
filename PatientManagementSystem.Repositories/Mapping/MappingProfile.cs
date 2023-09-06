using AutoMapper;
using PatientManagementSystem.Data;
using PatientManagementSystem.Repositories.DomainModels;

namespace PatientManagementSystem.Repositories.Mapping {
    public class MappingProfile : Profile {
        public MappingProfile() {
            CreateMap<Debtor, DebtorDto>().ReverseMap();
        }
    }
}
