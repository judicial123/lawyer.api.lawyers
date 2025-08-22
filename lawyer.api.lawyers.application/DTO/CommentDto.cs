namespace lawyer.api.lawyers.application.DTO;

public class CommentDto
{
    public Guid Id { get; set; }
    public Guid IdUser { get; set; }
    public Guid IdLawFirm { get; set; }
    public string CommentMessage { get; set; } = string.Empty;
    public int Stars { get; set; }
}
