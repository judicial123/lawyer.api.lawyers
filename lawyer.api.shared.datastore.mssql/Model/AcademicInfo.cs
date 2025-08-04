using System.ComponentModel.DataAnnotations.Schema;
using lawyer.api.shared.datastore.mssql.Model.Common;

namespace lawyer.api.shared.datastore.mssql.Model;

[Table("AcademicInfo", Schema = "lawyer")]
public class AcademicInfoEntity : EFEntity
{
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public Guid LawyerId { get; set; }
    public string Name { get; set; }
    public string Url { get; set; }
    
    [ForeignKey(nameof(LawyerId))]
    public LawyerEntity? Lawyer { get; set; }
}

