namespace OrderShipping.PropertySchema {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Property)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Property1", @"ShippingMethod", @"OrderId", @"ShipperOrderID", @"ShippingCompany"})]
    public sealed class PropertySchema : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://OrderShipping.PropertySchema"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""https://OrderShipping.PropertySchema"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:schemaInfo schema_type=""property"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" />
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""Property1"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo propertyGuid=""8e656f99-9419-4cbc-ad90-dfa3303f8226"" />
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""ShippingMethod"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo propertyGuid=""a350ccbd-c5e7-4f50-8e81-ddd75bfeee61"" />
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""OrderId"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo propertyGuid=""aed23907-a6d4-4fe5-90ed-283695d56068"" />
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""ShipperOrderID"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo propertyGuid=""45842294-ff48-4ed3-9bd7-d9c3e5b26092"" />
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""ShippingCompany"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo propertyGuid=""0602a1bb-7366-4f94-a3c9-5a3c6b3a2b32"" />
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
</xs:schema>";
        
        public PropertySchema() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [5];
                _RootElements[0] = "Property1";
                _RootElements[1] = "ShippingMethod";
                _RootElements[2] = "OrderId";
                _RootElements[3] = "ShipperOrderID";
                _RootElements[4] = "ShippingCompany";
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
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [System.SerializableAttribute()]
    [PropertyType(@"Property1",@"https://OrderShipping.PropertySchema","string","System.String")]
    [PropertyGuidAttribute(@"8e656f99-9419-4cbc-ad90-dfa3303f8226")]
    public sealed class Property1 : Microsoft.XLANGs.BaseTypes.MessageDataPropertyBase {
        
        [System.NonSerializedAttribute()]
        private static System.Xml.XmlQualifiedName _QName = new System.Xml.XmlQualifiedName(@"Property1", @"https://OrderShipping.PropertySchema");
        
        private static string PropertyValueType {
            get {
                throw new System.NotSupportedException();
            }
        }
        
        public override System.Xml.XmlQualifiedName Name {
            get {
                return _QName;
            }
        }
        
        public override System.Type Type {
            get {
                return typeof(string);
            }
        }
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [System.SerializableAttribute()]
    [PropertyType(@"ShippingMethod",@"https://OrderShipping.PropertySchema","string","System.String")]
    [PropertyGuidAttribute(@"a350ccbd-c5e7-4f50-8e81-ddd75bfeee61")]
    public sealed class ShippingMethod : Microsoft.XLANGs.BaseTypes.MessageDataPropertyBase {
        
        [System.NonSerializedAttribute()]
        private static System.Xml.XmlQualifiedName _QName = new System.Xml.XmlQualifiedName(@"ShippingMethod", @"https://OrderShipping.PropertySchema");
        
        private static string PropertyValueType {
            get {
                throw new System.NotSupportedException();
            }
        }
        
        public override System.Xml.XmlQualifiedName Name {
            get {
                return _QName;
            }
        }
        
        public override System.Type Type {
            get {
                return typeof(string);
            }
        }
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [System.SerializableAttribute()]
    [PropertyType(@"OrderId",@"https://OrderShipping.PropertySchema","string","System.String")]
    [PropertyGuidAttribute(@"aed23907-a6d4-4fe5-90ed-283695d56068")]
    public sealed class OrderId : Microsoft.XLANGs.BaseTypes.MessageDataPropertyBase {
        
        [System.NonSerializedAttribute()]
        private static System.Xml.XmlQualifiedName _QName = new System.Xml.XmlQualifiedName(@"OrderId", @"https://OrderShipping.PropertySchema");
        
        private static string PropertyValueType {
            get {
                throw new System.NotSupportedException();
            }
        }
        
        public override System.Xml.XmlQualifiedName Name {
            get {
                return _QName;
            }
        }
        
        public override System.Type Type {
            get {
                return typeof(string);
            }
        }
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [System.SerializableAttribute()]
    [PropertyType(@"ShipperOrderID",@"https://OrderShipping.PropertySchema","string","System.String")]
    [PropertyGuidAttribute(@"45842294-ff48-4ed3-9bd7-d9c3e5b26092")]
    public sealed class ShipperOrderID : Microsoft.XLANGs.BaseTypes.MessageDataPropertyBase {
        
        [System.NonSerializedAttribute()]
        private static System.Xml.XmlQualifiedName _QName = new System.Xml.XmlQualifiedName(@"ShipperOrderID", @"https://OrderShipping.PropertySchema");
        
        private static string PropertyValueType {
            get {
                throw new System.NotSupportedException();
            }
        }
        
        public override System.Xml.XmlQualifiedName Name {
            get {
                return _QName;
            }
        }
        
        public override System.Type Type {
            get {
                return typeof(string);
            }
        }
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [System.SerializableAttribute()]
    [PropertyType(@"ShippingCompany",@"https://OrderShipping.PropertySchema","string","System.String")]
    [PropertyGuidAttribute(@"0602a1bb-7366-4f94-a3c9-5a3c6b3a2b32")]
    public sealed class ShippingCompany : Microsoft.XLANGs.BaseTypes.MessageDataPropertyBase {
        
        [System.NonSerializedAttribute()]
        private static System.Xml.XmlQualifiedName _QName = new System.Xml.XmlQualifiedName(@"ShippingCompany", @"https://OrderShipping.PropertySchema");
        
        private static string PropertyValueType {
            get {
                throw new System.NotSupportedException();
            }
        }
        
        public override System.Xml.XmlQualifiedName Name {
            get {
                return _QName;
            }
        }
        
        public override System.Type Type {
            get {
                return typeof(string);
            }
        }
    }
}
