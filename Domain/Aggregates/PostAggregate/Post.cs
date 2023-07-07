using CdkSocial.Domain.Aggregates.UserProfileAggregate;

namespace CdkSocial.Domain.Aggregates.PostAggregate
{
    public class Post
    {
        public Guid Id { get; private set; }
        public Guid UserProfileId { get; private set; }
        public UserProfile UserProfile { get; private set; }
        public string TextContext { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime ModifiedAt { get; private set; }

        private readonly List<PostComment> _comments = new();
        public IEnumerable<PostComment> Comments
        {
            get { return _comments; }
        }

        private readonly List<PostInteraction> _interactions = new();
        public IEnumerable<PostInteraction> Interactions
        {
            get { return _interactions; }
        }

        private Post() { }

        public static Post CreatePost(Guid userProfileId, string textContent)
        {
            var createdAt = DateTime.UtcNow;

            return new Post
            {
                UserProfileId = userProfileId,
                TextContext = textContent,
                CreatedAt = createdAt,
                ModifiedAt = createdAt
            };
        }

        public void UpdatePostText(string nexText)
        {
            TextContext = nexText;
            ModifiedAt = DateTime.UtcNow;
        }

        public void AddPostComment(PostComment newComment)
        {
            _comments.Add(newComment);
        }

        public void RemovePostComment(PostComment toRemove)
        {
            _comments.Remove(toRemove);
        }

        public void AddInteraction(PostInteraction newInteraction)
        {
            _interactions.Add(newInteraction);
        }

        public void RemoveInteraction(PostInteraction toRemove)
        {
            _interactions.Remove(toRemove);
        }
    }
}
