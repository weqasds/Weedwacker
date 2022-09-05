// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: TriggerCreateGadgetToEquipPartNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from TriggerCreateGadgetToEquipPartNotify.proto</summary>
  public static partial class TriggerCreateGadgetToEquipPartNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for TriggerCreateGadgetToEquipPartNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TriggerCreateGadgetToEquipPartNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CipUcmlnZ2VyQ3JlYXRlR2FkZ2V0VG9FcXVpcFBhcnROb3RpZnkucHJvdG8i",
            "egokVHJpZ2dlckNyZWF0ZUdhZGdldFRvRXF1aXBQYXJ0Tm90aWZ5EhEKCWdh",
            "ZGdldF9pZBgBIAEoDRIRCgllbnRpdHlfaWQYDSABKA0SEgoKZXF1aXBfcGFy",
            "dBgOIAEoCRIYChBnYWRnZXRfZW50aXR5X2lkGAogASgNQhqqAhdXZWVkd2Fj",
            "a2VyLlNlcnZlci5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.TriggerCreateGadgetToEquipPartNotify), global::Weedwacker.Server.Proto.TriggerCreateGadgetToEquipPartNotify.Parser, new[]{ "GadgetId", "EntityId", "EquipPart", "GadgetEntityId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 350
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// IsAllowClient: true
  /// </summary>
  public sealed partial class TriggerCreateGadgetToEquipPartNotify : pb::IMessage<TriggerCreateGadgetToEquipPartNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TriggerCreateGadgetToEquipPartNotify> _parser = new pb::MessageParser<TriggerCreateGadgetToEquipPartNotify>(() => new TriggerCreateGadgetToEquipPartNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TriggerCreateGadgetToEquipPartNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.TriggerCreateGadgetToEquipPartNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TriggerCreateGadgetToEquipPartNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TriggerCreateGadgetToEquipPartNotify(TriggerCreateGadgetToEquipPartNotify other) : this() {
      gadgetId_ = other.gadgetId_;
      entityId_ = other.entityId_;
      equipPart_ = other.equipPart_;
      gadgetEntityId_ = other.gadgetEntityId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TriggerCreateGadgetToEquipPartNotify Clone() {
      return new TriggerCreateGadgetToEquipPartNotify(this);
    }

    /// <summary>Field number for the "gadget_id" field.</summary>
    public const int GadgetIdFieldNumber = 1;
    private uint gadgetId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GadgetId {
      get { return gadgetId_; }
      set {
        gadgetId_ = value;
      }
    }

    /// <summary>Field number for the "entity_id" field.</summary>
    public const int EntityIdFieldNumber = 13;
    private uint entityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EntityId {
      get { return entityId_; }
      set {
        entityId_ = value;
      }
    }

    /// <summary>Field number for the "equip_part" field.</summary>
    public const int EquipPartFieldNumber = 14;
    private string equipPart_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string EquipPart {
      get { return equipPart_; }
      set {
        equipPart_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "gadget_entity_id" field.</summary>
    public const int GadgetEntityIdFieldNumber = 10;
    private uint gadgetEntityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint GadgetEntityId {
      get { return gadgetEntityId_; }
      set {
        gadgetEntityId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TriggerCreateGadgetToEquipPartNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TriggerCreateGadgetToEquipPartNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (GadgetId != other.GadgetId) return false;
      if (EntityId != other.EntityId) return false;
      if (EquipPart != other.EquipPart) return false;
      if (GadgetEntityId != other.GadgetEntityId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (GadgetId != 0) hash ^= GadgetId.GetHashCode();
      if (EntityId != 0) hash ^= EntityId.GetHashCode();
      if (EquipPart.Length != 0) hash ^= EquipPart.GetHashCode();
      if (GadgetEntityId != 0) hash ^= GadgetEntityId.GetHashCode();
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
      if (GadgetId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(GadgetId);
      }
      if (GadgetEntityId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(GadgetEntityId);
      }
      if (EntityId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(EntityId);
      }
      if (EquipPart.Length != 0) {
        output.WriteRawTag(114);
        output.WriteString(EquipPart);
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
      if (GadgetId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(GadgetId);
      }
      if (GadgetEntityId != 0) {
        output.WriteRawTag(80);
        output.WriteUInt32(GadgetEntityId);
      }
      if (EntityId != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(EntityId);
      }
      if (EquipPart.Length != 0) {
        output.WriteRawTag(114);
        output.WriteString(EquipPart);
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
      if (GadgetId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GadgetId);
      }
      if (EntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EntityId);
      }
      if (EquipPart.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(EquipPart);
      }
      if (GadgetEntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GadgetEntityId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TriggerCreateGadgetToEquipPartNotify other) {
      if (other == null) {
        return;
      }
      if (other.GadgetId != 0) {
        GadgetId = other.GadgetId;
      }
      if (other.EntityId != 0) {
        EntityId = other.EntityId;
      }
      if (other.EquipPart.Length != 0) {
        EquipPart = other.EquipPart;
      }
      if (other.GadgetEntityId != 0) {
        GadgetEntityId = other.GadgetEntityId;
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
          case 8: {
            GadgetId = input.ReadUInt32();
            break;
          }
          case 80: {
            GadgetEntityId = input.ReadUInt32();
            break;
          }
          case 104: {
            EntityId = input.ReadUInt32();
            break;
          }
          case 114: {
            EquipPart = input.ReadString();
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
          case 8: {
            GadgetId = input.ReadUInt32();
            break;
          }
          case 80: {
            GadgetEntityId = input.ReadUInt32();
            break;
          }
          case 104: {
            EntityId = input.ReadUInt32();
            break;
          }
          case 114: {
            EquipPart = input.ReadString();
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