namespace MiniProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> guestBook = new Dictionary<string, int>();


            string firstName = "";
            int partyMembers = 0;
            string keyWord = "";
            do
            {
                firstName = GetUserInfo("Your name: ");
                partyMembers = StringToInt(GetUserInfo("#Party: "));

                guestBook.Add(firstName, partyMembers);

                Write("Are ther any more guests? yes/no ");
                keyWord = ReadLine();

            } while (keyWord.ToLower() == "yes");

            WriteLine("{0,-12} {1,15}", arg0: "Guest", "# Party Members");

            foreach (var name in guestBook)
            {
                WriteLine();
            }


            

            string GetUserInfo(string message)
            {
                Write(message);
                string outputText = ReadLine();

                return outputText;
            }

            int StringToInt(string input)
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
}
