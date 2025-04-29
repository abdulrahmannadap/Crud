namespace Crud.Dtos
{
    public class EmployeeCreateDto
    {
        public string EmpCode { get; set; }
        public string EmpName { get; set; }
        public string UserLogId { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string EmailAddress { get; set; }
        public DateTime CreateDateTime { get; set; }
    }
}
