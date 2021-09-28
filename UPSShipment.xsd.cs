namespace OrderShipping {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://OrderShipping.UPSShipment",@"UPS")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"UPS"})]
    public sealed class UPSShipment : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://OrderShipping.UPSShipment"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://OrderShipping.UPSShipment"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""UPS"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""DeliveryName"" type=""xs:string"" />
        <xs:element name=""DeliveryAddress1"" type=""xs:string"" />
        <xs:element name=""DeliveryAddress2"" type=""xs:string"" />
        <xs:element name=""DeliveryCity"" type=""xs:string"" />
        <xs:element name=""DeliveryState"" type=""xs:string"" />
        <xs:element name=""DeliveryPostalCode"" type=""xs:string"" />
        <xs:element name=""DeliveryCountry"" type=""xs:string"" />
        <xs:element name=""InsureAmount"" type=""xs:float"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public UPSShipment() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "UPS";
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
