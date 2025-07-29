using System.ComponentModel.DataAnnotations.Schema;
using lawyer.api.lawyers.datastore.mssql.Model.Common;

namespace lawyer.api.lawyers.datastore.mssql.Model;

[Table("LawFirms")]
public class LawFirmEntity : EFEntity
{
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public Guid IdCity { get; set; }
    public string Name { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public DateTime EntryDate { get; set; }
    public bool Active { get; set; }
    public string Address { get; set; }
    public string GoogleMapsAddress { get; set; }
    public string Biography { get; set; }
    public string SocialMediaLinks { get; set; }
}
