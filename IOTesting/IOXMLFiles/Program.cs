﻿using System;
using System.Xml;
using System.Xml.Linq;

namespace IOXMLFiles
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string value = "", property = "";

			string path	= System.IO.Path.Combine (AppDomain.CurrentDomain.BaseDirectory, "test.xml");

			//Прочитане на xml файл
			using (XmlReader reader = XmlReader.Create (path)) {

				while (reader.Read ()) {
					switch (reader.Name) {

					case "row":
						property = reader ["property"];
						value = reader.ReadInnerXml ();

						Console.WriteLine ("Value = " + value);
						Console.WriteLine ("Property = " + property);

						break;

					case "SimpleRow":
						//property = reader ["property"];
						value = reader.ReadInnerXml ();

						Console.WriteLine ("Value = " + value);
						//Console.WriteLine ("Property = " + property);

						break;
					}
				
				}
			}


			Console.ReadKey ();

			//Запис на xml файл

//			string path	= System.IO.Path.Combine (AppDomain.CurrentDomain.BaseDirectory, "test.xml");
//
//			using (XmlWriter writer = XmlWriter.Create (path)) {
//
//				writer.WriteStartDocument ();
//				writer.WriteStartElement ("Settings");
//
//				//Съдържание на файла
//				writer.WriteStartElement ("row");
//
//				writer.WriteAttributeString ( "property", property); 	//<row propetry=" ..."> ... </row>
//				writer.WriteString (value); //<row> value </row>
//
//				writer.WriteEndElement ();
//
//
//				writer.WriteEndElement ();
//				writer.WriteEndDocument ();
//
//			}
//
//			XDocument document = XDocument.Load ( path );
//			document.Save (path);
//
//			System.Diagnostics.Process.Start (path);
		}
	}
}
