namespace Hotel.API.Entities
{
    public class Hotel : BaseEntity
    {
        public string AuthorizedFirstName { get; set; }
        public string AuthorizedLastName { get; set; }
        public string CompanyTitle { get; set; }
    }
}
