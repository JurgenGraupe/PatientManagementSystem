namespace PatientManagementSystem.Repositories.DomainModels {
    public class Debtor {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public List<Patient> Patients { get; set; }
    }
}