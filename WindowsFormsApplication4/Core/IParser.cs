
using AngleSharp.Dom.Html;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication4.Core
{
    interface IParser<T> where T : class
    {
        T Parse(IHtmlDocument document);
        T Parse_Evaluation(IHtmlDocument document);
        T Parse_Discount(IHtmlDocument document);
        T Parse_Price(IHtmlDocument document);
        T Parse_Advice(IHtmlDocument document);
    }
}
