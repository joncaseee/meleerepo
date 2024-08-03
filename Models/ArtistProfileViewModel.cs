public class ArtistProfileViewModel
{
    public string Alias { get; set; } = string.Empty;
    public string PhotoUrl { get; set; } = string.Empty;
    public string[] SocialLinks { get; set; } = Array.Empty<string>(); // Initialize to an empty array
    public string EmbeddedContent { get; set; } = string.Empty;

    public string[] StreamingLinks { get; set; }  = Array.Empty<string>(); // Initialize to an empty array
}
