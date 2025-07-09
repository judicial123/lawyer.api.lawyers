namespace ${SolutionName}.Application.DTO;

public class AcademicInfoDto
{
    public Guid Id { get; set; }
    public Guid LawyerId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Url { get; set; } = string.Empty;
}
