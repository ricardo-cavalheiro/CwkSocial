namespace CdkSocial.Domain.Aggregates.PostAggregate
{
    public class PostComment
    {
        public Guid Id { get; private set; }
        public Guid PostId { get; private set; }
        public string Text { get; private set; }
        public Guid UserProfileId { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime ModifiedAt { get; private set; }

        private PostComment() { }

        public static PostComment CreatePostComment(Guid postId, string text, Guid userProfileId)
        {
            var createdAt = DateTime.UtcNow;

            return new PostComment
            {
                PostId = postId,
                Text = text,
                UserProfileId = userProfileId,
                CreatedAt = createdAt,
                ModifiedAt = createdAt,
            };
        }

        public void UpdateCommentText(string newText)
        {
            Text = newText;
            ModifiedAt = DateTime.UtcNow;
        }
    }
}
