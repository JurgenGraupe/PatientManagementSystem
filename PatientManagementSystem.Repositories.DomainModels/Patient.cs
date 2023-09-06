namespace PatientManagementSystem.Repositories.DomainModels {
    public class Patient {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Debtor Debtor { get; set; }
    }
}
