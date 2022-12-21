namespace RansomwareTest.Model
{
    /// <summary>
    /// This model is used to recieve user contact information
    /// </summary>
    public class ContactInfo
    {
        /// <param name="FullName">This parameter is used to recieve User's fullname.</param>
        public string FullName { get; set; }

        /// <param name="Email">This parameter is used to recieve User's emaill address.</param>
        public string Email { get; set; }

        /// <param name="Role">This parameter is used to recieve User's role in the company.</param>
        public string Role { get; set; }

        /// <param name="company">This parameter is used to recieve company object.</param>
        public Company company { get; set; }

    }
}
