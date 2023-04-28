using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.IO;

namespace Words
{
    class DictionaryItem
    {
        public DictionaryItem(string expression, string translation,
            string comment_expression, string comment_translation,
            string status, string counter, ArrayList properties)
        {
            Expression = expression;
            Translation = translation;
            CommentExpression = comment_expression;
            CommentTranslation = comment_translation;
            Status = status;
            Counter = counter;
            Properties = properties;
        }

        public string Expression;
        public string Translation;
        public string CommentExpression;
        public string CommentTranslation;
        public string Status;
        public string Counter;
        public ArrayList Properties;
    }

    class Dictionary
    {
        private string _fileName = "dictionary.xml";
		private XmlDocument _xmlDoc = new XmlDocument();
//-------------------------------------------------------------------
        public Dictionary()
		{
			try
			{
                _xmlDoc.Load(_fileName);
			}
			catch
			{
                _xmlDoc = new XmlDocument();

                string xmlData = "<dictionary></dictionary>";
                _xmlDoc.Load(new StringReader(xmlData));

				Save();
			}
		}
//-------------------------------------------------------------------
        private void Save()
        {
            _xmlDoc.Save(_fileName);
        }
//-------------------------------------------------------------------
        private XmlElement CreateItem(DictionaryItem data)
        {
            XmlElement item = _xmlDoc.CreateElement("item");
            item.SetAttribute("expression", data.Expression);
            item.SetAttribute("translation", data.Translation);
            item.SetAttribute("comment_expression", data.CommentExpression);
            item.SetAttribute("comment_translation", data.CommentTranslation);
            item.SetAttribute("status", data.Status);
            item.SetAttribute("counter", data.Counter);

            if (data.Properties != null)
            {
                foreach (string propName in data.Properties)
                {
                    XmlElement property = _xmlDoc.CreateElement("property");
                    property.SetAttribute("name", propName);
                    item.AppendChild(property);
                }
            }

            return item;
        }

        public void AddItem(DictionaryItem data)
        {
            _xmlDoc.DocumentElement.AppendChild(CreateItem(data));

            Save();
        }

        private bool CompareXmlElementAndDictionaryItem(XmlElement e, DictionaryItem data)
        {
            bool res = true;

            foreach (string dataPropName in data.Properties)
            {
                bool check = false;
                foreach (XmlElement node in e.ChildNodes)
                {
                    if (dataPropName == node.Attributes["name"].Value)
                    {
                        check = true;
                        break;
                    }
                }

                res = check;
                if (res == false) break;
            }

            return res == true &&
                data.Expression == e.Attributes["expression"].Value &&
                data.Translation == e.Attributes["translation"].Value &&
                data.CommentExpression == e.Attributes["comment_expression"].Value &&
                data.CommentTranslation == e.Attributes["comment_translation"].Value &&
                data.Status == e.Attributes["status"].Value &&
                data.Counter == e.Attributes["counter"].Value;
        }

        public void RemoveItem(DictionaryItem data)
        {
            if (data != null)
            {
                foreach (XmlElement e in _xmlDoc.DocumentElement)
                {
                    if (CompareXmlElementAndDictionaryItem(e, data))
                    {
                        _xmlDoc.DocumentElement.RemoveChild(e);
                    }
                }

                Save();
            }
        }

        public void ReplaceItem(DictionaryItem newData, DictionaryItem oldData)
        {
            if (oldData != null && newData != null)
            {
                foreach (XmlElement e in _xmlDoc.DocumentElement)
                {
                    if (CompareXmlElementAndDictionaryItem(e, oldData))
                    {
                        _xmlDoc.DocumentElement.ReplaceChild(CreateItem(newData), e);
                    }
                }

                Save();
            }
        }

        private XmlNodeList GetDictionary()
        {
            return _xmlDoc.DocumentElement.ChildNodes;
        }

        /*private ArrayList GetProperties(string groupName, string objectName)
        {
            XmlNodeList nodeList = GetObject(groupName, objectName);

            ArrayList list = new ArrayList();

            foreach (XmlElement element in nodeList)
            {
                list.Add(element.GetAttribute("name"));
            }

            return list;
        }*/

