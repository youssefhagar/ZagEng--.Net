using System;

namespace Task5_ZagEng
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Payment payment1 = new Payment()
                {
                    From = "Ahmed",
                    To = "Youssef",
                    Subject = "Course Fees",
                    Amount = 5000
                };

                bool result = Payment.Pay(payment1);

                payment1.Print(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("System Error: " + ex.Message);
            }
        }
    }

    class Payment
    {
        public string From { get; set; }
        public string To { get; set; }
        public string Subject { get; set; }
        public double Amount { get; set; }
        public bool IsSuccess { get; set; }

        public static bool Pay(Payment payment)
        {
            try
            {

                if (string.IsNullOrWhiteSpace(payment.From))
                    throw new Exception("Sender is required");

                if (string.IsNullOrWhiteSpace(payment.To))
                    throw new Exception("Receiver is required");

                if (payment.Amount <= 0)
                    throw new Exception("Amount must be greater than 0");

                Console.WriteLine("Processing Payment...");

                payment.IsSuccess = true;

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Payment Failed: " + ex.Message);
                payment.IsSuccess = false;
                return false;
            }
        }

        public void Print(bool status)
        {
            Console.WriteLine("\n===== Payment Receipt =====");
            Console.WriteLine($"From    : {From}");
            Console.WriteLine($"To      : {To}");
            Console.WriteLine($"Subject : {Subject}");
            Console.WriteLine($"Amount  : {Amount}");

            Console.WriteLine(
                status ? "Status  : Success"
                       : "Status  : Failed"
            );
        }
    }
}
