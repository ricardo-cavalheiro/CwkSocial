using CdkSocial.Domain.Aggregates.UserProfileAggregate;

namespace Api.Interfaces.UserProfile.Responses
{
    public record UserProfileResponse
    {
        public Guid Id { get; set; }
        public BasicInfo BasicInfo { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastModifiedAt { get; set; }
    }
}
