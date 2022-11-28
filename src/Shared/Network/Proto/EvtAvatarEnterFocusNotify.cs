// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: EvtAvatarEnterFocusNotify.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Weedwacker.Shared.Network.Proto {

  /// <summary>Holder for reflection information generated from EvtAvatarEnterFocusNotify.proto</summary>
  public static partial class EvtAvatarEnterFocusNotifyReflection {

    #region Descriptor
    /// <summary>File descriptor for EvtAvatarEnterFocusNotify.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EvtAvatarEnterFocusNotifyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9FdnRBdmF0YXJFbnRlckZvY3VzTm90aWZ5LnByb3RvGhFGb3J3YXJkVHlw",
            "ZS5wcm90bxoMVmVjdG9yLnByb3RvIusCChlFdnRBdmF0YXJFbnRlckZvY3Vz",
            "Tm90aWZ5EhEKCWVudGl0eV9pZBgBIAEoDRIQCghjYW5fbW92ZRgKIAEoCBIh",
            "ChllbnRlcl9ob2xkaW5nX2ZvY3VzX3Nob290GA0gASgIEhkKEWRpc2FibGVf",
            "YWltX2xheWVyGAYgASgIEhYKDnVzZV9hdXRvX2ZvY3VzGAUgASgIEhIKCmZh",
            "c3RfZm9jdXMYAyABKAgSFwoPc2hvd19jcm9zc19oYWlyGAwgASgIEiAKGGVu",
            "dGVyX25vcm1hbF9mb2N1c19zaG9vdBgOIAEoCBIiCgxmb3J3YXJkX3R5cGUY",
            "CCABKA4yDC5Gb3J3YXJkVHlwZRIeCg1mb2N1c19mb3J3YXJkGAcgASgLMgcu",
            "VmVjdG9yEhQKDGRpc2FibGVfYW5pbRgJIAEoCBIYChB1c2VfZm9jdXNfc3Rp",
            "Y2t5GA8gASgIEhAKCHVzZV9neXJvGAsgASgIQiKqAh9XZWVkd2Fja2VyLlNo",
            "YXJlZC5OZXR3b3JrLlByb3RvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Weedwacker.Shared.Network.Proto.ForwardTypeReflection.Descriptor, global::Weedwacker.Shared.Network.Proto.VectorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Weedwacker.Shared.Network.Proto.EvtAvatarEnterFocusNotify), global::Weedwacker.Shared.Network.Proto.EvtAvatarEnterFocusNotify.Parser, new[]{ "EntityId", "CanMove", "EnterHoldingFocusShoot", "DisableAimLayer", "UseAutoFocus", "FastFocus", "ShowCrossHair", "EnterNormalFocusShoot", "ForwardType", "FocusForward", "DisableAnim", "UseFocusSticky", "UseGyro" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// CmdId: 304
  /// EnetChannelId: 0
  /// EnetIsReliable: true
  /// IsAllowClient: true
  /// </summary>
  public sealed partial class EvtAvatarEnterFocusNotify : pb::IMessage<EvtAvatarEnterFocusNotify>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<EvtAvatarEnterFocusNotify> _parser = new pb::MessageParser<EvtAvatarEnterFocusNotify>(() => new EvtAvatarEnterFocusNotify());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<EvtAvatarEnterFocusNotify> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Weedwacker.Shared.Network.Proto.EvtAvatarEnterFocusNotifyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EvtAvatarEnterFocusNotify() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EvtAvatarEnterFocusNotify(EvtAvatarEnterFocusNotify other) : this() {
      entityId_ = other.entityId_;
      canMove_ = other.canMove_;
      enterHoldingFocusShoot_ = other.enterHoldingFocusShoot_;
      disableAimLayer_ = other.disableAimLayer_;
      useAutoFocus_ = other.useAutoFocus_;
      fastFocus_ = other.fastFocus_;
      showCrossHair_ = other.showCrossHair_;
      enterNormalFocusShoot_ = other.enterNormalFocusShoot_;
      forwardType_ = other.forwardType_;
      focusForward_ = other.focusForward_ != null ? other.focusForward_.Clone() : null;
      disableAnim_ = other.disableAnim_;
      useFocusSticky_ = other.useFocusSticky_;
      useGyro_ = other.useGyro_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public EvtAvatarEnterFocusNotify Clone() {
      return new EvtAvatarEnterFocusNotify(this);
    }

    /// <summary>Field number for the "entity_id" field.</summary>
    public const int EntityIdFieldNumber = 1;
    private uint entityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint EntityId {
      get { return entityId_; }
      set {
        entityId_ = value;
      }
    }

    /// <summary>Field number for the "can_move" field.</summary>
    public const int CanMoveFieldNumber = 10;
    private bool canMove_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool CanMove {
      get { return canMove_; }
      set {
        canMove_ = value;
      }
    }

    /// <summary>Field number for the "enter_holding_focus_shoot" field.</summary>
    public const int EnterHoldingFocusShootFieldNumber = 13;
    private bool enterHoldingFocusShoot_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool EnterHoldingFocusShoot {
      get { return enterHoldingFocusShoot_; }
      set {
        enterHoldingFocusShoot_ = value;
      }
    }

    /// <summary>Field number for the "disable_aim_layer" field.</summary>
    public const int DisableAimLayerFieldNumber = 6;
    private bool disableAimLayer_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool DisableAimLayer {
      get { return disableAimLayer_; }
      set {
        disableAimLayer_ = value;
      }
    }

    /// <summary>Field number for the "use_auto_focus" field.</summary>
    public const int UseAutoFocusFieldNumber = 5;
    private bool useAutoFocus_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool UseAutoFocus {
      get { return useAutoFocus_; }
      set {
        useAutoFocus_ = value;
      }
    }

    /// <summary>Field number for the "fast_focus" field.</summary>
    public const int FastFocusFieldNumber = 3;
    private bool fastFocus_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool FastFocus {
      get { return fastFocus_; }
      set {
        fastFocus_ = value;
      }
    }

    /// <summary>Field number for the "show_cross_hair" field.</summary>
    public const int ShowCrossHairFieldNumber = 12;
    private bool showCrossHair_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool ShowCrossHair {
      get { return showCrossHair_; }
      set {
        showCrossHair_ = value;
      }
    }

    /// <summary>Field number for the "enter_normal_focus_shoot" field.</summary>
    public const int EnterNormalFocusShootFieldNumber = 14;
    private bool enterNormalFocusShoot_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool EnterNormalFocusShoot {
      get { return enterNormalFocusShoot_; }
      set {
        enterNormalFocusShoot_ = value;
      }
    }

    /// <summary>Field number for the "forward_type" field.</summary>
    public const int ForwardTypeFieldNumber = 8;
    private global::Weedwacker.Shared.Network.Proto.ForwardType forwardType_ = global::Weedwacker.Shared.Network.Proto.ForwardType.Local;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.ForwardType ForwardType {
      get { return forwardType_; }
      set {
        forwardType_ = value;
      }
    }

    /// <summary>Field number for the "focus_forward" field.</summary>
    public const int FocusForwardFieldNumber = 7;
    private global::Weedwacker.Shared.Network.Proto.Vector focusForward_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Weedwacker.Shared.Network.Proto.Vector FocusForward {
      get { return focusForward_; }
      set {
        focusForward_ = value;
      }
    }

    /// <summary>Field number for the "disable_anim" field.</summary>
    public const int DisableAnimFieldNumber = 9;
    private bool disableAnim_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool DisableAnim {
      get { return disableAnim_; }
      set {
        disableAnim_ = value;
      }
    }

    /// <summary>Field number for the "use_focus_sticky" field.</summary>
    public const int UseFocusStickyFieldNumber = 15;
    private bool useFocusSticky_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool UseFocusSticky {
      get { return useFocusSticky_; }
      set {
        useFocusSticky_ = value;
      }
    }

    /// <summary>Field number for the "use_gyro" field.</summary>
    public const int UseGyroFieldNumber = 11;
    private bool useGyro_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool UseGyro {
      get { return useGyro_; }
      set {
        useGyro_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as EvtAvatarEnterFocusNotify);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(EvtAvatarEnterFocusNotify other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EntityId != other.EntityId) return false;
      if (CanMove != other.CanMove) return false;
      if (EnterHoldingFocusShoot != other.EnterHoldingFocusShoot) return false;
      if (DisableAimLayer != other.DisableAimLayer) return false;
      if (UseAutoFocus != other.UseAutoFocus) return false;
      if (FastFocus != other.FastFocus) return false;
      if (ShowCrossHair != other.ShowCrossHair) return false;
      if (EnterNormalFocusShoot != other.EnterNormalFocusShoot) return false;
      if (ForwardType != other.ForwardType) return false;
      if (!object.Equals(FocusForward, other.FocusForward)) return false;
      if (DisableAnim != other.DisableAnim) return false;
      if (UseFocusSticky != other.UseFocusSticky) return false;
      if (UseGyro != other.UseGyro) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (EntityId != 0) hash ^= EntityId.GetHashCode();
      if (CanMove != false) hash ^= CanMove.GetHashCode();
      if (EnterHoldingFocusShoot != false) hash ^= EnterHoldingFocusShoot.GetHashCode();
      if (DisableAimLayer != false) hash ^= DisableAimLayer.GetHashCode();
      if (UseAutoFocus != false) hash ^= UseAutoFocus.GetHashCode();
      if (FastFocus != false) hash ^= FastFocus.GetHashCode();
      if (ShowCrossHair != false) hash ^= ShowCrossHair.GetHashCode();
      if (EnterNormalFocusShoot != false) hash ^= EnterNormalFocusShoot.GetHashCode();
      if (ForwardType != global::Weedwacker.Shared.Network.Proto.ForwardType.Local) hash ^= ForwardType.GetHashCode();
      if (focusForward_ != null) hash ^= FocusForward.GetHashCode();
      if (DisableAnim != false) hash ^= DisableAnim.GetHashCode();
      if (UseFocusSticky != false) hash ^= UseFocusSticky.GetHashCode();
      if (UseGyro != false) hash ^= UseGyro.GetHashCode();
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
      if (EntityId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(EntityId);
      }
      if (FastFocus != false) {
        output.WriteRawTag(24);
        output.WriteBool(FastFocus);
      }
      if (UseAutoFocus != false) {
        output.WriteRawTag(40);
        output.WriteBool(UseAutoFocus);
      }
      if (DisableAimLayer != false) {
        output.WriteRawTag(48);
        output.WriteBool(DisableAimLayer);
      }
      if (focusForward_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(FocusForward);
      }
      if (ForwardType != global::Weedwacker.Shared.Network.Proto.ForwardType.Local) {
        output.WriteRawTag(64);
        output.WriteEnum((int) ForwardType);
      }
      if (DisableAnim != false) {
        output.WriteRawTag(72);
        output.WriteBool(DisableAnim);
      }
      if (CanMove != false) {
        output.WriteRawTag(80);
        output.WriteBool(CanMove);
      }
      if (UseGyro != false) {
        output.WriteRawTag(88);
        output.WriteBool(UseGyro);
      }
      if (ShowCrossHair != false) {
        output.WriteRawTag(96);
        output.WriteBool(ShowCrossHair);
      }
      if (EnterHoldingFocusShoot != false) {
        output.WriteRawTag(104);
        output.WriteBool(EnterHoldingFocusShoot);
      }
      if (EnterNormalFocusShoot != false) {
        output.WriteRawTag(112);
        output.WriteBool(EnterNormalFocusShoot);
      }
      if (UseFocusSticky != false) {
        output.WriteRawTag(120);
        output.WriteBool(UseFocusSticky);
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
      if (EntityId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(EntityId);
      }
      if (FastFocus != false) {
        output.WriteRawTag(24);
        output.WriteBool(FastFocus);
      }
      if (UseAutoFocus != false) {
        output.WriteRawTag(40);
        output.WriteBool(UseAutoFocus);
      }
      if (DisableAimLayer != false) {
        output.WriteRawTag(48);
        output.WriteBool(DisableAimLayer);
      }
      if (focusForward_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(FocusForward);
      }
      if (ForwardType != global::Weedwacker.Shared.Network.Proto.ForwardType.Local) {
        output.WriteRawTag(64);
        output.WriteEnum((int) ForwardType);
      }
      if (DisableAnim != false) {
        output.WriteRawTag(72);
        output.WriteBool(DisableAnim);
      }
      if (CanMove != false) {
        output.WriteRawTag(80);
        output.WriteBool(CanMove);
      }
      if (UseGyro != false) {
        output.WriteRawTag(88);
        output.WriteBool(UseGyro);
      }
      if (ShowCrossHair != false) {
        output.WriteRawTag(96);
        output.WriteBool(ShowCrossHair);
      }
      if (EnterHoldingFocusShoot != false) {
        output.WriteRawTag(104);
        output.WriteBool(EnterHoldingFocusShoot);
      }
      if (EnterNormalFocusShoot != false) {
        output.WriteRawTag(112);
        output.WriteBool(EnterNormalFocusShoot);
      }
      if (UseFocusSticky != false) {
        output.WriteRawTag(120);
        output.WriteBool(UseFocusSticky);
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
      if (EntityId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(EntityId);
      }
      if (CanMove != false) {
        size += 1 + 1;
      }
      if (EnterHoldingFocusShoot != false) {
        size += 1 + 1;
      }
      if (DisableAimLayer != false) {
        size += 1 + 1;
      }
      if (UseAutoFocus != false) {
        size += 1 + 1;
      }
      if (FastFocus != false) {
        size += 1 + 1;
      }
      if (ShowCrossHair != false) {
        size += 1 + 1;
      }
      if (EnterNormalFocusShoot != false) {
        size += 1 + 1;
      }
      if (ForwardType != global::Weedwacker.Shared.Network.Proto.ForwardType.Local) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ForwardType);
      }
      if (focusForward_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(FocusForward);
      }
      if (DisableAnim != false) {
        size += 1 + 1;
      }
      if (UseFocusSticky != false) {
        size += 1 + 1;
      }
      if (UseGyro != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(EvtAvatarEnterFocusNotify other) {
      if (other == null) {
        return;
      }
      if (other.EntityId != 0) {
        EntityId = other.EntityId;
      }
      if (other.CanMove != false) {
        CanMove = other.CanMove;
      }
      if (other.EnterHoldingFocusShoot != false) {
        EnterHoldingFocusShoot = other.EnterHoldingFocusShoot;
      }
      if (other.DisableAimLayer != false) {
        DisableAimLayer = other.DisableAimLayer;
      }
      if (other.UseAutoFocus != false) {
        UseAutoFocus = other.UseAutoFocus;
      }
      if (other.FastFocus != false) {
        FastFocus = other.FastFocus;
      }
      if (other.ShowCrossHair != false) {
        ShowCrossHair = other.ShowCrossHair;
      }
      if (other.EnterNormalFocusShoot != false) {
        EnterNormalFocusShoot = other.EnterNormalFocusShoot;
      }
      if (other.ForwardType != global::Weedwacker.Shared.Network.Proto.ForwardType.Local) {
        ForwardType = other.ForwardType;
      }
      if (other.focusForward_ != null) {
        if (focusForward_ == null) {
          FocusForward = new global::Weedwacker.Shared.Network.Proto.Vector();
        }
        FocusForward.MergeFrom(other.FocusForward);
      }
      if (other.DisableAnim != false) {
        DisableAnim = other.DisableAnim;
      }
      if (other.UseFocusSticky != false) {
        UseFocusSticky = other.UseFocusSticky;
      }
      if (other.UseGyro != false) {
        UseGyro = other.UseGyro;
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
            EntityId = input.ReadUInt32();
            break;
          }
          case 24: {
            FastFocus = input.ReadBool();
            break;
          }
          case 40: {
            UseAutoFocus = input.ReadBool();
            break;
          }
          case 48: {
            DisableAimLayer = input.ReadBool();
            break;
          }
          case 58: {
            if (focusForward_ == null) {
              FocusForward = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(FocusForward);
            break;
          }
          case 64: {
            ForwardType = (global::Weedwacker.Shared.Network.Proto.ForwardType) input.ReadEnum();
            break;
          }
          case 72: {
            DisableAnim = input.ReadBool();
            break;
          }
          case 80: {
            CanMove = input.ReadBool();
            break;
          }
          case 88: {
            UseGyro = input.ReadBool();
            break;
          }
          case 96: {
            ShowCrossHair = input.ReadBool();
            break;
          }
          case 104: {
            EnterHoldingFocusShoot = input.ReadBool();
            break;
          }
          case 112: {
            EnterNormalFocusShoot = input.ReadBool();
            break;
          }
          case 120: {
            UseFocusSticky = input.ReadBool();
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
            EntityId = input.ReadUInt32();
            break;
          }
          case 24: {
            FastFocus = input.ReadBool();
            break;
          }
          case 40: {
            UseAutoFocus = input.ReadBool();
            break;
          }
          case 48: {
            DisableAimLayer = input.ReadBool();
            break;
          }
          case 58: {
            if (focusForward_ == null) {
              FocusForward = new global::Weedwacker.Shared.Network.Proto.Vector();
            }
            input.ReadMessage(FocusForward);
            break;
          }
          case 64: {
            ForwardType = (global::Weedwacker.Shared.Network.Proto.ForwardType) input.ReadEnum();
            break;
          }
          case 72: {
            DisableAnim = input.ReadBool();
            break;
          }
          case 80: {
            CanMove = input.ReadBool();
            break;
          }
          case 88: {
            UseGyro = input.ReadBool();
            break;
          }
          case 96: {
            ShowCrossHair = input.ReadBool();
            break;
          }
          case 104: {
            EnterHoldingFocusShoot = input.ReadBool();
            break;
          }
          case 112: {
            EnterNormalFocusShoot = input.ReadBool();
            break;
          }
          case 120: {
            UseFocusSticky = input.ReadBool();
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
