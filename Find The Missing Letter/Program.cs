namespace Find_The_Missing_Letter
{
    internal class Program
    {
        public static char FindMissingLetter(char[] array)
        {
            bool isUpper = false;

            if (char.IsUpper(array[0]))
            {
                isUpper = true;
            }

            array = array.Select(c => char.ToLower(c)).ToArray();

            List<char> alphabet = new List<char>
            {
            'a', 'b', 'c', 'd', 'e',
            'f', 'g', 'h', 'i', 'j',
            'k', 'l', 'm', 'n', 'o',
            'p', 'q', 'r', 's', 't',
            'u', 'v', 'w', 'x', 'y', 'z'
            };

            List<char> alphabetRow = alphabet.GetRange(alphabet.IndexOf(array[0]), array.Length);

            if (isUpper)
            {
                return char.ToUpper(alphabetRow.Except(array).First());
            }

            return alphabetRow.Except(array).First();
        }

        static void Main(string[] args)
        {
            Console.WriteLine(FindMissingLetter(new char[] { 'O', 'Q', 'R', 'S' }));
        }
    }
}