namespace Core.Entities;

public class Coupon
{
    public required string Name { get; set; }
    public decimal? AmountOff { get; set; }
    public decimal? PercentOff { get; set; }
    public required string PromotionCode { get; set; }
    public string? CouponId { get; set; }
}
