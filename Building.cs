using System;

namespace Planner
{
    public class Building
    {
        //private field _designer of type string(your name)
        //_dateConstructed of type DateTime. hold exact time building created.
        // _address type string, _owner type string (store name of person who owns building)
        private string _designer = "Aryn";
        private DateTime _dateConstructed;
        private string _address = "523 montridge court";
        private string _owner = "James Weatherly";
        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public double Volume
        {
            get
            {
                return this.Width * this.Depth * (3 * this.Stories);
            }
        }
        public Building(string address)
        {
            _address = address;
        }
        public string Description
        {
            get
            {
                return $"{_address}, designed by {_designer}, constructed on {_dateConstructed}, owned by {_owner}, {Volume}";
            }
        }

        public void Construct()
        {
            _dateConstructed = DateTime.Now;
        }
        public void Purchase(string buyer)
        {
            _owner = buyer;
        }
    }
}
//         //Constructor-special method in a class that is called when a new instance of the class is created. The role of a constructor is to make sure the new object is setup and ready for use immediately after it is created.

//         public Building(string address, string name)
//         {
//             _address = address;
//             Name = name;
//         }
//         //public properties
//         public string Name { get; set; }
//         public int Stories { get; set; }
//         public double Width { get; set; }
//         public double Depth { get; set; }
//         public string Volume
//         {
//             get
//             {
//                 return ($"{Width * Depth * (3 * Stories)}");
//             }
//         }

//         public string Description
//         {
//             get
//             {
//                 return ($"{_address} Designed by: {_designer} Date Constructed: {_dateConstructed} Owned by: {_owner} Volume: {Volume}");
//             }
//         }

//         //Methods
//         //define a Construct() method. method's logic should set the _dateConstructed field's value to DateTime.Now
//         public void Construct()
//         {
//             _dateConstructed = DateTime.Now;
//         }
//         public void Purchase(string name)
//         {
//             _owner = name;
//         }
//     }
// }