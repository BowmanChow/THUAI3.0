// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MessageToClient.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Communication.Proto {

  /// <summary>Holder for reflection information generated from MessageToClient.proto</summary>
  public static partial class MessageToClientReflection {

    #region Descriptor
    /// <summary>File descriptor for MessageToClient.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MessageToClientReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVNZXNzYWdlVG9DbGllbnQucHJvdG8SD2dvb2dsZS5wcm90b2J1ZiIpChFY",
            "WVBvc2l0aW9uTWVzc2FnZRIJCgFYGAEgASgBEgkKAVkYAiABKAEi0AIKEUdh",
            "bWVPYmplY3RNZXNzYWdlEgoKAklEGAEgASgDEjAKBFR5cGUYAiABKA4yIi5n",
            "b29nbGUucHJvdG9idWYuT2JqZWN0VHlwZU1lc3NhZ2USEAoIaXNNb3ZpbmcY",
            "AyABKAgSNAoIUG9zaXRpb24YBCABKAsyIi5nb29nbGUucHJvdG9idWYuWFlQ",
            "b3NpdGlvbk1lc3NhZ2USDQoFV2lkdGgYBSABKAUSDgoGSGVpZ2h0GAYgASgF",
            "EjQKCURpcmVjdGlvbhgHIAEoDjIhLmdvb2dsZS5wcm90b2J1Zi5EaXJlY3Rp",
            "b25NZXNzYWdlEioKBEJ1ZmYYCCADKA4yHC5nb29nbGUucHJvdG9idWYuQnVm",
            "Zk1lc3NhZ2USNAoJRGlzaFN0YXRlGAkgASgOMiEuZ29vZ2xlLnByb3RvYnVm",
            "LkRpc2hTdGF0ZU1lc3NhZ2UizwEKD01lc3NhZ2VUb0NsaWVudBJaChVHYW1l",
            "T2JqZWN0TWVzc2FnZUxpc3QYASADKAsyOy5nb29nbGUucHJvdG9idWYuTWVz",
            "c2FnZVRvQ2xpZW50LkdhbWVPYmplY3RNZXNzYWdlTGlzdEVudHJ5GmAKGkdh",
            "bWVPYmplY3RNZXNzYWdlTGlzdEVudHJ5EgsKA2tleRgBIAEoAxIxCgV2YWx1",
            "ZRgCIAEoCzIiLmdvb2dsZS5wcm90b2J1Zi5HYW1lT2JqZWN0TWVzc2FnZToC",
            "OAEqSwoRT2JqZWN0VHlwZU1lc3NhZ2USCgoGUGVvcGxlEAASCQoFQmxvY2sQ",
            "ARIICgREaXNoEAISCAoEVG9vbBADEgsKB1RyaWdnZXIQBCpBCgtCdWZmTWVz",
            "c2FnZRIKCgZGcm96ZW4QABILCgdTdHVubmVkEAESCwoHU3BlZWRVcBACEgwK",
            "CFNsb3dEb3duEAMqNQoQRGlzaFN0YXRlTWVzc2FnZRIHCgNSYXcQABIICgRH",
            "b29kEAESDgoKT3ZlckNvb2tlZBACKm8KEERpcmVjdGlvbk1lc3NhZ2USCQoF",
            "UmlnaHQQABILCgdSaWdodFVwEAESBgoCVXAQAhIKCgZMZWZ0VXAQAxIICgRM",
            "ZWZ0EAQSDAoITGVmdERvd24QBRIICgREb3duEAYSDQoJUmlnaHREb3duEAdC",
            "FqoCE0NvbW11bmljYXRpb24uUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Communication.Proto.ObjectTypeMessage), typeof(global::Communication.Proto.BuffMessage), typeof(global::Communication.Proto.DishStateMessage), typeof(global::Communication.Proto.DirectionMessage), }, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Communication.Proto.XYPositionMessage), global::Communication.Proto.XYPositionMessage.Parser, new[]{ "X", "Y" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Communication.Proto.GameObjectMessage), global::Communication.Proto.GameObjectMessage.Parser, new[]{ "ID", "Type", "IsMoving", "Position", "Width", "Height", "Direction", "Buff", "DishState" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Communication.Proto.MessageToClient), global::Communication.Proto.MessageToClient.Parser, new[]{ "GameObjectMessageList" }, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Enums
  public enum ObjectTypeMessage {
    [pbr::OriginalName("People")] People = 0,
    [pbr::OriginalName("Block")] Block = 1,
    [pbr::OriginalName("Dish")] Dish = 2,
    [pbr::OriginalName("Tool")] Tool = 3,
    [pbr::OriginalName("Trigger")] Trigger = 4,
  }

  public enum BuffMessage {
    [pbr::OriginalName("Frozen")] Frozen = 0,
    [pbr::OriginalName("Stunned")] Stunned = 1,
    [pbr::OriginalName("SpeedUp")] SpeedUp = 2,
    [pbr::OriginalName("SlowDown")] SlowDown = 3,
  }

  public enum DishStateMessage {
    [pbr::OriginalName("Raw")] Raw = 0,
    [pbr::OriginalName("Good")] Good = 1,
    [pbr::OriginalName("OverCooked")] OverCooked = 2,
  }

  public enum DirectionMessage {
    [pbr::OriginalName("Right")] Right = 0,
    [pbr::OriginalName("RightUp")] RightUp = 1,
    [pbr::OriginalName("Up")] Up = 2,
    [pbr::OriginalName("LeftUp")] LeftUp = 3,
    [pbr::OriginalName("Left")] Left = 4,
    [pbr::OriginalName("LeftDown")] LeftDown = 5,
    [pbr::OriginalName("Down")] Down = 6,
    [pbr::OriginalName("RightDown")] RightDown = 7,
  }

  #endregion

  #region Messages
  public sealed partial class XYPositionMessage : pb::IMessage<XYPositionMessage> {
    private static readonly pb::MessageParser<XYPositionMessage> _parser = new pb::MessageParser<XYPositionMessage>(() => new XYPositionMessage());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<XYPositionMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Communication.Proto.MessageToClientReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public XYPositionMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public XYPositionMessage(XYPositionMessage other) : this() {
      x_ = other.x_;
      y_ = other.y_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public XYPositionMessage Clone() {
      return new XYPositionMessage(this);
    }

    /// <summary>Field number for the "X" field.</summary>
    public const int XFieldNumber = 1;
    private double x_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double X {
      get { return x_; }
      set {
        x_ = value;
      }
    }

    /// <summary>Field number for the "Y" field.</summary>
    public const int YFieldNumber = 2;
    private double y_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double Y {
      get { return y_; }
      set {
        y_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as XYPositionMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(XYPositionMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(X, other.X)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Y, other.Y)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (X != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(X);
      if (Y != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Y);
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (X != 0D) {
        output.WriteRawTag(9);
        output.WriteDouble(X);
      }
      if (Y != 0D) {
        output.WriteRawTag(17);
        output.WriteDouble(Y);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (X != 0D) {
        size += 1 + 8;
      }
      if (Y != 0D) {
        size += 1 + 8;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(XYPositionMessage other) {
      if (other == null) {
        return;
      }
      if (other.X != 0D) {
        X = other.X;
      }
      if (other.Y != 0D) {
        Y = other.Y;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 9: {
            X = input.ReadDouble();
            break;
          }
          case 17: {
            Y = input.ReadDouble();
            break;
          }
        }
      }
    }

  }

  public sealed partial class GameObjectMessage : pb::IMessage<GameObjectMessage> {
    private static readonly pb::MessageParser<GameObjectMessage> _parser = new pb::MessageParser<GameObjectMessage>(() => new GameObjectMessage());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GameObjectMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Communication.Proto.MessageToClientReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GameObjectMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GameObjectMessage(GameObjectMessage other) : this() {
      iD_ = other.iD_;
      type_ = other.type_;
      isMoving_ = other.isMoving_;
      position_ = other.position_ != null ? other.position_.Clone() : null;
      width_ = other.width_;
      height_ = other.height_;
      direction_ = other.direction_;
      buff_ = other.buff_.Clone();
      dishState_ = other.dishState_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GameObjectMessage Clone() {
      return new GameObjectMessage(this);
    }

    /// <summary>Field number for the "ID" field.</summary>
    public const int IDFieldNumber = 1;
    private long iD_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long ID {
      get { return iD_; }
      set {
        iD_ = value;
      }
    }

    /// <summary>Field number for the "Type" field.</summary>
    public const int TypeFieldNumber = 2;
    private global::Communication.Proto.ObjectTypeMessage type_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Communication.Proto.ObjectTypeMessage Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "isMoving" field.</summary>
    public const int IsMovingFieldNumber = 3;
    private bool isMoving_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IsMoving {
      get { return isMoving_; }
      set {
        isMoving_ = value;
      }
    }

    /// <summary>Field number for the "Position" field.</summary>
    public const int PositionFieldNumber = 4;
    private global::Communication.Proto.XYPositionMessage position_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Communication.Proto.XYPositionMessage Position {
      get { return position_; }
      set {
        position_ = value;
      }
    }

    /// <summary>Field number for the "Width" field.</summary>
    public const int WidthFieldNumber = 5;
    private int width_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Width {
      get { return width_; }
      set {
        width_ = value;
      }
    }

    /// <summary>Field number for the "Height" field.</summary>
    public const int HeightFieldNumber = 6;
    private int height_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Height {
      get { return height_; }
      set {
        height_ = value;
      }
    }

    /// <summary>Field number for the "Direction" field.</summary>
    public const int DirectionFieldNumber = 7;
    private global::Communication.Proto.DirectionMessage direction_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Communication.Proto.DirectionMessage Direction {
      get { return direction_; }
      set {
        direction_ = value;
      }
    }

    /// <summary>Field number for the "Buff" field.</summary>
    public const int BuffFieldNumber = 8;
    private static readonly pb::FieldCodec<global::Communication.Proto.BuffMessage> _repeated_buff_codec
        = pb::FieldCodec.ForEnum(66, x => (int) x, x => (global::Communication.Proto.BuffMessage) x);
    private readonly pbc::RepeatedField<global::Communication.Proto.BuffMessage> buff_ = new pbc::RepeatedField<global::Communication.Proto.BuffMessage>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Communication.Proto.BuffMessage> Buff {
      get { return buff_; }
    }

    /// <summary>Field number for the "DishState" field.</summary>
    public const int DishStateFieldNumber = 9;
    private global::Communication.Proto.DishStateMessage dishState_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Communication.Proto.DishStateMessage DishState {
      get { return dishState_; }
      set {
        dishState_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GameObjectMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GameObjectMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ID != other.ID) return false;
      if (Type != other.Type) return false;
      if (IsMoving != other.IsMoving) return false;
      if (!object.Equals(Position, other.Position)) return false;
      if (Width != other.Width) return false;
      if (Height != other.Height) return false;
      if (Direction != other.Direction) return false;
      if(!buff_.Equals(other.buff_)) return false;
      if (DishState != other.DishState) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ID != 0L) hash ^= ID.GetHashCode();
      if (Type != 0) hash ^= Type.GetHashCode();
      if (IsMoving != false) hash ^= IsMoving.GetHashCode();
      if (position_ != null) hash ^= Position.GetHashCode();
      if (Width != 0) hash ^= Width.GetHashCode();
      if (Height != 0) hash ^= Height.GetHashCode();
      if (Direction != 0) hash ^= Direction.GetHashCode();
      hash ^= buff_.GetHashCode();
      if (DishState != 0) hash ^= DishState.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (ID != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(ID);
      }
      if (Type != 0) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Type);
      }
      if (IsMoving != false) {
        output.WriteRawTag(24);
        output.WriteBool(IsMoving);
      }
      if (position_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Position);
      }
      if (Width != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(Width);
      }
      if (Height != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(Height);
      }
      if (Direction != 0) {
        output.WriteRawTag(56);
        output.WriteEnum((int) Direction);
      }
      buff_.WriteTo(output, _repeated_buff_codec);
      if (DishState != 0) {
        output.WriteRawTag(72);
        output.WriteEnum((int) DishState);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ID != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(ID);
      }
      if (Type != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (IsMoving != false) {
        size += 1 + 1;
      }
      if (position_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Position);
      }
      if (Width != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Width);
      }
      if (Height != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Height);
      }
      if (Direction != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Direction);
      }
      size += buff_.CalculateSize(_repeated_buff_codec);
      if (DishState != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) DishState);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GameObjectMessage other) {
      if (other == null) {
        return;
      }
      if (other.ID != 0L) {
        ID = other.ID;
      }
      if (other.Type != 0) {
        Type = other.Type;
      }
      if (other.IsMoving != false) {
        IsMoving = other.IsMoving;
      }
      if (other.position_ != null) {
        if (position_ == null) {
          Position = new global::Communication.Proto.XYPositionMessage();
        }
        Position.MergeFrom(other.Position);
      }
      if (other.Width != 0) {
        Width = other.Width;
      }
      if (other.Height != 0) {
        Height = other.Height;
      }
      if (other.Direction != 0) {
        Direction = other.Direction;
      }
      buff_.Add(other.buff_);
      if (other.DishState != 0) {
        DishState = other.DishState;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            ID = input.ReadInt64();
            break;
          }
          case 16: {
            Type = (global::Communication.Proto.ObjectTypeMessage) input.ReadEnum();
            break;
          }
          case 24: {
            IsMoving = input.ReadBool();
            break;
          }
          case 34: {
            if (position_ == null) {
              Position = new global::Communication.Proto.XYPositionMessage();
            }
            input.ReadMessage(Position);
            break;
          }
          case 40: {
            Width = input.ReadInt32();
            break;
          }
          case 48: {
            Height = input.ReadInt32();
            break;
          }
          case 56: {
            Direction = (global::Communication.Proto.DirectionMessage) input.ReadEnum();
            break;
          }
          case 66:
          case 64: {
            buff_.AddEntriesFrom(input, _repeated_buff_codec);
            break;
          }
          case 72: {
            DishState = (global::Communication.Proto.DishStateMessage) input.ReadEnum();
            break;
          }
        }
      }
    }

  }

  public sealed partial class MessageToClient : pb::IMessage<MessageToClient> {
    private static readonly pb::MessageParser<MessageToClient> _parser = new pb::MessageParser<MessageToClient>(() => new MessageToClient());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MessageToClient> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Communication.Proto.MessageToClientReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MessageToClient() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MessageToClient(MessageToClient other) : this() {
      gameObjectMessageList_ = other.gameObjectMessageList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MessageToClient Clone() {
      return new MessageToClient(this);
    }

    /// <summary>Field number for the "GameObjectMessageList" field.</summary>
    public const int GameObjectMessageListFieldNumber = 1;
    private static readonly pbc::MapField<long, global::Communication.Proto.GameObjectMessage>.Codec _map_gameObjectMessageList_codec
        = new pbc::MapField<long, global::Communication.Proto.GameObjectMessage>.Codec(pb::FieldCodec.ForInt64(8), pb::FieldCodec.ForMessage(18, global::Communication.Proto.GameObjectMessage.Parser), 10);
    private readonly pbc::MapField<long, global::Communication.Proto.GameObjectMessage> gameObjectMessageList_ = new pbc::MapField<long, global::Communication.Proto.GameObjectMessage>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<long, global::Communication.Proto.GameObjectMessage> GameObjectMessageList {
      get { return gameObjectMessageList_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MessageToClient);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MessageToClient other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!GameObjectMessageList.Equals(other.GameObjectMessageList)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= GameObjectMessageList.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      gameObjectMessageList_.WriteTo(output, _map_gameObjectMessageList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += gameObjectMessageList_.CalculateSize(_map_gameObjectMessageList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MessageToClient other) {
      if (other == null) {
        return;
      }
      gameObjectMessageList_.Add(other.gameObjectMessageList_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            gameObjectMessageList_.AddEntriesFrom(input, _map_gameObjectMessageList_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code