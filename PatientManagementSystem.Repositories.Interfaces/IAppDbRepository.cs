using PatientManagementSystem.Data;

namespace PatientManagementSystem.Repositories.Interfaces {
    public interface IAppDbRepository {
        Task<bool> AddDebtorAsync(DebtorDto debtor);
        Task<List<DebtorDto>> GetDebtorsAsync();
    }
}