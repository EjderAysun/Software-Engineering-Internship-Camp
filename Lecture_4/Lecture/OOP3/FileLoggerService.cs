using System;

namespace Lecture_4.OOP3
{
    class FileLoggerService : ILoggerService {
        public void Log() {
            Console.WriteLine("Logged to the file.");
        }
    }
}