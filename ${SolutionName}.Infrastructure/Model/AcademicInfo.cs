using System.ComponentModel.DataAnnotations.Schema;
using ${SolutionName}.Infrastructure.Model.Common;

namespace ${SolutionName}.Infrastructure.Model;

[Table("AcademicInfo")]
public class AcademicInfoEntity : EFEntity
{
    public Guid LawyerId { get; set; }
    public string Name { get; set; }
    public string Url { get; set; }
}

