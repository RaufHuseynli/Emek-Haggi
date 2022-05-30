using System;

namespace Emek_Haqqi__Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            string Disabilty;
            string MaritalStatus;
            int Tax;
            int NumberofChild = 0;
            int WageTaxPercentage = 0;
            float WageTaxAmount = 0;
            int FamilyAsistance = 0;
            float TotalSalary = 0;
            float FixedSalary = 0;
            float ChildCompensation = 0;
            int taxdegree = 0;

            bool Iscontinue = true;
            do
            {
                Console.WriteLine("Emek hagginizi daxil edin:");
                TotalSalary = int.Parse(Console.ReadLine());
                Console.Write("Aile veziyyetinizi daxil edin (e/E: evli, b/B: subay, d/Du: dul) :  ");
                MaritalStatus = Console.ReadLine();
                if (MaritalStatus == "evli" || MaritalStatus == "dul")
                {

                    Console.WriteLine("Usag sayini qeyd ediniz:");
                    NumberofChild = int.Parse(Console.ReadLine());
                }
                if (MaritalStatus == "evli")
                {
                    FamilyAsistance = +50;
                    TotalSalary = TotalSalary + FamilyAsistance;

                }
                if (NumberofChild == 1)
                {
                    ChildCompensation = ChildCompensation + 30;
                    TotalSalary = TotalSalary + ChildCompensation;

                }
                if (NumberofChild == 2)
                {
                    ChildCompensation = 30 + 25;
                    TotalSalary = TotalSalary + ChildCompensation;
                }
                if (NumberofChild == 3)
                {
                    ChildCompensation = 30 + 25 + 20;
                    TotalSalary = TotalSalary + ChildCompensation;
                }
                if (NumberofChild > 3)
                {
                    ChildCompensation = 30 + 25 + 20 + ((NumberofChild - 3) * 15);
                    TotalSalary = TotalSalary + ChildCompensation;

                }
                Console.WriteLine("Elilsinizmi?");
                Disabilty = Console.ReadLine();
                if (Disabilty == "he")
                {
                    if (TotalSalary <= 1000)
                    {
                        WageTaxPercentage = 15 / 2;
                        WageTaxAmount = (TotalSalary / 100) * WageTaxPercentage;
                        FixedSalary = TotalSalary - WageTaxAmount;

                    }
                    else if (TotalSalary <= 2000 || TotalSalary > 1000)
                    {
                        WageTaxPercentage = 20 / 2;
                        WageTaxAmount = (TotalSalary / 100) * WageTaxPercentage;
                        FixedSalary = TotalSalary - WageTaxAmount;

                    }
                    else if (TotalSalary <= 3000 || TotalSalary > 2000)
                    {
                        WageTaxPercentage = 25 / 2;
                        WageTaxAmount = (TotalSalary / 100) * WageTaxPercentage;
                        FixedSalary = TotalSalary - WageTaxAmount;
                    }
                    else
                    {
                        WageTaxPercentage = 30 / 2;
                        WageTaxAmount = (TotalSalary / 100) * WageTaxPercentage;
                        FixedSalary = TotalSalary - WageTaxAmount;
                    }
                }
                else
                {
                    if (TotalSalary <= 1000)
                    {
                        WageTaxPercentage = 15;
                        WageTaxAmount = (TotalSalary / 100) * 15;
                        FixedSalary = TotalSalary - WageTaxAmount;

                    }
                    else if (TotalSalary <= 2000 || TotalSalary > 1000)
                    {
                        WageTaxPercentage = 20;
                        WageTaxAmount = (TotalSalary / 100) * 20;
                        FixedSalary = TotalSalary - WageTaxAmount;

                    }
                    else if (TotalSalary <= 3000 || TotalSalary > 2000)
                    {
                        WageTaxPercentage = 25;
                        WageTaxAmount = (TotalSalary / 100) * 25;
                        FixedSalary = TotalSalary - WageTaxAmount;
                    }
                    else
                    {
                        WageTaxPercentage = 30;
                        WageTaxAmount = (TotalSalary / 100) * 30;
                        FixedSalary = TotalSalary - WageTaxAmount;
                    }
                }



                Console.WriteLine("Sizin Umumi geliriniz: " + TotalSalary);
                Console.WriteLine("Sizin Usaq geliriniz: " + ChildCompensation);
                Console.WriteLine("Sizin Aile muavinati: " + FamilyAsistance);
                Console.WriteLine("Sizin Xalis emek hagginiz:  " + FixedSalary);
                Console.WriteLine("Sizin gelir verginizin meblegi: " + WageTaxAmount);
                Console.WriteLine("Sizin gelir verginizin derecesi: " + WageTaxPercentage);



                int[] MonetaryUnit = { 200, 100, 50, 20, 10, 5, 1 };
                // Additional Method without using Math. 
                //int twoHundredBankotecount = 0;
                //int oneHundredBankotecount = 0;
                //int fiftyBankotecount = 0;
                //int twentyBankotecount = 0;
                //int tenBankotecount = 0;
                //int fiveBankotecount = 0;
                //int oneBankotecount = 0;
                int unitsCount = 0;

                for (int i = 0; i < MonetaryUnit.Length; i++)
                {
                    unitsCount = Convert.ToInt32(Math.Floor(FixedSalary / MonetaryUnit[i]));
                    if (unitsCount != 0)
                        Console.WriteLine($"{unitsCount} eded {MonetaryUnit[i]} AZN verildi");
                    FixedSalary = FixedSalary - (unitsCount * MonetaryUnit[i]);
                }
                // Additional Method without using Math. 
                //twoHundredBankotecount = FixedSalary / MonetaryUnit[0];
                //int result1 = FixedSalary - twoHundredBankotecount * MonetaryUnit;
                //oneHundredBankotecount = result1 / MonetaryUnit[1];
                //int result2 = FixedSalary - oneHundredBankotecount * MonetaryUnit;
                //fiftyBankotecount = result2 / MonetaryUnit[2];
                //int result3 = FixedSalary - fiftyBankotecount * MonetaryUnit;
                //twentyBankotecount = result3 / MonetaryUnit[3];
                //int result4 = FixedSalary - twentyBankotecount * MonetaryUnit;
                //tenBankotecount = result4 / MonetaryUnit[4];
                //int result5 = FixedSalary - tenBankotecount * MonetaryUnit;
                //fiveBankotecount = result5 / MonetaryUnit[5];
                //int result6 = FixedSalary - tenBankotecount * MonetaryUnit; 
                //oneBankotecount = result6 / MonetaryUnit[6];

                Console.WriteLine();
            } while (Iscontinue);

        }
    }
}
