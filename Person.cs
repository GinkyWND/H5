namespace MyBusinessCard.Models
{
    public class Person
    {
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Description { get; set; }

        public int GetAge()
        {
            return DateTime.Today.Year - BirthDate.Year;
        }
    }
}
