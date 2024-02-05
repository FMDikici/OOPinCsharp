using System;

class Node
{
    public string Name ;
    public string Surname ;
    public int Age ;
    public string Gender ;
    public bool HasTicket ;
    public string SeatNumber ;
    public string EntranceDoor ;
    public Node Next ;

    public Node(string name, string surname, int age, string gender, bool hasTicket, string seatNumber, string entranceDoor)
    {
        Name = name;
        Surname = surname;
        Age = age;
        Gender = gender;
        HasTicket = hasTicket;
        SeatNumber = seatNumber;
        EntranceDoor = entranceDoor;
        Next = null;
    }
}
