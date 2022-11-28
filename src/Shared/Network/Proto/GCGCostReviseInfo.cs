// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GCGCostReviseInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from GCGCostReviseInfo.proto</summary>
  public static partial class GCGCostReviseInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for GCGCostReviseInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GCGCostReviseInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdHQ0dDb3N0UmV2aXNlSW5mby5wcm90bxoXR0NHQXR0YWNrQ29zdEluZm8u",
            "cHJvdG8aGUdDR1BsYXlDYXJkQ29zdEluZm8ucHJvdG8aHkdDR1NlbGVjdE9u",
            "U3RhZ2VDb3N0SW5mby5wcm90byLsAQoRR0NHQ29zdFJldmlzZUluZm8SFQoN",
            "aXNfY2FuX2F0dGFjaxgEIAEoCBIhChljYW5fdXNlX2hhbmRfY2FyZF9pZF9s",
            "aXN0GAsgAygNEjEKE3BsYXlfY2FyZF9jb3N0X2xpc3QYBSADKAsyFC5HQ0dQ",
            "bGF5Q2FyZENvc3RJbmZvEjwKGXNlbGVjdF9vbl9zdGFnZV9jb3N0X2xpc3QY",
            "CiADKAsyGS5HQ0dTZWxlY3RPblN0YWdlQ29zdEluZm8SLAoQYXR0YWNrX2Nv",
            "c3RfbGlzdBgCIAMoCzISLkdDR0F0dGFja0Nvc3RJbmZvQiKqAh9XZWVkd2Fj",
            "a2VyLlNoYXJlZC5OZXR3b3JrLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.GCGAttackCostInfoReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.GCGPlayCardCostInfoReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.GCGSelectOnStageCostInfoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.GCGCostReviseInfo), global::Weedwacker.Shared.Network.Proto.GCGCostReviseInfo.Parser, new[]{ "IsCanAttack", "CanUseHandCardIdList", "PlayCardCostList", "SelectOnStageCostList", "AttackCostList" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GCGCostReviseInfo : pb::IMessage<GCGCostReviseInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GCGCostReviseInfo> _parser = new pb::MessageParser<GCGCostReviseInfo>(() => new GCGCostReviseInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GCGCostReviseInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.GCGCostReviseInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGCostReviseInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGCostReviseInfo(GCGCostReviseInfo other) : this() {
      isCanAttack_ = other.isCanAttack_;
      canUseHandCardIdList_ = other.canUseHandCardIdList_.Clone();
      playCardCostList_ = other.playCardCostList_.Clone();
      selectOnStageCostList_ = other.selectOnStageCostList_.Clone();
      attackCostList_ = other.attackCostList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GCGCostReviseInfo Clone() {
      return new GCGCostReviseInfo(this);
    }

    /// <summary>Field number for the "is_can_attack" field.</summary>
    public const int IsCanAttackFieldNumber = 4;
    private bool isCanAttack_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsCanAttack {
      get { return isCanAttack_; }
      set {
        isCanAttack_ = value;
      }
    }

    /// <summary>Field number for the "can_use_hand_card_id_list" field.</summary>
    public const int CanUseHandCardIdListFieldNumber = 11;
    private static readonly pb::FieldCodec<uint> _repeated_canUseHandCardIdList_codec
        = pb::FieldCodec.ForUInt32(90);
    private readonly pbc::RepeatedField<uint> canUseHandCardIdList_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<uint> CanUseHandCardIdList {
      get { return canUseHandCardIdList_; }
    }

    /// <summary>Field number for the "play_card_cost_list" field.</summary>
    public const int PlayCardCostListFieldNumber = 5;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.GCGPlayCardCostInfo> _repeated_playCardCostList_codec
        = pb::FieldCodec.ForMessage(42, global::Weedwacker.Shared.Network.Proto.GCGPlayCardCostInfo.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GCGPlayCardCostInfo> playCardCostList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GCGPlayCardCostInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GCGPlayCardCostInfo> PlayCardCostList {
      get { return playCardCostList_; }
    }

    /// <summary>Field number for the "select_on_stage_cost_list" field.</summary>
    public const int SelectOnStageCostListFieldNumber = 10;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.GCGSelectOnStageCostInfo> _repeated_selectOnStageCostList_codec
        = pb::FieldCodec.ForMessage(82, global::Weedwacker.Shared.Network.Proto.GCGSelectOnStageCostInfo.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GCGSelectOnStageCostInfo> selectOnStageCostList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GCGSelectOnStageCostInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GCGSelectOnStageCostInfo> SelectOnStageCostList {
      get { return selectOnStageCostList_; }
    }

    /// <summary>Field number for the "attack_cost_list" field.</summary>
    public const int AttackCostListFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Weedwacker.Shared.Network.Proto.GCGAttackCostInfo> _repeated_attackCostList_codec
        = pb::FieldCodec.ForMessage(18, global::Weedwacker.Shared.Network.Proto.GCGAttackCostInfo.Parser);
    private readonly pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GCGAttackCostInfo> attackCostList_ = new pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GCGAttackCostInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Weedwacker.Shared.Network.Proto.GCGAttackCostInfo> AttackCostList {
      get { return attackCostList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GCGCostReviseInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GCGCostReviseInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IsCanAttack != other.IsCanAttack) return false;
      if(!canUseHandCardIdList_.Equals(other.canUseHandCardIdList_)) return false;
      if(!playCardCostList_.Equals(other.playCardCostList_)) return false;
      if(!selectOnStageCostList_.Equals(other.selectOnStageCostList_)) return false;
      if(!attackCostList_.Equals(other.attackCostList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (IsCanAttack != false) hash ^= IsCanAttack.GetHashCode();
      hash ^= canUseHandCardIdList_.GetHashCode();
      hash ^= playCardCostList_.GetHashCode();
      hash ^= selectOnStageCostList_.GetHashCode();
      hash ^= attackCostList_.GetHashCode();
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
      attackCostList_.WriteTo(output, _repeated_attackCostList_codec);
      if (IsCanAttack != false) {
        output.WriteRawTag(32);
        output.WriteBool(IsCanAttack);
      }
      playCardCostList_.WriteTo(output, _repeated_playCardCostList_codec);
      selectOnStageCostList_.WriteTo(output, _repeated_selectOnStageCostList_codec);
      canUseHandCardIdList_.WriteTo(output, _repeated_canUseHandCardIdList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      attackCostList_.WriteTo(ref output, _repeated_attackCostList_codec);
      if (IsCanAttack != false) {
        output.WriteRawTag(32);
        output.WriteBool(IsCanAttack);
      }
      playCardCostList_.WriteTo(ref output, _repeated_playCardCostList_codec);
      selectOnStageCostList_.WriteTo(ref output, _repeated_selectOnStageCostList_codec);
      canUseHandCardIdList_.WriteTo(ref output, _repeated_canUseHandCardIdList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (IsCanAttack != false) {
        size += 1 + 1;
      }
      size += canUseHandCardIdList_.CalculateSize(_repeated_canUseHandCardIdList_codec);
      size += playCardCostList_.CalculateSize(_repeated_playCardCostList_codec);
      size += selectOnStageCostList_.CalculateSize(_repeated_selectOnStageCostList_codec);
      size += attackCostList_.CalculateSize(_repeated_attackCostList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GCGCostReviseInfo other) {
      if (other == null) {
        return;
      }
      if (other.IsCanAttack != false) {
        IsCanAttack = other.IsCanAttack;
      }
      canUseHandCardIdList_.Add(other.canUseHandCardIdList_);
      playCardCostList_.Add(other.playCardCostList_);
      selectOnStageCostList_.Add(other.selectOnStageCostList_);
      attackCostList_.Add(other.attackCostList_);
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
            attackCostList_.AddEntriesFrom(input, _repeated_attackCostList_codec);
            break;
          }
          case 32: {
            IsCanAttack = input.ReadBool();
            break;
          }
          case 42: {
            playCardCostList_.AddEntriesFrom(input, _repeated_playCardCostList_codec);
            break;
          }
          case 82: {
            selectOnStageCostList_.AddEntriesFrom(input, _repeated_selectOnStageCostList_codec);
            break;
          }
          case 90:
          case 88: {
            canUseHandCardIdList_.AddEntriesFrom(input, _repeated_canUseHandCardIdList_codec);
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
            attackCostList_.AddEntriesFrom(ref input, _repeated_attackCostList_codec);
            break;
          }
          case 32: {
            IsCanAttack = input.ReadBool();
            break;
          }
          case 42: {
            playCardCostList_.AddEntriesFrom(ref input, _repeated_playCardCostList_codec);
            break;
          }
          case 82: {
            selectOnStageCostList_.AddEntriesFrom(ref input, _repeated_selectOnStageCostList_codec);
            break;
          }
          case 90:
          case 88: {
            canUseHandCardIdList_.AddEntriesFrom(ref input, _repeated_canUseHandCardIdList_codec);
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
