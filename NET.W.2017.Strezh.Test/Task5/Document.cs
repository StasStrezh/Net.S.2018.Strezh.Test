using System;
using System.Collections.Generic;

namespace Task5
{
    public class Document
    {
        private List<DocumentPart> parts;

        public Document(IEnumerable<DocumentPart> parts)
        {
            if (parts == null)
            {
                throw new ArgumentNullException(nameof(parts));
            }
            this.parts = new List<DocumentPart>(parts);
        }

        public string ToOtherFormats(IConverter converter)
        {
            string output = string.Empty;

            foreach (var part in this.parts)
            {
                output += part.Convert(converter);
            }

            return output;
        }
    }
}
