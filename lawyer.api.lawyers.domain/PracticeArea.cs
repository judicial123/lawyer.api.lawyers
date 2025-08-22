using lawyer.api.lawyers.domain.Common;

namespace lawyer.api.lawyers.domain;

public class PracticeArea : BaseEntity
{
    public Guid IdCountry { get; set; }
    public string TechnicalName { get; set; } = string.Empty;
    public string CommonName { get; set; } = string.Empty;
    public List<LawFirmPracticeArea> LawFirmPracticeAreas { get; set; } = new();
}
