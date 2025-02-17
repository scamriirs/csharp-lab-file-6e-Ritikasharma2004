// write a program for the seat booking management system using 2d array menu driven
// 1- view the seats
// 2- book the seat(provide row and column no)
// 3- cancel the seat (provide row and column no)
// 4- check the availabilty of perticular seat
using System;

class SeatBookingSystem
{
    static int[,] seats = new int[5, 5]; // 5x5 array representing the seats (0 = available, 1 = booked)

    static void Main()
    {
        int choice;
        InitializeSeats();

        do
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Seat Booking Management System");
            Console.WriteLine("1. View the seats");
            Console.WriteLine("2. Book the seat");
            Console.WriteLine("3. Cancel the seat");
            Console.WriteLine("4. Check the availability of a particular seat");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    ViewSeats();
                    break;
                case 2:
                    BookSeat();
                    break;
                case 3:
                    CancelSeat();
                    break;
                case 4:
                    CheckAvailability();
                    break;
                case 5:
                    Console.WriteLine("Exiting the system...");
                    break;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        } while (choice != 5);
    }

    static void InitializeSeats()
    {
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                seats[i, j] = 0;
            }
        }
    }

    static void ViewSeats()
    {
        Console.WriteLine("\nCurrent Seat Availability:");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (seats[i, j] == 0)
                    Console.Write("[A] "); // A = Available
                else
                    Console.Write("[B] "); // B = Booked
            }
            Console.WriteLine();
        }
    }

    static void BookSeat()
    {
        Console.Write("Enter the row number (0-4): ");
        int row = int.Parse(Console.ReadLine());

        Console.Write("Enter the column number (0-4): ");
        int col = int.Parse(Console.ReadLine());

        if (row >= 0 && row < 5 && col >= 0 && col < 5)
        {
            if (seats[row, col] == 0)
            {
                seats[row, col] = 1; // Book the seat
                Console.WriteLine("Seat successfully booked.");
            }
            else
            {
                Console.WriteLine("Sorry, this seat is already booked.");
            }
        }
        else
        {
            Console.WriteLine("Invalid seat numbers, please enter valid row and column.");
        }
    }

    static void CancelSeat()
    {
        Console.Write("Enter the row number (0-4): ");
        int row = int.Parse(Console.ReadLine());

        Console.Write("Enter the column number (0-4): ");
        int col = int.Parse(Console.ReadLine());

        if (row >= 0 && row < 5 && col >= 0 && col < 5)
        {
            if (seats[row, col] == 1)
            {
                seats[row, col] = 0; // Cancel the seat
                Console.WriteLine("Seat booking has been successfully canceled.");
            }
            else
            {
                Console.WriteLine("This seat is not booked, so it cannot be canceled.");
            }
        }
        else
        {
            Console.WriteLine("Invalid seat numbers, please enter valid row and column.");
        }
    }

    static void CheckAvailability()
    {
        Console.Write("Enter the row number (0-4): ");
        int row = int.Parse(Console.ReadLine());

        Console.Write("Enter the column number (0-4): ");
        int col = int.Parse(Console.ReadLine());

        if (row >= 0 && row < 5 && col >= 0 && col < 5)
        {
            if (seats[row, col] == 0)
            {
                Console.WriteLine("The seat is available.");
            }
            else
            {
                Console.WriteLine("The seat is already booked.");
            }
        }
        else
        {
            Console.WriteLine("Invalid seat numbers, please enter valid row and column.");
        }
    }
}
