namespace Core.Interfaces;

public interface ICouponService
{
    Task<Entities.Coupon?> GetCouponFromPromoCode(string code);
}
