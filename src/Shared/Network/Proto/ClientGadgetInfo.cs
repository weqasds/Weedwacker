// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ClientGadgetInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from ClientGadgetInfo.proto</summary>
  public static partial class ClientGadgetInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for ClientGadgetInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ClientGadgetInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZDbGllbnRHYWRnZXRJbmZvLnByb3RvIsoBChBDbGllbnRHYWRnZXRJbmZv",
            "Eg8KB2NhbXBfaWQYASABKA0SEQoJY2FtcF90eXBlGAIgASgNEgwKBGd1aWQY",
            "AyABKAQSFwoPb3duZXJfZW50aXR5X2lkGAQgASgNEhgKEHRhcmdldF9lbnRp",
            "dHlfaWQYBSABKA0SEgoKYXN5bmNfbG9hZBgGIAEoCBIeChZpc19wZWVyX2lk",
            "X2Zyb21fcGxheWVyGAcgASgIEh0KFXRhcmdldF9lbnRpdHlfaWRfbGlzdBgI",
            "IAMoDUIiqgIfV2VlZHdhY2tlci5TaGFyZWQuTmV0d29yay5Qcm90b2IGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.ClientGadgetInfo), global::Weedwacker.Shared.Network.Proto.ClientGadgetInfo.Parser, new[]{ "CampId", "CampType", "Guid", "OwnerEntityId", "TargetEntityId", "AsyncLoad", "IsPeerIdFromPlayer", "TargetEntityIdList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ClientGadgetInfo : pb::IMessage<ClientGadgetInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ClientGadgetInfo> _parser = new pb::MessageParser<ClientGadgetInfo>(() => new ClientGadgetInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ClientGadgetInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.ClientGadgetInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ClientGadgetInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ClientGadgetInfo(ClientGadgetInfo other) : this() {
      campId_ = other.campId_;
      campType_ = other.campType_;
      guid_ = other.guid_;
      ownerEntityId_ = other.ownerEntityId_;
      targetEntityId_ = other.targetEntityId_;
      asyncLoad_ = other.asyncLoad_;
      isPeerIdFromPlayer_ = other.isPeerIdFromPlayer_;
      targetEntityIdList_ = other.targetEntityIdList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ClientGadgetInfo Clone() {
      return new ClientGadgetInfo(this);
    }

    /// <summary>Field number for the "camp_id" field.</summary>
    public const int CampIdFieldNumber = 1;
    private uint campId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CampId {
      get { return campId_; }
      set {
        campId_ = value;
      }
    }

    /// <summary>Field number for the "camp_type" field.</summary>
    public const int CampTypeFieldNumber = 2;
    private uint campType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CampType {
      get { return campType_; }
      set {
        campType_ = value;
      }
    }

    /// <summary>Field number for the "guid" field.</summary>
    public const int GuidFieldNumber = 3;
    private ulong guid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong Guid {
      get { return guid_; }
      set {
        guid_ = value;
      }
    }

    /// <summary>Field number for the "owner_entity_id" field.</summary>
    public const int OwnerEntityIdFieldNumber = 4;
    private uint ownerEntityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint OwnerEntityId {
      get { return ownerEntityId_; }
      set {
        ownerEntityId_ = value;
      }
    }

    /// <summary>Field number for the "target_entity_id" field.</summary>
    public const int TargetEntityIdFieldNumber = 5;
    private uint targetEntityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TargetEntityId {
      get { return targetEntityId_; }
      set {
        targetEntityId_ = value;
      }
    }

    /// <summary>Field number for the "async_load" field.</summary>
    public const int AsyncLoadFieldNumber = 6;
    private bool asyncLoad_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool AsyncLoad {
      get { return asyncLoad_; }
      set {
        asyncLoad_ = value;
      }
    }

    /// <summary>Field number for the "is_peer_id_from_player" field.</summary>
    public const int IsPeerIdFromPlayerFieldNumber = 7;
    private bool isPeerIdFromPlayer_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsPeerIdFromPlayer {
      get { return isPeerIdFromPlayer_; }
      set {
        isPeerIdFromPlayer_ = value;
      }
    }

    /// <summary>Field number for the "target_entity_id_list" field.</summary>
    public const int TargetEntityIdListFieldNumber = 8;
    private static readonly pb::FieldCodec<uint> _repeated_targetEntityIdList_codec
        = pb::FieldCodec.ForUInt32(66);
    private readonly pbc::RepeatedField<uint> targetEntityIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> TargetEntityIdList {
      get { return targetEntityIdList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ClientGadgetInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ClientGadgetInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CampId != other.CampId) return false;
      if (CampType != other.CampType) return false;
      if (Guid != other.Guid) return false;
      if (OwnerEntityId != other.OwnerEntityId) return false;
      if (TargetEntityId != other.TargetEntityId) return false;
      if (AsyncLoad != other.AsyncLoad) return false;
      if (IsPeerIdFromPlayer != other.IsPeerIdFromPlayer) return false;
      if(!targetEntityIdList_.Equals(other.targetEntityIdList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (CampId != 0) hash ^= CampId.GetHashCode();
      if (CampType != 0) hash ^= CampType.GetHashCode();
      if (Guid != 0UL) hash ^= Guid.GetHashCode();
      if (OwnerEntityId != 0) hash ^= OwnerEntityId.GetHashCode();
      if (TargetEntityId != 0) hash ^= TargetEntityId.GetHashCode();
      if (AsyncLoad != false) hash ^= AsyncLoad.GetHashCode();
      if (IsPeerIdFromPlayer != false) hash ^= IsPeerIdFromPlayer.GetHashCode();
      hash ^= targetEntityIdList_.GetHashCode();
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
      if (CampId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(CampId);
      }
      if (CampType != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(CampType);
      }
      if (Guid != 0UL) {
        output.WriteRawTag(24);
        output.WriteUInt64(Guid);
      }
      if (OwnerEntityId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(OwnerEntityId);
      }
      if (TargetEntityId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(TargetEntityId);
      }
      if (AsyncLoad != false) {
        output.WriteRawTag(48);
        output.WriteBool(AsyncLoad);
      }
      if (IsPeerIdFromPlayer != false) {
        output.WriteRawTag(56);
        output.WriteBool(IsPeerIdFromPlayer);
      }
      targetEntityIdList_.WriteTo(output, _repeated_targetEntityIdList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (CampId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(CampId);
      }
      if (CampType != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(CampType);
      }
      if (Guid != 0UL) {
        output.WriteRawTag(24);
        output.WriteUInt64(Guid);
      }
      if (OwnerEntityId != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(OwnerEntityId);
      }
      if (TargetEntityId != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(TargetEntityId);
      }
      if (AsyncLoad != false) {
        output.WriteRawTag(48);
        output.WriteBool(AsyncLoad);
      }
      if (IsPeerIdFromPlayer != false) {
        output.WriteRawTag(56);
        output.WriteBool(IsPeerIdFromPlayer);
      }
      targetEntityIdList_.WriteTo(ref output, _repeated_targetEntityIdList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (CampId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CampId);
      }
      if (CampType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CampType);
      }
      if (Guid != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(Guid);
      }
      if (OwnerEntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(OwnerEntityId);
      }
      if (TargetEntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TargetEntityId);
      }
      if (AsyncLoad != false) {
        size += 1 + 1;
      }
      if (IsPeerIdFromPlayer != false) {
        size += 1 + 1;
      }
      size += targetEntityIdList_.CalculateSize(_repeated_targetEntityIdList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ClientGadgetInfo other) {
      if (other == null) {
        return;
      }
      if (other.CampId != 0) {
        CampId = other.CampId;
      }
      if (other.CampType != 0) {
        CampType = other.CampType;
      }
      if (other.Guid != 0UL) {
        Guid = other.Guid;
      }
      if (other.OwnerEntityId != 0) {
        OwnerEntityId = other.OwnerEntityId;
      }
      if (other.TargetEntityId != 0) {
        TargetEntityId = other.TargetEntityId;
      }
      if (other.AsyncLoad != false) {
        AsyncLoad = other.AsyncLoad;
      }
      if (other.IsPeerIdFromPlayer != false) {
        IsPeerIdFromPlayer = other.IsPeerIdFromPlayer;
      }
      targetEntityIdList_.Add(other.targetEntityIdList_);
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
            CampId = input.ReadUInt32();
            break;
          }
          case 16: {
            CampType = input.ReadUInt32();
            break;
          }
          case 24: {
            Guid = input.ReadUInt64();
            break;
          }
          case 32: {
            OwnerEntityId = input.ReadUInt32();
            break;
          }
          case 40: {
            TargetEntityId = input.ReadUInt32();
            break;
          }
          case 48: {
            AsyncLoad = input.ReadBool();
            break;
          }
          case 56: {
            IsPeerIdFromPlayer = input.ReadBool();
            break;
          }
          case 66:
          case 64: {
            targetEntityIdList_.AddEntriesFrom(input, _repeated_targetEntityIdList_codec);
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
            CampId = input.ReadUInt32();
            break;
          }
          case 16: {
            CampType = input.ReadUInt32();
            break;
          }
          case 24: {
            Guid = input.ReadUInt64();
            break;
          }
          case 32: {
            OwnerEntityId = input.ReadUInt32();
            break;
          }
          case 40: {
            TargetEntityId = input.ReadUInt32();
            break;
          }
          case 48: {
            AsyncLoad = input.ReadBool();
            break;
          }
          case 56: {
            IsPeerIdFromPlayer = input.ReadBool();
            break;
          }
          case 66:
          case 64: {
            targetEntityIdList_.AddEntriesFrom(ref input, _repeated_targetEntityIdList_codec);
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
