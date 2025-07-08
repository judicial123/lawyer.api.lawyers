using System.ComponentModel.DataAnnotations.Schema;
using lawyer.api.lawyers.datastore.mssql.Model.Common;

namespace lawyer.api.lawyers.datastore.mssql.Model;

[Table("AcademicInfo")]
public class AcademicInfoEntity : EFEntity
{
    public Guid LawyerId { get; set; }
    public string Name { get; set; }
    public string Url { get; set; }
}

