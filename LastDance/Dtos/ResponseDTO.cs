namespace LastDance.Dtos
{
    public class ResponseDTO
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Department { get; set; }

        public DateTime DateRegistered { get; set; } = DateTime.Now;
        public int Salary { get; set; } = 30000;

    }
}
