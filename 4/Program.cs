using System;
public class SaleItem {
    public string Name {
        get;
        set;
    }
    public decimal Price {
        get;
        set;
    }
}
class Program {
    static void Main(string[] args) {
        Console.WriteLine("AUTO-IMPLEMENTED PROPERTIES");
        var item = new SaleItem {
            Name = "SHOES", Price = 19.95m
        };
        Console.WriteLine($"{item.Name}: SELLS FOR {item.Price:C2}");
    }
}