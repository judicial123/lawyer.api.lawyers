using MediatR;

namespace lawyer.api.shared.application.UseCases.Lawyer.Update;

public class UpdateLawyerCommand : IRequest<Guid>
{
    public Guid Id { get; set; }
    public Guid User { get; set; }
    public Guid LawFirmId { get; set; }
    public Guid City { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string CredentialNumber { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public string GoogleMapsAddress { get; set; } = string.Empty;
    public string SocialMediaLinks { get; set; } = string.Empty;
}