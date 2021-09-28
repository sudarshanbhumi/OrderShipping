namespace OrderShipping {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://OrderShipping.Order",@"Order")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::OrderShipping.PropertySchema.ShippingMethod), XPath = @"/*[local-name()='Order' and namespace-uri()='http://OrderShipping.Order']/*[local-name()='ShippingMethod' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::OrderShipping.PropertySchema.OrderId), XPath = @"/*[local-name()='Order' and namespace-uri()='http://OrderShipping.Order']/*[local-name()='OrderId' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::OrderShipping.PropertySchema.ShippingCompany), XPath = @"/*[local-name()='Order' and namespace-uri()='http://OrderShipping.Order']/*[local-name()='ShippingCompany' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "OrderId", XPath = @"/*[local-name()='Order' and namespace-uri()='http://OrderShipping.Order']/*[local-name()='OrderId' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "ShippingCompany", XPath = @"/*[local-name()='Order' and namespace-uri()='http://OrderShipping.Order']/*[local-name()='ShippingCompany' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "ShippingMethod", XPath = @"/*[local-name()='Order' and namespace-uri()='http://OrderShipping.Order']/*[local-name()='ShippingMethod' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Order"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"OrderShipping.PropertySchema.PropertySchema", typeof(global::OrderShipping.PropertySchema.PropertySchema))]
    public sealed class Order : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://OrderShipping.Order"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""https://OrderShipping.PropertySchema"" targetNamespace=""http://OrderShipping.Order"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:imports>
        <b:namespace prefix=""ns0"" uri=""https://OrderShipping.PropertySchema"" location=""OrderShipping.PropertySchema.PropertySchema"" />
      </b:imports>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""Order"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property name=""ns0:ShippingMethod"" xpath=""/*[local-name()='Order' and namespace-uri()='http://OrderShipping.Order']/*[local-name()='ShippingMethod' and namespace-uri()='']"" />
          <b:property name=""ns0:OrderId"" xpath=""/*[local-name()='Order' and namespace-uri()='http://OrderShipping.Order']/*[local-name()='OrderId' and namespace-uri()='']"" />
          <b:property name=""ns0:ShippingCompany"" xpath=""/*[local-name()='Order' and namespace-uri()='http://OrderShipping.Order']/*[local-name()='ShippingCompany' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='Order' and namespace-uri()='http://OrderShipping.Order']/*[local-name()='OrderId' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='Order' and namespace-uri()='http://OrderShipping.Order']/*[local-name()='ShippingCompany' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='Order' and namespace-uri()='http://OrderShipping.Order']/*[local-name()='ShippingMethod' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence minOccurs=""0"">
        <xs:element name=""OrderId"" type=""xs:string"" />
        <xs:element name=""FirstName"" type=""xs:string"" />
        <xs:element name=""LastName"" type=""xs:string"" />
        <xs:element name=""ShipToAddress"" type=""xs:string"" />
        <xs:element name=""ShipToCity"" type=""xs:string"" />
        <xs:element name=""ShipToState"" type=""xs:string"" />
        <xs:element name=""BillToAddress"" type=""xs:string"" />
        <xs:element name=""BillToCity"" type=""xs:string"" />
        <xs:element name=""BillToState"" type=""xs:string"" />
        <xs:element name=""BillToZip"" type=""xs:string"" />
        <xs:element name=""SalesTax"" type=""xs:double"" />
        <xs:element name=""ShippingCharge"" type=""xs:double"" />
        <xs:element name=""ShippingCompany"" type=""xs:string"" />
        <xs:element name=""ShippingMethod"">
          <xs:simpleType>
            <xs:restriction base=""xs:string"">
              <xs:enumeration value=""Ground"" />
              <xs:enumeration value=""OverNight"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
        <xs:element name=""LineItems"">
          <xs:complexType>
            <xs:sequence>
              <xs:element minOccurs=""1"" maxOccurs=""unbounded"" name=""LineItem"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""Quantity"" type=""xs:int"" />
                    <xs:element name=""ProductName"" type=""xs:string"" />
                    <xs:element name=""ProductCode"" type=""xs:string"" />
                    <xs:element name=""Price"" type=""xs:double"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public Order() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Order";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
    }
}
