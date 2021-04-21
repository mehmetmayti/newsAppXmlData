using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace newsAppXmlData
{
    class Services
    {
        string lastNewsApiUrl = "https://www.cnnturk.com/feed/rss/all/news";


        public List<DataModel> getAllLastNews()
        {
            List<DataModel> listNews = new List<DataModel>();
            XElement doc = XElement.Load(lastNewsApiUrl);

            var news = doc.Elements("channel").Elements("item");
          
            foreach (var item in news)
            {
                DataModel data = new DataModel();
                data.newsLink = item.Element("link").Value;
                data.newstitle = item.Element("title").Value;
                data.newsDescription= item.Element("description").Value;
                data.imageUrl= item.Element("image").Value;
                data.newsPubDate=DateTime.Parse(item.Element("pubDate").Value);
                listNews.Add(data);

            }

            
            return listNews;
        }




    }
}
