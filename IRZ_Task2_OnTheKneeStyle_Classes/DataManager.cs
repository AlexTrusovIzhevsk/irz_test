using System;
using System.IO;
using System.Net;

namespace IRZ_Task2_OnTheKneeStyle_Classes
{
    public static class DataManager
    {
        public static Data GetDataFromWeb(string title, string author, string link)
        {
            using (var stream = WebRequest.Create(link).GetResponse().GetResponseStream())
            {
                using (var reader = new StreamReader(stream))
                {
                    var answered = reader.ReadToEnd();
                    return new Data(DateTime.Now, title, author, answered, link);
                }
            }
        }

        public static Data ReadDataFromFile(string path) => DataSerializer.Read(path);

        public static void SaveDataToFile(Data data, string path) => DataSerializer.Writer(data, path);

        public static string ConvertToHtml(Data data)
        {
            var htmlText = "<html><head><title>Data</title></head><body><table>" +
                           "<tr><th>CreationDate</th><th>Title</th><th>Author</th><th>Answered</th><th>Link</th></tr>" +
                           $"<tr><td>{data.CreationDate}</td><td>{data.Title}</td><td>{data.Author}</td><td>{data.Answered}</td><td>{data.Link}</td></tr>" +
                           $"</table></body></html>";
            return htmlText;
        }

        public static void SaveDataAsHtmlToFile(Data data, string path)
        {
            using (var fileStream = new FileStream(path, FileMode.Create))
            {
                using (var writer = new StreamWriter(fileStream))
                {
                    writer.Write(ConvertToHtml(data));
                }
            }
        }
    }
}