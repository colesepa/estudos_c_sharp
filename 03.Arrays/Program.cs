using System;

string[] orderId = ["B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"];
List<string> suspectOrderId = [];

foreach(var order in orderId)
{
    if (order.StartsWith('B'))
    {
        suspectOrderId.Add(order);
    }
}

System.Console.WriteLine(string.Join("\n", suspectOrderId));

int firstValue = 600;
int secondValue = 300;

int largerValue = Math.Max(firstValue, secondValue);

System.Console.WriteLine(largerValue);