﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.0.30319.33440.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class RcvSndHandlers {
    
    private RcvSndHandlersRcvSndHandler[] rcvSndHandlerField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("RcvSndHandler")]
    public RcvSndHandlersRcvSndHandler[] RcvSndHandler {
        get {
            return this.rcvSndHandlerField;
        }
        set {
            this.rcvSndHandlerField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class RcvSndHandlersRcvSndHandler {
    
    private string hostNameField;
    
    private string adapterNameField;
    
    private string directionField;
    
    /// <remarks/>
    public string HostName {
        get {
            return this.hostNameField;
        }
        set {
            this.hostNameField = value;
        }
    }
    
    /// <remarks/>
    public string AdapterName {
        get {
            return this.adapterNameField;
        }
        set {
            this.adapterNameField = value;
        }
    }
    
    /// <remarks/>
    public string Direction {
        get {
            return this.directionField;
        }
        set {
            this.directionField = value;
        }
    }
}
