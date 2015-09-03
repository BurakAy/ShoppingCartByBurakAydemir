using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace burakAydemirFinalProject
{
    class Product
    {
        //private string mCategory;
        private string mMake;
        private string mModel;
        private string mSKU;
        private string mType;
        private decimal mPrice;
        private Image mItem;
        private string mDescription;

        //public string Category
        //{
        //    get { return mCategory; }
        //    set { mCategory = value; }
        //}

        public string Make
        {
            get { return mMake; }
            set { mMake = value; }
        }

        public string Model
        {
            get { return mModel; }
            set { mModel = value; }
        }

        public string SKU
        {
            get { return mSKU; }
            set { mSKU = value; }
        }

        public string Type
        {
            get { return mType; }
            set { mType = value; }
        }

        public decimal Price
        {
            get { return mPrice; }
            set { mPrice = value; }
        }

        public Image Item
        {
            get { return mItem; }
            set { mItem = value; }
        }

        public string Description
        {
            get { return mDescription; }
            set { mDescription = value; }
        }

        public Product()
        {

        }

        public Product(string make, string model, string sku, string type, decimal price, Image item, string description)
        {
            mMake = make;
            mModel = model;
            mSKU = sku;
            mType = type;
            mPrice = price;
            mItem = item;
            mDescription = description;
        }


    }//end class
}
