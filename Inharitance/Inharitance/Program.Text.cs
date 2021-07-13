using System;

namespace Inharitance
{
   
        public class Text : PresentationObject
        {
            public int FontSize { set; get; }
            public int FontName { set; get; }

            public void AddHyperLink(string url)
            {
                Console.WriteLine("you added a link: " + url);
            }
        }
    }
