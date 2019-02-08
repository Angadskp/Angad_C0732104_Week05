using System;

namespace Angad_C0732104_Week05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
        }
    }

    class Node
    {
        public Node() { }
        public Node floor;
        public Node elevatorUP;
        public string FloorNumber;

    }

    class Elevator
    {
        Node FirstFloor;
        Node SecondFloor;
        Node ThirdFloor;
        Node FourthFloor;

        public void run()
        {
            FirstFloor = new Node();
            FirstFloor.FloorNumber = "First Floor";
            Console.WriteLine("Floor number is {0}", FirstFloor.FloorNumber);
            FirstFloor.elevatorUP = SecondFloor;
            SecondFloor.FloorNumber = "Second Floor";

            Console.WriteLine("Floor number is {0}", SecondFloor.FloorNumber);
            
        }
    }
}
