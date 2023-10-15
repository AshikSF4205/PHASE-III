namespace Question3
{

    public enum Type{offline,online}
    public abstract class Ticket
    {

        public Ticket(){
            Ticket_No++;
            TicketID = "TID"+ Ticket_No;
        }
        private static int Ticket_No = 100;
        public string TicketID { get; set; }
        public abstract Type TicketType  { get; set; }

        public abstract int SeatNumber { get; set; }

        public abstract void BookTicket();
        public abstract void ShowTicket();
    }
}