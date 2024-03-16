namespace BowlingAPI.Data
{
    public interface iBowlerRepository
    {
        IEnumerable<Bowler> Bowlers { get; }       
    }
}
