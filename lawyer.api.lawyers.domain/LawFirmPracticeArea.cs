using lawyer.api.lawyers.domain.Common;

namespace lawyer.api.lawyers.domain;

public class LawFirmPracticeArea : BaseEntity
{
    public Guid IdLawFirm { get; set; }
    public Guid IdPracticeArea { get; set; }

    public LawFirm? LawFirm { get; set; }
    public PracticeArea? PracticeArea { get; set; }
}

