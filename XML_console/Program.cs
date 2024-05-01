
using System;
using System.Xml;


namespace XML_console
{
	class Program
	{
		static void Main(string[] args)
		{
			string URLString = @"C:\xml\Books.xml";

			XmlTextReader reader = new XmlTextReader(URLString);

			while (reader.Read())
			{
				switch (reader.NodeType)
				{
					case XmlNodeType.Element: // The node is an element.
						Console.Write("<" + reader.Name);

						while (reader.MoveToNextAttribute()) // Read the attributes.
							Console.Write(" " + reader.Name + "='" + reader.Value + "'");
						Console.Write(">");

						break;
					case XmlNodeType.Text: //Display the text in each element.
						Console.WriteLine(reader.Value);
						break;
					case XmlNodeType.EndElement: //Display the end of the element.
						Console.Write("</" + reader.Name);
						Console.WriteLine(">");
						break;
				}
			}
		}

	}
}

