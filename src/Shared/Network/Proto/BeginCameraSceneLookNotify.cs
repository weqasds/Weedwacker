// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: BeginCameraSceneLookNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from BeginCameraSceneLookNotify.proto</summary>
  public static partial class BeginCameraSceneLookNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for BeginCameraSceneLookNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BeginCameraSceneLookNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBCZWdpbkNhbWVyYVNjZW5lTG9va05vdGlmeS5wcm90bxoMVmVjdG9yLnBy",
            "b3RvIt0EChpCZWdpbkNhbWVyYVNjZW5lTG9va05vdGlmeRITCgpibGVuZF90",
            "eXBlGIIJIAEoDRIVCg1jdXN0b21fcmFkaXVzGAcgASgCEhgKEGlzX3NldF9z",
            "Y3JlZW5feHkYBSABKAgSGQoIbG9va19wb3MYBCABKAsyBy5WZWN0b3ISHwoX",
            "aXNfcmVjb3Zlcl9rZWVwX2N1cnJlbnQYCyABKAgSGgoRaXNfYWJzX2ZvbGxv",
            "d19wb3MY3wogASgIEj4KDWtlZXBfcm90X3R5cGUYBiABKA4yJy5CZWdpbkNh",
            "bWVyYVNjZW5lTG9va05vdGlmeS5LZWVwUm90VHlwZRIbChNpc19jaGFuZ2Vf",
            "cGxheV9tb2RlGAkgASgIEhgKD2Rpc2FibGVfcHJvdGVjdBjPCCABKA0SEAoI",
            "c2NyZWVuX3kYDyABKAISGQoRaXNfc2V0X2ZvbGxvd19wb3MYDSABKAgSEAoI",
            "aXNfZm9yY2UYDCABKAgSFwoOYmxlbmRfZHVyYXRpb24Y3g0gASgCEhIKCWVu",
            "dGl0eV9pZBivCiABKA0SEAoIc2NyZWVuX3gYAyABKAISFQoNaXNfZm9yY2Vf",
            "d2FsaxgKIAEoCBIUCgxvdGhlcl9wYXJhbXMYASADKAkSGwoKZm9sbG93X3Bv",
            "cxgIIAEoCzIHLlZlY3RvchIWCg5pc19hbGxvd19pbnB1dBgCIAEoCBIQCghk",
            "dXJhdGlvbhgOIAEoAiI4CgtLZWVwUm90VHlwZRITCg9LRUVQX1JPVF9UWVBF",
            "X1gQABIUChBLRUVQX1JPVF9UWVBFX1hZEAFCIqoCH1dlZWR3YWNrZXIuU2hh",
            "cmVkLk5ldHdvcmsuUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.VectorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.BeginCameraSceneLookNotify), global::Weedwacker.Shared.Network.Proto.BeginCameraSceneLookNotify.Parser, new[]{ "BlendType", "CustomRadius", "IsSetScreenXy", "LookPos", "IsRecoverKeepCurrent", "IsAbsFollowPos", "KeepRotType", "IsChangePlayMode", "DisableProtect", "ScreenY", "IsSetFollowPos", "IsForce", "BlendDuration", "EntityId", "ScreenX", "IsForceWalk", "OtherParams", "FollowPos", "IsAllowInput", "Duration" }, null, new[]{ typeof(global::Weedwacker.Shared.Network.Proto.BeginCameraSceneLookNotify.Types.KeepRotType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 270
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// </summary>
  public sealed partial class BeginCameraSceneLookNotify : pb::IMessage<BeginCameraSceneLookNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<BeginCameraSceneLookNotify> _parser = new pb::MessageParser<BeginCameraSceneLookNotify>(() => new BeginCameraSceneLookNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<BeginCameraSceneLookNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.BeginCameraSceneLookNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BeginCameraSceneLookNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BeginCameraSceneLookNotify(BeginCameraSceneLookNotify other) : this() {
      blendType_ = other.blendType_;
      customRadius_ = other.customRadius_;
      isSetScreenXy_ = other.isSetScreenXy_;
      lookPos_ = other.lookPos_ != null ? other.lookPos_.Clone() : null;
      isRecoverKeepCurrent_ = other.isRecoverKeepCurrent_;
      isAbsFollowPos_ = other.isAbsFollowPos_;
      keepRotType_ = other.keepRotType_;
      isChangePlayMode_ = other.isChangePlayMode_;
      disableProtect_ = other.disableProtect_;
      screenY_ = other.screenY_;
      isSetFollowPos_ = other.isSetFollowPos_;
      isForce_ = other.isForce_;
      blendDuration_ = other.blendDuration_;
      entityId_ = other.entityId_;
      screenX_ = other.screenX_;
      isForceWalk_ = other.isForceWalk_;
      otherParams_ = other.otherParams_.Clone();
      followPos_ = other.followPos_ != null ? other.followPos_.Clone() : null;
      isAllowInput_ = other.isAllowInput_;
      duration_ = other.duration_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BeginCameraSceneLookNotify Clone() {
      return new BeginCameraSceneLookNotify(this);
    }

    /// <summary>Field number for the "blend_type" field.</summary>
    public const int BlendTypeFieldNumber = 1154;
    private uint blendType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint BlendType {
      get { return blendType_; }
      set {
        blendType_ = value;
      }
    }

    /// <summary>Field number for the "custom_radius" field.</summary>
    public const int CustomRadiusFieldNumber = 7;
    private float customRadius_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float CustomRadius {
      get { return customRadius_; }
      set {
        customRadius_ = value;
      }
    }

    /// <summary>Field number for the "is_set_screen_xy" field.</summary>
    public const int IsSetScreenXyFieldNumber = 5;
    private bool isSetScreenXy_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsSetScreenXy {
      get { return isSetScreenXy_; }
      set {
        isSetScreenXy_ = value;
      }
    }

    /// <summary>Field number for the "look_pos" field.</summary>
    public const int LookPosFieldNumber = 4;
    private global::Weedwacker.Shared.Network.Proto.Vector lookPos_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.Vector LookPos {
      get { return lookPos_; }
      set {
        lookPos_ = value;
      }
    }

    /// <summary>Field number for the "is_recover_keep_current" field.</summary>
    public const int IsRecoverKeepCurrentFieldNumber = 11;
    private bool isRecoverKeepCurrent_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsRecoverKeepCurrent {
      get { return isRecoverKeepCurrent_; }
      set {
        isRecoverKeepCurrent_ = value;
      }
    }

    /// <summary>Field number for the "is_abs_follow_pos" field.</summary>
    public const int IsAbsFollowPosFieldNumber = 1375;
    private bool isAbsFollowPos_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsAbsFollowPos {
      get { return isAbsFollowPos_; }
      set {
        isAbsFollowPos_ = value;
      }
    }

    /// <summary>Field number for the "keep_rot_type" field.</summary>
    public const int KeepRotTypeFieldNumber = 6;
    private global::Weedwacker.Shared.Network.Proto.BeginCameraSceneLookNotify.Types.KeepRotType keepRotType_ = global::Weedwacker.Shared.Network.Proto.BeginCameraSceneLookNotify.Types.KeepRotType.X;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.BeginCameraSceneLookNotify.Types.KeepRotType KeepRotType {
      get { return keepRotType_; }
      set {
        keepRotType_ = value;
      }
    }

    /// <summary>Field number for the "is_change_play_mode" field.</summary>
    public const int IsChangePlayModeFieldNumber = 9;
    private bool isChangePlayMode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsChangePlayMode {
      get { return isChangePlayMode_; }
      set {
        isChangePlayMode_ = value;
      }
    }

    /// <summary>Field number for the "disable_protect" field.</summary>
    public const int DisableProtectFieldNumber = 1103;
    private uint disableProtect_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint DisableProtect {
      get { return disableProtect_; }
      set {
        disableProtect_ = value;
      }
    }

    /// <summary>Field number for the "screen_y" field.</summary>
    public const int ScreenYFieldNumber = 15;
    private float screenY_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float ScreenY {
      get { return screenY_; }
      set {
        screenY_ = value;
      }
    }

    /// <summary>Field number for the "is_set_follow_pos" field.</summary>
    public const int IsSetFollowPosFieldNumber = 13;
    private bool isSetFollowPos_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsSetFollowPos {
      get { return isSetFollowPos_; }
      set {
        isSetFollowPos_ = value;
      }
    }

    /// <summary>Field number for the "is_force" field.</summary>
    public const int IsForceFieldNumber = 12;
    private bool isForce_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsForce {
      get { return isForce_; }
      set {
        isForce_ = value;
      }
    }

    /// <summary>Field number for the "blend_duration" field.</summary>
    public const int BlendDurationFieldNumber = 1758;
    private float blendDuration_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float BlendDuration {
      get { return blendDuration_; }
      set {
        blendDuration_ = value;
      }
    }

    /// <summary>Field number for the "entity_id" field.</summary>
    public const int EntityIdFieldNumber = 1327;
    private uint entityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EntityId {
      get { return entityId_; }
      set {
        entityId_ = value;
      }
    }

    /// <summary>Field number for the "screen_x" field.</summary>
    public const int ScreenXFieldNumber = 3;
    private float screenX_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float ScreenX {
      get { return screenX_; }
      set {
        screenX_ = value;
      }
    }

    /// <summary>Field number for the "is_force_walk" field.</summary>
    public const int IsForceWalkFieldNumber = 10;
    private bool isForceWalk_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsForceWalk {
      get { return isForceWalk_; }
      set {
        isForceWalk_ = value;
      }
    }

    /// <summary>Field number for the "other_params" field.</summary>
    public const int OtherParamsFieldNumber = 1;
    private static readonly pb::FieldCodec<string> _repeated_otherParams_codec
        = pb::FieldCodec.ForString(10);
    private readonly pbc::RepeatedField<string> otherParams_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<string> OtherParams {
      get { return otherParams_; }
    }

    /// <summary>Field number for the "follow_pos" field.</summary>
    public const int FollowPosFieldNumber = 8;
    private global::Weedwacker.Shared.Network.Proto.Vector followPos_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.Vector FollowPos {
      get { return followPos_; }
      set {
        followPos_ = value;
      }
    }

    /// <summary>Field number for the "is_allow_input" field.</summary>
    public const int IsAllowInputFieldNumber = 2;
    private bool isAllowInput_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsAllowInput {
      get { return isAllowInput_; }
      set {
        isAllowInput_ = value;
      }
    }

    /// <summary>Field number for the "duration" field.</summary>
    public const int DurationFieldNumber = 14;
    private float duration_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float Duration {
      get { return duration_; }
      set {
        duration_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as BeginCameraSceneLookNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(BeginCameraSceneLookNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (BlendType != other.BlendType) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(CustomRadius, other.CustomRadius)) return false;
      if (IsSetScreenXy != other.IsSetScreenXy) return false;
      if (!object.Equals(LookPos, other.LookPos)) return false;
      if (IsRecoverKeepCurrent != other.IsRecoverKeepCurrent) return false;
      if (IsAbsFollowPos != other.IsAbsFollowPos) return false;
      if (KeepRotType != other.KeepRotType) return false;
      if (IsChangePlayMode != other.IsChangePlayMode) return false;
      if (DisableProtect != other.DisableProtect) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(ScreenY, other.ScreenY)) return false;
      if (IsSetFollowPos != other.IsSetFollowPos) return false;
      if (IsForce != other.IsForce) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(BlendDuration, other.BlendDuration)) return false;
      if (EntityId != other.EntityId) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(ScreenX, other.ScreenX)) return false;
      if (IsForceWalk != other.IsForceWalk) return false;
      if(!otherParams_.Equals(other.otherParams_)) return false;
      if (!object.Equals(FollowPos, other.FollowPos)) return false;
      if (IsAllowInput != other.IsAllowInput) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Duration, other.Duration)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (BlendType != 0) hash ^= BlendType.GetHashCode();
      if (CustomRadius != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(CustomRadius);
      if (IsSetScreenXy != false) hash ^= IsSetScreenXy.GetHashCode();
      if (lookPos_ != null) hash ^= LookPos.GetHashCode();
      if (IsRecoverKeepCurrent != false) hash ^= IsRecoverKeepCurrent.GetHashCode();
      if (IsAbsFollowPos != false) hash ^= IsAbsFollowPos.GetHashCode();
      if (KeepRotType != global::Weedwacker.Shared.Network.Proto.BeginCameraSceneLookNotify.Types.KeepRotType.X) hash ^= KeepRotType.GetHashCode();
      if (IsChangePlayMode != false) hash ^= IsChangePlayMode.GetHashCode();
      if (DisableProtect != 0) hash ^= DisableProtect.GetHashCode();
      if (ScreenY != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(ScreenY);
      if (IsSetFollowPos != false) hash ^= IsSetFollowPos.GetHashCode();
      if (IsForce != false) hash ^= IsForce.GetHashCode();
      if (BlendDuration != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(BlendDuration);
      if (EntityId != 0) hash ^= EntityId.GetHashCode();
      if (ScreenX != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(ScreenX);
      if (IsForceWalk != false) hash ^= IsForceWalk.GetHashCode();
      hash ^= otherParams_.GetHashCode();
      if (followPos_ != null) hash ^= FollowPos.GetHashCode();
      if (IsAllowInput != false) hash ^= IsAllowInput.GetHashCode();
      if (Duration != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Duration);
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
      otherParams_.WriteTo(output, _repeated_otherParams_codec);
      if (IsAllowInput != false) {
        output.WriteRawTag(16);
        output.WriteBool(IsAllowInput);
      }
      if (ScreenX != 0F) {
        output.WriteRawTag(29);
        output.WriteFloat(ScreenX);
      }
      if (lookPos_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(LookPos);
      }
      if (IsSetScreenXy != false) {
        output.WriteRawTag(40);
        output.WriteBool(IsSetScreenXy);
      }
      if (KeepRotType != global::Weedwacker.Shared.Network.Proto.BeginCameraSceneLookNotify.Types.KeepRotType.X) {
        output.WriteRawTag(48);
        output.WriteEnum((int) KeepRotType);
      }
      if (CustomRadius != 0F) {
        output.WriteRawTag(61);
        output.WriteFloat(CustomRadius);
      }
      if (followPos_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(FollowPos);
      }
      if (IsChangePlayMode != false) {
        output.WriteRawTag(72);
        output.WriteBool(IsChangePlayMode);
      }
      if (IsForceWalk != false) {
        output.WriteRawTag(80);
        output.WriteBool(IsForceWalk);
      }
      if (IsRecoverKeepCurrent != false) {
        output.WriteRawTag(88);
        output.WriteBool(IsRecoverKeepCurrent);
      }
      if (IsForce != false) {
        output.WriteRawTag(96);
        output.WriteBool(IsForce);
      }
      if (IsSetFollowPos != false) {
        output.WriteRawTag(104);
        output.WriteBool(IsSetFollowPos);
      }
      if (Duration != 0F) {
        output.WriteRawTag(117);
        output.WriteFloat(Duration);
      }
      if (ScreenY != 0F) {
        output.WriteRawTag(125);
        output.WriteFloat(ScreenY);
      }
      if (DisableProtect != 0) {
        output.WriteRawTag(248, 68);
        output.WriteUInt32(DisableProtect);
      }
      if (BlendType != 0) {
        output.WriteRawTag(144, 72);
        output.WriteUInt32(BlendType);
      }
      if (EntityId != 0) {
        output.WriteRawTag(248, 82);
        output.WriteUInt32(EntityId);
      }
      if (IsAbsFollowPos != false) {
        output.WriteRawTag(248, 85);
        output.WriteBool(IsAbsFollowPos);
      }
      if (BlendDuration != 0F) {
        output.WriteRawTag(245, 109);
        output.WriteFloat(BlendDuration);
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
      otherParams_.WriteTo(ref output, _repeated_otherParams_codec);
      if (IsAllowInput != false) {
        output.WriteRawTag(16);
        output.WriteBool(IsAllowInput);
      }
      if (ScreenX != 0F) {
        output.WriteRawTag(29);
        output.WriteFloat(ScreenX);
      }
      if (lookPos_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(LookPos);
      }
      if (IsSetScreenXy != false) {
        output.WriteRawTag(40);
        output.WriteBool(IsSetScreenXy);
      }
      if (KeepRotType != global::Weedwacker.Shared.Network.Proto.BeginCameraSceneLookNotify.Types.KeepRotType.X) {
        output.WriteRawTag(48);
        output.WriteEnum((int) KeepRotType);
      }
      if (CustomRadius != 0F) {
        output.WriteRawTag(61);
        output.WriteFloat(CustomRadius);
      }
      if (followPos_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(FollowPos);
      }
      if (IsChangePlayMode != false) {
        output.WriteRawTag(72);
        output.WriteBool(IsChangePlayMode);
      }
      if (IsForceWalk != false) {
        output.WriteRawTag(80);
        output.WriteBool(IsForceWalk);
      }
      if (IsRecoverKeepCurrent != false) {
        output.WriteRawTag(88);
        output.WriteBool(IsRecoverKeepCurrent);
      }
      if (IsForce != false) {
        output.WriteRawTag(96);
        output.WriteBool(IsForce);
      }
      if (IsSetFollowPos != false) {
        output.WriteRawTag(104);
        output.WriteBool(IsSetFollowPos);
      }
      if (Duration != 0F) {
        output.WriteRawTag(117);
        output.WriteFloat(Duration);
      }
      if (ScreenY != 0F) {
        output.WriteRawTag(125);
        output.WriteFloat(ScreenY);
      }
      if (DisableProtect != 0) {
        output.WriteRawTag(248, 68);
        output.WriteUInt32(DisableProtect);
      }
      if (BlendType != 0) {
        output.WriteRawTag(144, 72);
        output.WriteUInt32(BlendType);
      }
      if (EntityId != 0) {
        output.WriteRawTag(248, 82);
        output.WriteUInt32(EntityId);
      }
      if (IsAbsFollowPos != false) {
        output.WriteRawTag(248, 85);
        output.WriteBool(IsAbsFollowPos);
      }
      if (BlendDuration != 0F) {
        output.WriteRawTag(245, 109);
        output.WriteFloat(BlendDuration);
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
      if (BlendType != 0) {
        size += 2 + pb::CodedOutputStream.ComputeUInt32Size(BlendType);
      }
      if (CustomRadius != 0F) {
        size += 1 + 4;
      }
      if (IsSetScreenXy != false) {
        size += 1 + 1;
      }
      if (lookPos_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(LookPos);
      }
      if (IsRecoverKeepCurrent != false) {
        size += 1 + 1;
      }
      if (IsAbsFollowPos != false) {
        size += 2 + 1;
      }
      if (KeepRotType != global::Weedwacker.Shared.Network.Proto.BeginCameraSceneLookNotify.Types.KeepRotType.X) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) KeepRotType);
      }
      if (IsChangePlayMode != false) {
        size += 1 + 1;
      }
      if (DisableProtect != 0) {
        size += 2 + pb::CodedOutputStream.ComputeUInt32Size(DisableProtect);
      }
      if (ScreenY != 0F) {
        size += 1 + 4;
      }
      if (IsSetFollowPos != false) {
        size += 1 + 1;
      }
      if (IsForce != false) {
        size += 1 + 1;
      }
      if (BlendDuration != 0F) {
        size += 2 + 4;
      }
      if (EntityId != 0) {
        size += 2 + pb::CodedOutputStream.ComputeUInt32Size(EntityId);
      }
      if (ScreenX != 0F) {
        size += 1 + 4;
      }
      if (IsForceWalk != false) {
        size += 1 + 1;
      }
      size += otherParams_.CalculateSize(_repeated_otherParams_codec);
      if (followPos_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(FollowPos);
      }
      if (IsAllowInput != false) {
        size += 1 + 1;
      }
      if (Duration != 0F) {
        size += 1 + 4;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(BeginCameraSceneLookNotify other) {
      if (other == null) {
        return;
      }
      if (other.BlendType != 0) {
        BlendType = other.BlendType;
      }
      if (other.CustomRadius != 0F) {
        CustomRadius = other.CustomRadius;
      }
      if (other.IsSetScreenXy != false) {
        IsSetScreenXy = other.IsSetScreenXy;
      }
      if (other.lookPos_ != null) {
        if (lookPos_ == null) {
          LookPos = new global::Weedwacker.Shared.Network.Proto.Vector();
        }
        LookPos.MergeFrom(other.LookPos);
      }
      if (other.IsRecoverKeepCurrent != false) {
        IsRecoverKeepCurrent = other.IsRecoverKeepCurrent;
      }
      if (other.IsAbsFollowPos != false) {
        IsAbsFollowPos = other.IsAbsFollowPos;
      }
      if (other.KeepRotType != global::Weedwacker.Shared.Network.Proto.BeginCameraSceneLookNotify.Types.KeepRotType.X) {
        KeepRotType = other.KeepRotType;
      }
      if (other.IsChangePlayMode != false) {
        IsChangePlayMode = other.IsChangePlayMode;
      }
      if (other.DisableProtect != 0) {
        DisableProtect = other.DisableProtect;
      }
      if (other.ScreenY != 0F) {
        ScreenY = other.ScreenY;
      }
      if (other.IsSetFollowPos != false) {
        IsSetFollowPos = other.IsSetFollowPos;
      }
      if (other.IsForce != false) {
        IsForce = other.IsForce;
      }
      if (other.BlendDuration != 0F) {
        BlendDuration = other.BlendDuration;
      }
      if (other.EntityId != 0) {
        EntityId = other.EntityId;
      }
      if (other.ScreenX != 0F) {
        ScreenX = other.ScreenX;
      }
      if (other.IsForceWalk != false) {
        IsForceWalk = other.IsForceWalk;
      }
      otherParams_.Add(other.otherParams_);
      if (other.followPos_ != null) {
        if (followPos_ == null) {
          FollowPos = new global::Weedwacker.Shared.Network.Proto.Vector();
        }
        FollowPos.MergeFrom(other.FollowPos);
      }
      if (other.IsAllowInput != false) {
        IsAllowInput = other.IsAllowInput;
      }
      if (other.Duration != 0F) {
        Duration = other.Duration;
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
          case 10: {
            otherParams_.AddEntriesFrom(input, _repeated_otherParams_codec);
            break;
          }
          case 16: {
            IsAllowInput = input.ReadBool();
            break;
          }
          case 29: {
            ScreenX = input.ReadFloat();
            break;
          }
          case 34: {
            if (lookPos_ == null) {
              LookPos = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(LookPos);
            break;
          }
          case 40: {
            IsSetScreenXy = input.ReadBool();
            break;
          }
          case 48: {
            KeepRotType = (global::Weedwacker.Shared.Network.Proto.BeginCameraSceneLookNotify.Types.KeepRotType) input.ReadEnum();
            break;
          }
          case 61: {
            CustomRadius = input.ReadFloat();
            break;
          }
          case 66: {
            if (followPos_ == null) {
              FollowPos = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(FollowPos);
            break;
          }
          case 72: {
            IsChangePlayMode = input.ReadBool();
            break;
          }
          case 80: {
            IsForceWalk = input.ReadBool();
            break;
          }
          case 88: {
            IsRecoverKeepCurrent = input.ReadBool();
            break;
          }
          case 96: {
            IsForce = input.ReadBool();
            break;
          }
          case 104: {
            IsSetFollowPos = input.ReadBool();
            break;
          }
          case 117: {
            Duration = input.ReadFloat();
            break;
          }
          case 125: {
            ScreenY = input.ReadFloat();
            break;
          }
          case 8824: {
            DisableProtect = input.ReadUInt32();
            break;
          }
          case 9232: {
            BlendType = input.ReadUInt32();
            break;
          }
          case 10616: {
            EntityId = input.ReadUInt32();
            break;
          }
          case 11000: {
            IsAbsFollowPos = input.ReadBool();
            break;
          }
          case 14069: {
            BlendDuration = input.ReadFloat();
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
            otherParams_.AddEntriesFrom(ref input, _repeated_otherParams_codec);
            break;
          }
          case 16: {
            IsAllowInput = input.ReadBool();
            break;
          }
          case 29: {
            ScreenX = input.ReadFloat();
            break;
          }
          case 34: {
            if (lookPos_ == null) {
              LookPos = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(LookPos);
            break;
          }
          case 40: {
            IsSetScreenXy = input.ReadBool();
            break;
          }
          case 48: {
            KeepRotType = (global::Weedwacker.Shared.Network.Proto.BeginCameraSceneLookNotify.Types.KeepRotType) input.ReadEnum();
            break;
          }
          case 61: {
            CustomRadius = input.ReadFloat();
            break;
          }
          case 66: {
            if (followPos_ == null) {
              FollowPos = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(FollowPos);
            break;
          }
          case 72: {
            IsChangePlayMode = input.ReadBool();
            break;
          }
          case 80: {
            IsForceWalk = input.ReadBool();
            break;
          }
          case 88: {
            IsRecoverKeepCurrent = input.ReadBool();
            break;
          }
          case 96: {
            IsForce = input.ReadBool();
            break;
          }
          case 104: {
            IsSetFollowPos = input.ReadBool();
            break;
          }
          case 117: {
            Duration = input.ReadFloat();
            break;
          }
          case 125: {
            ScreenY = input.ReadFloat();
            break;
          }
          case 8824: {
            DisableProtect = input.ReadUInt32();
            break;
          }
          case 9232: {
            BlendType = input.ReadUInt32();
            break;
          }
          case 10616: {
            EntityId = input.ReadUInt32();
            break;
          }
          case 11000: {
            IsAbsFollowPos = input.ReadBool();
            break;
          }
          case 14069: {
            BlendDuration = input.ReadFloat();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the BeginCameraSceneLookNotify message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      public enum KeepRotType {
        [pbr::OriginalName("KEEP_ROT_TYPE_X")] X = 0,
        [pbr::OriginalName("KEEP_ROT_TYPE_XY")] Xy = 1,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
