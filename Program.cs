// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
namespace BasicCorePrograms
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please select the option which program can access");
            Console.WriteLine("Option 1 : Flip the Coin");
            Console.WriteLine("Option 2 : Learyear");
            Console.WriteLine("Option 3 : PowerOfTwo");
            Console.WriteLine("Option 4 : HormonicNumber");
            Console.WriteLine("Option 5 : PrimeFactor");
            Console.WriteLine("Option 6 : QuotientAndRemainder");
            Console.WriteLine("Option 7 : SwapTwoNumber");
            Console.WriteLine("Option 8 : EvenOrOdd");
            Console.WriteLine("Option 9 : VowelorConsonant");

            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    FlipCoin.CalculatePercentage();
                    break;
                    case 2:
                        Leapyear.CalculateLeapYear();
                    break;
                case 3:
                  //  PowerOfTwo.CalculateThePower();
                    break;
                case 4:
                    HarmonicNumber.CalculateHormonicNumber();
                    break;
                case 5:
                    PrimeFactor.CalculatePrimeFactor();
                    break;
                case 6:
                    QuotientRemainder.CalculateQuotientAndRemainder();
                    break;
                case 7:
                    SwapTwoNumber.DisplaySwapTwoNumber();
                    break;
                    case 8:
                    EvenOdd.CalculateEvenOrOdd();
                    break;
                case 9:
                    VowelOrConsonant.CalculateVowelorConsonant();
                        break;

                default:
                    Console.WriteLine("Please enter the correct option");
                    break;
            }
            }
            

            }
        }
  