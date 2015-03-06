using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MSXML2;
using System.Collections;
using System.Data;

namespace Lab6
{
    class MyContentHandler : MSXML2.IVBSAXContentHandler
    {
        const string CRLF = "\r\n";
        frmLanguages myForm;
        string thisText,name;
        
        private List<string> langList;
        private List<string> useList;
        private List<string> standardList;
        private Hashtable useMap, standardMap, propertiesMap;
        private string appliedproperties;

        // non-default constructor
        public MyContentHandler(frmLanguages LanguagesForm)
        {
            this.myForm = LanguagesForm;
            langList = new List<string>();
            useList = new List<string>();
            standardList = new List<string>();
            useMap = new Hashtable();
            standardMap = new Hashtable();
            propertiesMap = new Hashtable();
        }
    
        void IVBSAXContentHandler.characters(ref string strChars)
        {
            strChars = strChars.Replace("\n", CRLF);
            thisText += strChars.Trim();  // remove whitespace
        }

        IVBSAXLocator IVBSAXContentHandler.documentLocator
        {
            set { ; }
        }

        void IVBSAXContentHandler.endDocument()
        {
            // outputResults();
        }

        void IVBSAXContentHandler.endElement(ref string strNamespaceURI, ref string strLocalName, ref string strQName)
        {

            if (strLocalName.Equals("name"))
            {
                name = thisText;
                langList.Add(thisText);
            }
            if (strLocalName.Equals("use"))
                useList.Add(thisText);
            if (strLocalName.Equals("type"))
                standardList.Add(thisText);
            if (strLocalName.Equals("imperative"))
                appliedproperties += thisText + ",";
            if (strLocalName.Equals("object-oriented"))
                appliedproperties += thisText + ",";
            if (strLocalName.Equals("functional"))
                appliedproperties += thisText + ",";
            if (strLocalName.Equals("procedural"))
                appliedproperties += thisText + ",";
            if (strLocalName.Equals("generic"))
                appliedproperties += thisText + ",";
            if (strLocalName.Equals("reflective"))
                appliedproperties += thisText + ",";
            if (strLocalName.Equals("event-driven"))
                appliedproperties += thisText ;           
            thisText = null;
        }

        void IVBSAXContentHandler.endPrefixMapping(ref string strPrefix)
        {
            //throw new NotImplementedException();
        }

        void IVBSAXContentHandler.ignorableWhitespace(ref string strChars)
        {
            //throw new NotImplementedException();
        }

        void IVBSAXContentHandler.processingInstruction(ref string strTarget, ref string strData)
        {
            //throw new NotImplementedException();
        }

        void IVBSAXContentHandler.skippedEntity(ref string strName)
        {
            //throw new NotImplementedException();
        }

        void IVBSAXContentHandler.startDocument()
        {
            //  myForm.OutputText = "Document START" + CRLF;
        }

        void IVBSAXContentHandler.startElement(ref string strNamespaceURI, ref string strLocalName, ref string strQName, IVBSAXAttributes oAttributes)
        {
            int i;
            string ids = "";

            // only process votes element and find the totalVotes attribute value
            if (strLocalName.Equals("intendeduse"))
            {
                for (i = 0; i < oAttributes.length; i++)
                    if (oAttributes.getQName(i) == "id")
                        ids = oAttributes.getValue(i);
                useMap.Add(name, ids);                
            }
            ids = "";
            if (strLocalName.Equals("standardtype"))
            {
                for (i = 0; i < oAttributes.length; i++)
                    if (oAttributes.getQName(i) == "id")
                        ids = oAttributes.getValue(i);
                standardMap.Add(name, ids);
                propertiesMap.Add(name, appliedproperties);
                appliedproperties = "";
            }

        }

        void IVBSAXContentHandler.startPrefixMapping(ref string strPrefix, ref string strURI)
        {
            //throw new NotImplementedException();
        }

        internal List<string> getLanguages()
        {
            return langList;
        }

        internal List<string> getUses()
        {
            return useList;
        }

        internal List<string> getStandards()
        {
            return standardList;
        }

        internal Hashtable getUsesMap()
        {
            return useMap;
        }

        internal Hashtable getstandardsMap()
        {
            return standardMap;
        }

        internal Hashtable getpropertiesMap()
        {
            return propertiesMap;
        }
    }
}
