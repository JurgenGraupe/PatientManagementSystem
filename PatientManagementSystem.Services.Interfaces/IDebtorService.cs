using PatientManagementSystem.Data;

namespace PatientManagementSystem.Services.Interfaces {
    public interface IDebtorService {
        Task<List<DebtorDto>> GetDebtorsAsync();
    }
}