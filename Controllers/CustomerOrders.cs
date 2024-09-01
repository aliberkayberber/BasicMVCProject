using Microsoft.AspNetCore.Mvc;
using BasicMVCProject.Models;
using BasicMVCProject.Controllers;

public class CustomerOrders : Controller
{
    public IActionResult Index()
    {
        
        List<Customer> customers = new List<Customer>{ // customerlar tanımlanıyor

            new Customer{Id=1, FirstName="Berkay",LastName="Berber",Email = "Aliberkayberber@gmial.com"},
            new Customer{Id = 2, FirstName = "Ali",LastName="Veli", Email = "Aliveli4950@gmail.com"},
            new Customer{Id=3, FirstName="Nizamettin",LastName= "Güvenç", Email="Nizomizo@gmail.com"}
        };

        List<Order> orders = new List<Order> // orderlar tanımlanıyor
        {
            new Order {Id =1, ProductName = "Şapka", Price = 50000, Quantity =1},
            new Order {Id =2, ProductName = "Pantolon", Price = 25000, Quantity = 2},
            new Order {Id = 3, ProductName ="Kulaklık", Price= 1540, Quantity = 2},
            new Order {Id = 4, ProductName = "Şal", Price = 120,Quantity=154}
        };

        CustomerOrderViewModel viewModel = new CustomerOrderViewModel {  // oluşan listeleri view e gönderiyoruz

            Customers= customers,
            Orders = orders

        };

        return View(viewModel);
    }
}
