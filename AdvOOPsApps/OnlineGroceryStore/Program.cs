using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.Design;

namespace OnlineGroceryStore;

public enum Menu { Select, Registration, Login, Exit }
public enum SubMenu { Select, ShowCustomerDetails, ShowProductDetails, WalletRecharge, TakeOrder, ModifyOrderQuantity, CancelOrder, ShowBalance, MyPurchaseDetails, AllCustomerDetails, AllBookingDetails, AllOrderDetails, Exit }
public enum Choice { Select, Yes, No }

class Program
{
    public static List<CustomerRegistration> CustomerList = new List<CustomerRegistration>();
    public static List<ProductDetails> ProductList = new List<ProductDetails>();
    public static List<BookingDetails> BookingList = new List<BookingDetails>();
    public static List<OrderDetails> OrderList = new List<OrderDetails>();

    static CustomerRegistration LoggedInCustomer;

    public static void Main(string[] args)
    {
        AddDefaultData();

        System.Console.WriteLine("\n-------------------------------WELCOME TO ONLINE GROCERY PORTAL-----------------------------");
        System.Console.WriteLine("|                                                                                            |");

        bool run = true;

        // main loop
        while (run)
        {

            // main menu
            Console.WriteLine("\nPlease choose any one from the below options.\n1.Registration\n2.Login\n3.Exit\nEither enter the number or enter the name as shown above.");

            bool menuCheck;
            Menu chosenMenu;

            menuCheck = Enum.TryParse<Menu>(Console.ReadLine(), true, out chosenMenu);

            if (menuCheck)
            {
                switch (chosenMenu)
                {
                    case Menu.Registration:
                        Registration();
                        break;

                    case Menu.Login:
                        Login();
                        break;

                    case Menu.Exit:
                        run = false;
                        System.Console.WriteLine("|                                                                                          |");
                        System.Console.WriteLine("-----------------------------------THANK YOU VISIT AGAIN!-----------------------------------");
                        break;

                    default:
                        menuCheck = false;
                        Console.WriteLine("Invalid input. Please try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please try again.");
            }
        }
    }

    public static void AddDefaultData()
    {
        CustomerRegistration customer1 = new CustomerRegistration("Ravi", "Ettapparajan", Gender.Male, 974774646, new DateTime(1999, 11, 11), "ravi@gmail.com", 10000);
        CustomerRegistration customer2 = new CustomerRegistration("Baskaran", "Sethurajan", Gender.Male, 847575775, new DateTime(1999, 11, 11), "baskaran@gmail.com", 15000);

        CustomerList.Add(customer1);
        CustomerList.Add(customer2);

        ProductDetails product1 = new ProductDetails("Sugar", 20, 40);
        ProductDetails product2 = new ProductDetails("Rice", 100, 50);
        ProductDetails product3 = new ProductDetails("Milk", 10, 40);
        ProductDetails product4 = new ProductDetails("Coffee", 10, 10);
        ProductDetails product5 = new ProductDetails("Tea", 10, 10);
        ProductDetails product6 = new ProductDetails("Masala Powder", 10, 20);
        ProductDetails product7 = new ProductDetails("Salt", 10, 10);
        ProductDetails product8 = new ProductDetails("Turmeric Powder", 10, 25);
        ProductDetails product9 = new ProductDetails("Chilli Powder", 10, 20);
        ProductDetails product10 = new ProductDetails("Groundnut Oil", 10, 140);

        ProductList.Add(product1);
        ProductList.Add(product2);
        ProductList.Add(product3);
        ProductList.Add(product4);
        ProductList.Add(product5);
        ProductList.Add(product6);
        ProductList.Add(product7);
        ProductList.Add(product8);
        ProductList.Add(product9);
        ProductList.Add(product10);

        BookingDetails booking1 = new BookingDetails("CID3001", 220, new DateTime(2022, 07, 26), BookingStatus.Booked);
        BookingDetails booking2 = new BookingDetails("CID3002", 400, new DateTime(2022, 07, 26), BookingStatus.Booked);
        BookingDetails booking3 = new BookingDetails("CID3001", 280, new DateTime(2022, 07, 26), BookingStatus.Cancelled);
        BookingDetails booking4 = new BookingDetails("CID3002", 0, new DateTime(2022, 07, 26), BookingStatus.Initiated);

        BookingList.Add(booking1);
        BookingList.Add(booking2);
        BookingList.Add(booking3);
        BookingList.Add(booking4);

        OrderDetails order1 = new OrderDetails("BID3001", "PID101", 2, 80);
        OrderDetails order2 = new OrderDetails("BID3001", "PID102", 2, 100);
        OrderDetails order3 = new OrderDetails("BID3001", "PID103", 1, 40);
        OrderDetails order4 = new OrderDetails("BID3002", "PID101", 1, 40);
        OrderDetails order5 = new OrderDetails("BID3002", "PID102", 4, 200);
        OrderDetails order6 = new OrderDetails("BID3002", "PID110", 1, 140);
        OrderDetails order7 = new OrderDetails("BID3002", "PID109", 1, 20);
        OrderDetails order8 = new OrderDetails("BID3003", "PID102", 2, 100);
        OrderDetails order9 = new OrderDetails("BID3003", "PID108", 4, 100);
        OrderDetails order10 = new OrderDetails("BID3003", "PID101", 2, 80);

        OrderList.Add(order1);
        OrderList.Add(order2);
        OrderList.Add(order3);
        OrderList.Add(order4);
        OrderList.Add(order5);
        OrderList.Add(order6);
        OrderList.Add(order7);
        OrderList.Add(order8);
        OrderList.Add(order9);
        OrderList.Add(order10);

    }

    public static void Registration()
    {
        Console.WriteLine("\nFill out the below form");

        bool userNameCheck = false;
        string userName;

        do
        {
            Console.Write("\nUser Name: ");
            userName = Console.ReadLine();

            if (userName.Any(char.IsDigit)) Console.WriteLine("Numbers Not Allowed!");
            else userNameCheck = true;
        } while (!userNameCheck);

        bool fatherNameCheck = false;
        string fatherName;

        do
        {
            Console.Write("\nFather Name: ");
            fatherName = Console.ReadLine();

            if (fatherName.Any(char.IsDigit)) Console.WriteLine("Numbers Not Allowed!");
            else fatherNameCheck = true;
        } while (!fatherNameCheck);

        bool genderCheck = false;
        Gender gender;

        do
        {
            Console.WriteLine("\nSelect the gender\n1.Male\n2.Female\nEither enter the number or enter the name as shown above.");
            Console.Write("Gender: ");
            genderCheck = Enum.TryParse<Gender>(Console.ReadLine(), true, out gender);

            if ((!Enum.IsDefined(typeof(Gender), gender)) || (gender == Gender.Select)) genderCheck = false;

            if (!genderCheck) Console.WriteLine("Invalid gender! Please try again.");

        } while (!genderCheck);

        bool mobileCheck = false;
        long mobileNumber;

        do
        {
            Console.Write("\nPhone: (+91) ");
            mobileCheck = long.TryParse(Console.ReadLine(), out mobileNumber);

            if (!mobileCheck) Console.WriteLine("Invalid number. Please try again.");
            else if (!(mobileNumber.ToString().Length == 10))
            {
                mobileCheck = false;
                Console.WriteLine("Please enter 10 digits correctly.");
            }
        } while (!mobileCheck);

        bool dobCheck = false;
        DateTime dob;

        do
        {
            Console.Write("\nDOB (dd/mm/yyyy): "); ;
            dobCheck = DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out dob);

            if (!dobCheck) Console.WriteLine("Invalid date! Please try again.");

        } while (!dobCheck);

        bool mailIDCheck = false;
        string mailID;

        do
        {
            Console.Write("\nMail ID: ");
            mailID = Console.ReadLine();

            if (mailID.Contains('@') && mailID.Contains('.') && !mailID.StartsWith("@") && !mailID.EndsWith(".") && (mailID.LastIndexOf('.') - mailID.IndexOf('@') > 1)) mailIDCheck = true;
            else Console.WriteLine("Invalid Mail ID! Please try again!");
        } while (!mailIDCheck);

        bool balanceCheck = false;
        double walletBalance;

        do
        {
            Console.Write("\nWallet Balance: (Rs.) ");
            balanceCheck = double.TryParse(Console.ReadLine(), out walletBalance);

            if (!balanceCheck) Console.WriteLine("Invalid amount! Please try again.");
            else if (walletBalance < 0)
            {
                balanceCheck = false;
                Console.WriteLine("Negative Value not allowed! Enter a valid amount.");
            }
        } while (!balanceCheck);

        CustomerRegistration customer = new CustomerRegistration(userName, fatherName, gender, mobileNumber, dob, mailID, walletBalance);

        CustomerList.Add(customer);

        Console.WriteLine($"\nKindly check your details\nName: {customer.Name}\nFather Name: {customer.FatherName}\nGender: {customer.Gender}\nMobile Number: {customer.MobileNumber}\nDOB: {customer.DOB}\nMail ID: {customer.MailID}\nWallet Balance: {customer.WalletBalance}\n\nPlease make note of your Customer ID\nCustomer ID: {customer.CustomerID}");
    }

