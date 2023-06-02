using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecom_Project_1030.Utility
{
   public static class SD          //SD=STANDARD DICTONARY

    {
        //CoverType StoredProcedure
        public const string Proc_GetCoverTypes = "GetCoverTypes";
        public const string Proc_GetCoverType = "GetCoverType";
        public const string Proc_CreateCoverTypes = "CreateCoverTypes";
        public const string Proc_UpdateCoverTypes = "UpdateCoverTypes";
        public const string Proc_DeleteCoverTypes = "DeleteCoverTypes";
        //Roles
        public const string Role_Admin = "Admin";
        public const string Role_Employee = "Employee User";
        public const string Role_Company = "Company User";
        public const string Role_Individual = "Individual User";
        //Sessions
        public const string Ss_CartSessionCount = "CartSession";
        //Order Status
        public const string OrderStatusPending = "Pending";
        public const string OrderStatusApproved= "Approved";
        public const string OrderStatusInProgress = "Processing";
        public const string OrderStatusShipped = "Shipped";
        public const string OrderStatusCancelled = "Cancelled";
        public const string OrderStatusRefunded = "Refunded";
        //Payment Status
        public const string PaymentStatusPending = "Pending";
        public const string PaymentStatusApproved = "Approved";
        public const string PaymentStatusDelayPayment = "PaymentStatusDelay";
        public const string PaymentStatusRejected = "Rejected";


        
        public static double GetPriceBasedOnQuantity(double quantity,double price,double price50,double price100)
        {
            if (quantity < 50)
                return price;
            else if (quantity < 100)
                return price50;
            else
                return price100;

        }
        //<p>Hello</p><p>Welcome</p>
        public static string ConvertToRawHTML(string source)
        {
            char[] array = new char[source.Length];
            int arrayIndex = 0;
            bool inside = false;
            for(int i=0;i<source.Length;i++)
            {
                char let = source[i];  //</p>
                if(let=='<')
                {
                    inside = true;
                    continue;
                }
                if(let=='>')
                {
                    inside = false;
                    continue;
                }
                if(!inside)
                {
                    array[arrayIndex] = let;    //Hello Hi Welcome
                    arrayIndex ++;
                }
            }
            return new string(array,0 , arrayIndex);
        }
        public static string NumberToWords(int number)
        {
            if (number == 0)
                return "zero";

            if (number < 0)
                return "minus " + NumberToWords(Math.Abs(number));

            string words = "";

            if ((number / 1000000) > 0)
            {
                words += NumberToWords(number / 1000000) + " Million ";
                number %= 1000000;
            }

            if ((number / 1000) > 0)
            {
                words += NumberToWords(number / 1000) + " Thousand ";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                words += NumberToWords(number / 100) + " Hundred ";
                number %= 100;
            }

            if (number > 0)
            {
                if (words != "")
                    words += "and ";

                var unitsMap = new[] { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven",
                    "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
                var tensMap = new[] { "Zero", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

                if (number < 20)
                    words += unitsMap[number];
                else
                {
                    words += tensMap[number / 10];
                    if ((number % 10) > 0)
                        words += "-" + unitsMap[number % 10];
                }
            }

            return words;
        }


    }
}
