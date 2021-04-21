using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierAdministrator
{
    class GetItem
    {
        private string name, id, price, path;

        //get and set item name
        public string ItemName {
            set {

                name = value;

            }

            get {

                return name;
            }

        }

        //get and set item identification number
        public string ItemId
        {
            set
            {

                id = value;

            }

            get
            {

                return id;
            }

        }

        //get and set item price
        public string ItemPrice
        {
            set
            {

                price = value;

            }

            get
            {

                return price;
            }

        }

        //get and set item picture path or url
        public string ItemPath
        {
            set
            {

                path = value;

            }

            get
            {

                return path;
            }

        }
    }
}
