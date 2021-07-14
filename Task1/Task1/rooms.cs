
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
        private static readonly  List<Rooms> _availableRooms = new List<Rooms>();
        private static readonly List<Rooms> _reservedRooms = new List<Rooms>();

        public Rooms(Courses course)
        {
            if (course == null)
            {
                return;
            }
            roomsManager = new Teacher("Hamza", new DateTime(1990, 1, 1), 21379723);
            this.course = course;
            roomsAccount = new CurrentAccount(roomsManager);

        }

        private Rooms()
        {
            roomsManager = new Teacher("Hamza", new DateTime(1990, 1, 1), 21379723);
            roomsAccount = new CurrentAccount(roomsManager);


        }




        public void addRoom()
        {
            _availableRooms.Add(new Rooms());

        }

        public void reserveRoom(int courseId)
        {
            if (_availableRooms.Count == 0) return;

            if (course.GeTeacher().getAccount().Balance > roomPrice)
            {
                course.GeTeacher().getAccount().Pay(roomPrice, roomsAccount);
                _availableRooms.Last().course = course.getCourse(courseId);


                _reservedRooms.Add(_availableRooms.Last());
                _availableRooms.Remove(_availableRooms.Last());

            }

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

        public List<Rooms> GetReservedRooms()
        {
            return _reservedRooms;
        }
    }
}