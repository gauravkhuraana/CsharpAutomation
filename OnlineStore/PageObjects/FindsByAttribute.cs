using System;
using SeleniumExtras.PageObjects;

namespace OnlineStore.PageObjects
{
    internal class FindBy : Attribute
    {
        public How How { get; set; }
        public string Using { get; set; }
    }
}