    public static void Login()
    {
        Console.WriteLine("\nEnter your Customer ID: ");

        string CustomerID = Console.ReadLine();
        bool customerCheck = false;

        foreach (CustomerRegistration customer in CustomerList)
        {
            if (customer.CustomerID == CustomerID.ToUpper())
            {
                LoggedInCustomer = customer;
                SubMenu subMenu;

                customerCheck = true;
                bool subMenuCheck = false;

                do
                {
                    // sub menu
                    Console.WriteLine("\nPlease choose any one from the below options.\n1.Show my details\n2.Show Product Details\n3.Wallet Recharge\n4.Take Order\n5.Modify Order Quantity\n6.Cancel Order\n7.Show My Balance\n8.My Purchase Details\n9.All Customer Details\n10.All Booking Details\n11.All Order Details\n12.Exit\nEither enter the number or enter the name as shown above without any space.");

                    subMenuCheck = Enum.TryParse<SubMenu>(Console.ReadLine(), true, out subMenu);

                    if (!subMenuCheck)
                    {
                        subMenuCheck = true;

                        Console.WriteLine("Invalid option! Please try again.");
                    }

                    else
                    {
                        switch (subMenu)
                        {
                            case SubMenu.ShowCustomerDetails:
                                ShowCustomerDetails();
                                break;

                            case SubMenu.ShowProductDetails:
                                ShowProductDetails();
                                break;

                            case SubMenu.WalletRecharge:
                                WalletRecharge();
                                break;

                            case SubMenu.TakeOrder:
                                TakeOrder();
                                break;

                            case SubMenu.ModifyOrderQuantity:
                                ModifyOrderQuantity();
                                break;

                            case SubMenu.CancelOrder:
                                CancelOrder();
                                break;

                            case SubMenu.ShowBalance:
                                Console.WriteLine($"\nYour wallet Balance is Rs. {LoggedInCustomer.WalletBalance}");
                                break;

                            case SubMenu.MyPurchaseDetails:
                                MyOrderDetails();
                                break;

                            case SubMenu.AllCustomerDetails:
                                AllCustomerDetails();
                                break;

                            case SubMenu.AllBookingDetails:
                                AllBookingDetails();
                                break;

                            case SubMenu.AllOrderDetails:
                                AllOrderDetails();
                                break;

                            case SubMenu.Exit:
                                subMenuCheck = false;
                                break;

                            default:
                                Console.WriteLine("Invalid input! Please try again.");
                                break;
                        }
                    }
                } while (subMenuCheck);
            }
        }
        if (!customerCheck) Console.WriteLine("Invalid Customer ID! Please enter a valid one.");
    }

