// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: HideAndSeekActivityDetailInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from HideAndSeekActivityDetailInfo.proto</summary>
  public static partial class HideAndSeekActivityDetailInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for HideAndSeekActivityDetailInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HideAndSeekActivityDetailInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNIaWRlQW5kU2Vla0FjdGl2aXR5RGV0YWlsSW5mby5wcm90bxoZVW5rMjcw",
            "MF9MQk9BRUZNRUNDUC5wcm90byKuAQodSGlkZUFuZFNlZWtBY3Rpdml0eURl",
            "dGFpbEluZm8SMQoTVW5rMjcwMF9KRE1ET09IRk5DQRgBIAMoCzIULlVuazI3",
            "MDBfTEJPQUVGTUVDQ1ASIAoYY2hvc2VuX2h1bnRlcl9za2lsbF9saXN0GAQg",
            "AygNEhcKD3VubG9ja19tYXBfbGlzdBgNIAMoDRIfChdjaG9zZW5faGlkZXJf",
            "c2tpbGxfbGlzdBgGIAMoDUIaqgIXV2VlZHdhY2tlci5TZXJ2ZXIuUHJvdG9i",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Server.Proto.Unk2700LBOAEFMECCPReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.HideAndSeekActivityDetailInfo), global::Weedwacker.Server.Proto.HideAndSeekActivityDetailInfo.Parser, new[]{ "Unk2700JDMDOOHFNCA", "ChosenHunterSkillList", "UnlockMapList", "ChosenHiderSkillList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class HideAndSeekActivityDetailInfo : pb::IMessage<HideAndSeekActivityDetailInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HideAndSeekActivityDetailInfo> _parser = new pb::MessageParser<HideAndSeekActivityDetailInfo>(() => new HideAndSeekActivityDetailInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HideAndSeekActivityDetailInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.HideAndSeekActivityDetailInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HideAndSeekActivityDetailInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HideAndSeekActivityDetailInfo(HideAndSeekActivityDetailInfo other) : this() {
      unk2700JDMDOOHFNCA_ = other.unk2700JDMDOOHFNCA_.Clone();
      chosenHunterSkillList_ = other.chosenHunterSkillList_.Clone();
      unlockMapList_ = other.unlockMapList_.Clone();
      chosenHiderSkillList_ = other.chosenHiderSkillList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HideAndSeekActivityDetailInfo Clone() {
      return new HideAndSeekActivityDetailInfo(this);
    }

    /// <summary>Field number for the "Unk2700_JDMDOOHFNCA" field.</summary>
    public const int Unk2700JDMDOOHFNCAFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Weedwacker.Server.Proto.Unk2700_LBOAEFMECCP> _repeated_unk2700JDMDOOHFNCA_codec
        = pb::FieldCodec.ForMessage(10, global::Weedwacker.Server.Proto.Unk2700_LBOAEFMECCP.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Server.Proto.Unk2700_LBOAEFMECCP> unk2700JDMDOOHFNCA_ = new pbc::RepeatedField<global::Weedwacker.Server.Proto.Unk2700_LBOAEFMECCP>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Server.Proto.Unk2700_LBOAEFMECCP> Unk2700JDMDOOHFNCA {
      get { return unk2700JDMDOOHFNCA_; }
    }

    /// <summary>Field number for the "chosen_hunter_skill_list" field.</summary>
    public const int ChosenHunterSkillListFieldNumber = 4;
    private static readonly pb::FieldCodec<uint> _repeated_chosenHunterSkillList_codec
        = pb::FieldCodec.ForUInt32(34);
    private readonly pbc::RepeatedField<uint> chosenHunterSkillList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> ChosenHunterSkillList {
      get { return chosenHunterSkillList_; }
    }

    /// <summary>Field number for the "unlock_map_list" field.</summary>
    public const int UnlockMapListFieldNumber = 13;
    private static readonly pb::FieldCodec<uint> _repeated_unlockMapList_codec
        = pb::FieldCodec.ForUInt32(106);
    private readonly pbc::RepeatedField<uint> unlockMapList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> UnlockMapList {
      get { return unlockMapList_; }
    }

    /// <summary>Field number for the "chosen_hider_skill_list" field.</summary>
    public const int ChosenHiderSkillListFieldNumber = 6;
    private static readonly pb::FieldCodec<uint> _repeated_chosenHiderSkillList_codec
        = pb::FieldCodec.ForUInt32(50);
    private readonly pbc::RepeatedField<uint> chosenHiderSkillList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> ChosenHiderSkillList {
      get { return chosenHiderSkillList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as HideAndSeekActivityDetailInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HideAndSeekActivityDetailInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!unk2700JDMDOOHFNCA_.Equals(other.unk2700JDMDOOHFNCA_)) return false;
      if(!chosenHunterSkillList_.Equals(other.chosenHunterSkillList_)) return false;
      if(!unlockMapList_.Equals(other.unlockMapList_)) return false;
      if(!chosenHiderSkillList_.Equals(other.chosenHiderSkillList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= unk2700JDMDOOHFNCA_.GetHashCode();
      hash ^= chosenHunterSkillList_.GetHashCode();
      hash ^= unlockMapList_.GetHashCode();
      hash ^= chosenHiderSkillList_.GetHashCode();
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
      unk2700JDMDOOHFNCA_.WriteTo(output, _repeated_unk2700JDMDOOHFNCA_codec);
      chosenHunterSkillList_.WriteTo(output, _repeated_chosenHunterSkillList_codec);
      chosenHiderSkillList_.WriteTo(output, _repeated_chosenHiderSkillList_codec);
      unlockMapList_.WriteTo(output, _repeated_unlockMapList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      unk2700JDMDOOHFNCA_.WriteTo(ref output, _repeated_unk2700JDMDOOHFNCA_codec);
      chosenHunterSkillList_.WriteTo(ref output, _repeated_chosenHunterSkillList_codec);
      chosenHiderSkillList_.WriteTo(ref output, _repeated_chosenHiderSkillList_codec);
      unlockMapList_.WriteTo(ref output, _repeated_unlockMapList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += unk2700JDMDOOHFNCA_.CalculateSize(_repeated_unk2700JDMDOOHFNCA_codec);
      size += chosenHunterSkillList_.CalculateSize(_repeated_chosenHunterSkillList_codec);
      size += unlockMapList_.CalculateSize(_repeated_unlockMapList_codec);
      size += chosenHiderSkillList_.CalculateSize(_repeated_chosenHiderSkillList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(HideAndSeekActivityDetailInfo other) {
      if (other == null) {
        return;
      }
      unk2700JDMDOOHFNCA_.Add(other.unk2700JDMDOOHFNCA_);
      chosenHunterSkillList_.Add(other.chosenHunterSkillList_);
      unlockMapList_.Add(other.unlockMapList_);
      chosenHiderSkillList_.Add(other.chosenHiderSkillList_);
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
          case 10: {
            unk2700JDMDOOHFNCA_.AddEntriesFrom(input, _repeated_unk2700JDMDOOHFNCA_codec);
            break;
          }
          case 34:
          case 32: {
            chosenHunterSkillList_.AddEntriesFrom(input, _repeated_chosenHunterSkillList_codec);
            break;
          }
          case 50:
          case 48: {
            chosenHiderSkillList_.AddEntriesFrom(input, _repeated_chosenHiderSkillList_codec);
            break;
          }
          case 106:
          case 104: {
            unlockMapList_.AddEntriesFrom(input, _repeated_unlockMapList_codec);
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
          case 10: {
            unk2700JDMDOOHFNCA_.AddEntriesFrom(ref input, _repeated_unk2700JDMDOOHFNCA_codec);
            break;
          }
          case 34:
          case 32: {
            chosenHunterSkillList_.AddEntriesFrom(ref input, _repeated_chosenHunterSkillList_codec);
            break;
          }
          case 50:
          case 48: {
            chosenHiderSkillList_.AddEntriesFrom(ref input, _repeated_chosenHiderSkillList_codec);
            break;
          }
          case 106:
          case 104: {
            unlockMapList_.AddEntriesFrom(ref input, _repeated_unlockMapList_codec);
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