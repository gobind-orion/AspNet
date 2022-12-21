namespace RansomwareTest.Model
{
    /// <summary>
    /// This model is used to recieve company information
    /// </summary>    
    public class Company
    {
        /// <param name="Name">This parameter is used to take company name.</param>
        public string Name { get; set; }

        /// <param name="Size">This parameter is used to recieve company user size.</param>
        public string Size { get; set; }

        /// <param name="Location">This parameter is used to recieve company's location.</param>
        public string Location { get; set; }

    }
}
