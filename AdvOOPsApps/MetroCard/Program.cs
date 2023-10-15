using System;
using System.Collections.Generic;
using System.Data.Common;
namespace MetroCard;
public class Program
{
    public static CustomList<UserDetails> userList = new CustomList<UserDetails>();
    public static CustomList<TravelDetails> travelList = new CustomList<TravelDetails>();
    public static CustomList<TicketFairDetails> ticketFairList = new CustomList<TicketFairDetails>();


    public static UserDetails loggedUser;

    public static void Main(string[] args)
    {
        DefaultData();
        System.Console.WriteLine("\n-------------------------WELCOME TO METRO CARD MANAGEMENT SYSTEM--------------------------");
        System.Console.WriteLine("|                                                                                         |");

        bool flag = true;
        do
        {
            System.Console.WriteLine("\nMAIN MENU: ");
            System.Console.Write("\n1. User Registration\n2. Login\n3. Exit\nEnter Your Choice:");
            flag = int.TryParse(Console.ReadLine(), out int choice);
            switch (choice)
            {
                case 1:
                    {
                        Registration();
                        break;
                    }
                case 2:
                    {
                        Login();
                        break;
                    }
                case 3:
                    {
                        flag = false;
                        System.Console.WriteLine("|                                                                                         |");
                        System.Console.WriteLine("-----------------------------------THANK YOU VISIT AGAIN!----------------------------------");
                        break;
                    }
                default:
                    {
                        System.Console.WriteLine("Invalid Input!");
                        flag = true;
                        break;
                    }
            }
        } while (flag);

    }
    public static void DefaultData()
    {

        userList.Add(new UserDetails("Ravi", 98488, 1000));
        userList.Add(new UserDetails("Baskaran", 99488, 1000));



        travelList.Add(new TravelDetails("CMRL101", "Airport", "Egmore", new DateTime(2022, 10, 10), 55));
        travelList.Add(new TravelDetails("CMRL101", "Egmore", "Koyambedu", new DateTime(2022, 10, 10), 32));
        travelList.Add(new TravelDetails("CMRL102", "Alandur", "Koyambedu", new DateTime(2022, 11, 10), 25));
        travelList.Add(new TravelDetails("CMRL102", "Egmore", "Thirumangalam", new DateTime(2022, 11, 10), 25));


        ticketFairList.Add(new TicketFairDetails("Airport", "Egmore", 55));
        ticketFairList.Add(new TicketFairDetails("Airport", "Koyambedu", 25));
        ticketFairList.Add(new TicketFairDetails("Alandur", "Koyambedu", 25));
        ticketFairList.Add(new TicketFairDetails("Koyambedu", "Egmore", 32));
        ticketFairList.Add(new TicketFairDetails("Vadapalani", "Egmore", 45));
        ticketFairList.Add(new TicketFairDetails("Arumbakkam", "Egmore", 25));
        ticketFairList.Add(new TicketFairDetails("Vadapalani", "Koyambedu", 25));
        ticketFairList.Add(new TicketFairDetails("Arumbakkam", "Koyambedu", 16));

    }
    public static void Registration()
    {
        System.Console.Write("Enter your Name: ");
        string name = Console.ReadLine();


        long phoneNumber;
        bool temp;
        do
        {
            System.Console.Write("Enter your Phone Number: ");
            temp = long.TryParse(Console.ReadLine(), out phoneNumber);
            if (!temp || phoneNumber.ToString().Length != 10)
            {
                System.Console.Write("Invaild Phone Number. Please enter correctly!.\n");
            }
        } while (!temp || phoneNumber.ToString().Length != 10);


        double balance;
        do
        {
            System.Console.Write("Enter your Balance: ");
            temp = double.TryParse(Console.ReadLine(), out balance);
            if (!temp || balance < 0)
            {
                System.Console.Write("\nInvaild Amount. Please enter correctly!.\n");
            }
        } while (!temp || balance < 0);

        UserDetails user = new UserDetails(name, phoneNumber, balance);

        userList.Add(user);

        System.Console.WriteLine("\n--------------------------------\n");
        System.Console.WriteLine($"Registration Completed Successfully!\nYour Card Numnber is {user.CardNumber}");
        System.Console.WriteLine("\n--------------------------------\n");

    }

