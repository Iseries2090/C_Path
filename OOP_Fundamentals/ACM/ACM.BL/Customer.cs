using System;

namespace ACM.BL
{
    public class Customer
    {
        public int CustomerID { get; private set; }
        public string EmailAddress { get; set; }
        //Using the short hand if the getters / setters require no logic.  Behind the scenes it still makes the backing field
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return LastName + "," + FirstName;
            }
        }





    }
}
