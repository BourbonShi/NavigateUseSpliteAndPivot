using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Model
{
    public class MyPivotItem
    {
        public string Header { get; set; }
        public List<ContentItem> ContentList { get; set; }
        public MyPivotItem()
        {
            this.Header = "123";
            this.ContentList = new List<ContentItem>()
            {
                    new ContentItem()
                    {
                        Content = "1111111111111"
                    },
                    new ContentItem()
                    {
                        Content = "22222222222222"
                    },
                    new ContentItem()
                    {
                        Content = "33333333333333"
                    },
            };
        }
    }
}
