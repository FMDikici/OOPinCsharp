using ntp_projeler2;
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] seatNumbers = new int[40];
        for (int i = 0; i < 40; i++)
        {
            seatNumbers[i] = -1;
        }

        Random rand = new Random();

        List<Passengers> passengers = new List<Passengers>();

        string[] maleNames = { "Ahmet", "Mehmet", "Mustafa", "Ali", "Osman","Fatih", "Levent", "Gökhan", "İbrahim", "Esad", "Batuhan" }; // Erkek isimleri
        string[] femaleNames = { "Ayşe", "Fatma", "Zeynep", "Emine", "Havva", "İrem", "Gizem", "Sude", "Sıla", "Zehra", "Sümeyye", "Merve" }; // Kadın isimleri
        string[] surnames = { "Yılmaz", "Kaya", "Demir", "Acar", "Şahin", "Demirkol", "Dikici", "Aslan", "Ateş", "Güneş", "Şimşek" }; // Ortak surnames

        for (int i = 0; i < 15; i++) // ilk kapıdan girenler için
        {
            string a = (i % 2 == 0) ? "Man" : "Woman";
            int c;
            do
            {
                int seatNumber = rand.Next(1, 41);
                c = seatNumber;
            } while (seatNumbers.Contains(c) || c < 1 || c > 40);
            seatNumbers[c - 1] = c;

            string randomIsim = (a == "Man") ? maleNames[rand.Next(maleNames.Length)] : femaleNames[rand.Next(femaleNames.Length)];
            string randomSoyisim = surnames[rand.Next(surnames.Length)];

            passengers.Add(new Passengers(randomIsim, randomSoyisim, i + 20, a, true, "Seat Number: " + c, "Front Door"));
        }

        for (int i = 0; i < 10; i++) // ikinci kapıdan girenler için
        {
            string a = (i % 2 == 0) ? "Man" : "Woman";
            int c;
            do
            {
                int seatNumber = rand.Next(1, 41);
                c = seatNumber;
            } while (seatNumbers.Contains(c) || c < 1 || c > 40);
            seatNumbers[c - 1] = c;

            string randomIsim = (a == "Man") ? maleNames[rand.Next(maleNames.Length)] : femaleNames[rand.Next(femaleNames.Length)];
            string randomSoyisim = surnames[rand.Next(surnames.Length)];

            bool b = (i % 2 == 0) ? true : false;

            passengers.Add(new Passengers(randomIsim, randomSoyisim, i + 30, a, b, "Seat Number: " + c, "Middle Door"));
        }

        for (int i = 0; i < 13; i++)
        {
            string a = (i % 2 == 0) ? "Man" : "Woman";
            int c;
            do
            {
                int seatNumber = rand.Next(1, 41);
                c = seatNumber;
            } while (seatNumbers.Contains(c) || c < 1 || c > 40);
            seatNumbers[c - 1] = c;

            string randomIsim = (a == "Man") ? maleNames[rand.Next(maleNames.Length)] : femaleNames[rand.Next(femaleNames.Length)];
            string randomSoyisim = surnames[rand.Next(surnames.Length)];

            bool b = (i % 4 == 0) ? true : false;

            passengers.Add(new Passengers(randomIsim, randomSoyisim, i + 40, a, b, "Seat Number: " + c, "Back Door"));
        }

        // Otobüs yolcularını listeleme
        int count = 1;
        foreach (var passenger in passengers)
        {
            Console.WriteLine($"{count}. {passenger.Name} {passenger.Surname}, Age: {passenger.Age}, Gender: {passenger.Gender}, Ticket: {(passenger.HasTicket ? "Yes" : "No")}, {passenger.SeatNumber}, { passenger.EntranceDoor}");
            count++;
        }
        Console.ReadKey();
    }
}
