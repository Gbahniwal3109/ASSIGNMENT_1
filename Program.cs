using System;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------WELCOME TO ARNOLD'S AMAZING EATS------------------");
            Console.WriteLine("ENTER FIRST NAME  : ");
            var name =  Console.ReadLine();
            Console.WriteLine("ENTER LAST NAME  :");
            var l_name = Console.ReadLine();
            Console.WriteLine("STEERT NUMBER  : ");
            var street_no_add=Console.ReadLine();
            Console.WriteLine("ENTER STREET NAME ");
            var street_name_add=Console.ReadLine();
            Console.WriteLine("ENTER CITY NAME ");
            var add_city=Console.ReadLine();
            Console.WriteLine("ENTER PROVINCE ");
            var add_province=Console.ReadLine();
            Console.WriteLine("ENTER POSTAL CODE ");
            var add_po_code=Console.ReadLine();
            Console.WriteLine("ENTER SPECIAL  INSTRUCTION  ");
            var add_specail=Console.ReadLine();
            Console.WriteLine("ENTER PHONE NUMBER ");
            var add_phone=Console.ReadLine();
            
            data:;
            Console.WriteLine("ENTER THE ITEM  NUMBER YOU WANT TO BUY");
            Console.WriteLine("1. PIZZA   AMOUNT $6.45 \n 2. BURGER AMOUNT $3.0 " );
            Console.WriteLine(" ITEM NUMBER ");
            var check=Console.ReadLine();
            int checkCase = Convert.ToInt32(check);
            
            switch(checkCase){
                case 1: Console.WriteLine("ENTER THE QUANTITY FOR PIZZA  YOU WANT");
                        String p_quantity = Console.ReadLine();
                        
                        // Console.WriteLine("QUANTITY FOR PIZZA ARE " + p_quantity);
                        d_chck:;
                        Console.WriteLine("QUANTITY FOR PIZZA ARE " + p_quantity);
                        int qp=Convert.ToInt32(p_quantity);
                        var f_price_pizza = 6.45* qp;
                        
                        // Console.WriteLine("ENTERED Q IS "+ p_q);
                        Console.WriteLine( "Enter Y and y  for Yes and N and  n for No");
                        Console.WriteLine("CONFORM YOUR ORDER ");
                        String con= Console.ReadLine();
                        if (con =="Y" || con =="y"){
                            Console.WriteLine("YOUR ORDER IS CONFORM");
                            p_student:;
                            Console.WriteLine("ENTER y and Y for STUDENT , n and N FOR NOT A STUDENT");
                            var s_check = Console.ReadLine();
                            if (s_check =="y" || s_check=="Y"){
                                Console.WriteLine("YOUR ARE GIVEN A 10% DISCOUNT");
                                double dis = f_price_pizza *10/100;
                                Console.WriteLine("FINAL PRICE AFTER GIVING DISCOUNT "+dis);
                                Console.WriteLine("NAME IS : "+name ,l_name);
                                Console.WriteLine("ORDER                ITEM AMT          ITEM PRICE           TOTAL");
                                Console.WriteLine("------------       -----------         ------------       -----------");
                                Console.WriteLine("PIZZA              "+ qp+"                   $6.45" +"              "+"$"+f_price_pizza);
                                Console.WriteLine();
                                Console.WriteLine("10% STUDENT SAVING                                       -$"+dis);
                                double su= f_price_pizza-dis;
                                Console.WriteLine("                                            SUB TOTAL     $"+su);
                                double tax = su*13/100;
                                Console.WriteLine("                                            TAX (13%)    $"+tax);
                                Console.WriteLine("                                                       ------------");
                                double f_p_price = su+tax;
                                Console.WriteLine("                                            TOTAL       $"+f_p_price);
                            }else if (s_check=="n"|| s_check=="N"){
                                Console.WriteLine("NAME IS : "+name ,l_name);
                                Console.WriteLine("ORDER                ITEM AMT          ITEM PRICE           TOTAL");
                                Console.WriteLine("------------       -----------         ------------       -----------");
                                Console.WriteLine("PIZZA              "+ qp+"                   $6.45" +"              "+"$"+f_price_pizza);
                                Console.WriteLine();
                               
                                Console.WriteLine("                                            SUB TOTAL     $"+f_price_pizza);
                                double tax = f_price_pizza*13/100;
                                Console.WriteLine("                                            TAX (13%)    $"+tax);
                                Console.WriteLine("                                                       ------------");
                                double f_p_price = f_price_pizza+tax;
                                Console.WriteLine("                                            TOTAL       $"+f_p_price);
                            }
                        }else if (con == "n" || con=="N") {
                            goto data;
                        }else {
                            Console.WriteLine("ENTER VALID INPUT");
                            // goto d_chck;
                        }
                        // goto data;
                        
                        break;
                case 2: Console.WriteLine("ENTER THE QUANTITY FOR BURGER  YOU WANT");
                        var b_quantity = Console.ReadLine();
                        
                        // Console.WriteLine("QUANTITY FOR PIZZA ARE " + p_quantity);
                        b_chck:;
                        Console.WriteLine("QUANTITY FOR BURGER ARE " + b_quantity);
                        int qb=Convert.ToInt32(b_quantity);
                        double f_price_burger = 3* qb;
                        
                        // Console.WriteLine("ENTERED Q IS "+ p_q);
                        Console.WriteLine( "Enter Y and y  for Yes and N and  n for No");
                        Console.WriteLine("CONFORM YOUR ORDER ");
                        String con_b= Console.ReadLine();
                        if (con_b =="Y" || con_b =="y"){
                            Console.WriteLine("YOUR ORDER IS CONFORM");
                        
                            Console.WriteLine("ENTER y and Y for STUDENT , n and N FOR NOT A STUDENT");
                            var s_check = Console.ReadLine();
                            if (s_check =="y" || s_check=="Y"){
                                Console.WriteLine("YOUR ARE GIVEN A 10% DISCOUNT");
                                double dis = f_price_burger *10/100;
                                Console.WriteLine("FINAL PRICE AFTER GIVING DISCOUNT "+dis);
                                Console.WriteLine("NAME IS : "+name ,l_name);
                                Console.WriteLine("ORDER                ITEM AMT          ITEM PRICE           TOTAL");
                                Console.WriteLine("------------       -----------         ------------       -----------");
                                Console.WriteLine("BURGER              "+ qb+"                   $3.00" +"              "+"$"+f_price_burger);
                                Console.WriteLine();
                                Console.WriteLine("10% STUDENT SAVING                                       -$"+dis);
                                double su= f_price_burger-dis;
                                Console.WriteLine("                                            SUB TOTAL     $"+su);
                                double tax = su*13/100;
                                Console.WriteLine("                                            TAX (13%)    $"+tax);
                                Console.WriteLine("                                                       ------------");
                                double f_b_price = su+tax;
                                Console.WriteLine("                                            TOTAL       $"+f_b_price);
                            }else if (s_check=="n"|| s_check=="N"){
                                Console.WriteLine("NAME IS : "+name ,l_name);
                                Console.WriteLine("ORDER                ITEM AMT          ITEM PRICE           TOTAL");
                                Console.WriteLine("------------       -----------         ------------       -----------");
                                Console.WriteLine("BURGER              "+ qb+"                   $3.00" +"              "+"$"+f_price_burger);
                                Console.WriteLine();
                                
                                Console.WriteLine("                                            SUB TOTAL     $"+f_price_burger);
                                double tax = f_price_burger*13/100;
                                Console.WriteLine("                                            TAX (13%)    $"+tax);
                                Console.WriteLine("                                                       ------------");
                                double f_b_price = f_price_burger+tax;
                                Console.WriteLine("                                            TOTAL       $"+f_b_price);
                            }
                        }else if (con_b == "n" || con_b=="N") {
                            goto data;
                        }else {
                            Console.WriteLine("ENTER VALID INPUT");
                            goto b_chck;
                        }
                        // goto data;
                        
                        break;
                default:Console.WriteLine("INVALID INPUT") ;
                        break;
            }
            


            
            // Console.WriteLine( "FIRST NAME IS "+name,l_name);
            // Console.WriteLine("YOUR ADDRESS IS +"+street_no_add+"\n"+street_name_add+"\n"+add_city+"\n"+add_province+"\n"+add_po_code+"\n"+add_specail+"\n"+add_phone);
        }
    }
}
