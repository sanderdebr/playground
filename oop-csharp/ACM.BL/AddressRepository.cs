using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class AddressRepository
    {
        public Address Retrieve(int addressId)
        {
            Address address = new Address(addressId);

            if (addressId == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "berend";
            }

            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "berend"
            };
            addressList.Add(address);

            address = new Address(1)
            {
                AddressType = 2,
                StreetLine1 = "balhaar"
            };
            addressList.Add(address);

            return addressList;

        }

        public bool Save(Address address)
        {
            return true;
        }
    }
}