    public static void ShowCustomerDetails()
    {
        Console.WriteLine($"\nHere are your details:\n\nCustomer ID: {LoggedInCustomer.CustomerID}Name: {LoggedInCustomer.Name}\nFather Name: {LoggedInCustomer.FatherName}\nGender: {LoggedInCustomer.Gender}\nMobile Number: {LoggedInCustomer.MobileNumber}\nDOB: {LoggedInCustomer.DOB}\nMail ID: {LoggedInCustomer.MailID}\nWallet Balance: {LoggedInCustomer.WalletBalance}");
    }

    public static void ShowProductDetails()
    {
        Console.WriteLine("\nHere are the products available: ");

        Console.WriteLine("Product ID".PadRight(20) + "Product Name".PadRight(20) + "Quantity Available".PadRight(20) + "Price Per Quantity".PadRight(20));
        foreach (ProductDetails product in ProductList)
        {
            Console.WriteLine($"{product.ProductID.PadRight(20)}{product.ProductName.PadRight(20)}{product.QuantityAvailable.ToString().PadRight(20)}{product.PricePerQuantity.ToString().PadRight(20)}");
        }
    }

    public static void WalletRecharge()
    {
        bool amountCheck = false;
        double amount;

        do
        {
            Console.Write("\nWallet amount: (Rs.) ");
            amountCheck = double.TryParse(Console.ReadLine(), out amount);

            if (!amountCheck) Console.WriteLine("Invalid amount! Please try again.");
            else if (amount < 0)
            {
                amountCheck = false;
                Console.WriteLine("The amount can't be in negative value. Enter a valid amount.");
            }
        } while (!amountCheck);

        LoggedInCustomer.WalletRecharge(amount);

        Console.WriteLine($"\nYour wallet Balance is Rs. {LoggedInCustomer.WalletBalance}");
    }

