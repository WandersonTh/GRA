namespace GRA.Domain.Entities
{
    public class AwardsInterval
    {
        public AwardsInterval(string producer, int interval, int previousWin, int followingWin)
        {
            Producer = producer;
            Interval = interval;
            PreviousWin = previousWin;
            FollowingWin = followingWin;
        }

        public string Producer { get; }
        public int Interval { get; }
        public int PreviousWin { get; }
        public int FollowingWin { get; }
    }
}
