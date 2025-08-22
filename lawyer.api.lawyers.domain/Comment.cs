using lawyer.api.lawyers.domain.Common;

namespace lawyer.api.lawyers.domain;

public class Comment : BaseEntity
{
    public Guid IdUser { get; set; }
    public Guid IdLawFirm { get; set; }
    public string CommentMessage { get; set; } = string.Empty;
    public int Stars { get; set; }

    public LawFirm? LawFirm { get; set; }
}
