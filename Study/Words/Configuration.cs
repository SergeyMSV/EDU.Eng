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
    class Configuration
    {
        private string _configFileName = "config.xml";
		private XmlDocument _config = new XmlDocument();
//-------------------------------------------------------------------
		public Configuration()
		{
			try
			{
				_config.Load(_configFileName);
			}
			catch
			{
				_config = new XmlDocument();

				string xmlData = "<configuration></configuration>";
				_config.Load(new StringReader(xmlData));

				Save();
			}
		}
//-------------------------------------------------------------------
        private void Save()
        {
            _config.Save(_configFileName);
        }
//-------------------------------------------------------------------
        //private XmlElement MakeObject(string group, string objectType, string objectName)
        //{
        //    XmlElement el = null;
        //    XmlElement groupEl = null;
        //    int i, j;


        //    if (0 == _config.DocumentElement.ChildNodes.Count)
        //    {
        //        groupEl = _config.CreateElement(group);
        //        _config.DocumentElement.AppendChild(groupEl);
        //    }
        //    else
        //    {
        //        for (i = 0; i < _config.DocumentElement.ChildNodes.Count; i++)
        //        {
        //            if (group == _config.DocumentElement.ChildNodes[i].Name)
        //            {
        //                groupEl = (XmlElement)_config.DocumentElement.ChildNodes[i];
        //                for (j = 0; j < _config.DocumentElement.ChildNodes[i].ChildNodes.Count; j++)
        //                {
        //                    if (objectType == _config.DocumentElement.ChildNodes[i].ChildNodes[j].Name &&
        //                        objectName == ((XmlElement)_config.DocumentElement.ChildNodes[i].ChildNodes[j]).GetAttribute("name"))
        //                    {
        //                        return ((XmlElement)_config.DocumentElement.ChildNodes[i].ChildNodes[j]);
        //                    }
        //                }
        //            }
        //        }
        //    }

        //    el = _config.CreateElement(objectType);
        //    el.SetAttribute("name", objectName);
        //    groupEl.AppendChild(el);

        //    return el;
        //}
//-------------------------------------------------------------------
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

   		private XmlNodeList GetObject(string groupName, string objectName)
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

        public ArrayList GetProperties(string groupName, string objectName)
        {
            XmlNodeList nodeList = GetObject(groupName, objectName);

            ArrayList list = new ArrayList();

            foreach (XmlElement element in nodeList)
            {
                list.Add(element.GetAttribute("name"));
            }

            return list;
        }
//-------------------------------------------------------------------
	}
}
