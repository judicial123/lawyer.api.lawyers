namespace lawyer.api.lawyers.application.DTO;

public class LawyerQueryDto : LawyerDto
{
    public List<AcademicInfoDto> AcademicInfos { get; set; } = new();
}