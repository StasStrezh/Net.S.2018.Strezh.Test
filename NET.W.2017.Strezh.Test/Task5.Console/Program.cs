namespace Task5.Console
{
    using System.Collections.Generic;
    using System;
    using Task5;

    class Program
    {
        static void Main(string[] args)
        {
            List<DocumentPart> parts = new List<DocumentPart>
                {
                    new PlainText {Text = "Some plain text"},
                    new Hyperlink {Text = "google.com", Url = "https://www.google.by/"},
                    new BoldText {Text = "Some bold text"}
                };

            Document document = new Document(parts);
            var html = new ToHtmlConverter();
            var plain = new ToPlainConverter();
            Console.WriteLine(document.ToOtherFormats(html));

            Console.WriteLine(document.ToOtherFormats(plain));
            Console.ReadKey();
        }
    }
}
