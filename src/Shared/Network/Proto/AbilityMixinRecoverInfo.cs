// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AbilityMixinRecoverInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from AbilityMixinRecoverInfo.proto</summary>
  public static partial class AbilityMixinRecoverInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for AbilityMixinRecoverInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AbilityMixinRecoverInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1BYmlsaXR5TWl4aW5SZWNvdmVySW5mby5wcm90bxoZTWFzc2l2ZVByb3BT",
            "eW5jSW5mby5wcm90byLaAQoXQWJpbGl0eU1peGluUmVjb3ZlckluZm8SEAoI",
            "bG9jYWxfaWQYAyABKA0SEQoJZGF0YV9saXN0GAQgAygNEh4KFmlzX3NlcnZl",
            "cmJ1ZmZfbW9kaWZpZXIYBSABKAgSLwoRbWFzc2l2ZV9wcm9wX2xpc3QYBiAD",
            "KAsyFC5NYXNzaXZlUHJvcFN5bmNJbmZvEh4KFGluc3RhbmNlZF9hYmlsaXR5",
            "X2lkGAEgASgNSAASHwoVaW5zdGFuY2VkX21vZGlmaWVyX2lkGAIgASgNSABC",
            "CAoGc291cmNlQiKqAh9XZWVkd2Fja2VyLlNoYXJlZC5OZXR3b3JrLlByb3Rv",
            "YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.MassivePropSyncInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.AbilityMixinRecoverInfo), global::Weedwacker.Shared.Network.Proto.AbilityMixinRecoverInfo.Parser, new[]{ "LocalId", "DataList", "IsServerbuffModifier", "MassivePropList", "InstancedAbilityId", "InstancedModifierId" }, new[]{ "Source" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class AbilityMixinRecoverInfo : pb::IMessage<AbilityMixinRecoverInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AbilityMixinRecoverInfo> _parser = new pb::MessageParser<AbilityMixinRecoverInfo>(() => new AbilityMixinRecoverInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AbilityMixinRecoverInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.AbilityMixinRecoverInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AbilityMixinRecoverInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AbilityMixinRecoverInfo(AbilityMixinRecoverInfo other) : this() {
      localId_ = other.localId_;
      dataList_ = other.dataList_.Clone();
      isServerbuffModifier_ = other.isServerbuffModifier_;
      massivePropList_ = other.massivePropList_.Clone();
      switch (other.SourceCase) {
        case SourceOneofCase.InstancedAbilityId:
          InstancedAbilityId = other.InstancedAbilityId;
          break;
        case SourceOneofCase.InstancedModifierId:
          InstancedModifierId = other.InstancedModifierId;
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AbilityMixinRecoverInfo Clone() {
      return new AbilityMixinRecoverInfo(this);
    }

    /// <summary>Field number for the "local_id" field.</summary>
    public const int LocalIdFieldNumber = 3;
    private uint localId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint LocalId {
      get { return localId_; }
      set {
        localId_ = value;
      }
    }

    /// <summary>Field number for the "data_list" field.</summary>
    public const int DataListFieldNumber = 4;
    private static readonly pb::FieldCodec<uint> _repeated_dataList_codec
        = pb::FieldCodec.ForUInt32(34);
    private readonly pbc::RepeatedField<uint> dataList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> DataList {
      get { return dataList_; }
    }

    /// <summary>Field number for the "is_serverbuff_modifier" field.</summary>
    public const int IsServerbuffModifierFieldNumber = 5;
    private bool isServerbuffModifier_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsServerbuffModifier {
      get { return isServerbuffModifier_; }
      set {
        isServerbuffModifier_ = value;
      }
    }

    /// <summary>Field number for the "massive_prop_list" field.</summary>
    public const int MassivePropListFieldNumber = 6;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.MassivePropSyncInfo> _repeated_massivePropList_codec
        = pb::FieldCodec.ForMessage(50, global::Weedwacker.Shared.Network.Proto.MassivePropSyncInfo.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.MassivePropSyncInfo> massivePropList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.MassivePropSyncInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.MassivePropSyncInfo> MassivePropList {
      get { return massivePropList_; }
    }

    /// <summary>Field number for the "instanced_ability_id" field.</summary>
    public const int InstancedAbilityIdFieldNumber = 1;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint InstancedAbilityId {
      get { return sourceCase_ == SourceOneofCase.InstancedAbilityId ? (uint) source_ : 0; }
      set {
        source_ = value;
        sourceCase_ = SourceOneofCase.InstancedAbilityId;
      }
    }

    /// <summary>Field number for the "instanced_modifier_id" field.</summary>
    public const int InstancedModifierIdFieldNumber = 2;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint InstancedModifierId {
      get { return sourceCase_ == SourceOneofCase.InstancedModifierId ? (uint) source_ : 0; }
      set {
        source_ = value;
        sourceCase_ = SourceOneofCase.InstancedModifierId;
      }
    }

    private object source_;
    /// <summary>Enum of possible cases for the "source" oneof.</summary>
    public enum SourceOneofCase {
      None = 0,
      InstancedAbilityId = 1,
      InstancedModifierId = 2,
    }
    private SourceOneofCase sourceCase_ = SourceOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SourceOneofCase SourceCase {
      get { return sourceCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearSource() {
      sourceCase_ = SourceOneofCase.None;
      source_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AbilityMixinRecoverInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AbilityMixinRecoverInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (LocalId != other.LocalId) return false;
      if(!dataList_.Equals(other.dataList_)) return false;
      if (IsServerbuffModifier != other.IsServerbuffModifier) return false;
      if(!massivePropList_.Equals(other.massivePropList_)) return false;
      if (InstancedAbilityId != other.InstancedAbilityId) return false;
      if (InstancedModifierId != other.InstancedModifierId) return false;
      if (SourceCase != other.SourceCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (LocalId != 0) hash ^= LocalId.GetHashCode();
      hash ^= dataList_.GetHashCode();
      if (IsServerbuffModifier != false) hash ^= IsServerbuffModifier.GetHashCode();
      hash ^= massivePropList_.GetHashCode();
      if (sourceCase_ == SourceOneofCase.InstancedAbilityId) hash ^= InstancedAbilityId.GetHashCode();
      if (sourceCase_ == SourceOneofCase.InstancedModifierId) hash ^= InstancedModifierId.GetHashCode();
      hash ^= (int) sourceCase_;
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
      if (sourceCase_ == SourceOneofCase.InstancedAbilityId) {
        output.WriteRawTag(8);
        output.WriteUInt32(InstancedAbilityId);
      }
      if (sourceCase_ == SourceOneofCase.InstancedModifierId) {
        output.WriteRawTag(16);
        output.WriteUInt32(InstancedModifierId);
      }
      if (LocalId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(LocalId);
      }
      dataList_.WriteTo(output, _repeated_dataList_codec);
      if (IsServerbuffModifier != false) {
        output.WriteRawTag(40);
        output.WriteBool(IsServerbuffModifier);
      }
      massivePropList_.WriteTo(output, _repeated_massivePropList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (sourceCase_ == SourceOneofCase.InstancedAbilityId) {
        output.WriteRawTag(8);
        output.WriteUInt32(InstancedAbilityId);
      }
      if (sourceCase_ == SourceOneofCase.InstancedModifierId) {
        output.WriteRawTag(16);
        output.WriteUInt32(InstancedModifierId);
      }
      if (LocalId != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(LocalId);
      }
      dataList_.WriteTo(ref output, _repeated_dataList_codec);
      if (IsServerbuffModifier != false) {
        output.WriteRawTag(40);
        output.WriteBool(IsServerbuffModifier);
      }
      massivePropList_.WriteTo(ref output, _repeated_massivePropList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (LocalId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LocalId);
      }
      size += dataList_.CalculateSize(_repeated_dataList_codec);
      if (IsServerbuffModifier != false) {
        size += 1 + 1;
      }
      size += massivePropList_.CalculateSize(_repeated_massivePropList_codec);
      if (sourceCase_ == SourceOneofCase.InstancedAbilityId) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(InstancedAbilityId);
      }
      if (sourceCase_ == SourceOneofCase.InstancedModifierId) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(InstancedModifierId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AbilityMixinRecoverInfo other) {
      if (other == null) {
        return;
      }
      if (other.LocalId != 0) {
        LocalId = other.LocalId;
      }
      dataList_.Add(other.dataList_);
      if (other.IsServerbuffModifier != false) {
        IsServerbuffModifier = other.IsServerbuffModifier;
      }
      massivePropList_.Add(other.massivePropList_);
      switch (other.SourceCase) {
        case SourceOneofCase.InstancedAbilityId:
          InstancedAbilityId = other.InstancedAbilityId;
          break;
        case SourceOneofCase.InstancedModifierId:
          InstancedModifierId = other.InstancedModifierId;
          break;
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
            InstancedAbilityId = input.ReadUInt32();
            break;
          }
          case 16: {
            InstancedModifierId = input.ReadUInt32();
            break;
          }
          case 24: {
            LocalId = input.ReadUInt32();
            break;
          }
          case 34:
          case 32: {
            dataList_.AddEntriesFrom(input, _repeated_dataList_codec);
            break;
          }
          case 40: {
            IsServerbuffModifier = input.ReadBool();
            break;
          }
          case 50: {
            massivePropList_.AddEntriesFrom(input, _repeated_massivePropList_codec);
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
            InstancedAbilityId = input.ReadUInt32();
            break;
          }
          case 16: {
            InstancedModifierId = input.ReadUInt32();
            break;
          }
          case 24: {
            LocalId = input.ReadUInt32();
            break;
          }
          case 34:
          case 32: {
            dataList_.AddEntriesFrom(ref input, _repeated_dataList_codec);
            break;
          }
          case 40: {
            IsServerbuffModifier = input.ReadBool();
            break;
          }
          case 50: {
            massivePropList_.AddEntriesFrom(ref input, _repeated_massivePropList_codec);
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