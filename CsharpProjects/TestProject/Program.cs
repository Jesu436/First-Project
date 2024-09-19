using System;
string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

string[] orderIds =  orderStream.Split(',');
foreach(string order in orderIds )
{
    if ( order.Length != 4 )
    {
        Console.WriteLine(order + "- Error" );
    }
    else 
    {
        Console.WriteLine(order);
    }

}





    






