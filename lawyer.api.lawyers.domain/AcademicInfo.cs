using lawyer.api.lawyers.domain.Common;

namespace lawyer.api.lawyers.domain;

public class AcademicInfo : BaseEntity
{
    public Guid LawyerId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Url { get; set; } = string.Empty;
}

