using System;

namespace Home_Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
                    while               (true)
            {
                Console.WriteLine("Please enter two values.");
                                string firstString = Console.ReadLine();
            int firstValue = convertFirstInt(firstString);

            Console.WriteLine("Please enter the second value.");

        string secondString = Console.ReadLine();
        int secondValue = convertSecondInt(secondString);

        int finalValue = 0;

if (firstValue == secondValue)
{
    finalValue = tripeValue(firstValue);
    Console.WriteLine("Triple that shit, the final value: " + finalValue);
}
                                        else
                                        {
                                            finalValue = boringValue(firstValue, secondValue);
                                            Console.WriteLine("Booooring, the final value: " + finalValue);
                                        }               
            }

    int convertFirstInt(string index_1)
    {
                        int newIndex_1 = Convert.ToInt32(index_1);
                        return newIndex_1;
            }

                                                            int convertSecondInt(string index_2)
            {
                int newIndex_2 = Convert.ToInt32(index_2);
        return newIndex_2;
                                                                                                                             }

            int tripeValue(int tripleIndex)
            {
                                        tripleIndex = tripleIndex * 3;
                                        return tripleIndex;
            }

                    int boringValue(int boringIndex_1, int boringIndex_2)
                    {
                                    int finalBoringIndex = boringIndex_1 + boringIndex_2;
                                    return finalBoringIndex;
            }
        }
    }
}
