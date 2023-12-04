namespace WebApp.Models.Domain
{
    public class Project
    {
        public string Intro { get; set; }
        public string Skills { get; set; }
        public string RecentExperience { get; set; }

        public ICollection<Profile> Portfolio { get; set; }
    }
}
