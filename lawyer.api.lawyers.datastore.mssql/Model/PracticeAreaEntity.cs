using System.ComponentModel.DataAnnotations.Schema;
using lawyer.api.lawyers.datastore.mssql.Model.Common;

namespace lawyer.api.lawyers.datastore.mssql.Model;

[Table("PracticeAreas", Schema = "lawyer")]
public class PracticeAreaEntity : EFEntity
{
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public Guid IdCountry { get; set; }
    public string TechnicalName { get; set; }
    public string CommonName { get; set; }
    public ICollection<LawFirmPracticeAreaEntity> LawFirmPracticeAreas { get; set; } = new List<LawFirmPracticeAreaEntity>();
}