    public static void TakeOrder()
    {
        bool choiceCheck;
        Choice choice;

        do
        {
            Console.WriteLine("\nDo you want to purchase ?\n1.Yes\n2.No\nEither enter the number or enter the choice as shown above.");
            choiceCheck = Enum.TryParse<Choice>(Console.ReadLine(), true, out choice);

            if ((!Enum.IsDefined(typeof(Choice), choice)) || (choice == Choice.Select)) choiceCheck = false;

            if (!choiceCheck) Console.WriteLine("Invalid option! Please try again.");

        } while (!choiceCheck);

        if (choice == Choice.Yes)
        {
            BookingDetails booking = new BookingDetails(LoggedInCustomer.CustomerID);

            List<OrderDetails> tempOrderList = new List<OrderDetails>();

            bool buying = false;

            do
            {
                ShowProductDetails();

                bool productIDCheck = false;
                string productID;

                Console.WriteLine("\nEnter the Product ID that you want to buy");
                Console.Write("\nProduct ID: ");

                productID = Console.ReadLine();

                foreach (ProductDetails product in ProductList)
                {
                    if (product.ProductID == productID.ToUpper())
                    {
                        productIDCheck = true;

                        bool countCheck = false;
                        int count;

                        do
                        {
                            Console.WriteLine("\nEnter the quantity to buy: ");
                            Console.Write("Count: ");

                            countCheck = int.TryParse(Console.ReadLine(), out count);

                            if (!countCheck || count < 0) Console.WriteLine("Invalid quantity. Please try again");

                            else if (count > 0)
                            {
                                if (count > product.QuantityAvailable) Console.WriteLine("Sorry, we have insufficient quantity.");

                                else
                                {
                                    product.QuantityAvailable -= count;

                                    double price = product.PricePerQuantity * count;

                                    OrderDetails order = new OrderDetails(booking.BookingID, productID, count, price);

                                    buying = true;

                                    tempOrderList.Add(order);

                                    Console.WriteLine("\nYour Cart:");
                                    Console.WriteLine("\nOrder ID".PadRight(20) + "Product ID".PadRight(20) + "Quantity".PadRight(20) + "Price".PadRight(20));
                                    foreach (OrderDetails tempOrder in tempOrderList)
                                    {
                                        Console.WriteLine($"{tempOrder.OrderID.PadRight(20)}{tempOrder.ProductID.PadRight(20)}{tempOrder.PurchaseCount.ToString().PadRight(20)}{tempOrder.PriceOfOrder.ToString().PadRight(20)}");
                                    }
                                    Console.WriteLine($"Please make note of your Booking ID\nBooking ID: {booking.BookingID}");

                                    bool buyAgainCheck;
                                    Choice buyAgain;

                                    do
                                    {
                                        Console.WriteLine("\nDo you buy another product ?\n1.Yes\n2.No\nEither enter the number or enter the choice as shown above.");
                                        buyAgainCheck = Enum.TryParse<Choice>(Console.ReadLine(), true, out buyAgain);

                                        if ((!Enum.IsDefined(typeof(Choice), buyAgain)) || (buyAgain == Choice.Select)) buyAgainCheck = false;

                                        if (!buyAgainCheck) Console.WriteLine("Invalid option. Please try again.");

                                    } while (!buyAgainCheck);

                                    if (buyAgain == Choice.No) buying = false;
                                }
                            }

                        } while (!countCheck);

                        break;
                    }
                }

                if (!productIDCheck) Console.WriteLine("Invalid Product ID! Please try again.");

            } while (buying);

            if (tempOrderList.Count > 0)
            {
                double totalPrice = 0;

                foreach (OrderDetails order in tempOrderList)
                {
                    totalPrice += order.PriceOfOrder;
                }

                Console.WriteLine($"\nThe total price of your cart is {totalPrice}");

                bool placeOrderCheck = false;
                Choice placeOrder;

                do
                {
                    Console.WriteLine("\nDo you place your order ?\n1.Yes\n2.No\nEither enter the number or enter the choice as shown above.");
                    placeOrderCheck = Enum.TryParse<Choice>(Console.ReadLine(), true, out placeOrder);

                    if ((!Enum.IsDefined(typeof(Choice), placeOrder)) || (placeOrder == Choice.Select)) placeOrderCheck = false;

                    if (!placeOrderCheck) Console.WriteLine("Invalid option. Please try again.");

                } while (!placeOrderCheck);

                if (placeOrder == Choice.Yes)
                {
                    while (totalPrice > LoggedInCustomer.WalletBalance)
                    {
                        Console.WriteLine("You have insufficient balance! Recharge before proceeding.");
                        WalletRecharge();
                    }

                    LoggedInCustomer.WalletBalance -= totalPrice;

                    booking.BookingStatus = BookingStatus.Booked;

                    booking.TotalPrice = totalPrice;

                    foreach (OrderDetails order in tempOrderList)
                    {
                        OrderList.Add(order);
                    }

                    Console.WriteLine("\nYour order has been successfully placed!");
                }

                if (placeOrder == Choice.No)
                {
                    foreach (OrderDetails order in tempOrderList)
                    {
                        foreach (ProductDetails product in ProductList)
                        {
                            if (order.ProductID == product.ProductID)
                            {
                                product.QuantityAvailable += order.PurchaseCount;
                            }
                        }
                    }
                    Console.WriteLine("\nCart Removed Successfully!");
                }
            }
            BookingList.Add(booking);
        }
    }

