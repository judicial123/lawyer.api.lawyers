using ${SolutionName}.Domain.Common;

namespace ${SolutionName}.Domain;

public class AcademicInfo : BaseEntity
{
    public Guid LawyerId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Url { get; set; } = string.Empty;
}

