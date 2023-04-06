using Basket.Entities;

namespace Basket.BAL.IServices
{
    public interface IBasketService
    {
        Task<ShoppingCart> GetBasket(string userName);
        Task<ShoppingCart> UpdateBasket(ShoppingCart basket);
        Task DeleteBasket(string userName);
    }
}
