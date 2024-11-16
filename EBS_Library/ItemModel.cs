namespace EBS_Library
{
    public class ItemModel
    {
        /// <summary>
        /// Name of item
        /// </summary>
        public string ItemName { get; set; }
        /// <summary>
        /// Fee of item once time limit passes
        /// </summary>
        public decimal overdueFee { get; set; }
        /// <summary>
        /// Available amount of item
        /// </summary>
        public int ItemCount { get; set; }
        /// <summary>
        /// tags/categories of which the item will belong to
        /// </summary>
        public string ItemType { get; set; }
        // picture for item later
        /// <summary>
        /// Time limit of an item before overduefee is given to account
        /// </summary>
        public int ItemTimeLimit { get; set; }

    }
}
