// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Unk2700_CILGDLMHCNG_ServerNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Server.Proto {

  /// <summary>Holder for reflection information generated from Unk2700_CILGDLMHCNG_ServerNotify.proto</summary>
  public static partial class Unk2700CILGDLMHCNGServerNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for Unk2700_CILGDLMHCNG_ServerNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static Unk2700CILGDLMHCNGServerNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiZVbmsyNzAwX0NJTEdETE1IQ05HX1NlcnZlck5vdGlmeS5wcm90byJTCiBV",
            "bmsyNzAwX0NJTEdETE1IQ05HX1NlcnZlck5vdGlmeRIbChNVbmsyNzAwX0dF",
            "Qk9LQU1HRUVCGAcgASgJEhIKCmNoYXB0ZXJfaWQYDyABKA1CGqoCF1dlZWR3",
            "YWNrZXIuU2VydmVyLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Server.Proto.Unk2700_CILGDLMHCNG_ServerNotify), global::Weedwacker.Server.Proto.Unk2700_CILGDLMHCNG_ServerNotify.Parser, new[]{ "Unk2700GEBOKAMGEEB", "ChapterId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 1951
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class Unk2700_CILGDLMHCNG_ServerNotify : pb::IMessage<Unk2700_CILGDLMHCNG_ServerNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Unk2700_CILGDLMHCNG_ServerNotify> _parser = new pb::MessageParser<Unk2700_CILGDLMHCNG_ServerNotify>(() => new Unk2700_CILGDLMHCNG_ServerNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Unk2700_CILGDLMHCNG_ServerNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Server.Proto.Unk2700CILGDLMHCNGServerNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_CILGDLMHCNG_ServerNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_CILGDLMHCNG_ServerNotify(Unk2700_CILGDLMHCNG_ServerNotify other) : this() {
      unk2700GEBOKAMGEEB_ = other.unk2700GEBOKAMGEEB_;
      chapterId_ = other.chapterId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Unk2700_CILGDLMHCNG_ServerNotify Clone() {
      return new Unk2700_CILGDLMHCNG_ServerNotify(this);
    }

    /// <summary>Field number for the "Unk2700_GEBOKAMGEEB" field.</summary>
    public const int Unk2700GEBOKAMGEEBFieldNumber = 7;
    private string unk2700GEBOKAMGEEB_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Unk2700GEBOKAMGEEB {
      get { return unk2700GEBOKAMGEEB_; }
      set {
        unk2700GEBOKAMGEEB_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "chapter_id" field.</summary>
    public const int ChapterIdFieldNumber = 15;
    private uint chapterId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint ChapterId {
      get { return chapterId_; }
      set {
        chapterId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Unk2700_CILGDLMHCNG_ServerNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Unk2700_CILGDLMHCNG_ServerNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Unk2700GEBOKAMGEEB != other.Unk2700GEBOKAMGEEB) return false;
      if (ChapterId != other.ChapterId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Unk2700GEBOKAMGEEB.Length != 0) hash ^= Unk2700GEBOKAMGEEB.GetHashCode();
      if (ChapterId != 0) hash ^= ChapterId.GetHashCode();
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
      if (Unk2700GEBOKAMGEEB.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(Unk2700GEBOKAMGEEB);
      }
      if (ChapterId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(ChapterId);
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
      if (Unk2700GEBOKAMGEEB.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(Unk2700GEBOKAMGEEB);
      }
      if (ChapterId != 0) {
        output.WriteRawTag(120);
        output.WriteUInt32(ChapterId);
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
      if (Unk2700GEBOKAMGEEB.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Unk2700GEBOKAMGEEB);
      }
      if (ChapterId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ChapterId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Unk2700_CILGDLMHCNG_ServerNotify other) {
      if (other == null) {
        return;
      }
      if (other.Unk2700GEBOKAMGEEB.Length != 0) {
        Unk2700GEBOKAMGEEB = other.Unk2700GEBOKAMGEEB;
      }
      if (other.ChapterId != 0) {
        ChapterId = other.ChapterId;
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
          case 58: {
            Unk2700GEBOKAMGEEB = input.ReadString();
            break;
          }
          case 120: {
            ChapterId = input.ReadUInt32();
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
          case 58: {
            Unk2700GEBOKAMGEEB = input.ReadString();
            break;
          }
          case 120: {
            ChapterId = input.ReadUInt32();
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