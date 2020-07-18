using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaDeliveryProgram
{
    // this class is used for the base of the pizza
    public class Base
    {
        private string baseType;
        public Base(string BaseType)
        {
            baseType = BaseType;
        }

        public string GetBaseType()
        {
            // returns name of base size
            return baseType;
        }
    }

    // derived classes of Base to get size of pizza base
    public class Small : Base
    {
        private string baseType;
        public Small(string BaseType): base(BaseType)
        {
            baseType = BaseType;
        }

        

        // returns name of base size
        public string getbaseType()
        {
            return baseType;
        }

    }

    public class Medium : Base
    {
        private string baseType;
        public Medium(string BaseType) : base(BaseType)
        {
            baseType = BaseType;
        }



        public string getbaseType()
        {
            // returns name of base size
            return baseType;
        }

    }

    public class Large : Base
    {
        private string baseType;
        public Large(string BaseType) : base(BaseType)
        {
            baseType = BaseType;
        }



        public string getbaseType()
        {
            // returns name of base size
            return baseType;
        }

    }

}
