namespace Question3
{
    public class OnlineTicket : Ticket
    {
        public override Type TicketType { get  ; set  ; }
        public override int SeatNumber { get  ; set  ; }

        public override void BookTicket()
        {
            System.Console.WriteLine("Booking Ticket...");;
        }

        public override void ShowTicket()
        {
            System.Console.WriteLine($"{TicketID} and Type is {TicketType}");
        }
        

    }
}