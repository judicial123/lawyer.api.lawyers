using System.ComponentModel.DataAnnotations.Schema;
using ${SolutionName}.Infrastructure.Model.Common;

namespace ${SolutionName}.Infrastructure.Model;

[Table("Examples")]
public class ExampleEntity : EFEntity
{
    public string PropertyOne { get; set; }
    public string PropertyTwo { get; set; }
}
