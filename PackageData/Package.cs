using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _207Proj2
{
    /* Creation of Customer class including parameters, constructors, and methods
    * Author: Chad Dundas Smith 
    * Date: Dec 13, 2018
    */
    public class Package 
    {
        // class level declarations
        //const decimal BASE_RATE_RES = 6.00m;        // base rate for bill even if energy usage = 0kWh
        //const decimal RATE_RES = 0.052m;            // rate charge of dollars/kWh if base amount is exceeded
        //const decimal BASE_RATE_COM = 60.00m;       // base rate for bill if energy used is <= 1000
        //const decimal BASE_AMT_COM = 1000;          // amount of energy that can be used before additional charges occur
        //const decimal RATE_COM = 0.045m;            // rate charge of dollars/kWh if base amount is exceeded
        //const decimal BASE_RATE_IND_PEAK = 76.00m;  // base rate for bill if energy used is <= 1000 during peak hours
        //const decimal BASE_AMT_IND = 1000;          // amount of energy that can be used before additional charges occur
        //const decimal RATE_IND_PEAK = 0.065m;       // rate charge of dollars/kWh if base amount is exceeded during peak hours
        //const decimal BASE_RATE_IND_OFF = 40.00m;   // base rate for bill if energy used is <= 1000 during off peak hours
        //const decimal RATE_IND_OFF = 0.028m;        // rate charge of dollars/kWh if base amount is exceeded during off peak hours

        // private data
        private int pkgId; // package id number
        private string pkgName; // package name
        private DateTime pkgStartDate; // start date of package
        private DateTime pkgEndDate; // end date of package
        private string pkgDesc; // brief description of package
        private decimal pkgPrice; // base price of package 
        private decimal pkgAgtCommission; // agency commission on package sale

        // public properties that provide access to the private data
        public int PkgId // package id number
        {
            get { return pkgId; }
            set { pkgId = value; }
        }

        public string PkgName // package name
        {
            get { return pkgName; }
            set { pkgName = value; }
        }

        public DateTime PkgStartDate // start date of package
        {
            get { return pkgStartDate; }
            set { pkgStartDate = value; }
        }

        public DateTime PkgEndDate // end date of package
        {
            get { return pkgEndDate; }
            set { pkgEndDate = value; }
        }

        public string PkgDesc // brief description of package
        {
            get { return pkgDesc; }
            set { pkgDesc = value; }
        }

        public decimal PkgPrice // base price of package 
        {
            get { return pkgPrice; }
            set { pkgPrice = value; }
        }

        public decimal PkgAgtCommission // agency commission on package sale
        {
            get { return pkgAgtCommission; }
            set { pkgAgtCommission = value; }
        }

        public Package() { }
        // constructor
        public Package(int id, string name, DateTime start, DateTime end, string desc, decimal price, decimal commission)
        {
            PkgId = id;
            PkgName = name;
            PkgStartDate = start;
            PkgEndDate = end;
            PkgDesc = desc;
            PkgPrice = price;
            PkgAgtCommission = commission;
        }

        // To.String method used to return a display string
        public override string ToString()
        {
            return pkgId.ToString() + " : " + pkgName.ToString() +
               " : " + pkgStartDate.ToString() + " : " + pkgEndDate.ToString() + " : " +
               pkgDesc.ToString() + " : " + pkgPrice.ToString("c") + " : " + pkgAgtCommission.ToString("c");
        }

        //// method to create string that will be saved to file
        //public string ToFileString()
        //{
        //    return acctNum.ToString() + "," + custName.ToString() + "," +
        //        chargeAmt.ToString() + "," + custType.ToString();
        //}
    }
}
