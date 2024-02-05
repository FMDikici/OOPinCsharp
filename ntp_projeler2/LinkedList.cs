using System;

class CustomLinkedList
{
    private Node head;

    public void AddPassenger(string name, string surname, int age, string gender, bool hasTicket, string seatNumber, string entranceDoor)
    {
        Node newNode = new Node(name, surname, age, gender, hasTicket, seatNumber, entranceDoor);
        if (head == null)
        {
            head = newNode;
        }
        else
        {
            Node current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
    }

    public void DisplayPassengers()
    {
        Node current = head;
        int count = 1;
        while (current != null)
        {
            Console.WriteLine($"{count}. {current.Name} {current.Surname}, Age: {current.Age}, Gender: {current.Gender}, Ticket: {(current.HasTicket ? "Yes" : "No")}, {current.SeatNumber}, {current.EntranceDoor}");
            current = current.Next;
            count++;
        }
    }
}