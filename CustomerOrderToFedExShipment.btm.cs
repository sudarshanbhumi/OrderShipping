namespace OrderShipping {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"OrderShipping.Order", typeof(global::OrderShipping.Order))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"OrderShipping.FedExShipment", typeof(global::OrderShipping.FedExShipment))]
    public sealed class CustomerOrderToFedExShipment : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns0=""http://OrderShipping.FedExShipment"" xmlns:s0=""http://OrderShipping.Order"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Order"" />
  </xsl:template>
  <xsl:template match=""/s0:Order"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(string(FirstName/text()) , &quot; _ &quot; , string(LastName/text()))"" />
    <xsl:variable name=""var:v2"" select=""userCSharp:StringConcat(&quot;Texas&quot;)"" />
    <xsl:variable name=""var:v3"" select=""userCSharp:StringConcat(string(ShipToCity/text()) , &quot; _to_&quot; , string(ShipToState/text()))"" />
    <ns0:FedEx>
      <ShipperOrderID>
        <xsl:value-of select=""OrderId/text()"" />
      </ShipperOrderID>
      <ShipFromName>
        <xsl:value-of select=""$var:v1"" />
      </ShipFromName>
      <ShipFromAddress>
        <xsl:value-of select=""$var:v2"" />
      </ShipFromAddress>
      <ShipFromCity>
        <xsl:value-of select=""$var:v2"" />
      </ShipFromCity>
      <ShipToName>
        <xsl:value-of select=""$var:v2"" />
      </ShipToName>
      <ShipToCompany>
        <xsl:value-of select=""ShipToAddress/text()"" />
      </ShipToCompany>
      <ShipToAddress1>
        <xsl:value-of select=""$var:v3"" />
      </ShipToAddress1>
      <ShipToAddress2>
        <xsl:value-of select=""BillToAddress/text()"" />
      </ShipToAddress2>
      <ShipToCityStateZip>
        <xsl:value-of select=""BillToCity/text()"" />
      </ShipToCityStateZip>
      <xsl:variable name=""var:v4"" select=""userCSharp:InitCumulativeSum(0)"" />
      <xsl:for-each select=""/s0:Order/LineItems/LineItem"">
        <xsl:variable name=""var:v5"" select=""userCSharp:MathMultiply(string(Quantity/text()) , string(Price/text()))"" />
        <xsl:variable name=""var:v6"" select=""userCSharp:AddToCumulativeSum(0,string($var:v5),&quot;1000&quot;)"" />
      </xsl:for-each>
      <xsl:variable name=""var:v7"" select=""userCSharp:GetCumulativeSum(0)"" />
      <OrderTotal>
        <xsl:value-of select=""$var:v7"" />
      </OrderTotal>
      <TotalWeight>
        <xsl:value-of select=""SalesTax/text()"" />
      </TotalWeight>
      <FromZip>
        <xsl:value-of select=""BillToZip/text()"" />
      </FromZip>
      <ToZip>
        <xsl:value-of select=""BillToZip/text()"" />
      </ToZip>
      <xsl:variable name=""var:v8"" select=""userCSharp:MyConcat(string(ShippingCompany/text()) , string(ShippingMethod/text()))"" />
      <ShippingMethod>
        <xsl:value-of select=""$var:v8"" />
      </ShippingMethod>
    </ns0:FedEx>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringConcat(string param0, string param1, string param2)
{
   return param0 + param1 + param2;
}


public string MathMultiply(string param0, string param1)
{
	System.Collections.ArrayList listValues = new System.Collections.ArrayList();
	listValues.Add(param0);
	listValues.Add(param1);
	double ret = 1;
	bool first = true;
	foreach (string obj in listValues)
	{
		double d = 0;
		if (IsNumeric(obj, ref d))
		{
			if (first)
			{
				first = false;
				ret = d;
			}
			else
			{
				ret *= d;
			}
		}
		else
		{
			return """";
		}
	}
	return ret.ToString(System.Globalization.CultureInfo.InvariantCulture);
}


public string InitCumulativeSum(int index)
{
	if (index >= 0)
	{
		if (index >= myCumulativeSumArray.Count)
		{
			int i = myCumulativeSumArray.Count;
			for (; i<=index; i++)
			{
				myCumulativeSumArray.Add("""");
			}
		}
		else
		{
			myCumulativeSumArray[index] = """";
		}
	}
	return """";
}

public System.Collections.ArrayList myCumulativeSumArray = new System.Collections.ArrayList();

public string AddToCumulativeSum(int index, string val, string notused)
{
	if (index < 0 || index >= myCumulativeSumArray.Count)
	{
		return """";
    }
	double d = 0;
	if (IsNumeric(val, ref d))
	{
		if (myCumulativeSumArray[index] == """")
		{
			myCumulativeSumArray[index] = d;
		}
		else
		{
			myCumulativeSumArray[index] = (double)(myCumulativeSumArray[index]) + d;
		}
	}
	return (myCumulativeSumArray[index] is double) ? ((double)myCumulativeSumArray[index]).ToString(System.Globalization.CultureInfo.InvariantCulture) : """";
}

public string GetCumulativeSum(int index)
{
	if (index < 0 || index >= myCumulativeSumArray.Count)
	{
		return """";
	}
	return (myCumulativeSumArray[index] is double) ? ((double)myCumulativeSumArray[index]).ToString(System.Globalization.CultureInfo.InvariantCulture) : """";
}

public string StringConcat(string param0)
{
   return param0;
}


///*Uncomment the following code for a sample Inline C# function
//that concatenates two inputs. Change the number of parameters of
//this function to be equal to the number of inputs connected to this functoid.*/

public string MyConcat(string ShippingCompany, string ShippingMethod)
{
if(ShippingCompany==""FEDEX"" && ShippingMethod==""Ground""){
return ShippingCompany+""-----------""+ShippingMethod;
}
if(ShippingCompany==""UPS"" && ShippingMethod==""Ground""){
return ShippingCompany+""-----from elseif------""+ShippingMethod;
}
return ShippingCompany+""--------from else-----""+ShippingMethod;
}


public bool IsNumeric(string val)
{
	if (val == null)
	{
		return false;
	}
	double d = 0;
	return Double.TryParse(val, System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out d);
}

public bool IsNumeric(string val, ref double d)
{
	if (val == null)
	{
		return false;
	}
	return Double.TryParse(val, System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out d);
}


]]></msxsl:script>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"OrderShipping.Order";
        
        private const global::OrderShipping.Order _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"OrderShipping.FedExShipment";
        
        private const global::OrderShipping.FedExShipment _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"OrderShipping.Order";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"OrderShipping.FedExShipment";
                return _TrgSchemas;
            }
        }
    }
}
