// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: VintageDetailInfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from VintageDetailInfo.proto</summary>
  public static partial class VintageDetailInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for VintageDetailInfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static VintageDetailInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdWaW50YWdlRGV0YWlsSW5mby5wcm90bxoeVmludGFnZUJvb3RoVXNlZEl0",
            "ZW1EYXRhLnByb3RvGiNWaW50YWdlQ2FtcENoYWxsZW5nZVN0YWdlRGF0YS5w",
            "cm90bxodVmludGFnZUh1bnRpbmdTdGFnZURhdGEucHJvdG8aF1ZpbnRhZ2VN",
            "YXJrZXRJbmZvLnByb3RvGh1WaW50YWdlUHJlc2VudFN0YWdlRGF0YS5wcm90",
            "byLFBAoRVmludGFnZURldGFpbEluZm8SJwoLbWFya2V0X2luZm8YAiABKAsy",
            "Ei5WaW50YWdlTWFya2V0SW5mbxJCChFodW50aW5nX3N0YWdlX21hcBgHIAMo",
            "CzInLlZpbnRhZ2VEZXRhaWxJbmZvLkh1bnRpbmdTdGFnZU1hcEVudHJ5Ei0K",
            "CmJvb3RoX2RhdGEYBSABKAsyGS5WaW50YWdlQm9vdGhVc2VkSXRlbURhdGES",
            "PAoOY2FtcF9zdGFnZV9tYXAYDSADKAsyJC5WaW50YWdlRGV0YWlsSW5mby5D",
            "YW1wU3RhZ2VNYXBFbnRyeRJCChFwcmVzZW50X3N0YWdlX21hcBgEIAMoCzIn",
            "LlZpbnRhZ2VEZXRhaWxJbmZvLlByZXNlbnRTdGFnZU1hcEVudHJ5EhkKEWlz",
            "X2NvbnRlbnRfY2xvc2VkGAsgASgIGlAKFEh1bnRpbmdTdGFnZU1hcEVudHJ5",
            "EgsKA2tleRgBIAEoDRInCgV2YWx1ZRgCIAEoCzIYLlZpbnRhZ2VIdW50aW5n",
            "U3RhZ2VEYXRhOgI4ARpTChFDYW1wU3RhZ2VNYXBFbnRyeRILCgNrZXkYASAB",
            "KA0SLQoFdmFsdWUYAiABKAsyHi5WaW50YWdlQ2FtcENoYWxsZW5nZVN0YWdl",
            "RGF0YToCOAEaUAoUUHJlc2VudFN0YWdlTWFwRW50cnkSCwoDa2V5GAEgASgN",
            "EicKBXZhbHVlGAIgASgLMhguVmludGFnZVByZXNlbnRTdGFnZURhdGE6AjgB",
            "QiKqAh9XZWVkd2Fja2VyLlNoYXJlZC5OZXR3b3JrLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.VintageBoothUsedItemDataReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.VintageCampChallengeStageDataReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.VintageHuntingStageDataReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.VintageMarketInfoReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.VintagePresentStageDataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.VintageDetailInfo), global::Weedwacker.Shared.Network.Proto.VintageDetailInfo.Parser, new[]{ "MarketInfo", "HuntingStageMap", "BoothData", "CampStageMap", "PresentStageMap", "IsContentClosed" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, null, null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class VintageDetailInfo : pb::IMessage<VintageDetailInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<VintageDetailInfo> _parser = new pb::MessageParser<VintageDetailInfo>(() => new VintageDetailInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<VintageDetailInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.VintageDetailInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public VintageDetailInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public VintageDetailInfo(VintageDetailInfo other) : this() {
      marketInfo_ = other.marketInfo_ != null ? other.marketInfo_.Clone() : null;
      huntingStageMap_ = other.huntingStageMap_.Clone();
      boothData_ = other.boothData_ != null ? other.boothData_.Clone() : null;
      campStageMap_ = other.campStageMap_.Clone();
      presentStageMap_ = other.presentStageMap_.Clone();
      isContentClosed_ = other.isContentClosed_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public VintageDetailInfo Clone() {
      return new VintageDetailInfo(this);
    }

    /// <summary>Field number for the "market_info" field.</summary>
    public const int MarketInfoFieldNumber = 2;
    private global::Weedwacker.Shared.Network.Proto.VintageMarketInfo marketInfo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.VintageMarketInfo MarketInfo {
      get { return marketInfo_; }
      set {
        marketInfo_ = value;
      }
    }

    /// <summary>Field number for the "hunting_stage_map" field.</summary>
    public const int HuntingStageMapFieldNumber = 7;
    private static readonly pbc::MapField<uint, global::Weedwacker.Shared.Network.Proto.VintageHuntingStageData>.Codec _map_huntingStageMap_codec
        = new pbc::MapField<uint, global::Weedwacker.Shared.Network.Proto.VintageHuntingStageData>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForMessage(18, global::Weedwacker.Shared.Network.Proto.VintageHuntingStageData.Parser), 58);
    private readonly pbc::MapField<uint, global::Weedwacker.Shared.Network.Proto.VintageHuntingStageData> huntingStageMap_ = new pbc::MapField<uint, global::Weedwacker.Shared.Network.Proto.VintageHuntingStageData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, global::Weedwacker.Shared.Network.Proto.VintageHuntingStageData> HuntingStageMap {
      get { return huntingStageMap_; }
    }

    /// <summary>Field number for the "booth_data" field.</summary>
    public const int BoothDataFieldNumber = 5;
    private global::Weedwacker.Shared.Network.Proto.VintageBoothUsedItemData boothData_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.VintageBoothUsedItemData BoothData {
      get { return boothData_; }
      set {
        boothData_ = value;
      }
    }

    /// <summary>Field number for the "camp_stage_map" field.</summary>
    public const int CampStageMapFieldNumber = 13;
    private static readonly pbc::MapField<uint, global::Weedwacker.Shared.Network.Proto.VintageCampChallengeStageData>.Codec _map_campStageMap_codec
        = new pbc::MapField<uint, global::Weedwacker.Shared.Network.Proto.VintageCampChallengeStageData>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForMessage(18, global::Weedwacker.Shared.Network.Proto.VintageCampChallengeStageData.Parser), 106);
    private readonly pbc::MapField<uint, global::Weedwacker.Shared.Network.Proto.VintageCampChallengeStageData> campStageMap_ = new pbc::MapField<uint, global::Weedwacker.Shared.Network.Proto.VintageCampChallengeStageData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, global::Weedwacker.Shared.Network.Proto.VintageCampChallengeStageData> CampStageMap {
      get { return campStageMap_; }
    }

    /// <summary>Field number for the "present_stage_map" field.</summary>
    public const int PresentStageMapFieldNumber = 4;
    private static readonly pbc::MapField<uint, global::Weedwacker.Shared.Network.Proto.VintagePresentStageData>.Codec _map_presentStageMap_codec
        = new pbc::MapField<uint, global::Weedwacker.Shared.Network.Proto.VintagePresentStageData>.Codec(pb::FieldCodec.ForUInt32(8, 0), pb::FieldCodec.ForMessage(18, global::Weedwacker.Shared.Network.Proto.VintagePresentStageData.Parser), 34);
    private readonly pbc::MapField<uint, global::Weedwacker.Shared.Network.Proto.VintagePresentStageData> presentStageMap_ = new pbc::MapField<uint, global::Weedwacker.Shared.Network.Proto.VintagePresentStageData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<uint, global::Weedwacker.Shared.Network.Proto.VintagePresentStageData> PresentStageMap {
      get { return presentStageMap_; }
    }

    /// <summary>Field number for the "is_content_closed" field.</summary>
    public const int IsContentClosedFieldNumber = 11;
    private bool isContentClosed_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsContentClosed {
      get { return isContentClosed_; }
      set {
        isContentClosed_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as VintageDetailInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(VintageDetailInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(MarketInfo, other.MarketInfo)) return false;
      if (!HuntingStageMap.Equals(other.HuntingStageMap)) return false;
      if (!object.Equals(BoothData, other.BoothData)) return false;
      if (!CampStageMap.Equals(other.CampStageMap)) return false;
      if (!PresentStageMap.Equals(other.PresentStageMap)) return false;
      if (IsContentClosed != other.IsContentClosed) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (marketInfo_ != null) hash ^= MarketInfo.GetHashCode();
      hash ^= HuntingStageMap.GetHashCode();
      if (boothData_ != null) hash ^= BoothData.GetHashCode();
      hash ^= CampStageMap.GetHashCode();
      hash ^= PresentStageMap.GetHashCode();
      if (IsContentClosed != false) hash ^= IsContentClosed.GetHashCode();
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
      if (marketInfo_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(MarketInfo);
      }
      presentStageMap_.WriteTo(output, _map_presentStageMap_codec);
      if (boothData_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(BoothData);
      }
      huntingStageMap_.WriteTo(output, _map_huntingStageMap_codec);
      if (IsContentClosed != false) {
        output.WriteRawTag(88);
        output.WriteBool(IsContentClosed);
      }
      campStageMap_.WriteTo(output, _map_campStageMap_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (marketInfo_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(MarketInfo);
      }
      presentStageMap_.WriteTo(ref output, _map_presentStageMap_codec);
      if (boothData_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(BoothData);
      }
      huntingStageMap_.WriteTo(ref output, _map_huntingStageMap_codec);
      if (IsContentClosed != false) {
        output.WriteRawTag(88);
        output.WriteBool(IsContentClosed);
      }
      campStageMap_.WriteTo(ref output, _map_campStageMap_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (marketInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MarketInfo);
      }
      size += huntingStageMap_.CalculateSize(_map_huntingStageMap_codec);
      if (boothData_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(BoothData);
      }
      size += campStageMap_.CalculateSize(_map_campStageMap_codec);
      size += presentStageMap_.CalculateSize(_map_presentStageMap_codec);
      if (IsContentClosed != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(VintageDetailInfo other) {
      if (other == null) {
        return;
      }
      if (other.marketInfo_ != null) {
        if (marketInfo_ == null) {
          MarketInfo = new global::Weedwacker.Shared.Network.Proto.VintageMarketInfo();
        }
        MarketInfo.MergeFrom(other.MarketInfo);
      }
      huntingStageMap_.Add(other.huntingStageMap_);
      if (other.boothData_ != null) {
        if (boothData_ == null) {
          BoothData = new global::Weedwacker.Shared.Network.Proto.VintageBoothUsedItemData();
        }
        BoothData.MergeFrom(other.BoothData);
      }
      campStageMap_.Add(other.campStageMap_);
      presentStageMap_.Add(other.presentStageMap_);
      if (other.IsContentClosed != false) {
        IsContentClosed = other.IsContentClosed;
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
          case 18: {
            if (marketInfo_ == null) {
              MarketInfo = new global::Weedwacker.Shared.Network.Proto.VintageMarketInfo();
            }
            input.ReadMessage(MarketInfo);
            break;
          }
          case 34: {
            presentStageMap_.AddEntriesFrom(input, _map_presentStageMap_codec);
            break;
          }
          case 42: {
            if (boothData_ == null) {
              BoothData = new global::Weedwacker.Shared.Network.Proto.VintageBoothUsedItemData();
            }
            input.ReadMessage(BoothData);
            break;
          }
          case 58: {
            huntingStageMap_.AddEntriesFrom(input, _map_huntingStageMap_codec);
            break;
          }
          case 88: {
            IsContentClosed = input.ReadBool();
            break;
          }
          case 106: {
            campStageMap_.AddEntriesFrom(input, _map_campStageMap_codec);
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
            if (marketInfo_ == null) {
              MarketInfo = new global::Weedwacker.Shared.Network.Proto.VintageMarketInfo();
            }
            input.ReadMessage(MarketInfo);
            break;
          }
          case 34: {
            presentStageMap_.AddEntriesFrom(ref input, _map_presentStageMap_codec);
            break;
          }
          case 42: {
            if (boothData_ == null) {
              BoothData = new global::Weedwacker.Shared.Network.Proto.VintageBoothUsedItemData();
            }
            input.ReadMessage(BoothData);
            break;
          }
          case 58: {
            huntingStageMap_.AddEntriesFrom(ref input, _map_huntingStageMap_codec);
            break;
          }
          case 88: {
            IsContentClosed = input.ReadBool();
            break;
          }
          case 106: {
            campStageMap_.AddEntriesFrom(ref input, _map_campStageMap_codec);
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
