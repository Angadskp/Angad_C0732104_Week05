using System;

namespace Angad_C0732104_Week05
{
    class Program
    {
        static void Main(string[] args)
        {
            Elevator e = new Elevator();
            e.setup();
            e.traverseList();
        }
    }

    class Node
    {
        public Node() { }
       
        public Node elevatorUP;
        public string FloorNumber;

    }
    class Department
    {
        public Department(string dept_name)
        {
            DepartmentDescription = dept_name;
        }
        public Department aDepartment;
        public string DepartmentDescription;

    }
    class DepartmentStore
    {
        public void initializedepartments()
        {
            Department Kitchenware = new Department("Kichtenware");
            Department Books = new Department("Books");

        }
    }

    class Elevator
    {
        Node Head;
        Node FirstFloor;
        Node SecondFloor;
        Node ThirdFloor;
        Node FourthFloor;

        public void setup()
        {
            FirstFloor = new Node();
            SecondFloor = new Node();
            ThirdFloor = new Node();
            FourthFloor = new Node();

            FirstFloor.FloorNumber = "First Floor";
            Console.WriteLine("Floor number is {0}", FirstFloor.FloorNumber);
            FirstFloor.elevatorUP = SecondFloor;
            SecondFloor.FloorNumber = "Second Floor";
            Console.WriteLine("Floor number is {0}", SecondFloor.FloorNumber);
            SecondFloor.elevatorUP = ThirdFloor;
            ThirdFloor.FloorNumber = "Third Floor";
            Console.WriteLine("Floor number is {0}", ThirdFloor.FloorNumber);
            ThirdFloor.elevatorUP = FourthFloor;
            FourthFloor.FloorNumber = "Fourth Floor";
            Console.WriteLine("Floor number is {0}", FourthFloor.FloorNumber);
            FourthFloor.elevatorUP = null;


        }

        public void traverseList()
        {
            Node temp;
            temp = Head;
            
            while (temp != null) 
            {
                Console.WriteLine(temp.FloorNumber);
                temp = Head.elevatorUP;
               
            }
        }
    }
}
