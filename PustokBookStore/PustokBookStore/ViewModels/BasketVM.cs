namespace PustokBookStore.ViewModels
{
    public class BasketVM
    {
        public List<BasketItemVM> Items { get; set; }
        public decimal TotalAmount { get; set; }    
    }
}
