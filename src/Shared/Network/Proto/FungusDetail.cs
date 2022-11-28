// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: FungusDetail.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from FungusDetail.proto</summary>
  public static partial class FungusDetailReflection {

    #region Descriptor
    /// <summary>File descriptor for FungusDetail.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FungusDetailReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJGdW5ndXNEZXRhaWwucHJvdG8iewoMRnVuZ3VzRGV0YWlsEhQKDGlzX2N1",
            "bHRpdmF0ZRgFIAEoCBIVCg1jYXB0dXJlX29yZGVyGAYgASgNEg8KB25hbWVf",
            "aWQYDiABKA0SGgoSbWluX2N1bHRpdmF0ZV9zdGVwGAEgASgNEhEKCWZ1bmd1",
            "c19pZBgJIAEoDUIiqgIfV2VlZHdhY2tlci5TaGFyZWQuTmV0d29yay5Qcm90",
            "b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.FungusDetail), global::Weedwacker.Shared.Network.Proto.FungusDetail.Parser, new[]{ "IsCultivate", "CaptureOrder", "NameId", "MinCultivateStep", "FungusId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class FungusDetail : pb::IMessage<FungusDetail>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FungusDetail> _parser = new pb::MessageParser<FungusDetail>(() => new FungusDetail());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FungusDetail> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.FungusDetailReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FungusDetail() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FungusDetail(FungusDetail other) : this() {
      isCultivate_ = other.isCultivate_;
      captureOrder_ = other.captureOrder_;
      nameId_ = other.nameId_;
      minCultivateStep_ = other.minCultivateStep_;
      fungusId_ = other.fungusId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FungusDetail Clone() {
      return new FungusDetail(this);
    }

    /// <summary>Field number for the "is_cultivate" field.</summary>
    public const int IsCultivateFieldNumber = 5;
    private bool isCultivate_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsCultivate {
      get { return isCultivate_; }
      set {
        isCultivate_ = value;
      }
    }

    /// <summary>Field number for the "capture_order" field.</summary>
    public const int CaptureOrderFieldNumber = 6;
    private uint captureOrder_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CaptureOrder {
      get { return captureOrder_; }
      set {
        captureOrder_ = value;
      }
    }

    /// <summary>Field number for the "name_id" field.</summary>
    public const int NameIdFieldNumber = 14;
    private uint nameId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint NameId {
      get { return nameId_; }
      set {
        nameId_ = value;
      }
    }

    /// <summary>Field number for the "min_cultivate_step" field.</summary>
    public const int MinCultivateStepFieldNumber = 1;
    private uint minCultivateStep_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint MinCultivateStep {
      get { return minCultivateStep_; }
      set {
        minCultivateStep_ = value;
      }
    }

    /// <summary>Field number for the "fungus_id" field.</summary>
    public const int FungusIdFieldNumber = 9;
    private uint fungusId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint FungusId {
      get { return fungusId_; }
      set {
        fungusId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FungusDetail);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FungusDetail other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IsCultivate != other.IsCultivate) return false;
      if (CaptureOrder != other.CaptureOrder) return false;
      if (NameId != other.NameId) return false;
      if (MinCultivateStep != other.MinCultivateStep) return false;
      if (FungusId != other.FungusId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (IsCultivate != false) hash ^= IsCultivate.GetHashCode();
      if (CaptureOrder != 0) hash ^= CaptureOrder.GetHashCode();
      if (NameId != 0) hash ^= NameId.GetHashCode();
      if (MinCultivateStep != 0) hash ^= MinCultivateStep.GetHashCode();
      if (FungusId != 0) hash ^= FungusId.GetHashCode();
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
      if (MinCultivateStep != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(MinCultivateStep);
      }
      if (IsCultivate != false) {
        output.WriteRawTag(40);
        output.WriteBool(IsCultivate);
      }
      if (CaptureOrder != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(CaptureOrder);
      }
      if (FungusId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(FungusId);
      }
      if (NameId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(NameId);
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
      if (MinCultivateStep != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(MinCultivateStep);
      }
      if (IsCultivate != false) {
        output.WriteRawTag(40);
        output.WriteBool(IsCultivate);
      }
      if (CaptureOrder != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(CaptureOrder);
      }
      if (FungusId != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(FungusId);
      }
      if (NameId != 0) {
        output.WriteRawTag(112);
        output.WriteUInt32(NameId);
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
      if (IsCultivate != false) {
        size += 1 + 1;
      }
      if (CaptureOrder != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CaptureOrder);
      }
      if (NameId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(NameId);
      }
      if (MinCultivateStep != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MinCultivateStep);
      }
      if (FungusId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(FungusId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FungusDetail other) {
      if (other == null) {
        return;
      }
      if (other.IsCultivate != false) {
        IsCultivate = other.IsCultivate;
      }
      if (other.CaptureOrder != 0) {
        CaptureOrder = other.CaptureOrder;
      }
      if (other.NameId != 0) {
        NameId = other.NameId;
      }
      if (other.MinCultivateStep != 0) {
        MinCultivateStep = other.MinCultivateStep;
      }
      if (other.FungusId != 0) {
        FungusId = other.FungusId;
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
            MinCultivateStep = input.ReadUInt32();
            break;
          }
          case 40: {
            IsCultivate = input.ReadBool();
            break;
          }
          case 48: {
            CaptureOrder = input.ReadUInt32();
            break;
          }
          case 72: {
            FungusId = input.ReadUInt32();
            break;
          }
          case 112: {
            NameId = input.ReadUInt32();
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
            MinCultivateStep = input.ReadUInt32();
            break;
          }
          case 40: {
            IsCultivate = input.ReadBool();
            break;
          }
          case 48: {
            CaptureOrder = input.ReadUInt32();
            break;
          }
          case 72: {
            FungusId = input.ReadUInt32();
            break;
          }
          case 112: {
            NameId = input.ReadUInt32();
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
