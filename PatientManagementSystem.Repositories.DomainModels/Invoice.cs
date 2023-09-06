namespace PatientManagementSystem.Repositories.DomainModels {
    public class Invoice {
        public Guid Id { get; set; }
        public Guid AccountNumber { get; set; }
        public double Total { get; set; }
    }
}
