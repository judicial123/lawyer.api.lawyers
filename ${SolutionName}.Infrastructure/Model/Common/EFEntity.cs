using System.ComponentModel.DataAnnotations.Schema;

namespace ${SolutionName}.Infrastructure.Model.Common;

public class EFEntity
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }

    public DateTime? DateCreated { get; set; }
    public DateTime? DateModified { get; set; }}