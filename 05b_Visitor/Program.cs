/* 	
 * David Kranewitter
 * Simon Hintersonnleitner
*/


using System;
using System.Xml;


namespace b_Visitor
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			XmlDocument doc = new XmlDocument();
			doc.Load("test.xml");
			XmlElement root = doc.DocumentElement;


			ItemList allItems = readNodes(root);

			Console.WriteLine("DebugVisitor\n");
			DebugVisitor dv = new DebugVisitor(); 
			allItems.accept(dv);

			Console.WriteLine("\n -------- \n");

			Console.WriteLine("XMLWriterVisitor\n");
			XMLWriterVisitor wv = new XMLWriterVisitor(); 
			allItems.acceptXMLVisitor(wv);

		}

		public static ItemList readNodes (XmlNode actNode)
		{
			ItemList list = new ItemList (actNode.Attributes["name"].Value);
			XmlNodeList nodes = actNode.ChildNodes;

			foreach (XmlNode node in nodes)
			{
				if (node.Name == "list") 
				{
					list.addItem(readNodes(node));
				} 
				else if (node.Name == "book") 
				{
					list.addItem(new Book (node.Attributes ["name"].Value, Convert.ToDouble(node.Attributes ["price"].Value), node.Attributes ["isbn"].Value));
				} 
				else if (node.Name == "cd") 
				{
					list.addItem(new Cd (node.Attributes ["name"].Value, Convert.ToDouble(node.Attributes ["price"].Value)));
				}
			}
			return list;
		}
	}
}
