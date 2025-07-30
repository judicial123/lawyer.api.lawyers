using System.ComponentModel.DataAnnotations.Schema;
using lawyer.api.lawyers.datastore.mssql.Model.Common;

namespace lawyer.api.lawyers.datastore.mssql.Model;

[Table("Lawyers", Schema = "lawyer")]
public class LawyerEntity : EFEntity
{
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public Guid User { get; set; }
    public Guid LawFirmId { get; set; }
    public Guid City { get; set; }
    public string Name { get; set; }
    public string Title { get; set; }
    public string CredentialNumber { get; set; }
    public string Phone { get; set; }
    public string Address { get; set; }
    public string GoogleMapsAddress { get; set; }
    public string SocialMediaLinks { get; set; }
    
    [ForeignKey(nameof(LawFirmId))]
    public LawFirmEntity? LawFirm { get; set; }
}