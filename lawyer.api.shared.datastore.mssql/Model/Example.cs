using System.ComponentModel.DataAnnotations.Schema;
using lawyer.api.shared.datastore.mssql.Model.Common;

namespace lawyer.api.shared.datastore.mssql.Model;

[Table("Examples", Schema = "lawyer")]
public class ExampleEntity : EFEntity
{
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public string PropertyOne { get; set; }
    public string PropertyTwo { get; set; }
}
