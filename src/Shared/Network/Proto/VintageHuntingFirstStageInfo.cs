// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: VintageHuntingFirstStageInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from VintageHuntingFirstStageInfo.proto</summary>
  public static partial class VintageHuntingFirstStageInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for VintageHuntingFirstStageInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static VintageHuntingFirstStageInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiJWaW50YWdlSHVudGluZ0ZpcnN0U3RhZ2VJbmZvLnByb3RvImcKHFZpbnRh",
            "Z2VIdW50aW5nRmlyc3RTdGFnZUluZm8SEQoJdGltaWRfY250GA8gASgNEhIK",
            "CmJydXRhbF9jbnQYByABKA0SDQoFc2NvcmUYDiABKA0SEQoJZWxpdGVfY250",
            "GAsgASgNQiKqAh9XZWVkd2Fja2VyLlNoYXJlZC5OZXR3b3JrLlByb3RvYgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.VintageHuntingFirstStageInfo), global::Weedwacker.Shared.Network.Proto.VintageHuntingFirstStageInfo.Parser, new[]{ "TimidCnt", "BrutalCnt", "Score", "EliteCnt" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class VintageHuntingFirstStageInfo : pb::IMessage<VintageHuntingFirstStageInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<VintageHuntingFirstStageInfo> _parser = new pb::MessageParser<VintageHuntingFirstStageInfo>(() => new VintageHuntingFirstStageInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<VintageHuntingFirstStageInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.VintageHuntingFirstStageInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public VintageHuntingFirstStageInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public VintageHuntingFirstStageInfo(VintageHuntingFirstStageInfo other) : this() {
      timidCnt_ = other.timidCnt_;
      brutalCnt_ = other.brutalCnt_;
      score_ = other.score_;
      eliteCnt_ = other.eliteCnt_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public VintageHuntingFirstStageInfo Clone() {
      return new VintageHuntingFirstStageInfo(this);
    }

    /// <summary>Field number for the "timid_cnt" field.</summary>
    public const int TimidCntFieldNumber = 15;
    private uint timidCnt_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint TimidCnt {
      get { return timidCnt_; }
      set {
        timidCnt_ = value;
      }
    }

    /// <summary>Field number for the "brutal_cnt" field.</summary>
    public const int BrutalCntFieldNumber = 7;
    private uint brutalCnt_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BrutalCnt {
      get { return brutalCnt_; }
      set {
        brutalCnt_ = value;
      }
    }

    /// <summary>Field number for the "score" field.</summary>
    public const int ScoreFieldNumber = 14;
    private uint score_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Score {
      get { return score_; }
      set {
        score_ = value;
      }
    }

    /// <summary>Field number for the "elite_cnt" field.</summary>
    public const int EliteCntFieldNumber = 11;
    private uint eliteCnt_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EliteCnt {
      get { return eliteCnt_; }
      set {
        eliteCnt_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as VintageHuntingFirstStageInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(VintageHuntingFirstStageInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (TimidCnt != other.TimidCnt) return false;
      if (BrutalCnt != other.BrutalCnt) return false;
      if (Score != other.Score) return false;
      if (EliteCnt != other.EliteCnt) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (TimidCnt != 0) hash ^= TimidCnt.GetHashCode();
      if (BrutalCnt != 0) hash ^= BrutalCnt.GetHashCode();
      if (Score != 0) hash ^= Score.GetHashCode();
      if (EliteCnt != 0) hash ^= EliteCnt.GetHashCode();
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
      if (BrutalCnt != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(BrutalCnt);
      }
      if (EliteCnt != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(EliteCnt);
      }
      if (Score != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(Score);
      }
      if (TimidCnt != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(TimidCnt);
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
      if (BrutalCnt != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(BrutalCnt);
      }
      if (EliteCnt != 0) {
        output.WriteRawTag(88);
        output.WriteUInt32(EliteCnt);
      }
      if (Score != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(Score);
      }
      if (TimidCnt != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(TimidCnt);
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
      if (TimidCnt != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(TimidCnt);
      }
      if (BrutalCnt != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(BrutalCnt);
      }
      if (Score != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Score);
      }
      if (EliteCnt != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EliteCnt);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(VintageHuntingFirstStageInfo other) {
      if (other == null) {
        return;
      }
      if (other.TimidCnt != 0) {
        TimidCnt = other.TimidCnt;
      }
      if (other.BrutalCnt != 0) {
        BrutalCnt = other.BrutalCnt;
      }
      if (other.Score != 0) {
        Score = other.Score;
      }
      if (other.EliteCnt != 0) {
        EliteCnt = other.EliteCnt;
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
          case 56: {
            BrutalCnt = input.ReadUInt32();
            break;
          }
          case 88: {
            EliteCnt = input.ReadUInt32();
            break;
          }
          case 112: {
            Score = input.ReadUInt32();
            break;
          }
          case 120: {
            TimidCnt = input.ReadUInt32();
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
          case 56: {
            BrutalCnt = input.ReadUInt32();
            break;
          }
          case 88: {
            EliteCnt = input.ReadUInt32();
            break;
          }
          case 112: {
            Score = input.ReadUInt32();
            break;
          }
          case 120: {
            TimidCnt = input.ReadUInt32();
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