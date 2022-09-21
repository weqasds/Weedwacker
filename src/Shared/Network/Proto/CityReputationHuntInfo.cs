// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CityReputationHuntInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from CityReputationHuntInfo.proto</summary>
  public static partial class CityReputationHuntInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for CityReputationHuntInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CityReputationHuntInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxDaXR5UmVwdXRhdGlvbkh1bnRJbmZvLnByb3RvIloKFkNpdHlSZXB1dGF0",
            "aW9uSHVudEluZm8SDwoHaXNfb3BlbhgGIAEoCBIbChNjdXJfd2Vla19maW5p",
            "c2hfbnVtGA8gASgNEhIKCmhhc19yZXdhcmQYBSABKAhCIqoCH1dlZWR3YWNr",
            "ZXIuU2hhcmVkLk5ldHdvcmsuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.CityReputationHuntInfo), global::Weedwacker.Shared.Network.Proto.CityReputationHuntInfo.Parser, new[]{ "IsOpen", "CurWeekFinishNum", "HasReward" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CityReputationHuntInfo : pb::IMessage<CityReputationHuntInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CityReputationHuntInfo> _parser = new pb::MessageParser<CityReputationHuntInfo>(() => new CityReputationHuntInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CityReputationHuntInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.CityReputationHuntInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CityReputationHuntInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CityReputationHuntInfo(CityReputationHuntInfo other) : this() {
      isOpen_ = other.isOpen_;
      curWeekFinishNum_ = other.curWeekFinishNum_;
      hasReward_ = other.hasReward_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CityReputationHuntInfo Clone() {
      return new CityReputationHuntInfo(this);
    }

    /// <summary>Field number for the "is_open" field.</summary>
    public const int IsOpenFieldNumber = 6;
    private bool isOpen_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsOpen {
      get { return isOpen_; }
      set {
        isOpen_ = value;
      }
    }

    /// <summary>Field number for the "cur_week_finish_num" field.</summary>
    public const int CurWeekFinishNumFieldNumber = 15;
    private uint curWeekFinishNum_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CurWeekFinishNum {
      get { return curWeekFinishNum_; }
      set {
        curWeekFinishNum_ = value;
      }
    }

    /// <summary>Field number for the "has_reward" field.</summary>
    public const int HasRewardFieldNumber = 5;
    private bool hasReward_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasReward {
      get { return hasReward_; }
      set {
        hasReward_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CityReputationHuntInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CityReputationHuntInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IsOpen != other.IsOpen) return false;
      if (CurWeekFinishNum != other.CurWeekFinishNum) return false;
      if (HasReward != other.HasReward) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (IsOpen != false) hash ^= IsOpen.GetHashCode();
      if (CurWeekFinishNum != 0) hash ^= CurWeekFinishNum.GetHashCode();
      if (HasReward != false) hash ^= HasReward.GetHashCode();
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
      if (HasReward != false) {
        output.WriteRawTag(40);
        output.WriteBool(HasReward);
      }
      if (IsOpen != false) {
        output.WriteRawTag(48);
        output.WriteBool(IsOpen);
      }
      if (CurWeekFinishNum != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(CurWeekFinishNum);
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
      if (HasReward != false) {
        output.WriteRawTag(40);
        output.WriteBool(HasReward);
      }
      if (IsOpen != false) {
        output.WriteRawTag(48);
        output.WriteBool(IsOpen);
      }
      if (CurWeekFinishNum != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(CurWeekFinishNum);
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
      if (IsOpen != false) {
        size += 1 + 1;
      }
      if (CurWeekFinishNum != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CurWeekFinishNum);
      }
      if (HasReward != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CityReputationHuntInfo other) {
      if (other == null) {
        return;
      }
      if (other.IsOpen != false) {
        IsOpen = other.IsOpen;
      }
      if (other.CurWeekFinishNum != 0) {
        CurWeekFinishNum = other.CurWeekFinishNum;
      }
      if (other.HasReward != false) {
        HasReward = other.HasReward;
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
          case 40: {
            HasReward = input.ReadBool();
            break;
          }
          case 48: {
            IsOpen = input.ReadBool();
            break;
          }
          case 120: {
            CurWeekFinishNum = input.ReadUInt32();
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
          case 40: {
            HasReward = input.ReadBool();
            break;
          }
          case 48: {
            IsOpen = input.ReadBool();
            break;
          }
          case 120: {
            CurWeekFinishNum = input.ReadUInt32();
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