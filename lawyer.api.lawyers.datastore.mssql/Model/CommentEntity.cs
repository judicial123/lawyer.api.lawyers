using System.ComponentModel.DataAnnotations.Schema;
using lawyer.api.lawyers.datastore.mssql.Model.Common;

namespace lawyer.api.lawyers.datastore.mssql.Model;

[Table("Comments", Schema = "lawyer")]
public class CommentEntity : EFEntity
{
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public Guid IdUser { get; set; }
    public Guid IdLawFirm { get; set; }
    public string CommentMessage { get; set; }
    public int Stars { get; set; }

    [ForeignKey(nameof(IdLawFirm))]
    public LawFirmEntity? LawFirm { get; set; }
}