    public static void ModifyOrderQuantity()
    {
        Console.WriteLine("\nHere are your bookings that are available for modifying:");
        Console.WriteLine("\nBooking ID".PadRight(20) + "Total Price".PadRight(20) + "Order date".PadRight(20) + "Booking status".PadRight(20));

        bool modifyExistCheck = false;

        foreach (BookingDetails booking in BookingList)
        {
            if ((booking.CustomerID == LoggedInCustomer.CustomerID) && (booking.BookingStatus != BookingStatus.Cancelled))
            {
                modifyExistCheck = true;
                Console.WriteLine($"{booking.BookingID.PadRight(20)}{booking.TotalPrice.ToString().PadRight(20)}{booking.DateOfBooking.ToString("dd/MM/yyyy").PadRight(20)}{booking.BookingStatus.ToString().PadRight(20)}");
            }
        }

        if (modifyExistCheck)
        {
            bool modifyBookIDCheck = false;
            string modifyBookID;

            Console.WriteLine("\nEnter the Booking ID that you want to modify quantity:");
            Console.Write("\nBooking ID: ");

            modifyBookID = Console.ReadLine();

            foreach (BookingDetails booking in BookingList)
            {
                if ((booking.CustomerID == LoggedInCustomer.CustomerID) && (booking.BookingStatus != BookingStatus.Cancelled) && (booking.BookingID == modifyBookID.ToUpper()))
                {
                    modifyBookIDCheck = true;

                    Console.WriteLine("\nHere are the order details of the selected:");
                    Console.WriteLine("Order ID".PadRight(20) + "Product ID".PadRight(20) + "Quantity".PadRight(20) + "Price".PadRight(20));

                    foreach (OrderDetails order in OrderList)
                    {
                        if (order.BookingID == booking.BookingID)
                        {
                            Console.WriteLine($"{order.OrderID.PadRight(20)}{order.ProductID.PadRight(20)}{order.PurchaseCount.ToString().PadRight(20)}{order.PriceOfOrder.ToString().PadRight(20)}");
                        }
                    }

                    bool modifyOrderIDCheck = false;
                    string modifyOrderID;

                    Console.WriteLine("\nEnter the Order ID that you want to modify quantity:");
                    Console.Write("\nOrder ID: ");

                    modifyOrderID = Console.ReadLine();

                    foreach (OrderDetails order in OrderList)
                    {
                        if ((order.BookingID == booking.BookingID) && (order.OrderID == modifyOrderID.ToUpper()))
                        {
                            modifyOrderIDCheck = true;

                            Console.WriteLine($"The previous quantity is {order.PurchaseCount}");

                            bool modifyCountCheck = false;
                            int modifyCount;

                            do
                            {
                                Console.WriteLine("\nEnter the new quantity: ");
                                Console.Write("\nCount: ");

                                modifyCountCheck = int.TryParse(Console.ReadLine(), out modifyCount);

                                if (!modifyCountCheck) Console.WriteLine("\nInvalid quantity! Please try again");

                                else if (modifyCount < 0)
                                {
                                    modifyCountCheck = false;
                                    Console.WriteLine("\nNegative Value not Allowed! Please try again.");
                                }

                            } while (!modifyCountCheck);

                            if (modifyCountCheck && (modifyCount > 0))
                            {
                                int countDifference = order.PurchaseCount - modifyCount;

                                double productPrice = 0;

                                foreach (ProductDetails product in ProductList)
                                {
                                    if (order.ProductID == product.ProductID)
                                    {
                                        productPrice = product.PricePerQuantity;
                                        break;
                                    }
                                }
                                order.PurchaseCount = modifyCount;

                                booking.TotalPrice -= countDifference * productPrice;

                                LoggedInCustomer.WalletBalance += countDifference * productPrice;

                                Console.WriteLine("Order modified successfully!");
                            }
                            break;
                        }
                    }
                    if (!modifyOrderIDCheck) Console.WriteLine("Invalid Order ID! Please try again.");
                }
            }
            if (!modifyBookIDCheck) Console.WriteLine("Invalid Booking ID! Please try again.");
        }
        else
        {
            Console.WriteLine("No books exist to modify!");
        }
    }

