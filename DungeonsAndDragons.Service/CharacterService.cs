using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonsAndDragons.Data;

namespace DungeonsAndDragons.Service
{
    public class CharacterService
    {
        //dependencies
        private readonly Guid _userId;
        private readonly ApplicationDbContext _ctx;

        public CharacterService(Guid userId, ApplicationDbContext context)
        {
            _userId = userId;
            _ctx = context;
        }
    }
}
