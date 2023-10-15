using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using ConsoleTables;
namespace OnlineMovieTicketBooking;
class Program
{
    static CustomList<UserDetails> userDetailsList = new CustomList<UserDetails>();
    static CustomList<TheatreDetails> theatreDetailsList = new CustomList<TheatreDetails>();
    static CustomList<MovieDetails> movieDetailsList = new CustomList<MovieDetails>();
    static CustomList<ScreeningDetails> screeningDetailsList = new CustomList<ScreeningDetails>();
    static CustomList<BookingDetails> bookingDetailsList = new CustomList<BookingDetails>();

    static UserDetails currentLoggedInUser;

    public static void Main(string[] args)
    {
        AddDefaultData();
        System.Console.WriteLine("\n-------------------------WELCOME TO ONLINE THEATER TICKET BOOKING APPLICATION-------------------------");
        System.Console.WriteLine("|                                                                                                    |");
        MainMenu();
    }

    public static void AddDefaultData()
    {
        //User Details
        userDetailsList.Add(new UserDetails("Ravichandran", 30, 8599488003, 1000));
        userDetailsList.Add(new UserDetails("Baskaran", 30, 9857747327, 2000));

        //Theater Details
        theatreDetailsList.Add(new TheatreDetails("Inox", "Anna Nagar"));
        theatreDetailsList.Add(new TheatreDetails("Ega Theatre", "Chetpet"));
        theatreDetailsList.Add(new TheatreDetails("Kamala", "Vadapalani"));

        //Movie Details
        movieDetailsList.Add(new MovieDetails("Bagubali 2", "Telugu"));
        movieDetailsList.Add(new MovieDetails("Ponniyin Selvan", "Tamil"));
        movieDetailsList.Add(new MovieDetails("Cobra", "Tamil"));
        movieDetailsList.Add(new MovieDetails("Vikram", "Tamil"));
        movieDetailsList.Add(new MovieDetails("Vikram", "Hindi (Dubbed)"));
        movieDetailsList.Add(new MovieDetails("Beast", "English"));

        //Screening Details
        screeningDetailsList.Add(new ScreeningDetails("MID501", "TID301", 200, 5));
        screeningDetailsList.Add(new ScreeningDetails("MID502", "TID301", 300, 2));
        screeningDetailsList.Add(new ScreeningDetails("MID506", "TID301", 50, 1));
        screeningDetailsList.Add(new ScreeningDetails("MID501", "TID302", 400, 11));
        screeningDetailsList.Add(new ScreeningDetails("MID505", "TID302", 300, 20));
        screeningDetailsList.Add(new ScreeningDetails("MID504", "TID302", 500, 2));
        screeningDetailsList.Add(new ScreeningDetails("MID505", "TID303", 100, 11));
        screeningDetailsList.Add(new ScreeningDetails("MID502", "TID303", 200, 20));
        screeningDetailsList.Add(new ScreeningDetails("MID504", "TID303", 350, 2));

        //Booking Details
        bookingDetailsList.Add(new BookingDetails("UID1001", "MID501", "TID301", 1, 200, BookingStatusEnum.Booked));
        bookingDetailsList.Add(new BookingDetails("UID1001", "MID504", "TID302", 1, 400, BookingStatusEnum.Booked));
        bookingDetailsList.Add(new BookingDetails("UID1002", "MID505", "TID302", 1, 300, BookingStatusEnum.Booked));

    }

    public static void MainMenu()
    {
        bool tryParseChecker, exitChecker = false;
        do
        {
            //Main Menu
            System.Console.WriteLine("\nMAIN MENU:");
            System.Console.WriteLine("1. User Registration \n2. User Login \n3. Exit");
            System.Console.Write("Enter the  Appropriate digit[1/2/3]: ");
            tryParseChecker = int.TryParse(Console.ReadLine(), out int option);
            switch (option)
            {
                case 1:
                    {
                        //Register
                        Registration();
                        break;
                    }
                case 2:
                    {
                        //Login
                        Login();
                        break;
                    }
                case 3:
                    {
                        //Exit
                        exitChecker = true;
                        System.Console.WriteLine("|                                                                                                    |");
                        System.Console.WriteLine("----------------------------------------THANK YOU VISIT AGAIN!----------------------------------------");
                        break;
                    }
                default:
                    {
                        System.Console.WriteLine("INVALID ENTRY! [ENTER - 1 / 2 / 3 ]");
                        break;
                    }
            }
        } while (!(tryParseChecker && exitChecker));
    }

