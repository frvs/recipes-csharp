namespace Recipes.Api.Dtos
{
    public class EquipmentDto
    {
        public ToolDto Tool { get; set; } = new ToolDto();
        public int Quantity { get; set; }
    }
}
