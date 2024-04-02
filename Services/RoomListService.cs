using Chat.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Services
{
    internal class RoomListService
    {
        public RoomListService() { }

        public IEnumerable<Room> GetListOfAllRooms()
        {
            using (var _dbContect = new ChatDbContext())
            { 
                var allRooms = _dbContect.Set<Room>()
                        .ToList();

                return allRooms;
            }
        }

    }
}
