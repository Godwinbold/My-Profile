namespace WebApp.Models.Domain
{
    public class Profile
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public ICollection<Project> Projects { get; set; }


    }
}
