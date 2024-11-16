namespace EBS_Library
{
    public class AccountModel
    {
        /// <summary>
        /// AccountID, usually student ID or faculty ID
        /// </summary>
        public string AccountID { get; set; }
        /// <summary>
        /// first name of user
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// last name of user
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// program/course of user
        /// </summary>
        public string CourseProgram { get; set; }
        /// <summary>
        /// username of user
        /// </summary>
        public string Username { get; set; }
        /// <summary>
        /// password of user 
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// selected year of user
        /// </summary>
        public string Year { get; set; }
        /// <summary>
        /// list that contains all items borrowed by user
        /// </summary>
        public List<ItemModel> ItemsBorrowed { get; set; } = new List<ItemModel>();
        /// <summary>
        /// overduefees accumulated by user for each overdue item.
        /// </summary>
        public decimal overdueFees { get; set; }
    }
}