    public static void CancelOrder()
    {
        Console.WriteLine("\nHere are your bookings that are available for cancelling:");
        Console.WriteLine("\nBooking ID".PadRight(20) + "Total Price".PadRight(20) + "Order date".PadRight(20) + "Booking status".PadRight(20));

        foreach (BookingDetails booking in BookingList)
        {
            if ((booking.CustomerID == LoggedInCustomer.CustomerID) && (booking.BookingStatus != BookingStatus.Cancelled))
            {
                Console.WriteLine($"{booking.BookingID.PadRight(20)}{booking.TotalPrice.ToString().PadRight(20)}{booking.DateOfBooking.ToString("dd/MM/yyyy").PadRight(20)}{booking.BookingStatus.ToString().PadRight(20)}");
            }
        }

        bool modifyBookIDCheck = false;
        string modifyBookID;

        Console.WriteLine("\nEnter the Booking ID that you want to cancel:");
        Console.Write("\nBooking ID: ");

        modifyBookID = Console.ReadLine();

        foreach (BookingDetails booking in BookingList)
        {
            if ((booking.CustomerID == LoggedInCustomer.CustomerID) && (booking.BookingStatus != BookingStatus.Cancelled) && (booking.BookingID == modifyBookID.ToUpper()))
            {
                modifyBookIDCheck = true;

                booking.BookingStatus = BookingStatus.Cancelled;

                LoggedInCustomer.WalletBalance += booking.TotalPrice;

                foreach (OrderDetails order in OrderList)
                {
                    if (order.BookingID == booking.BookingID)
                    {
                        foreach (ProductDetails product in ProductList)
                        {
                            if (product.ProductID == order.ProductID)
                            {
                                product.QuantityAvailable += order.PurchaseCount;

                                break;
                            }
                        }
                        break;
                    }
                }
                Console.WriteLine("Order cancelled successfully!");

                break;
            }
        }

        if (!modifyBookIDCheck) Console.WriteLine("Invalid Booking ID! Please try again.");
    }

