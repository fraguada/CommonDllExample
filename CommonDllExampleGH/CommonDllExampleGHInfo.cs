using System;
using System.Drawing;
using Grasshopper.Kernel;

namespace CommonDllExampleGH
{
    public class CommonDllExampleGHInfo : GH_AssemblyInfo
    {
        public override string Name
        {
            get
            {
                return "CommonDllExampleGH";
            }
        }
        public override Bitmap Icon
        {
            get
            {
                //Return a 24x24 pixel bitmap to represent this GHA library.
                return null;
            }
        }
        public override string Description
        {
            get
            {
                //Return a short string describing the purpose of this GHA library.
                return "";
            }
        }
        public override Guid Id
        {
            get
            {
                return new Guid("2af0e648-5d8a-4822-8fba-8a79ee7b3aca");
            }
        }

        public override string AuthorName
        {
            get
            {
                //Return a string identifying you or your company.
                return "";
            }
        }
        public override string AuthorContact
        {
            get
            {
                //Return a string representing your preferred contact details.
                return "";
            }
        }
    }
}
