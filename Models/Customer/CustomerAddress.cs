using System.Xml.Serialization;

namespace Cosmos.Models.Customer
{
    [XmlRoot("customerAddress")]
    public class CustomerAddress 
    {
        [XmlElement(ElementName = "addressLine1")]
        public string AddressLine1 { get; set; }

        [XmlElement(ElementName = "addressLine2")]
        public string AddressLine2 { get; set; }

        [XmlElement(ElementName = "addressLine3")]
        public string AddressLine3 { get; set; }

        [XmlElement(ElementName = "addressLine4")]
        public string AddressLine4 { get; set; }

        [XmlElement(ElementName = "country")]
        public string Country { get; set; }

        [XmlElement(ElementName = "zipCode")]
        public string ZipCode { get; set; }

        [XmlElement(ElementName = "regionCode")]
        public string RegionCode { get; set; }

        [XmlElement(ElementName = "county")]
        public string County { get; set; }

        [XmlElement(ElementName = "city")]
        public string City { get; set; }

        [XmlElement(ElementName = "state")]
        public string State { get; set; }

        [XmlElement(ElementName = "street")]
        public string Street { get; set; }

        [XmlElement(ElementName = "firstName")]
        public string FirstName { get; set; }

        [XmlElement(ElementName = "lastName")]
        public string LastName { get; set; }

        [XmlElement(ElementName = "middleInitial")]
        public string MiddleInitial { get; set; }

        [XmlElement(ElementName = "companyName")]
        public string CompanyName { get; set; }

        [XmlElement(ElementName = "primaryPhone")]
        public string PrimaryPhone { get; set; }

        [XmlElement(ElementName = "secondaryPhone")]
        public string SecondaryPhone { get; set; }

        [XmlElement(ElementName = "emailAddress")]
        public string EmailAddress { get; set; }
    }
}