namespace BasicMVCProject.Models;

public class CustomerOrderViewModel
{
    public List<Customer> Customers {get; set;} // view e gönderirken birden fazla custumer göndermek için list tanımlandı
    public List<Order> Orders {get; set;} // view e gönderirken birden fazla order göndermek için list tanımlandı
}