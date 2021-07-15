
using System;
using System.Collections.Generic;
using System.Linq;

namespace Task1
{
    public class Rooms
    {

        private const double roomPrice = 399.99;
        private Teacher roomsManager;
        private CurrentAccount roomsAccount;
        private Courses course;
        private static readonly List<Rooms> _availableRooms = new List<Rooms>();
        private static readonly List<Rooms> _reservedRooms = new List<Rooms>();

        public Rooms(Courses course)
        {
            if (course == null)
            {
                return;
            }
            addRoom(100);
           
            roomsManager = new Teacher("Hamza", new DateTime(1990, 1, 1), 21379723);
            this.course = course;
            roomsAccount = new CurrentAccount(roomsManager);

        }

        private Rooms()
        {
            roomsManager = new Teacher("Hamza", new DateTime(1990, 1, 1), 21379723);
            roomsAccount = new CurrentAccount(roomsManager);


        }




        public void addRoom(int toAdd)
        {
            for (int i = 0; i < toAdd; i++)
            {
                _availableRooms.Add(new Rooms());

            }

        }

        public Rooms reserveRoom(int courseId)
        {
            Rooms reserverRoom = null;
            if (getAvailableRooms() == 0) throw new NoFreeRoomsAvailableException() ;

            if (course.GeTeacher().getAccount().Balance > roomPrice)
            {
                course.GeTeacher().getAccount().Pay(roomPrice, roomsAccount);
                _availableRooms.Last().course = course.getCourse(courseId);


                _reservedRooms.Add(_availableRooms.Last());
                 reserverRoom = _availableRooms.Last();
                _availableRooms.Remove(_availableRooms.Last());

            }
            else
            {
                Console.WriteLine("You Don't have enough money to reserve a Room");
            }
            return reserverRoom;

        }

        public void FreeRoom(int courseId)
        {
            Rooms targetedRoom = null;
            foreach (var room in _reservedRooms)
            {
                if (room.course.getCourse(courseId) != null)
                {
                    targetedRoom = room;
                    break;
                }

            }

            if (targetedRoom != null)
            {
                _availableRooms.Add(targetedRoom);
                _reservedRooms.Remove(targetedRoom);
                Console.WriteLine("Room is free now");

            }
            else
            {
                Console.WriteLine("Room with this course does not exist");
            }
        }

        private int getAvailableRooms()
        {
            int freeRooms = 0;
            foreach (var room in _availableRooms)
            {
                if (room.course == null)
                    freeRooms++;

            }

            return freeRooms;
        }

        public List<Rooms> GetReservedRooms()
        {
            return _reservedRooms;
        }
    }
}