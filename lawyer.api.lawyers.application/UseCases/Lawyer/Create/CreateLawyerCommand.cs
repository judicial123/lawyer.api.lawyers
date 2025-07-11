using MediatR;

namespace lawyer.api.lawyers.application.UseCases.Lawyer.Create;

public class CreateLawyerCommand : IRequest<Guid>
{
    public Guid User { get; set; }
    public Guid Studio { get; set; }
    public Guid City { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string CredentialNumber { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public string GoogleMapsAddress { get; set; } = string.Empty;
    public string SocialMediaLinks { get; set; } = string.Empty;
}