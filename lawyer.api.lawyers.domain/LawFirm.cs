using lawyer.api.lawyers.domain.Common;

namespace lawyer.api.lawyers.domain;

public class LawFirm : BaseEntity
{
    public Guid IdCity { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public DateTime EntryDate { get; set; }
    public bool Active { get; set; }
    public string Address { get; set; } = string.Empty;
    public string GoogleMapsAddress { get; set; } = string.Empty;
    public string Biography { get; set; } = string.Empty;
    public string SocialMediaLinks { get; set; } = string.Empty;
    public List<Lawyer> Lawyers { get; set; } = new();
}
