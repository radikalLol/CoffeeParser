
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngleSharp.Dom.Html;
using AngleSharp.Extensions;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication4.Core.Optalist
{
    class OptParset : IParser<string[]>
    {

        public string[] Parse_Evaluation(IHtmlDocument document)
        {
            var Evaluationlist = new List<string>();
            var evaluations = document.All.Where(evaluation => evaluation.LocalName != null && evaluation.LocalName == "div" && evaluation.HasAttribute("data-rateit-value")).Attr("data-rateit-value");

            foreach (var evaluation in evaluations)
            {
                Evaluationlist.Add(evaluation);
            }

            return Evaluationlist.ToArray();
        }



        public string[] Parse_Discount(IHtmlDocument document)
        {
            var Discountlist = new List<string>();
            var Discounts = document.All.Where(discount => discount.ClassName != null && discount.LocalName == "div" && discount.ClassName.Contains("discount_price"));

            foreach (var discount in Discounts)
            {
                Discountlist.Add(discount.TextContent);
            }

           for (int i = 0; i < Discountlist.Count; i++)
            {
                Discountlist[i] = Discountlist[i].Trim();
            }

            return Discountlist.ToArray();
        }



        public string[] Parse_Price(IHtmlDocument document)
        {
            int i = 0;
            var PriceList = new List<string>();
            var prices = document.All.Where(price => price.ClassName != null && price.LocalName == "div" && price.ClassName.Contains("price_weight"));


            foreach (var price in prices)
            {
                PriceList.Add(price.TextContent);
            }

            while (i < PriceList.Count)
            {
                PriceList.RemoveRange(i, Math.Min(1, PriceList.Count - i++));
            }

            return PriceList.ToArray();

        }


        public string[] Parse_Advice(IHtmlDocument document)
        {
            var AdviceList = new List<string>();
            var advices = document.All.Where(advice => advice.ClassName != null && advice.LocalName == "div" && advice.ClassName.Contains("labelCategoryName"));


            foreach (var advice in advices)
            {
                AdviceList.Add(advice.TextContent);
            }
            for (int i = 0; i < AdviceList.Count; i++)
            {
                AdviceList[i] = AdviceList[i].Trim();
            }
            return AdviceList.ToArray();
        }



        public string[] Parse(IHtmlDocument document)

        {
            var list = new List<string>();

            var items = document.QuerySelectorAll("a").Where(item => item.ClassName != null && item.ClassName.Contains("name_item mobileNone"));

            foreach (var item in items)
            {

                list.Add(item.TextContent);
            }
            for (int i = 0; i < list.Count; i++)
            {
                list[i] = list[i].Trim();
            }

            return list.ToArray();
        }

    }
}
