using System;

namespace Lecture_4.OOP3
{
    class DatabaseLoggerService : ILoggerService {
        public void Log() {
            Console.WriteLine("Logged to the database.");
        }
    }
}