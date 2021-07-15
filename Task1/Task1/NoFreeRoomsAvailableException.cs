using System;

namespace Task1
{
    public class NoFreeRoomsAvailableException : Exception
    {
        public NoFreeRoomsAvailableException(string message) : base(message) { }

        public NoFreeRoomsAvailableException():base(message: "There is no Free Rooms Available Right now ") { }
    }
}