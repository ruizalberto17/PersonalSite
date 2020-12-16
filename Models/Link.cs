namespace PersonalSite.Models
{
    // Additional Challenge
    public class Link
    {
        public string URLPath { get; set; }
        public LinkType Type { get; set; }
        public Link(LinkType linkType, string urlPath)
        {
            Type = linkType;
            URLPath = urlPath;
        }
    }

    public enum LinkType
    {
        GitHub,
        LinkedIn
    }
}
