// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Unk2700_MLMEFKLMOEF.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from Unk2700_MLMEFKLMOEF.proto</summary>
  public static partial class Unk2700MLMEFKLMOEFReflection {

    #region Descriptor
    /// <summary>File descriptor for Unk2700_MLMEFKLMOEF.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static Unk2700MLMEFKLMOEFReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlVbmsyNzAwX01MTUVGS0xNT0VGLnByb3RvGhlVbmsyNzAwX0VBSkNHRU5E",
            "SUNJLnByb3RvIkgKE1VuazI3MDBfTUxNRUZLTE1PRUYSDQoFdmFsdWUYBSAB",
            "KAUSIgoEdHlwZRgEIAEoDjIULlVuazI3MDBfRUFKQ0dFTkRJQ0lCIqoCH1dl",
            "ZWR3YWNrZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.Unk2700EAJCGENDICIReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.Unk2700_MLMEFKLMOEF), global::Weedwacker.Shared.Network.Proto.Unk2700_MLMEFKLMOEF.Parser, new[]{ "Value", "Type" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Unk2700_MLMEFKLMOEF : pb::IMessage<Unk2700_MLMEFKLMOEF>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Unk2700_MLMEFKLMOEF> _parser = new pb::MessageParser<Unk2700_MLMEFKLMOEF>(() => new Unk2700_MLMEFKLMOEF());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Unk2700_MLMEFKLMOEF> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.Unk2700MLMEFKLMOEFReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_MLMEFKLMOEF() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_MLMEFKLMOEF(Unk2700_MLMEFKLMOEF other) : this() {
      value_ = other.value_;
      type_ = other.type_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_MLMEFKLMOEF Clone() {
      return new Unk2700_MLMEFKLMOEF(this);
    }

    /// <summary>Field number for the "value" field.</summary>
    public const int ValueFieldNumber = 5;
    private int value_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Value {
      get { return value_; }
      set {
        value_ = value;
      }
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 4;
    private global::Weedwacker.Shared.Network.Proto.Unk2700_EAJCGENDICI type_ = global::Weedwacker.Shared.Network.Proto.Unk2700_EAJCGENDICI.Unk2700Ndnhcnoocca;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.Unk2700_EAJCGENDICI Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Unk2700_MLMEFKLMOEF);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Unk2700_MLMEFKLMOEF other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Value != other.Value) return false;
      if (Type != other.Type) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Value != 0) hash ^= Value.GetHashCode();
      if (Type != global::Weedwacker.Shared.Network.Proto.Unk2700_EAJCGENDICI.Unk2700Ndnhcnoocca) hash ^= Type.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Type != global::Weedwacker.Shared.Network.Proto.Unk2700_EAJCGENDICI.Unk2700Ndnhcnoocca) {
        output.WriteRawTag(32);
        output.WriteEnum((int) Type);
      }
      if (Value != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(Value);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Type != global::Weedwacker.Shared.Network.Proto.Unk2700_EAJCGENDICI.Unk2700Ndnhcnoocca) {
        output.WriteRawTag(32);
        output.WriteEnum((int) Type);
      }
      if (Value != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(Value);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Value != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Value);
      }
      if (Type != global::Weedwacker.Shared.Network.Proto.Unk2700_EAJCGENDICI.Unk2700Ndnhcnoocca) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Unk2700_MLMEFKLMOEF other) {
      if (other == null) {
        return;
      }
      if (other.Value != 0) {
        Value = other.Value;
      }
      if (other.Type != global::Weedwacker.Shared.Network.Proto.Unk2700_EAJCGENDICI.Unk2700Ndnhcnoocca) {
        Type = other.Type;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 32: {
            Type = (global::Weedwacker.Shared.Network.Proto.Unk2700_EAJCGENDICI) input.ReadEnum();
            break;
          }
          case 40: {
            Value = input.ReadInt32();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 32: {
            Type = (global::Weedwacker.Shared.Network.Proto.Unk2700_EAJCGENDICI) input.ReadEnum();
            break;
          }
          case 40: {
            Value = input.ReadInt32();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code