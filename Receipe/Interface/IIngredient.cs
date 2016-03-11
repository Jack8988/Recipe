namespace Recipes
{
    public interface IIngredient
    {
        decimal UnitPrice { get; set; }
        decimal Quantity { get; set; }        
        bool IsOrganicDiscount { get; set; }
        bool IsTaxable { get; set; }        
        decimal SaleTaxRate { get; set; }
        decimal DiscountRate { get; set; }

    }
}
