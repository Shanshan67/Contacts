namespace ContactsAPI.Models
{
    public class AddContactRequest//to get only certain fields from store it in the database
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public long Phone { get; set; }
        public string Address { get; set; }
    }
}