    public static void Login()
    {
        System.Console.Write("Card Number: ");
        string cardNumber = Console.ReadLine().ToUpper();
        bool check = false;
        foreach (UserDetails user in userList)
        {
            if (user.CardNumber.Equals(cardNumber))
            {
                check = true;
                loggedUser = user;
                System.Console.WriteLine("You are Logged in Successfully!");

                SubMenu();
            }
        }

        if (!check)
        {
            System.Console.WriteLine("Invalid card number!");
        }

    }
    public static void SubMenu()
    {
        bool flag = true;
        do
        {
            System.Console.WriteLine("\nSUB MENU: ");
            System.Console.Write("\na. Balance Check\nb. Recharge\nc. View travel History\nd. Travel\ne. exit\nEnter Your Choice: ");
            flag = char.TryParse(Console.ReadLine().ToLower(), out char choice);
            switch (choice)
            {
                case 'a':
                    {
                        System.Console.WriteLine("Your Current Balance is " + loggedUser.Balance);
                        break;
                    }
                case 'b':
                    {
                        Recharge();
                        break;
                    }
                case 'c':
                    {
                        ViewTravelHistory();
                        break;
                    }
                case 'd':
                    {
                        Travel();
                        break;
                    }
                case 'e':
                    {
                        flag = false;
                        break;
                    }
                default:
                    {
                        System.Console.WriteLine("Invalid Input!\n");
                        flag = true;
                        break;
                    }
            }

        } while (flag);
    }
    public static void Recharge()
    {
        double amount;
        bool temp;
        do
        {
            System.Console.Write("Enter the amount to Recharge: ");
            temp = double.TryParse(Console.ReadLine(), out amount);
            if (!temp || amount < 0)
            {
                System.Console.Write("\n\t\t Invaild Amount! Please enter correctly.");
            }
        } while (!temp || amount < 0);
        loggedUser.Balance += amount;
    }
    public static void ViewTravelHistory()
    {
        bool check = true;
        foreach (TravelDetails travel in travelList)
        {
            if (travel.CardNumber.Equals(loggedUser.CardNumber))
            {
                check = false;
                System.Console.WriteLine($"\t{travel.TravelID.PadRight(10)}{travel.CardNumber.PadRight(10)}{travel.FromLocation.PadRight(20)}{travel.ToLocation.PadRight(20)}{travel.Date.ToString("dd/MM/yyyy").PadRight(15)}{travel.TravelCost.ToString().PadRight(10)}");
            }
        }
        if (check)
        {
            Console.WriteLine($"No History found!");
        }

    }
    public static void Travel()
    {
        foreach (TicketFairDetails ticket in ticketFairList)
        {
            System.Console.WriteLine($"\t{ticket.TicketID.PadRight(10)}{ticket.FromLocation.PadRight(20)}{ticket.ToLocation.PadRight(20)}{ticket.TicketPrice.ToString().PadRight(20)}");
        }

        System.Console.Write("Enter the Ticket ID: ");
        string ticketID = Console.ReadLine().ToUpper();
        bool check = false;
        foreach (TicketFairDetails ticket in ticketFairList)
        {
            if (ticket.TicketID.Equals(ticketID))
            {
                check = true;
                if (loggedUser.Balance >= ticket.TicketPrice)
                {
                    loggedUser.Balance -= ticket.TicketPrice;
                    TravelDetails travel = new TravelDetails(loggedUser.CardNumber, ticket.FromLocation, ticket.ToLocation, DateTime.Now, ticket.TicketPrice);
                    travelList.Add(travel);
                    System.Console.WriteLine("\nYour travel was booked!");
                }
                else
                {
                    System.Console.WriteLine("Insufficient Balance!Recharge to continue.");
                }
            }
        }
        if (!check)
        {
            System.Console.WriteLine("Invalid Ticket Id!");
        }

    }
}

