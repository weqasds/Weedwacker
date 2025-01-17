// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GCGOperationPlayCard.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from GCGOperationPlayCard.proto</summary>
  public static partial class GCGOperationPlayCardReflection {

    #region Descriptor
    /// <summary>File descriptor for GCGOperationPlayCard.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GCGOperationPlayCardReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpHQ0dPcGVyYXRpb25QbGF5Q2FyZC5wcm90byJmChRHQ0dPcGVyYXRpb25Q",
            "bGF5Q2FyZBIRCgljYXJkX2d1aWQYDCABKA0SHAoUY29zdF9kaWNlX2luZGV4",
            "X2xpc3QYBCADKA0SHQoVdGFyZ2V0X2NhcmRfZ3VpZF9saXN0GAogAygNQiKq",
            "Ah9XZWVkd2Fja2VyLlNoYXJlZC5OZXR3b3JrLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.GCGOperationPlayCard), global::Weedwacker.Shared.Network.Proto.GCGOperationPlayCard.Parser, new[]{ "CardGuid", "CostDiceIndexList", "TargetCardGuidList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GCGOperationPlayCard : pb::IMessage<GCGOperationPlayCard>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GCGOperationPlayCard> _parser = new pb::MessageParser<GCGOperationPlayCard>(() => new GCGOperationPlayCard());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GCGOperationPlayCard> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.GCGOperationPlayCardReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGOperationPlayCard() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGOperationPlayCard(GCGOperationPlayCard other) : this() {
      cardGuid_ = other.cardGuid_;
      costDiceIndexList_ = other.costDiceIndexList_.Clone();
      targetCardGuidList_ = other.targetCardGuidList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGOperationPlayCard Clone() {
      return new GCGOperationPlayCard(this);
    }

    /// <summary>Field number for the "card_guid" field.</summary>
    public const int CardGuidFieldNumber = 12;
    private uint cardGuid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint CardGuid {
      get { return cardGuid_; }
      set {
        cardGuid_ = value;
      }
    }

    /// <summary>Field number for the "cost_dice_index_list" field.</summary>
    public const int CostDiceIndexListFieldNumber = 4;
    private static readonly pb::FieldCodec<uint> _repeated_costDiceIndexList_codec
        = pb::FieldCodec.ForUInt32(34);
    private readonly pbc::RepeatedField<uint> costDiceIndexList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> CostDiceIndexList {
      get { return costDiceIndexList_; }
    }

    /// <summary>Field number for the "target_card_guid_list" field.</summary>
    public const int TargetCardGuidListFieldNumber = 10;
    private static readonly pb::FieldCodec<uint> _repeated_targetCardGuidList_codec
        = pb::FieldCodec.ForUInt32(82);
    private readonly pbc::RepeatedField<uint> targetCardGuidList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> TargetCardGuidList {
      get { return targetCardGuidList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GCGOperationPlayCard);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GCGOperationPlayCard other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CardGuid != other.CardGuid) return false;
      if(!costDiceIndexList_.Equals(other.costDiceIndexList_)) return false;
      if(!targetCardGuidList_.Equals(other.targetCardGuidList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (CardGuid != 0) hash ^= CardGuid.GetHashCode();
      hash ^= costDiceIndexList_.GetHashCode();
      hash ^= targetCardGuidList_.GetHashCode();
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
      costDiceIndexList_.WriteTo(output, _repeated_costDiceIndexList_codec);
      targetCardGuidList_.WriteTo(output, _repeated_targetCardGuidList_codec);
      if (CardGuid != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(CardGuid);
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
      costDiceIndexList_.WriteTo(ref output, _repeated_costDiceIndexList_codec);
      targetCardGuidList_.WriteTo(ref output, _repeated_targetCardGuidList_codec);
      if (CardGuid != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(CardGuid);
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
      if (CardGuid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CardGuid);
      }
      size += costDiceIndexList_.CalculateSize(_repeated_costDiceIndexList_codec);
      size += targetCardGuidList_.CalculateSize(_repeated_targetCardGuidList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GCGOperationPlayCard other) {
      if (other == null) {
        return;
      }
      if (other.CardGuid != 0) {
        CardGuid = other.CardGuid;
      }
      costDiceIndexList_.Add(other.costDiceIndexList_);
      targetCardGuidList_.Add(other.targetCardGuidList_);
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
          case 34:
          case 32: {
            costDiceIndexList_.AddEntriesFrom(input, _repeated_costDiceIndexList_codec);
            break;
          }
          case 82:
          case 80: {
            targetCardGuidList_.AddEntriesFrom(input, _repeated_targetCardGuidList_codec);
            break;
          }
          case 96: {
            CardGuid = input.ReadUInt32();
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
          case 34:
          case 32: {
            costDiceIndexList_.AddEntriesFrom(ref input, _repeated_costDiceIndexList_codec);
            break;
          }
          case 82:
          case 80: {
            targetCardGuidList_.AddEntriesFrom(ref input, _repeated_targetCardGuidList_codec);
            break;
          }
          case 96: {
            CardGuid = input.ReadUInt32();
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
