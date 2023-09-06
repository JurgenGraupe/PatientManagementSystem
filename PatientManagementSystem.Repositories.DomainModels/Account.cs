namespace PatientManagementSystem.Repositories.DomainModels {
    public class Account {
        public Guid Id { get; set; }
        public long AccountNumber { get; set; }
        public double Credit { get; set; }
        public double Debit { get; set; }        
    }
}
