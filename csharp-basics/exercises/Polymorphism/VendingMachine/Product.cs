namespace VendingMachine
{
    public struct Product
    {
        public int Available { get; set; }
        public Money Price { get; set; }
        public string Name { get; set; }
    }
}
