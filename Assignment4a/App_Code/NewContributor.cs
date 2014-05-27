using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for NewContributor
/// </summary>
public class NewContributor
{
	
		public string lastName{set; get;}
        public string firstName{set; get;}
        public string email{set; get;}
        public string streetAddress{set; get;}
        public string city{set; get;}
        public string state{set; get;}
        public string postalCode{set; get;}
        public string homePhone{set; get;}
        public string plainTextPassword{set; get;}
        public Byte[] Password { set; get; }
        public int Passcode { set; get; }
}