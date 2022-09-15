using InheritanceAssignment;

namespace InheritanceAssignment
{

    class furniture
    {
        int OrderID;
        DateTime OrderDate;
        string FurnitureType;
        int Quantity;
        int TotalAmt;
        string PaymentMode;


        
        public void getData()
        {
            Console.Write("Enter OrderID : ");
            OrderID = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter OrderDate : ");
            OrderDate = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Enter Furniture type : ");
            FurnitureType = Console.ReadLine();
            if (FurnitureType.ToLower() == "chair" || FurnitureType.ToLower() == "cot")
            {

            }
            else
            {
                Console.WriteLine("Enter valid input");
                return;
            }
            Console.Write("enter Quantity : ");
            Quantity = Convert.ToInt32(Console.ReadLine());

            Console.Write("enter TotalAmt : ");
            TotalAmt = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Payment Mode : ");

            PaymentMode = Console.ReadLine();
            if (PaymentMode.ToLower() == "credit" || PaymentMode.ToLower() == "debit") { }
            else
            {
                Console.WriteLine("Enter valid input");
                return;
            }
        }

        public void showdata()
        {
            Console.WriteLine("OrderID : " + OrderID);
            Console.WriteLine("OrderDate : " + OrderDate);
            Console.WriteLine("Furniture Type : " + FurnitureType);
            Console.WriteLine("Quantity : " + Quantity);
            Console.WriteLine("Total amount : " + TotalAmt);
            Console.WriteLine("Payment Mode : " + PaymentMode);


        }



    }

    class chair : furniture
    {
        string chairtype;
        string purpose;
        string type;
        int rate;


        public void getData()
        {

            base.getData();
            Console.Write("Enter Chair type : ");
            chairtype = Console.ReadLine();
            if (chairtype.ToLower() == "wood" || chairtype.ToLower() == "steel" || chairtype.ToLower() == "plastic")
            {

            }
            else
            {
                Console.WriteLine("Enter valid input");
                return;
            }


            Console.Write("Enter purpose : ");
            purpose = Console.ReadLine();
            if (purpose.ToLower() == "home" || purpose.ToLower() == "office") { }
            else
            {
                Console.WriteLine("Enter valid input");
                return;
            }


            Console.Write("Enter type : ");
            type = Console.ReadLine();

            if (chairtype.ToLower() == "wood" && (type.ToLower() == "teak wood" || type.ToLower() == "rose wood")) { }


            else if (chairtype.ToLower() == "steel" && (type.ToLower() == "gray steel" || type.ToLower() == "green steel" || type.ToLower() == "brown steel")) { }


            else if (chairtype.ToLower() == "plastic" && (type.ToLower() == "green" || type.ToLower() == "red" || type.ToLower() == "blue" || type.ToLower() == "white")) { }
            else { Console.WriteLine("Invalid Input"); return; }

            Console.Write("Enter Rate : ");
            rate = Convert.ToInt32(Console.ReadLine());
        }

        public void showdata()
        {
            base.showdata();
            Console.WriteLine("ChairType : " + chairtype);
            Console.WriteLine("Purpose : " + purpose);
            Console.WriteLine("Type : " + type);
            Console.WriteLine("Rate : " + rate);

        }
    }


    class cot : furniture
    {
        string cottype;
        string cottype_type;
        string capacity;
        int rate;

        public void getData()
        {

            base.getData();
            Console.Write("Enter Cot type : ");
            cottype = Console.ReadLine();
            if (cottype.ToLower() == "wood" || cottype.ToLower() == "steel")
            {

            }
            else
            {
                Console.WriteLine("Enter valid input");
                return;
            }


            Console.Write("Enter Capacity : ");
            capacity = Console.ReadLine();
            if (capacity.ToLower() == "single" || capacity.ToLower() == "double") { }
            else
            {
                Console.WriteLine("Enter valid input");
                return;
            }


            Console.Write("Enter type : ");
            cottype_type = Console.ReadLine();

            if (cottype.ToLower() == "wood" && (cottype_type.ToLower() == "teak wood" || cottype_type.ToLower() == "rose wood")) { }


            else if (cottype.ToLower() == "steel" && (cottype_type.ToLower() == "gray steel" || cottype_type.ToLower() == "green steel" || cottype_type.ToLower() == "brown steel")) { }


            else { Console.WriteLine("Invalid Input"); return; }

            Console.Write("Enter Rate : ");
            rate = Convert.ToInt32(Console.ReadLine());
        }

        public void showdata()
        {
            base.showdata();
            Console.WriteLine("ChairType : " + cottype);
            Console.WriteLine("Purpose : " + capacity);
            Console.WriteLine("Type : " + cottype_type);
            Console.WriteLine("Rate : " + rate);

        }


    }


    class Program
    {
        static void Main(string[] args)
        {
            var ob = new chair();
            ob.getData();
            Console.WriteLine("");

            ob.showdata();

            var ob2 = new cot();
            ob2.getData();
            Console.WriteLine("");

            ob2.showdata();
        }
    }
}