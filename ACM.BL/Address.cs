namespace ACM.BL
{
    public class Address
    {
        public Address()
        {
        }

        public Address(int addressId)
        {
            AddressId = addressId;
        }

        public int AddressId { get; private set; }
        public int AddressType { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string State { get; set; }
        public int StreetLine1 { get; set; }
        public int StreetLine2 { get; set; }

        /// <summary>Validates the address data</summary>
        public bool Validate()
        {
            var isValid = true;

            if (IsNull(PostalCode))
                isValid = false;

            return isValid;
        }

        private bool IsNull(string value)
        {
            return value == null;
        }
    }
}