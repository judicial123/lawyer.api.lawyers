namespace lawyer.api.shared.application.DTO;

public class LawyerQueryDto : LawyerDto
{
    public List<AcademicInfoDto> AcademicInfos { get; set; } = new();
}