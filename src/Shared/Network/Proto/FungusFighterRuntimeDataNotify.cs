// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: FungusFighterRuntimeDataNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from FungusFighterRuntimeDataNotify.proto</summary>
  public static partial class FungusFighterRuntimeDataNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for FungusFighterRuntimeDataNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FungusFighterRuntimeDataNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiRGdW5ndXNGaWdodGVyUnVudGltZURhdGFOb3RpZnkucHJvdG8aIkZ1bmd1",
            "c1RyYWluaW5nUHJvZ3Jlc3NEZXRhaWwucHJvdG8iWAoeRnVuZ3VzRmlnaHRl",
            "clJ1bnRpbWVEYXRhTm90aWZ5EjYKD3Byb2dyZXNzX2RldGFpbBgHIAEoCzId",
            "LkZ1bmd1c1RyYWluaW5nUHJvZ3Jlc3NEZXRhaWxCIqoCH1dlZWR3YWNrZXIu",
            "U2hhcmVkLk5ldHdvcmsuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.FungusTrainingProgressDetailReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.FungusFighterRuntimeDataNotify), global::Weedwacker.Shared.Network.Proto.FungusFighterRuntimeDataNotify.Parser, new[]{ "ProgressDetail" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 24674
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class FungusFighterRuntimeDataNotify : pb::IMessage<FungusFighterRuntimeDataNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FungusFighterRuntimeDataNotify> _parser = new pb::MessageParser<FungusFighterRuntimeDataNotify>(() => new FungusFighterRuntimeDataNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FungusFighterRuntimeDataNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.FungusFighterRuntimeDataNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FungusFighterRuntimeDataNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FungusFighterRuntimeDataNotify(FungusFighterRuntimeDataNotify other) : this() {
      progressDetail_ = other.progressDetail_ != null ? other.progressDetail_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FungusFighterRuntimeDataNotify Clone() {
      return new FungusFighterRuntimeDataNotify(this);
    }

    /// <summary>Field number for the "progress_detail" field.</summary>
    public const int ProgressDetailFieldNumber = 7;
    private global::Weedwacker.Shared.Network.Proto.FungusTrainingProgressDetail progressDetail_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.FungusTrainingProgressDetail ProgressDetail {
      get { return progressDetail_; }
      set {
        progressDetail_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FungusFighterRuntimeDataNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FungusFighterRuntimeDataNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(ProgressDetail, other.ProgressDetail)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (progressDetail_ != null) hash ^= ProgressDetail.GetHashCode();
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
      if (progressDetail_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(ProgressDetail);
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
      if (progressDetail_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(ProgressDetail);
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
      if (progressDetail_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ProgressDetail);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FungusFighterRuntimeDataNotify other) {
      if (other == null) {
        return;
      }
      if (other.progressDetail_ != null) {
        if (progressDetail_ == null) {
          ProgressDetail = new global::Weedwacker.Shared.Network.Proto.FungusTrainingProgressDetail();
        }
        ProgressDetail.MergeFrom(other.ProgressDetail);
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
            if (progressDetail_ == null) {
              ProgressDetail = new global::Weedwacker.Shared.Network.Proto.FungusTrainingProgressDetail();
            }
            input.ReadMessage(ProgressDetail);
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
            if (progressDetail_ == null) {
              ProgressDetail = new global::Weedwacker.Shared.Network.Proto.FungusTrainingProgressDetail();
            }
            input.ReadMessage(ProgressDetail);
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
