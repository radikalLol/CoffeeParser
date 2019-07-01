using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngleSharp.Parser.Html;
using WindowsFormsApplication4.Core.Optalist;

namespace WindowsFormsApplication4.Core
{
    class ParserWorker<T> where T: class
    {
        IParser<T> parser;
        IParserSettings parserSettings;

        HTMLLoad loader;
        OptParset data = new OptParset();

        bool isActive;


        #region ProperLies

        public event Action<object, T> OnNewDataName;
        public event Action<object> OnCompleted;
        public event Action<object, T> OnNewDataEvaluation;
        public event Action<object, T> OnNewDataPrice;
        public event Action<object, T> OnNewDataAdvice;
        public event Action<object, T> OnNewDataDiscount;

        public IParser<T> Parser
        {
            get
            {
                return parser;
            }
            set
            {
                parser = value;
            }
        }

        public IParserSettings Settings
        {
            get
            {
                return parserSettings;
            }
            set
            {
                parserSettings = value;
                loader = new HTMLLoad(value);
            }
        }


        public bool IsActive
        {
            get
            {
                return isActive;
            }
        }

        #endregion

        public ParserWorker(IParser<T> parser)
        {
            this.parser = parser;
        }


        public ParserWorker(IParser<T> parser, IParserSettings parserSettings) : this(parser)
        {
            this.parserSettings = parserSettings;
        }

        public void Start()
        {
            isActive = true;
            Worker();
        }

        public void Abort()
        {
            isActive = false;

        }

        private async void Worker()
        {
            for (int i = parserSettings.StartPoint; i <= parserSettings.EndPoint; i++)
            {
                if (!isActive)
                {
                    OnCompleted?.Invoke(this);
                    return;
                }


                var source = await loader.GetSourceByPageId(i);
                var domParser = new HtmlParser();


                var document = await domParser.ParseAsync(source);
                var result = parser.Parse(document);
                var result_Evaluation = parser.Parse_Evaluation(document);
                var result_Price = parser.Parse_Price(document);
                var result_Advice = parser.Parse_Advice(document);
                var result_Discount = parser.Parse_Discount(document);

                OnNewDataName(this, result);
                OnNewDataAdvice(this, result_Advice);
                OnNewDataDiscount(this, result_Discount);
                OnNewDataPrice(this, result_Price);
                OnNewDataEvaluation(this, result_Evaluation);

       
            }

            OnCompleted?.Invoke(this);
            isActive = false;
        }
    }
}
