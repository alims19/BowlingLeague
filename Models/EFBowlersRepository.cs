using System;
using System.Linq;

namespace BowlingLeague.Models
{
    public class EFBowlersRepository : IBowlersRepository
    {
        private BowlingLeagueDbContext _context { get; set; }

        //Constructor
        public EFBowlersRepository(BowlingLeagueDbContext bl)
        {
            _context = bl;
        }

        public IQueryable<Bowler> Bowlers => _context.Bowlers;

        public IQueryable<Team> Teams => _context.Teams;

        public void AddBowler(Bowler b)
        {
            _context.Add(b);
            _context.SaveChanges();
        }

        public void DeleteBowler(Bowler b)
        {
            _context.Remove(b);
            _context.SaveChanges();
        }

        public void SaveBowler(Bowler b)
        {
            _context.Update(b);
            _context.SaveChanges();
        }
    }
}
