using System.ComponentModel.DataAnnotations.Schema;
using lawyer.api.lawyers.datastore.mssql.Model.Common;

namespace lawyer.api.lawyers.datastore.mssql.Model;

[Table("LawFirmPracticeAreas", Schema = "lawyer")]
public class LawFirmPracticeAreaEntity : EFEntity
{
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public Guid IdLawFirm { get; set; }
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public Guid IdPracticeArea { get; set; }

    [ForeignKey(nameof(IdLawFirm))]
    public LawFirmEntity? LawFirm { get; set; }
    [ForeignKey(nameof(IdPracticeArea))]
    public PracticeAreaEntity? PracticeArea { get; set; }
}

