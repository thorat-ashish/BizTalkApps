namespace BTAppXMLToFF {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BTAppXMLToFF.InputOrderSchema", typeof(global::BTAppXMLToFF.InputOrderSchema))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BTAppXMLToFF.OutputCustomerOrderFFSchema", typeof(global::BTAppXMLToFF.OutputCustomerOrderFFSchema))]
    public sealed class MapOrderToCustomer : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:s0=""http://BTAppXMLToFF.InputOrderSchema"" xmlns:ns0=""http://BTAppXMLToFF.OutputCustomerOrderFFSchema"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:CustomerOrder"" />
  </xsl:template>
  <xsl:template match=""/s0:CustomerOrder"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(string(CustomerInfo/FirstName/text()) , &quot; &quot; , string(CustomerInfo/LastName/text()))"" />
    <ns0:Customers>
      <Customer>
        <FullName>
          <xsl:value-of select=""$var:v1"" />
        </FullName>
        <ContactNo>
          <xsl:value-of select=""CustomerInfo/Phone/text()"" />
        </ContactNo>
      </Customer>
    </ns0:Customers>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringConcat(string param0, string param1, string param2)
{
   return param0 + param1 + param2;
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _xsltEngine = @"";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"BTAppXMLToFF.InputOrderSchema";
        
        private const global::BTAppXMLToFF.InputOrderSchema _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"BTAppXMLToFF.OutputCustomerOrderFFSchema";
        
        private const global::BTAppXMLToFF.OutputCustomerOrderFFSchema _trgSchemaTypeReference0 = null;
        
        public override string XmlContent {
            get {
                return _strMap;
            }
        }
        
        public override string XsltEngine {
            get {
                return _xsltEngine;
            }
        }
        
        public override int UseXSLTransform {
            get {
                return _useXSLTransform;
            }
        }
        
        public override string XsltArgumentListContent {
            get {
                return _strArgList;
            }
        }
        
        public override string[] SourceSchemas {
            get {
                string[] _SrcSchemas = new string [1];
                _SrcSchemas[0] = @"BTAppXMLToFF.InputOrderSchema";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"BTAppXMLToFF.OutputCustomerOrderFFSchema";
                return _TrgSchemas;
            }
        }
    }
}
