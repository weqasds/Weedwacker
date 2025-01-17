// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: WindFieldGalleryChallengeInfoNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from WindFieldGalleryChallengeInfoNotify.proto</summary>
  public static partial class WindFieldGalleryChallengeInfoNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for WindFieldGalleryChallengeInfoNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static WindFieldGalleryChallengeInfoNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CilXaW5kRmllbGRHYWxsZXJ5Q2hhbGxlbmdlSW5mb05vdGlmeS5wcm90byLb",
            "AQojV2luZEZpZWxkR2FsbGVyeUNoYWxsZW5nZUluZm9Ob3RpZnkSGwoTY2hh",
            "bGxlbmdlX3RpbWVzdGFtcBgGIAEoDRIQCghpc19zdGFydBgIIAEoCBIPCgdz",
            "aG93X2lkGAwgASgNEhIKCmlzX3N1Y2Nlc3MYByABKAgSHAoUY2hhbGxlbmdl",
            "X3RvdGFsX3RpbWUYDSABKA0SIAoYY2hhbGxlbmdlX2JhbGxfbWF4X2NvdW50",
            "GAsgASgNEiAKGGNoYWxsZW5nZV9iYWxsX2N1cl9jb3VudBgBIAEoDUIiqgIf",
            "V2VlZHdhY2tlci5TaGFyZWQuTmV0d29yay5Qcm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.WindFieldGalleryChallengeInfoNotify), global::Weedwacker.Shared.Network.Proto.WindFieldGalleryChallengeInfoNotify.Parser, new[]{ "ChallengeTimestamp", "IsStart", "ShowId", "IsSuccess", "ChallengeTotalTime", "ChallengeBallMaxCount", "ChallengeBallCurCount" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 5563
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class WindFieldGalleryChallengeInfoNotify : pb::IMessage<WindFieldGalleryChallengeInfoNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<WindFieldGalleryChallengeInfoNotify> _parser = new pb::MessageParser<WindFieldGalleryChallengeInfoNotify>(() => new WindFieldGalleryChallengeInfoNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<WindFieldGalleryChallengeInfoNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.WindFieldGalleryChallengeInfoNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WindFieldGalleryChallengeInfoNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WindFieldGalleryChallengeInfoNotify(WindFieldGalleryChallengeInfoNotify other) : this() {
      challengeTimestamp_ = other.challengeTimestamp_;
      isStart_ = other.isStart_;
      showId_ = other.showId_;
      isSuccess_ = other.isSuccess_;
      challengeTotalTime_ = other.challengeTotalTime_;
      challengeBallMaxCount_ = other.challengeBallMaxCount_;
      challengeBallCurCount_ = other.challengeBallCurCount_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public WindFieldGalleryChallengeInfoNotify Clone() {
      return new WindFieldGalleryChallengeInfoNotify(this);
    }

    /// <summary>Field number for the "challenge_timestamp" field.</summary>
    public const int ChallengeTimestampFieldNumber = 6;
    private uint challengeTimestamp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ChallengeTimestamp {
      get { return challengeTimestamp_; }
      set {
        challengeTimestamp_ = value;
      }
    }

    /// <summary>Field number for the "is_start" field.</summary>
    public const int IsStartFieldNumber = 8;
    private bool isStart_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsStart {
      get { return isStart_; }
      set {
        isStart_ = value;
      }
    }

    /// <summary>Field number for the "show_id" field.</summary>
    public const int ShowIdFieldNumber = 12;
    private uint showId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ShowId {
      get { return showId_; }
      set {
        showId_ = value;
      }
    }

    /// <summary>Field number for the "is_success" field.</summary>
    public const int IsSuccessFieldNumber = 7;
    private bool isSuccess_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsSuccess {
      get { return isSuccess_; }
      set {
        isSuccess_ = value;
      }
    }

    /// <summary>Field number for the "challenge_total_time" field.</summary>
    public const int ChallengeTotalTimeFieldNumber = 13;
    private uint challengeTotalTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ChallengeTotalTime {
      get { return challengeTotalTime_; }
      set {
        challengeTotalTime_ = value;
      }
    }

    /// <summary>Field number for the "challenge_ball_max_count" field.</summary>
    public const int ChallengeBallMaxCountFieldNumber = 11;
    private uint challengeBallMaxCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ChallengeBallMaxCount {
      get { return challengeBallMaxCount_; }
      set {
        challengeBallMaxCount_ = value;
      }
    }

    /// <summary>Field number for the "challenge_ball_cur_count" field.</summary>
    public const int ChallengeBallCurCountFieldNumber = 1;
    private uint challengeBallCurCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ChallengeBallCurCount {
      get { return challengeBallCurCount_; }
      set {
        challengeBallCurCount_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as WindFieldGalleryChallengeInfoNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(WindFieldGalleryChallengeInfoNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ChallengeTimestamp != other.ChallengeTimestamp) return false;
      if (IsStart != other.IsStart) return false;
      if (ShowId != other.ShowId) return false;
      if (IsSuccess != other.IsSuccess) return false;
      if (ChallengeTotalTime != other.ChallengeTotalTime) return false;
      if (ChallengeBallMaxCount != other.ChallengeBallMaxCount) return false;
      if (ChallengeBallCurCount != other.ChallengeBallCurCount) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ChallengeTimestamp != 0) hash ^= ChallengeTimestamp.GetHashCode();
      if (IsStart != false) hash ^= IsStart.GetHashCode();
      if (ShowId != 0) hash ^= ShowId.GetHashCode();
      if (IsSuccess != false) hash ^= IsSuccess.GetHashCode();
      if (ChallengeTotalTime != 0) hash ^= ChallengeTotalTime.GetHashCode();
      if (ChallengeBallMaxCount != 0) hash ^= ChallengeBallMaxCount.GetHashCode();
      if (ChallengeBallCurCount != 0) hash ^= ChallengeBallCurCount.GetHashCode();
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
      if (ChallengeBallCurCount != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(ChallengeBallCurCount);
      }
      if (ChallengeTimestamp != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(ChallengeTimestamp);
      }
      if (IsSuccess != false) {
        output.WriteRawTag(56);
        output.WriteBool(IsSuccess);
      }
      if (IsStart != false) {
        output.WriteRawTag(64);
        output.WriteBool(IsStart);
      }
      if (ChallengeBallMaxCount != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(ChallengeBallMaxCount);
      }
      if (ShowId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(ShowId);
      }
      if (ChallengeTotalTime != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(ChallengeTotalTime);
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
      if (ChallengeBallCurCount != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(ChallengeBallCurCount);
      }
      if (ChallengeTimestamp != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(ChallengeTimestamp);
      }
      if (IsSuccess != false) {
        output.WriteRawTag(56);
        output.WriteBool(IsSuccess);
      }
      if (IsStart != false) {
        output.WriteRawTag(64);
        output.WriteBool(IsStart);
      }
      if (ChallengeBallMaxCount != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(ChallengeBallMaxCount);
      }
      if (ShowId != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(ShowId);
      }
      if (ChallengeTotalTime != 0) {
        output.WriteRawTag(104);
        output.WriteUInt32(ChallengeTotalTime);
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
      if (ChallengeTimestamp != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ChallengeTimestamp);
      }
      if (IsStart != false) {
        size += 1 + 1;
      }
      if (ShowId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ShowId);
      }
      if (IsSuccess != false) {
        size += 1 + 1;
      }
      if (ChallengeTotalTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ChallengeTotalTime);
      }
      if (ChallengeBallMaxCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ChallengeBallMaxCount);
      }
      if (ChallengeBallCurCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ChallengeBallCurCount);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(WindFieldGalleryChallengeInfoNotify other) {
      if (other == null) {
        return;
      }
      if (other.ChallengeTimestamp != 0) {
        ChallengeTimestamp = other.ChallengeTimestamp;
      }
      if (other.IsStart != false) {
        IsStart = other.IsStart;
      }
      if (other.ShowId != 0) {
        ShowId = other.ShowId;
      }
      if (other.IsSuccess != false) {
        IsSuccess = other.IsSuccess;
      }
      if (other.ChallengeTotalTime != 0) {
        ChallengeTotalTime = other.ChallengeTotalTime;
      }
      if (other.ChallengeBallMaxCount != 0) {
        ChallengeBallMaxCount = other.ChallengeBallMaxCount;
      }
      if (other.ChallengeBallCurCount != 0) {
        ChallengeBallCurCount = other.ChallengeBallCurCount;
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
            ChallengeBallCurCount = input.ReadUInt32();
            break;
          }
          case 48: {
            ChallengeTimestamp = input.ReadUInt32();
            break;
          }
          case 56: {
            IsSuccess = input.ReadBool();
            break;
          }
          case 64: {
            IsStart = input.ReadBool();
            break;
          }
          case 88: {
            ChallengeBallMaxCount = input.ReadUInt32();
            break;
          }
          case 96: {
            ShowId = input.ReadUInt32();
            break;
          }
          case 104: {
            ChallengeTotalTime = input.ReadUInt32();
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
            ChallengeBallCurCount = input.ReadUInt32();
            break;
          }
          case 48: {
            ChallengeTimestamp = input.ReadUInt32();
            break;
          }
          case 56: {
            IsSuccess = input.ReadBool();
            break;
          }
          case 64: {
            IsStart = input.ReadBool();
            break;
          }
          case 88: {
            ChallengeBallMaxCount = input.ReadUInt32();
            break;
          }
          case 96: {
            ShowId = input.ReadUInt32();
            break;
          }
          case 104: {
            ChallengeTotalTime = input.ReadUInt32();
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