    public static void Registration()
    {
        System.Console.WriteLine("\nREGISTRATION");

        //Getting User Details
        System.Console.Write("Enter Name: ");
        string name = Console.ReadLine();
        while (!Regex.IsMatch(name, @"^[a-z A-Z]+$"))
        {
            System.Console.WriteLine("NUMBERS NOT ALLOWED!");
            System.Console.Write("Enter Valid Name: ");
            name = Console.ReadLine();

        }

        System.Console.Write("Enter Age: ");
        bool boolAge = int.TryParse(Console.ReadLine(), out int age);
        while (!(age > 0 & age < 150 & boolAge))
        {
            System.Console.WriteLine("INVALID AGE!");
            System.Console.Write("Enter Correct Age: ");
            boolAge = int.TryParse(Console.ReadLine(), out age);
        }

        System.Console.Write("Enter Phone Number(10-digits): (+91) ");
        bool boolPhno = long.TryParse(Console.ReadLine(), out long phoneNumber);
        while (!(boolPhno && phoneNumber < 9999999999 && phoneNumber > 1000000000))
        {
            System.Console.WriteLine("INVALID PHONE NUMBER!");
            System.Console.Write("Enter Correct Phone Number(10-digits): (+91) ");
            boolPhno = long.TryParse(Console.ReadLine(), out phoneNumber);
        }


        System.Console.Write("Enter Initial Wallet Top-up in Rupees: Rs.");
        bool boolBal = int.TryParse(Console.ReadLine(), out int balance);
        while (!(boolBal && balance > 0))
        {
            System.Console.WriteLine("INVALID AMOUNT!");
            System.Console.Write("Enter Correct Amount in Rupees: Rs.");
            boolBal = int.TryParse(Console.ReadLine(), out balance);
        }

        UserDetails user = new UserDetails(name, age, phoneNumber, balance);
        userDetailsList.Add(user);


        //Displaying User ID after completion of Registration
        System.Console.WriteLine("REGISTRATION SUCCESSFUL!");
        System.Console.WriteLine("\n-------------------------------------");
        System.Console.WriteLine("YOUR USER ID IS " + user.UserId);
        System.Console.WriteLine("Please note down your User ID.");
        System.Console.WriteLine("\n--------------------------------------");

    }

    public static void Login()
    {
        System.Console.WriteLine("\nLOGIN");

        // Ask for the  UserID  of the user
        System.Console.Write("Enter Your User ID: ");
        string userId = Console.ReadLine().ToUpper();
        bool custCond = true;

        // Check the  UserID  in the user list
        foreach (UserDetails user in userDetailsList)
        {
            if (userId.Equals(user.UserId))
            {
                custCond = false;
                System.Console.WriteLine("LOGGED IN SUCCESSFULLY!");
                System.Console.WriteLine($"Welcome {user.UserName}!");
                currentLoggedInUser = user;

                // Calling submenu
                SubMenu();

            }

        }

        if (custCond)
        {
            System.Console.WriteLine("INVALID USER ID!");
        }
    }

    public static void SubMenu()
    {
        bool tryParseChecker, exitChecker = false;
        do
        {
            //Sub Menu
            System.Console.WriteLine("\nSUB MENU:");
            System.Console.WriteLine("a. Ticket Booking  \nb. Ticket cancellation \nc. Booking History \nd. Wallet Recharge \ne. Show Wallet balance \nf. Exit");
            System.Console.Write("\nEnter the Appropriate character[a/b/c/d/e/f]: ");
            tryParseChecker = char.TryParse(Console.ReadLine(), out char subOption);

            switch (subOption)
            {
                case 'a':
                    {
                        TicketBooking();
                        break;
                    }
                case 'b':
                    {
                        TicketCancellation();
                        break;
                    }
                case 'c':
                    {
                        BookingHistory();
                        break;
                    }
                case 'd':
                    {
                        WalletRecharge();
                        break;
                    }
                case 'e':
                    {
                        ShowWalletBalance();
                        break;
                    }
                case 'f':
                    {
                        //Exit
                        exitChecker = true;
                        System.Console.WriteLine("\n-------------------------------------Redirecting back to MAIN MENU------------------------------------");
                        break;
                    }
                default:
                    {
                        System.Console.WriteLine("INVALID ENTRY! [ENTER - a / b / c / d / e / f ]");
                        break;
                    }
            }
        } while (!(tryParseChecker && exitChecker));
    }

