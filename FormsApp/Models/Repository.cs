namespace FormsApp.Models;

public class Repository
{
    private static readonly List<Product> _products = new();
    private static readonly List<Category> _categories = new();

    static Repository()
    {
        _categories.Add(new Category{CategoryId = 1,Name = "Telefon"});
        _categories.Add(new Category{CategoryId = 2,Name = "Bilgisayar"});
        
        _products.Add(new Product{ProductId = 1,Name = "Iphone 11",Price = 40300,IsAvtive = true,Image = "1.jpeg",CategoryId = 1});
        _products.Add(new Product{ProductId = 2,Name = "Iphone 12",Price = 3000,IsAvtive = true,Image = "2.jpeg",CategoryId = 1});
        _products.Add(new Product{ProductId = 3,Name = "Iphone 13",Price = 42000,IsAvtive = true,Image = "3.jpeg",CategoryId = 1});
        _products.Add(new Product{ProductId = 4,Name = "Iphone 14",Price = 40060,IsAvtive = true,Image = "4.jpeg",CategoryId = 1});
        
        _products.Add(new Product{ProductId = 5,Name = "Macbook Air",Price = 124000,IsAvtive = true,Image = "5.jpeg",CategoryId = 2});
        _products.Add(new Product{ProductId = 6,Name = "Macbook Pro",Price = 131000,IsAvtive = true,Image = "6.jpeg",CategoryId = 2});


    }
    
    
    
    public static List<Product> Products
    {
        get
        {
            return _products;
        }
    }
    
    public static List<Category> Categories 
    {
        get
        {
            return _categories;
        }
    }
}