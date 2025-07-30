using System.ComponentModel.DataAnnotations.Schema;
using lawyer.api.lawyers.datastore.mssql.Model.Common;

namespace lawyer.api.lawyers.datastore.mssql.Model;

[Table("Examples", Schema = "lawyer")]
public class ExampleEntity : EFEntity
{
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public string PropertyOne { get; set; }
    public string PropertyTwo { get; set; }
}