    public static void TicketBooking()
    {
        System.Console.WriteLine("\nTICKET BOOKING");
        bool statusBool = false;
        TheatreDetails selectedTheater = new TheatreDetails();
        do
        {
            System.Console.WriteLine("LIST OF THEATRES:");

            var theatreTable = new ConsoleTable("Theatre ID", "Theatre Name", "Theatre Location");

            foreach (TheatreDetails theatre in theatreDetailsList)
            {
                theatreTable.AddRow(theatre.TheatreId, theatre.TheatreName, theatre.TheatreLocation);
            }
            System.Console.Write(theatreTable);
            System.Console.WriteLine();

            System.Console.Write("\nSelect a Theatre using Theatre ID: ");
            string theaterId = Console.ReadLine().ToUpper();


            while (!theaterId.Contains("TID"))
            {
                System.Console.WriteLine("INVALID THEATRE ID!");
                System.Console.Write("Enter Correct Theatre ID from the table: ");
                theaterId = Console.ReadLine().ToUpper();
            }

            foreach (TheatreDetails theatre in theatreDetailsList)
            {
                if (theaterId.Equals(theatre.TheatreId))
                {
                    statusBool = true;
                    selectedTheater = theatre;

                }
            }
            if (!statusBool) System.Console.WriteLine("THEATRE NOT FOUND!");
        } while (!statusBool);

        var screeningTable = new ConsoleTable("Movie ID", "Movie Name", "Movie Language", "Theatre Name", "Theatre Location", "Ticket Price", "Seat Availability");
        Dictionary<string, string[]> movieDict = new Dictionary<string, string[]>();
        foreach (MovieDetails mov in movieDetailsList)
        {
            movieDict.Add(mov.MovieId, new string[] { mov.MovieName, mov.Language });
        }

        foreach (ScreeningDetails show in screeningDetailsList)
        {
            if (selectedTheater.TheatreId.Equals(show.TheaterId))
            {
                movieDict.TryGetValue(show.MovieId, out string[] movArr);
                screeningTable.AddRow(show.MovieId, movArr[0], movArr[1], selectedTheater.TheatreName, selectedTheater.TheatreLocation, show.TicketPrice, show.NoOfSeatsAvailable);
            }
        }
        System.Console.Write(screeningTable);
        System.Console.WriteLine();

        System.Console.Write("\nSelect a Movie using Movie ID: ");
        string movieId = Console.ReadLine().ToUpper();


        while (!movieId.Contains("MID"))
        {
            System.Console.WriteLine("INVALID MOVIE ID!");
            System.Console.Write("Enter Correct Movie ID from the table: ");
            movieId = Console.ReadLine().ToUpper();
        }

        foreach (ScreeningDetails show in screeningDetailsList)
        {
            if (movieId.Equals(show.MovieId) && selectedTheater.TheatreId.Equals(show.TheaterId))
            {
                statusBool = true;
                do
                {
                    System.Console.Write("Enter number of tickets to be booked: ");
                    bool boolQuant = int.TryParse(Console.ReadLine(), out int quantity);
                    while (!(boolQuant && quantity > 0))
                    {
                        System.Console.WriteLine("INVALID NUMBER!");
                        System.Console.Write("Enter Correct quantity(Only whole number greater than 1 is accepted): ");
                        boolQuant = int.TryParse(Console.ReadLine(), out quantity);
                    }

                    if (quantity <= show.NoOfSeatsAvailable)
                    {

                        double ticketPrice = quantity * show.TicketPrice;
                        double tax = ticketPrice * 0.18;
                        double totalAmount = ticketPrice + tax;
                        if (totalAmount <= currentLoggedInUser.WalletBalance)
                        {
                            statusBool = true;
                            currentLoggedInUser.DeductBalance(totalAmount);
                            show.NoOfSeatsAvailable -= quantity;
                            BookingDetails currentBooking = new BookingDetails(currentLoggedInUser.UserId, show.MovieId, show.TheaterId, quantity, totalAmount, BookingStatusEnum.Booked);
                            bookingDetailsList.Add(currentBooking);
                            System.Console.WriteLine($"\nBooking successfully!, Your Booking ID is {currentBooking.BookingId}");
                        }
                        else
                        {
                            statusBool = false;
                            System.Console.WriteLine($"Insufficient Balance {currentLoggedInUser.WalletBalance}. Please Recharge!");
                            System.Console.Write("Do u wanna go back to sub menu or continue with the booking [Yes/No]? ");
                            string choice = Console.ReadLine().ToLower();

                            while (choice != "yes" && choice != "no")
                            {
                                System.Console.Write("Invalid choice, Enter Yes or No: ");
                                choice = Console.ReadLine().ToLower();
                            }
                            if (choice == "yes") statusBool = true;
                            else WalletRecharge();
                        }

                    }

                    else
                    {
                        statusBool = false;
                        System.Console.WriteLine($"Required number of tickets not available. Current availability is {show.NoOfSeatsAvailable}");
                        System.Console.Write("Do u wanna go back to sub menu or continue with the booking [Yes/No]? ");
                        string choice = Console.ReadLine().ToLower();

                        while (choice != "yes" && choice != "no")
                        {
                            System.Console.Write("Invalid choice, Enter Yes or No: ");
                            choice = Console.ReadLine().ToLower();
                        }
                        if (choice == "yes") statusBool = true;
                    }

                } while (!statusBool);

            }
        }

    }

