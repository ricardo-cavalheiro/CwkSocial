namespace CdkSocial.Domain.Aggregates.PostAggregate
{
    public class PostInteraction
    {
        public Guid Id { get; private set; }
        public Guid PostId { get; private set; }
        public EInteraction InteractionType { get; private set; }

        private PostInteraction() { }

        public static PostInteraction CreatePostInteraction(Guid postId, EInteraction type)
        {
            return new PostInteraction { PostId = postId, InteractionType = type };
        }
    }
}
