namespace modul9_1302210094
{
    public class Moviee
    {
        public string Title { get; private set; }
        public string Director { get; private set; }
        public List<string> Stars { get; private set; }
        public string Description { get; private set; }

        public Moviee(string title, string director, List<string> stars, string description)
        {
            this.Title = title;
            this.Director = director;
            this.Stars = stars;
            this.Description = description;
        }
    }
}
