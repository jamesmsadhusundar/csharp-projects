using System;

namespace employee_salary_pay
{
    class Program
    {
        static void Main (String[] args)
        {
            string first_name,last_name;

            int id,designation;

            double basic_pay1 = 30000,basic_pay2 = 25000,basic_pay3 = 20000,da,hra,ta,pf,it,net_pay;

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("*************************************");
            Console.WriteLine("          EMPLOYEE DERTAILS          ");

            Console.WriteLine("Enter First Name : ");
            first_name = Console.ReadLine();

            Console.WriteLine("Enter Last Name : ");
            last_name = Console.ReadLine();

            Console.WriteLine("Enter ID (4-digits) : ");
            id = Convert.ToInt32(Console.ReadLine());

            if (id == 2345)
            {
                Console.WriteLine("Choose Designation : ");

                Console.WriteLine("1 - Chief Employee");
                Console.WriteLine("2 - Senior Employee");
                Console.WriteLine("3 - Junior Employee");

                designation = Convert.ToInt32(Console.ReadLine());

                if (designation == 1)
                {
                    da = (10*basic_pay1)/100;
                    hra = (6*basic_pay1)/100;
                    ta = (0*basic_pay1)/100;

                    pf = (8*basic_pay1)/100;
                    it = (10*basic_pay1)/100;

                    net_pay = basic_pay1+da+hra+ta-(pf+it);

                    Console.WriteLine("*************************************");
 
                    Console.WriteLine("            SALARY SLIP              ");

                    Console.WriteLine("Employee Name : "+first_name+" "+last_name);

                    Console.WriteLine("Employee ID : "+id);

                    Console.WriteLine("Designation : Chief Employee");

                    Console.WriteLine("Basic Pay : "+basic_pay1);

                    Console.WriteLine("DA : "+da);
                    Console.WriteLine("HRA : "+hra);
                    Console.WriteLine("TA "+ta);

                    Console.WriteLine();

                    Console.WriteLine("PF : "+pf);
                    Console.WriteLine("IT : "+it);

                    Console.WriteLine();

                    Console.WriteLine("Net Pay : "+net_pay);

                    Console.WriteLine("*************************************");
                }

                else if (designation == 2)
                {
                    da = (8*basic_pay2)/100;
                    hra = (10*basic_pay2)/100;
                    ta = (5*basic_pay2)/100;

                    pf = (7*basic_pay2)/100;
                    it = (9*basic_pay2)/100;

                    net_pay = basic_pay2+da+hra+ta-(pf+it);

                    Console.WriteLine("*************************************");
 
                    Console.WriteLine("            SALARY SLIP              ");

                    Console.WriteLine("Employee Name : "+first_name+" "+last_name);

                    Console.WriteLine("Employee ID : "+id);

                    Console.WriteLine("Designation : Senior Employee");

                    Console.WriteLine("Basic Pay : "+basic_pay2);

                    Console.WriteLine("DA : "+da);
                    Console.WriteLine("HRA : "+hra);
                    Console.WriteLine("TA "+ta);

                    Console.WriteLine();

                    Console.WriteLine("PF : "+pf);
                    Console.WriteLine("IT : "+it);

                    Console.WriteLine();

                    Console.WriteLine("Net Pay : "+net_pay);

                    Console.WriteLine("*************************************");
                }

                else if (designation == 3)
                {
                    da = (6*basic_pay1)/100;
                    hra = (12*basic_pay1)/100;
                    ta = (5*basic_pay1)/100;

                    pf = (7*basic_pay1)/100;
                    it = (7*basic_pay1)/100;

                    net_pay = basic_pay3+da+hra+ta-(pf+it);

                    Console.WriteLine("*************************************");
 
                    Console.WriteLine("            SALARY SLIP              ");

                    Console.WriteLine("Employee Name : "+first_name+" "+last_name);

                    Console.WriteLine("Employee ID : "+id);

                    Console.WriteLine("Designation : Junior Employee");

                    Console.WriteLine("Basic Pay : "+basic_pay3);

                    Console.WriteLine("DA : "+da);
                    Console.WriteLine("HRA : "+hra);
                    Console.WriteLine("TA "+ta);

                    Console.WriteLine();

                    Console.WriteLine("PF : "+pf);
                    Console.WriteLine("IT : "+it);

                    Console.WriteLine();

                    Console.WriteLine("Net Pay : "+net_pay);

                    Console.WriteLine("*************************************");
                }

                else
                {
                    Console.WriteLine("Sorry! Invalid Designation");
                }
            }

            else
            {
                Console.WriteLine("Sorry! Invalid ID");
            }
        }
    }
}