    public static void TicketCancellation()
    {
        System.Console.WriteLine("\nTICKET CANCELLATION");

        BookingHistory();

        System.Console.Write("Select a Booking to be cancelled using Booking ID: ");
        string bookingId = Console.ReadLine().ToUpper();


        while (!bookingId.Contains("BID"))
        {
            System.Console.WriteLine("INVALID BOOKING ID!");
            System.Console.Write("Enter Correct Booking ID from the table: ");
            bookingId = Console.ReadLine().ToUpper();
        }

        bool idBool = false;

        foreach (BookingDetails booking in bookingDetailsList)
        {
            if (bookingId.Equals(booking.BookingId))
            {
                idBool = true;
                if (booking.BookingStatus == BookingStatusEnum.Booked)
                {


                    foreach (ScreeningDetails show in screeningDetailsList)
                    {
                        if (booking.MovieId.Equals(show.MovieId) && booking.TheaterId.Equals(show.TheaterId))
                        {
                            show.NoOfSeatsAvailable += booking.SeatCount;

                        }
                    }

                    currentLoggedInUser.WalletRecharge(booking.TotalAmount - 20);
                    booking.BookingStatus = BookingStatusEnum.Cancelled;
                    System.Console.WriteLine($"\nBooking Cancelled!, For the Booking ID : {booking.BookingId}");

                }
            }
        }

        if (!idBool) System.Console.WriteLine("\nBOOKING ID NOT FOUND!");

    }

    public static void BookingHistory()
    {
        System.Console.WriteLine("\nBOOKING HISTORY");

        var table = new ConsoleTable("Booking ID", "Movie ID", "Theatre ID", "Seat Count", "Total Amount", "Booking Status");

        foreach (BookingDetails booking in bookingDetailsList)
        {
            if (currentLoggedInUser.UserId.Equals(booking.UserId))
                table.AddRow(booking.BookingId, booking.MovieId, booking.TheaterId, booking.SeatCount, booking.TotalAmount, booking.BookingStatus);
        }
        System.Console.Write(table);
        System.Console.WriteLine();


    }

    public static void WalletRecharge()
    {
        System.Console.WriteLine("\nWALLET RECHARGE");
        System.Console.Write("Enter the amount to be recharged: ");
        bool boolAmt = double.TryParse(Console.ReadLine(), out double amount);

        while (!(boolAmt && amount > 0))
        {
            System.Console.WriteLine("INVALID AMOUNT!");
            System.Console.Write("Enter valid amount (Amount should not be negative and less than Rs. 1): ");
            boolAmt = double.TryParse(Console.ReadLine(), out amount);
        }

        currentLoggedInUser.WalletRecharge(amount);
        System.Console.WriteLine("RECHARGE SUCCESSFUL!");
        ShowWalletBalance();
    }

    public static void ShowWalletBalance()
    {
        System.Console.WriteLine("\nSHOW WALLET BALANCE");
        System.Console.WriteLine($"\n{currentLoggedInUser.UserName} your balance is Rs. {currentLoggedInUser.WalletBalance}");
    }
     

}