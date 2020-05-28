using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Advance_ATM_Machine
{
    class Program
    {



        // VARIABLES DECLEARATION =========================================================

        static string card;
        static string pin;
        static int option;
        static int current_balance = 5000;
        static int withdraw;
        static int deposit;
        static string ref_num;
        static int bill_amount;
        static int fund;    
        static DateTime date_time = DateTime.Now;

        // MAIN FUNCTION STARTS FROM HERE===============================================================

        public static void Main(string[] args)
        {
          

            Intro(); // CALLING INTRO ===========================================================
            First_Question();  //  ASK FOR PIN   ==============================================
            if (option == 1) // PIN CONDITION  STARTS HERE =================================
            {
                Pin();
            }
            else if (option == 2)
            {
                Details();

            }
            else
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("   =====  You have Entered Wrong Information Please Read The Details  ====");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Details();

            }// PIN CONDITION END FROM HERE =========================================================



            Console.ReadLine();
        }// MAIN FUNCTION END FROM HERE  ================================================================




        public static void Intro()// INTRO FUNCTION STARTS FROM HERE  ====================================
        {
            Console.ForegroundColor = System.ConsoleColor.Blue;
            Console.WriteLine("============================================================================================================");
            Console.WriteLine();
            Console.WriteLine("================    W E L C O M E    T O    O U R    A T M    S E R V I C E    =============================");
            Console.WriteLine();
            Console.WriteLine("============================================================================================================");
            Console.WriteLine();
            Console.ForegroundColor = System.ConsoleColor.White;
            Console.WriteLine("    Please Press Enter To Swap The Card ");
            Console.Write("    "); card = Console.ReadLine();
            
        }// INTRO FUNCTION END FROM HERE  ============================================================



        public static void First_Question()// FIRST QUESTION FUNCTION STARTS FROM HERE  ==================
        {
            Console.WriteLine();
            Console.WriteLine("   Press [1] TO ENTER PIN");
            Console.WriteLine();
            Console.WriteLine("   Press [2] TO KNOW HOW TO USE ATM MACHINE");
            Console.WriteLine();
            Console.Write("   Select : "); option = int.Parse(Console.ReadLine());
        }// FIRST QUESTION FUNCTION END FROM HERE ==========================================================




        public static void Pin()// PIN FUNCTION STARTS FROM HERE  ==========================================
        {
            for (int i = 1; i <= 3; i++)
            {

                Console.WriteLine("");
                Console.WriteLine("    Please Enter the Pin Code");
                Console.Write("    "); pin = Console.ReadLine();
                Console.WriteLine("");
                Regex rgx = new Regex(@"^[0-9]{4}$");
                if (rgx.IsMatch(pin))
                {

                    Option();
                    break;

                }
                if (i == 3)
                {

                    Console.WriteLine();
                    Console.ForegroundColor = System.ConsoleColor.Red;
                    Console.WriteLine("     Sorry !! You have entered wrong pin multiple times that's why your card blocked for 24 hours") ;
                    Console.ForegroundColor = System.ConsoleColor.White;
                    Console.WriteLine();
                    Console.WriteLine("     Thanks for choosing us !!" + "              " + date_time);
                }

            }


        }// PIN FUNCTION END FROM HERE  =========================================================



        public static void Option()// OPTION FUNCTION STARTS FROM HERE ===============================
        {
            Console.WriteLine();
            Console.WriteLine("    Please Select The Option ");
            Console.WriteLine("");
            Console.ForegroundColor = System.ConsoleColor.Cyan;
            Console.WriteLine(" 1. Check Current Balance");
            Console.WriteLine("");
            Console.WriteLine(" 2. Fast Cash");
            Console.WriteLine("");
            Console.WriteLine(" 3. Whithdraw");
            Console.WriteLine();
            Console.WriteLine(" 4. Deposite");
            Console.WriteLine();
            Console.WriteLine(" 5. Bill Payment");
            Console.WriteLine("");
            Console.WriteLine(" 6. Prim Minister Corona Relief Fund");
            Console.WriteLine("");
            Console.WriteLine(" 7. Exit");
            Console.WriteLine("");
            Console.ForegroundColor = System.ConsoleColor.White;
            Console.Write("    Select : "); option = int.Parse(Console.ReadLine());

            if (option == 1)
            {
                Currnt_Balance();
            }
            else if (option == 2)
            {
                Fast_Cash();
            }
            else if (option == 3)
            {
                Whithdraw();
            }
            else if (option == 4)
            {
                Deposit();
            }
            else if (option == 5)
            {
                billingSystem();
            }
            else if (option == 6)
            {
                Corona_Fund();
            }
            else if (option == 7)
            {
                Console.WriteLine();
                Console.WriteLine("   Do you really want to Exit");
                Console.WriteLine();
                AnotherTransaction();
            }
            else{
                AnotherTransaction();
            }

        }//  OPTION FUNCTION END FROM HERE  ==============================================================


        public static void Currnt_Balance() // BALANCE CHECKINK FUNCTION STARTS FROM ====================== 
        {
            Console.WriteLine();
            Console.WriteLine("    =========== Your Current Balance is Rs. " + current_balance + "          " + date_time);
            Console.WriteLine();
            AnotherTransaction();
        }// BALANCE CHECKING FUNCTION END FROM HERE  ====================================================


        //FAST - CASH METHOD =========================================
        public static void Fast_Cash()
        {
            Console.WriteLine();
            Console.WriteLine("   ========  select one of them   ========");
            Console.WriteLine();
            Console.WriteLine(" 1. 100");
            Console.WriteLine(" 2. 500");
            Console.WriteLine(" 3. 1000");
            Console.WriteLine(" 4. 5000");
            Console.WriteLine();
            Console.Write("   "); option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    {
                        if (current_balance >= 100)
                        {
                            Console.WriteLine();
                            Console.ForegroundColor = System.ConsoleColor.Green;
                            Console.WriteLine("   Your Fast Cash Withdraw Successfully !");
                            Console.ForegroundColor = System.ConsoleColor.White;
                            Console.WriteLine();
                            Console.WriteLine("   Take your money : " + 100);
                            Console.WriteLine();
                            current_balance = current_balance - 100;
                            Console.WriteLine("   Your Current Balance : " + current_balance +  "          " + date_time);
                            AnotherTransaction();
                        }
                        else if (current_balance < 100)
                        {
                            Console.WriteLine();
                            Console.ForegroundColor = System.ConsoleColor.Red;
                            Console.WriteLine("   your balance did not found Sufficient " +  "          " + date_time);
                            Console.ForegroundColor = System.ConsoleColor.White;
                            Console.WriteLine();
                            AnotherTransaction();
                        }
                        break;
                    }
                case 2:
                    {
                        if (current_balance >= 500)
                        {
                            Console.WriteLine();
                            Console.ForegroundColor = System.ConsoleColor.Green;
                            Console.WriteLine("   Your Fast Cash Withdraw Successfully !");
                            Console.ForegroundColor = System.ConsoleColor.White;
                            Console.WriteLine();
                            Console.WriteLine("   Take your money : " + 500);
                            Console.WriteLine();
                            current_balance = current_balance - 500;
                            Console.WriteLine("   Your Current Balance : " + current_balance +  "          " + date_time);
                            AnotherTransaction();
                        }
                        else if (current_balance < 500)
                        {
                            Console.WriteLine();
                            Console.ForegroundColor = System.ConsoleColor.Red;
                            Console.WriteLine("   your balance did not found Sufficient " +  "          " + date_time);
                            Console.WriteLine();
                            Console.ForegroundColor = System.ConsoleColor.White;
                            AnotherTransaction();
                        }
                        break;
                    }
                case 3:
                    {
                        if (current_balance >= 1000)
                        {
                            Console.WriteLine();
                            Console.ForegroundColor = System.ConsoleColor.Green;
                            Console.WriteLine("   Your Fast Cash Withdraw Successfully !");
                            Console.WriteLine();
                            Console.ForegroundColor = System.ConsoleColor.White;
                            Console.WriteLine("   Take your money : " + 1000);
                            Console.WriteLine();
                            current_balance = current_balance - 1000;
                            Console.WriteLine("   Your Current Balance : " + current_balance +  "          " + date_time);
                            AnotherTransaction();
                        }
                        else if (current_balance < 1000)
                        {
                            Console.WriteLine();
                            Console.ForegroundColor = System.ConsoleColor.Red;
                            Console.WriteLine("   your balance did not found Sufficient " +  "          " + date_time);
                            Console.WriteLine();
                            Console.ForegroundColor = System.ConsoleColor.White;
                            AnotherTransaction();
                        }
                        break;
                    }
                case 4:
                    {
                        if (current_balance >= 5000)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine();
                            Console.WriteLine("   Your Fast Cash Withdraw Successfully !");
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("   Take your money : " + 5000);
                            Console.WriteLine();
                            current_balance = current_balance - 5000;
                            Console.WriteLine("   Your Current Balance : " + current_balance +  "          " + date_time);
                            AnotherTransaction();
                        }
                        else if (current_balance < 5000)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine();
                            Console.WriteLine("   your balance did not found Sufficient " +  "          " + date_time);
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.White;
                            AnotherTransaction();
                        }
                        break;
                    }
            }
        }// END OF FAST CASH METHOD ========================================

        public static void Whithdraw()// WHITHDRAWAL METHOD STARTS FROM HERE ===========================
        {
            Console.WriteLine();
            Console.WriteLine("    Please Enter the amount of Whithdrawal");
            Console.Write("");
            Console.WriteLine();
            Console.Write("    "); withdraw = int.Parse(Console.ReadLine());
            Console.Write("");
            if (withdraw <= current_balance)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("    Your Amount Withdraw Successfully");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("    Take your money Rs." + withdraw);
                Console.WriteLine();
                current_balance = current_balance - withdraw;
                Console.WriteLine("    Your Current Balance is : " + current_balance +  "          " + date_time);
                Console.WriteLine();
                Console.WriteLine("   ----  Thanks For Using Our Servise    ----");
                Console.WriteLine();
                AnotherTransaction();
            }
            else if (withdraw > current_balance)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine("    ---- Amount does not found Sufficient ----"  +  "          " + date_time);
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                AnotherTransaction();
            }


        }// WHITHDRAWAL METHOD END FROM HERE =======================================================



        public static void Deposit()// DEPOSIT METHOD STARTS FROM HERE  ===============================
        {
            Console.WriteLine();
            Console.WriteLine("    Please Enter the amount to be Deposit");
            Console.WriteLine();
            Console.Write("    "); deposit = int.Parse(Console.ReadLine());
            Console.WriteLine();
            current_balance = current_balance + deposit;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("    You have Deposited :" + deposit);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("    Your Current Amount is : " + current_balance);
            Console.WriteLine();
            AnotherTransaction();

        }// DEPOSIT METHOD END FROM HERE  =============================================================



        public static void Details() // DETAILS METHOD STARTS FROM HERE  ==============================
        {
            Console.WriteLine();
            Console.WriteLine("    Details are here");
            Console.WriteLine();
            Console.WriteLine("    Step 1: First of all to Swap the Card Press Enter");
            Console.WriteLine();
            Console.WriteLine("    Step 2: Then Enter your Right Pin Code");
            Console.WriteLine();
            Console.WriteLine("    Step 3: Press [1] to check your Curent Balance\n" + "            Press [2] for Fast Cash\n" + "            Press [3] to Deposit Amount\n" + "            Press [4] to Withdraw Amount\n" + "            Press [5] to Deposit Amount\n" +  "            Press [6] for Bill Payment\n" + "            Press [7] to Exit");
            Console.WriteLine();
            Console.WriteLine("    ----   Thanks For Visiting ----   ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("    Press [ 1 ] to Enter Pin Code");
            Console.WriteLine("    Press [ 2 ] to Exit ");
            Console.Write("    "); option = int.Parse(Console.ReadLine());
            switch (option)
            {

                case 1:
                    Pin();
                    break;
                case 2:
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("    Thanks for choosing us !!" +  "          " + date_time);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine();
                    Console.WriteLine("    Invalid Choise");
                    Console.ForegroundColor = ConsoleColor.White;
                    Details();
                    break;
            }
        }// DETAILS METHOD END FROM HERE  ==========================================================




        public static void AnotherTransaction()// ANOTHER TRANSACTION STARTS FROM HERE  ==================
        {
            Console.WriteLine("   Do you want to do another transaction Press [ 1 ]");
            Console.WriteLine("   To Exit Press [ 2 ]");
            Console.Write("   "); option = int.Parse(Console.ReadLine());

            if (option == 1)
            {
                Option();
            }
            else if (option == 2)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("   Thanks For Choosing us! | Good By |"+  "          " + date_time);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("   Invalid Choice !!");
                Console.ForegroundColor = ConsoleColor.White;
                AnotherTransaction();
            }

        }// ANOTHER TRANSACTION END FROM HERE  ==================================================




        // START OF BILLING METHOD ====================================
        public static void billingSystem()
        {

            Console.WriteLine("");
            Console.WriteLine("   Please Select The Option");
            Console.WriteLine();
            Console.WriteLine("   [ 1 ]  Electricity");
            Console.WriteLine("   [ 2 ]  Gass");
            Console.WriteLine("   [ 3 ]  Water");
            Console.WriteLine();
            Console.Write("   "); option = int.Parse(Console.ReadLine());
            switch (option)
            {

                case 1:
                    {
                        Console.WriteLine();
                        Console.WriteLine("   Please Enter The Refrence Number");
                        Console.WriteLine();
                        Console.Write("   "); ref_num = Console.ReadLine();
                        Console.WriteLine();
                        Regex rgx = new Regex(@"^[0-9]{14}$");
                        if (rgx.IsMatch(ref_num))
                        {

                            Console.WriteLine();
                            Console.WriteLine("   Please Enter The Payment Amount");
                            Console.WriteLine();
                            Console.Write("   "); bill_amount = int.Parse(Console.ReadLine());
                            if (bill_amount <= current_balance)
                            {

                                Console.WriteLine();
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("   =====   Your Electric Bill Has Been Paid Successfully   =====");
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("   Paid Ammount : " + bill_amount);
                                Console.WriteLine();
                                current_balance = current_balance - bill_amount;
                                Console.WriteLine("   Current Amount : " + current_balance+  "          " + date_time);
                                Console.WriteLine();
                                AnotherTransaction();

                            }
                            else if (bill_amount > current_balance)
                            {

                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("   =====   You Have Insussicient Ammount   =====" +  "          " + date_time);
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.White;
                                AnotherTransaction();

                            }

                        }
                        else
                        {

                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("   =====   Incorrect Refrence Number   =====" +  "          " + date_time);
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.White;
                            AnotherTransaction();

                        }
                        break;
                    }

                case 2:
                    {
                        Console.WriteLine();
                        Console.WriteLine("   Please Enter The Refrence Number");
                        Console.WriteLine();
                        Console.Write("   "); ref_num = Console.ReadLine();
                        Console.WriteLine();
                        Regex rgx = new Regex(@"^[0-9]{10}$");
                        if (rgx.IsMatch(ref_num))
                        {

                            Console.WriteLine();
                            Console.WriteLine("   Please Enter The Payment Amount");
                            Console.WriteLine();
                            Console.Write("   "); bill_amount = int.Parse(Console.ReadLine());
                            if (bill_amount <= current_balance)
                            {

                                Console.WriteLine();
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("   =====   Your Gass Bill Has Been Paid Successfully   =====");
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("   Paid Ammount : " + bill_amount);
                                Console.WriteLine();
                                current_balance = current_balance - bill_amount;
                                Console.WriteLine("   Current Amount : " + current_balance +  "          " + date_time);
                                Console.WriteLine();
                                AnotherTransaction();

                            }
                            else if (bill_amount > current_balance)
                            {

                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("   =====   You Have Insussicient Ammount   =====" +  "          " + date_time);
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.White;
                                AnotherTransaction();

                            }
                        }
                        else
                        {

                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("   =====   Incorrect Refrence Number   =====" +  "          " + date_time);
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.White;
                            AnotherTransaction();

                        }
                        break;
                    }

                case 3:
                    {
                        Console.WriteLine();
                        Console.WriteLine("   Please Enter The Refrence Number");
                        Console.WriteLine();
                        Console.Write("   "); ref_num = Console.ReadLine();
                        Console.WriteLine();
                        Regex rgx = new Regex(@"^[0-9]{10}$");
                        if (rgx.IsMatch(ref_num))
                        {

                            Console.WriteLine();
                            Console.WriteLine("   Please Enter The Payment Amount");
                            Console.WriteLine();
                            Console.Write("   "); bill_amount = int.Parse(Console.ReadLine());
                            if (bill_amount <= current_balance)
                            {

                                Console.WriteLine();
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("   =====   Your Water Bill Has Been Paid Successfully   =====");
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("   Paid Ammount : " + bill_amount);
                                Console.WriteLine();
                                current_balance = current_balance - bill_amount;
                                Console.WriteLine("   Current Amount : " + current_balance +  "          " + date_time);
                                Console.WriteLine();
                                AnotherTransaction();

                            }
                            else if (bill_amount > current_balance)
                            {

                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("   =====   You Have Insussicient Ammount   =====" +  "          " + date_time);
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.White;
                                AnotherTransaction();

                            }
                        }
                        else
                        {

                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("   =====   Incorrect Refrence Number   =====" +  "          " + date_time);
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.White;
                            AnotherTransaction();

                        }
                        break;
                    }
            }
        }// END OF BILLING METHOD =========================================





        //START OF FUND METHOD ==============================
        public static void Corona_Fund()
        {

            Console.WriteLine();
            Console.WriteLine("   Donations to assist the Pakistan government in its efforts to fight the current coronavirus related crisis can be transferred to:");
            Console.WriteLine();
            Console.WriteLine("   Account Title : PM Relief Fund for COVID-19");
            Console.WriteLine();
            Console.WriteLine("   Account No. : 4162786786");
            Console.WriteLine();
            Console.WriteLine("   IBAN :  PK46NBPA0002004162786786");
            Console.WriteLine();
            Console.WriteLine("   SWIFT CODE : NBPAPKKAMBR");
            Console.WriteLine();
            Console.WriteLine("   Account Title : PM Relief Fund for COVID-19");
            Console.WriteLine();
            Console.WriteLine("   ========   Enter The Amount   ========");
            Console.WriteLine();
            Console.Write("   "); fund = int.Parse(Console.ReadLine());
            if (current_balance >= fund)
            {

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("   Your Fund Transfer Successfully !!");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("   =====  STAY HOME SAVE LIFE ====" +  "          " + date_time);
                Console.WriteLine();
                AnotherTransaction();
            }
            else if (current_balance < fund)
            {

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("   Sorry You Have Insufficient Amount !!");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("   =====  STAY HOME SAVE LIFE ====" +  "          " + date_time);
                AnotherTransaction();
            }
        }// END OF FUND METHOD =====================
    }
}





