using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ValaisBookingV2.Models;

namespace ValaisBookingV2.EF
{
    public class EF_RoomManager
    {
        Modele_ValaisBookingContainer context = new Modele_ValaisBookingContainer();

        //Get all rooms
        public void GetAllRooms(){
            var q = from r in context.Rooms
                    select r;
        }

        public void GetRoom(int IdRoom)
        {
          

        }
    }
}