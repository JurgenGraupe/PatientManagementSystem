using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PatientManagementSystem.Data;
using PatientManagementSystem.Repositories.DomainModels;
using PatientManagementSystem.Repositories.Interfaces;

namespace PatientManagementSystem.Repositories {
    public class AppDbRepository : IAppDbRepository {
        private readonly IMapper mapper;
        private readonly IDbContextFactory<AppDbContext> contextFactory;

        public AppDbRepository(IMapper mapper, IDbContextFactory<AppDbContext> contextFactory) {
            this.contextFactory = contextFactory;
            this.mapper = mapper;
        }

        public async Task<bool> AddDebtorAsync(DebtorDto debtor) {
            using var db = contextFactory.CreateDbContext();
            db.Debtors.Add(mapper.Map<Debtor>(debtor));
            await db.SaveChangesAsync();
            return true;
        }

        public async Task<List<DebtorDto>> GetDebtorsAsync() {
            using var db = contextFactory.CreateDbContext();
            var debtors = await db.Debtors.ToListAsync();
            return mapper.Map<List<DebtorDto>>(debtors);
        }
    }
}
