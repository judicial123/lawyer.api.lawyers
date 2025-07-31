namespace lawyer.api.lawyers.application.DTO;

public class LawFirmQueryDto: LawFirmDto
{
    public List<LawyerDto> Lawyers { get; set; } = new();
}
