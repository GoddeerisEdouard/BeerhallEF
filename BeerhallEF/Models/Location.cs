namespace BeerhallEF.Models
{
    public class Location
    {
        #region Properties
        public string PostalCode { get; }
        public string Name { get; }
        #endregion

        #region Constructors
        public Location(string postalCode, string name)
        {
            PostalCode = postalCode;
            Name = name;
        }
        #endregion
    }
}
