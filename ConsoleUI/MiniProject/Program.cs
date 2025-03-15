namespace MiniProject
{
    internal class Program
    {
        private static Dictionary<string, int> guestBook = new Dictionary<string, int>();
        static void Main(string[] args)
        {

            LoadGuests();            

            PrintGuestTable(guestBook);

        }

        private static void LoadGuests()
        {
            string firstName = "";
            int partyMembers = 0;
            string keyWord = "";

            do
            {
            A_label:
                firstName = GetUserInfo("Your name: ");
                partyMembers = StringToInt(GetUserInfo("# Party Members: "));

                if (partyMembers > 0)
                {
                    guestBook.Add(firstName, partyMembers);
                }
                else
                {
                    WriteLine("That is not a valid party number. Try again.");
                    goto A_label;
                }

                Write("Are ther any more guests? yes/no ");
                keyWord = ReadLine();
                WriteLine();

            } while (keyWord.ToLower() == "yes");
        }

        private static void PrintGuestTable(Dictionary<string,int> book)
        {
            WriteLine("{0,-12} {1,15}", arg0: "Guest", "# Party Members");
            foreach (var name in book)
            {
                WriteLine($"{name.Key,-12} {book[name.Key],15}");
            }
            WriteLine($"Total number of guests: {TotalGuests(book)}");
        }
        private static int TotalGuests(Dictionary<string,int> book)
        {
            int total = 0;
            foreach (var name in book)
            {
                total += name.Value;
            }
            return total;
        }
        private static string GetUserInfo(string message)
        {
            Write(message);
            string outputText = ReadLine();

            return outputText;
        }

        private static int StringToInt(string input)
        {
            int returnValue;
            bool isValidInt = int.TryParse(input, out int output);
            if (isValidInt == true)
            {
                returnValue = output;
                return returnValue;
            }
            else
            {
                return -1;
            }
        }
    }
}
