using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Data;

namespace TextEditor
{
    public class Plist
    {
        private static DataTable mainTable;

        public static DataTable Load(string file)
        {
            mainTable = new DataTable();

            XDocument doc = XDocument.Load(file);
            XElement plist = doc.Element("plist");
            XElement dict = plist.Element("dict");

            var dictElements = dict.Elements();
            Parse(dictElements);

            return mainTable;
        }

        private static void Parse(IEnumerable<XElement> elements)
        {
            //languages
            int numberColumn = elements.Count() / 2;
            Console.WriteLine("NumberColumn: " + numberColumn);

            //get all language package, add to columns
            for (int i = 0; i < numberColumn * 2; i += 2)
            {
                XElement key = elements.ElementAt(i);
                mainTable.Columns.Add(key.Value);
                Console.WriteLine("Add column: " + key.Value);
            }

            //get numberRow
            XElement l = elements.ElementAt(1);
            var lp = l.Elements();
            int numberRow = lp.Count() / 2;
            Console.WriteLine("NumberRow: " + numberRow);


            //foreach all pack
            for (int j = 0; j < numberRow * 2; j += 2)
            {
                string[] rows = new string[numberColumn];

                //foreach each language package
                for (int i = 0; i < numberColumn * 2; i += 2)
                {
                    XElement lang = elements.ElementAt(i + 1); //English -> Vietnamese -> more...
                    var langpack = lang.Elements(); //dict English -> dict Vietnamese -> more...

                    XElement text = langpack.ElementAt(j + 1);
                    rows[i/2] = text.Value;
                    Console.WriteLine(text.Value);
                }

                mainTable.Rows.Add(rows);
            }
        }
    }
}