        public ArrayList GetItems()
        {
            ArrayList list = new ArrayList();

            XmlNodeList dict = GetDictionary();

            foreach (XmlElement item in dict)
            {
                ArrayList properties = new ArrayList();

                foreach (XmlElement proper in item.ChildNodes)
                {
                    properties.Add(proper.GetAttribute("name"));
                }

                list.Add(new DictionaryItem(item.GetAttribute("expression"),
                    item.GetAttribute("translation"),
                    item.GetAttribute("comment_expression"),
                    item.GetAttribute("comment_translation"),
                    item.GetAttribute("status"),
                    item.GetAttribute("counter"),
                    properties));
            }

            return list;
        }

        //public DictionaryItem Items
        //{
        //    get
        //    {
        //        DictionaryItem item = new DictionaryItem("", "", "", null);
        //        return item;
        //    }
        //}


        /*private*/ public DictionaryItem GetItem(int index)
        {
            XmlNodeList qwe = GetDictionary();
            return null;
        }

//-------------------------------------------------------------------
        //public 

        //public void SetProperty(string group, string objectType, string objectName, string propertyType, string propertyName, string propertyAttr, string attrValue)
        //{
        //    XmlElement el = GetElement(group, objectType, objectName, propertyType, propertyName);

        //    if (el != null)
        //    {
        //        el.SetAttribute(propertyAttr, attrValue);
        //    }
        //    else
        //    {
        //        XmlElement elem = _config.CreateElement(propertyType);
        //        elem.SetAttribute("name", propertyName);
        //        elem.SetAttribute(propertyAttr, attrValue);

        //        el = GetObject(group, objectType, objectName);

        //        if(el == null)
        //        {
        //            el = MakeObject(group, objectType, objectName);
        //        }
        //        el.AppendChild(elem);
        //    }
        //    Save();
        //}
//-------------------------------------------------------------------
        //private XmlElement GetObject(string group, string objectType, string objectName)
        //{
        //    int i, j;

        //    for (i = 0; i < _config.DocumentElement.ChildNodes.Count; i++)
        //    {
        //        if (group == _config.DocumentElement.ChildNodes[i].Name)
        //        {
        //            for (j = 0; j < _config.DocumentElement.ChildNodes[i].ChildNodes.Count; j++)
        //            {
        //                if (objectType == _config.DocumentElement.ChildNodes[i].ChildNodes[j].Name &&
        //                    objectName == ((XmlElement)_config.DocumentElement.ChildNodes[i].ChildNodes[j]).GetAttribute("name"))
        //                {
        //                    return ((XmlElement)_config.DocumentElement.ChildNodes[i].ChildNodes[j]);
        //                }
        //            }
        //        }
        //    }
        //    return null;
        //}

/*   		private XmlNodeList GetObject(string groupName, string objectName)
		{
			int i, j;

			for (i = 0; i < _config.DocumentElement.ChildNodes.Count; i++)
			{
				if (groupName == _config.DocumentElement.ChildNodes[i].Name)
				{
                    for (j = 0; j < _config.DocumentElement.ChildNodes[i].ChildNodes.Count; j++)
					{
                        if (objectName == _config.DocumentElement.ChildNodes[i].ChildNodes[j].Name)
                            return _config.DocumentElement.ChildNodes[i].ChildNodes[j].ChildNodes;
                    }
				}
			}
			return null;
		}
*/
//-------------------------------------------------------------------
        //private XmlElement GetElement(string group, string objectType, string objectName, string propertyType, string propertyName)
        //{
        //    int i;

        //    XmlElement el = GetObject(group, objectType, objectName);

        //    if(el != null)
        //    {
        //        for (i = 0; i < el.ChildNodes.Count; i++)
        //        {
        //            if (propertyType == el.ChildNodes[i].Name &&
        //                propertyName == ((XmlElement)el.ChildNodes[i]).GetAttribute("name"))
        //            {
        //                return ((XmlElement)el.ChildNodes[i]);
        //            }
        //        }
        //    }

        //    return null;
        //}
//-------------------------------------------------------------------
        //public string GetProperty(string group, string objectType, string objectName, string propertyType, string propertyName, string propertyAttr)
        //{
        //    XmlElement el = GetElement(group, objectType, objectName, propertyType, propertyName);

        //    if(el != null)
        //    {
        //        return el.GetAttribute(propertyAttr);
        //    }

        //    return string.Empty;
        //}

/*        public ArrayList GetProperties(string groupName, string objectName)
        {
            XmlNodeList nodeList = GetObject(groupName, objectName);

            ArrayList list = new ArrayList();

            foreach (XmlElement element in nodeList)
            {
                list.Add(element.GetAttribute("name"));
            }

            return list;
        }*/
//-------------------------------------------------------------------
    }
}
