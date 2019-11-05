public class InventoryItem
{
    public InventoryItemConfig Config { get; }
    public int Amount { get; set; }

    public InventoryItem(InventoryItemConfig config, int amount)
    {
        Config = config;
        Amount = amount;
    }
}