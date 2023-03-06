namespace Mphomoses.Models
{
    public class Learners
    {
        public long LearnersId { get; set; }
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public string LearnersName { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public string LearnersSurname { get; set; }
        public string LearnersIdentityNumber { get; set; }
    }
}
