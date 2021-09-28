namespace OrderShipping {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"OrderShipping.FedExShipment", typeof(global::OrderShipping.FedExShipment))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"OrderShipping.FedExShipmentResponse", typeof(global::OrderShipping.FedExShipmentResponse))]
    public sealed class FedExToFedExResponse : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:s0=""http://OrderShipping.FedExShipment"" xmlns:ns0=""http://OrderShipping.FedExShipmentResponse"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:FedEx"" />
  </xsl:template>
  <xsl:template match=""/s0:FedEx"">
    <xsl:variable name=""var:v2"" select=""string(ShippingMethod/text())"" />
    <ns0:FedExResponse>
      <CustomerOrderId>
        <xsl:value-of select=""ShipperOrderID/text()"" />
      </CustomerOrderId>
      <xsl:variable name=""var:v1"" select=""userCSharp:MyConcat(string(ShippingMethod/text()) , string(FromZip/text()) , string(ToZip/text()) , string(TotalWeight/text()))"" />
      <CostOfShipment>
        <xsl:value-of select=""$var:v1"" />
      </CostOfShipment>
      <xsl:variable name=""var:v3"" select=""userCSharp:MyConcat($var:v2 , string(ShipToCompany/text()))"" />
      <EstimatedDeliveryDate>
        <xsl:value-of select=""$var:v3"" />
      </EstimatedDeliveryDate>
      <TrackingNumber>
        <xsl:value-of select=""OrderTotal/text()"" />
      </TrackingNumber>
    </ns0:FedExResponse>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
///*Uncomment the following code for a sample Inline C# function
//that concatenates two inputs. Change the number of parameters of
//this function to be equal to the number of inputs connected to this functoid.*/

public string MyConcat(string ShippingMethod, string FromZip, string ToZip, double TotalWeight)
{
double baseprice=5+ 0.75*TotalWeight;
if(ShippingMethod==""Ground""){
baseprice=baseprice+0.5*TotalWeight;
}
if(ShippingMethod==""OverNight""){
baseprice=baseprice+0.8*TotalWeight;
}
else{
baseprice=baseprice+0.4*TotalWeight;
}
	return baseprice.ToString();
}


///*Uncomment the following code for a sample Inline C# function
//that concatenates two inputs. Change the number of parameters of
//this function to be equal to the number of inputs connected to this functoid.*/

public string MyConcat(string spmethod, string param2)
{
int days=3;
if(spmethod==""OverNight""){
days+=1;
}
else if(spmethod==""Ground""){
days+=5;
}
DateTime estimated=DateTime.Now.AddDays(days);
return estimated.ToString();
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"OrderShipping.FedExShipment";
        
        private const global::OrderShipping.FedExShipment _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"OrderShipping.FedExShipmentResponse";
        
        private const global::OrderShipping.FedExShipmentResponse _trgSchemaTypeReference0 = null;
        
        public override string XmlContent {
            get {
                return _strMap;
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
                _SrcSchemas[0] = @"OrderShipping.FedExShipment";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"OrderShipping.FedExShipmentResponse";
                return _TrgSchemas;
            }
        }
    }
}
