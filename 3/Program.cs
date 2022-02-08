using System;
public class SaleItem {
    string _name;
    decimal _cost;
    public SaleItem(string name, decimal cost) {
        _name = name;
        _cost = cost;
    }
    public string Name {
        get => _name;
        set => _name = value;
    }
    public decimal Price {
        get => _cost;
        set => _cost = value;
    }
}
class Program {
    static void Main(string[] args) {
        Console.WriteLine("EXPRESSION BODY DEFINITIONS");
        var item = new SaleItem("SHOES",19.95m);
        Console.WriteLine($"{item.Name}: SELLS FOR {item.Price:C2}");
    }
}