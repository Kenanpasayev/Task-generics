using ConsoleApp15.exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Hotel
    {
        public string name;
        List<Room> rooms;

        public string Name;

        public Hotel(string name)
        {
            Name = name;
            rooms = new List<Room>();
        }
        public void AddRoom(Room room)
        {
            rooms.Add(room);
            Console.WriteLine("room elave olundu");
        }
        public List<Room> GetAllRooms()
        {
            return rooms;
        }
        public void MakeReservation(int? roomId)
        {
            Room room = rooms.Find(x => x.Id == roomId);
            if (roomId == null)
            {
                throw new NullReferenceException("Roomid null olmamalidir");
            }


            if (room.IsAvailable)
            {
                throw new Exception("Otaq yoxdur");
                room.IsAvailable = false;

            }
            else
            {
                throw new NotAvailableException("otaq tapilmadi");
            }

        }
    }
}

