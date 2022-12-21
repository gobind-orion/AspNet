namespace RansomwareTest.Model
{
    /// <summary>
    /// This model is used to recieve membership plan details information
    /// </summary> 
    public class PlanDetails
    {
        /// <param name="PlanType">This parameter is used to recieve plan type selected by user</param>
        public string PlanType { get; set; }

        /// <param name="NoOfUsers">This parameter is used to recieve no of user selected by user</param>
        public string NoOfUsers { get; set; }

        /// <param name="TotalPrice">This parameter is used to recieve total price</param>
        public decimal TotalPrice { get; set; }

        /// <param name="contactInfo">This parameter is used to recieve contact information</param>
        public ContactInfo contactInfo { get; set; }

    }
}
