namespace CdkSocial.Domain.Aggregates.UserProfileAggregate
{
    public class BasicInfo
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public string Phone { get; private set; }
        public DateTime DateOfBirth { get; private set; }
        public string CurrentCity { get; private set; }

        private BasicInfo() { }

        public static BasicInfo CreateBasicInfo(
            string firstNaame,
            string lastName,
            string email,
            string phone,
            DateTime dateOfBirth,
            string currentCity
        )
        {
            return new BasicInfo
            {
                FirstName = firstNaame,
                LastName = lastName,
                Email = email,
                Phone = phone,
                DateOfBirth = dateOfBirth,
                CurrentCity = currentCity
            };
        }
    }
}
