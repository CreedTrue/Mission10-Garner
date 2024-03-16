using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace BowlingAPI.Data
{
    public class EFBowlerRepository : iBowlerRepository
    {
        private BowlerContext _bowlerContext;
        public EFBowlerRepository(BowlerContext temp)
        {
            _bowlerContext = temp;
        }

        // This method gets a list of bowlers from the Marlins and Sharks teams
        public IEnumerable<Bowler> Bowlers => _bowlerContext.Bowlers
            .Include(p => p.Team)
            .Where(b => b.Team != null && (b.Team.TeamName == "Marlins" || b.Team.TeamName == "Sharks"))
            .ToList();
    }
}
