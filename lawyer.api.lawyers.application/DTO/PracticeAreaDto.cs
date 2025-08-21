namespace lawyer.api.lawyers.application.DTO;

public class PracticeAreaDto
{
    public Guid Id { get; set; }
    public Guid IdCountry { get; set; }
    public string TechnicalName { get; set; } = string.Empty;
    public string CommonName { get; set; } = string.Empty;
}
