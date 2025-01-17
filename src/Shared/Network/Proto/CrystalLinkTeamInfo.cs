// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CrystalLinkTeamInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from CrystalLinkTeamInfo.proto</summary>
  public static partial class CrystalLinkTeamInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for CrystalLinkTeamInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CrystalLinkTeamInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlDcnlzdGFsTGlua1RlYW1JbmZvLnByb3RvGhtDcnlzdGFsTGlua0F2YXRh",
            "ckluZm8ucHJvdG8aGUNyeXN0YWxMaW5rQnVmZkluZm8ucHJvdG8idQoTQ3J5",
            "c3RhbExpbmtUZWFtSW5mbxIsCg5idWZmX2luZm9fbGlzdBgCIAMoCzIULkNy",
            "eXN0YWxMaW5rQnVmZkluZm8SMAoQYXZhdGFyX2luZm9fbGlzdBgLIAMoCzIW",
            "LkNyeXN0YWxMaW5rQXZhdGFySW5mb0IiqgIfV2VlZHdhY2tlci5TaGFyZWQu",
            "TmV0d29yay5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.CrystalLinkAvatarInfoReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.CrystalLinkBuffInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.CrystalLinkTeamInfo), global::Weedwacker.Shared.Network.Proto.CrystalLinkTeamInfo.Parser, new[]{ "BuffInfoList", "AvatarInfoList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CrystalLinkTeamInfo : pb::IMessage<CrystalLinkTeamInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CrystalLinkTeamInfo> _parser = new pb::MessageParser<CrystalLinkTeamInfo>(() => new CrystalLinkTeamInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CrystalLinkTeamInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.CrystalLinkTeamInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CrystalLinkTeamInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CrystalLinkTeamInfo(CrystalLinkTeamInfo other) : this() {
      buffInfoList_ = other.buffInfoList_.Clone();
      avatarInfoList_ = other.avatarInfoList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CrystalLinkTeamInfo Clone() {
      return new CrystalLinkTeamInfo(this);
    }

    /// <summary>Field number for the "buff_info_list" field.</summary>
    public const int BuffInfoListFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.CrystalLinkBuffInfo> _repeated_buffInfoList_codec
        = pb::FieldCodec.ForMessage(18, global::Weedwacker.Shared.Network.Proto.CrystalLinkBuffInfo.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.CrystalLinkBuffInfo> buffInfoList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.CrystalLinkBuffInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.CrystalLinkBuffInfo> BuffInfoList {
      get { return buffInfoList_; }
    }

    /// <summary>Field number for the "avatar_info_list" field.</summary>
    public const int AvatarInfoListFieldNumber = 11;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.CrystalLinkAvatarInfo> _repeated_avatarInfoList_codec
        = pb::FieldCodec.ForMessage(90, global::Weedwacker.Shared.Network.Proto.CrystalLinkAvatarInfo.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.CrystalLinkAvatarInfo> avatarInfoList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.CrystalLinkAvatarInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.CrystalLinkAvatarInfo> AvatarInfoList {
      get { return avatarInfoList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CrystalLinkTeamInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CrystalLinkTeamInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!buffInfoList_.Equals(other.buffInfoList_)) return false;
      if(!avatarInfoList_.Equals(other.avatarInfoList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= buffInfoList_.GetHashCode();
      hash ^= avatarInfoList_.GetHashCode();
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
      buffInfoList_.WriteTo(output, _repeated_buffInfoList_codec);
      avatarInfoList_.WriteTo(output, _repeated_avatarInfoList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      buffInfoList_.WriteTo(ref output, _repeated_buffInfoList_codec);
      avatarInfoList_.WriteTo(ref output, _repeated_avatarInfoList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += buffInfoList_.CalculateSize(_repeated_buffInfoList_codec);
      size += avatarInfoList_.CalculateSize(_repeated_avatarInfoList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CrystalLinkTeamInfo other) {
      if (other == null) {
        return;
      }
      buffInfoList_.Add(other.buffInfoList_);
      avatarInfoList_.Add(other.avatarInfoList_);
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
          case 18: {
            buffInfoList_.AddEntriesFrom(input, _repeated_buffInfoList_codec);
            break;
          }
          case 90: {
            avatarInfoList_.AddEntriesFrom(input, _repeated_avatarInfoList_codec);
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
          case 18: {
            buffInfoList_.AddEntriesFrom(ref input, _repeated_buffInfoList_codec);
            break;
          }
          case 90: {
            avatarInfoList_.AddEntriesFrom(ref input, _repeated_avatarInfoList_codec);
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
