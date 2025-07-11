using System.ComponentModel.DataAnnotations.Schema;
using lawyer.api.lawyers.datastore.mssql.Model.Common;

namespace lawyer.api.lawyers.datastore.mssql.Model;

[Table("Lawyers")]
public class LawyerEntity : EFEntity
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid User { get; set; }

    public Guid Studio { get; set; }
    public Guid City { get; set; }
    public string Name { get; set; }
    public string Title { get; set; }
    public string CredentialNumber { get; set; }
    public string Phone { get; set; }
    public string Address { get; set; }
    public string GoogleMapsAddress { get; set; }
    public string SocialMediaLinks { get; set; }
}