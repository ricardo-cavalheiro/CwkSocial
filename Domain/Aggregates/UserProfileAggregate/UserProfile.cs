namespace CdkSocial.Domain.Aggregates.UserProfileAggregate
{
    public class UserProfile
    {
        public Guid Id { get; private set; }
        public string IdentityId { get; private set; }
        public BasicInfo BasicInfo { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime LastModifiedAt { get; private set; }
        public string CurrentCity { get; private set; }

        private UserProfile() { }

        public static UserProfile CreateUserProfile(string identityId, BasicInfo basicInfo)
        {
            var createAt = DateTime.UtcNow;

            return new UserProfile()
            {
                IdentityId = identityId,
                BasicInfo = basicInfo,
                CreatedAt = createAt,
                LastModifiedAt = createAt
            };
        }

        public void UpdateBasicInfo(BasicInfo newInfo)
        {
            BasicInfo = newInfo;
            LastModifiedAt = DateTime.UtcNow;
        }
    }
}
