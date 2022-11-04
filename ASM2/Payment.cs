    namespace ASM2;

    public abstract class Payment
    {
        private int paymentID { get; set; }
        private String paymentMethod { get; set; }
        private String paymentStatus { get; set; }

        public Payment(int paymentID, String paymentMethod, String paymentStatus)
        {
            this.paymentID = paymentID;
            this.paymentMethod = paymentMethod;
            this.paymentStatus = paymentStatus;
        }

        public void viewPayment()
        {
            Console.WriteLine("Payment ID: " + paymentID);
            Console.WriteLine("Payment method: " + paymentMethod);
            Console.WriteLine("Payment status: " + paymentStatus);
        }
    }