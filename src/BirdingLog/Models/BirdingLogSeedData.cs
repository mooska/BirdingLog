using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BirdingLog.Models
{
    public class BirdingLogSeedData
    {
        private BirdingLogContext _context;

        public BirdingLogSeedData(BirdingLogContext context)
        {
            _context = context;
        }

        public async Task EnsureSeedData()
        {
            if (!_context.Photos.Any())
            {
                // var 
            }
        }
    }
}