    public static void AllCustomerDetails()
    {
        Console.WriteLine("Customer ID" + "Name" + "Father Name" + "Gender" + "Mobile Number" + "DOB" + "Mail ID" + "Wallet Balance");

        foreach (CustomerRegistration customer in CustomerList)
        {
            Console.WriteLine($"{customer.CustomerID}{customer.Name}{customer.FatherName}{customer.Gender}{customer.MobileNumber}{customer.DOB}{customer.MailID}{customer.WalletBalance}");
        }
    }

    public static void MyOrderDetails()
    {
        Console.WriteLine("Order ID".PadRight(20) + "Booking ID".PadRight(20) + "Product ID".PadRight(20) + "Quantity".PadRight(20) + "Price".PadRight(20));

        foreach (BookingDetails booking in BookingList)
        {
            if (booking.CustomerID == LoggedInCustomer.CustomerID)
            {
                foreach (OrderDetails order in OrderList)
                {
                    if (order.BookingID == booking.BookingID)
                    {
                        Console.WriteLine($"{order.OrderID.PadRight(20)}{order.BookingID.PadRight(20)}{order.ProductID.PadRight(20)}{order.PurchaseCount.ToString().PadRight(20)}{order.PriceOfOrder.ToString().PadRight(20)}");
                    }
                }
            }
        }
    }

    public static void AllBookingDetails()
    {
        Console.WriteLine("\nBooking ID".PadRight(20) + "Total Price".PadRight(20) + "Order date".PadRight(20) + "Booking status".PadRight(20));

        foreach (BookingDetails booking in BookingList)
        {
            Console.WriteLine($"{booking.BookingID.PadRight(20)}{booking.TotalPrice.ToString().PadRight(20)}{booking.DateOfBooking.ToString("dd/MM/yyyy").PadRight(20)}{booking.BookingStatus.ToString().PadRight(20)}");
        }
    }

    public static void AllOrderDetails()
    {
        Console.WriteLine("Order ID".PadRight(20) + "Booking ID".PadRight(20) + "Product ID".PadRight(20) + "Quantity".PadRight(20) + "Price".PadRight(20));

        foreach (OrderDetails order in OrderList)
        {
            Console.WriteLine($"{order.OrderID.PadRight(20)}{order.BookingID.PadRight(20)}{order.ProductID.PadRight(20)}{order.PurchaseCount.ToString().PadRight(20)}{order.PriceOfOrder.ToString().PadRight(20)}");
        }
    }

}