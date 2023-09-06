using PatientManagementSystem.Data;
using PatientManagementSystem.Repositories.Interfaces;
using PatientManagementSystem.Services.Interfaces;

namespace PatientManagementSystem.Services {
    public class DebtorService : IDebtorService {
        private readonly IAppDbRepository appDbRepository;

        public async Task<List<DebtorDto>> GetDebtorsAsync() =>
            await appDbRepository.GetDebtorsAsync();

        public async Task<bool> AddDebtorAsync(DebtorDto debtor) =>
            await appDbRepository.AddDebtorAsync(debtor);
    }
}