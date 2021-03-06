// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: PingPacket.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Communication.Proto {

  /// <summary>Holder for reflection information generated from PingPacket.proto</summary>
  public static partial class PingPacketReflection {

    #region Descriptor
    /// <summary>File descriptor for PingPacket.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PingPacketReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChBQaW5nUGFja2V0LnByb3RvEg9nb29nbGUucHJvdG9idWYiGwoKUGluZ1Bh",
            "Y2tldBINCgVUaWNrcxgBIAEoA0IWqgITQ29tbXVuaWNhdGlvbi5Qcm90b2IG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Communication.Proto.PingPacket), global::Communication.Proto.PingPacket.Parser, new[]{ "Ticks" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PingPacket : pb::IMessage<PingPacket> {
    private static readonly pb::MessageParser<PingPacket> _parser = new pb::MessageParser<PingPacket>(() => new PingPacket());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PingPacket> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Communication.Proto.PingPacketReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PingPacket() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PingPacket(PingPacket other) : this() {
      ticks_ = other.ticks_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PingPacket Clone() {
      return new PingPacket(this);
    }

    /// <summary>Field number for the "Ticks" field.</summary>
    public const int TicksFieldNumber = 1;
    private long ticks_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Ticks {
      get { return ticks_; }
      set {
        ticks_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PingPacket);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PingPacket other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Ticks != other.Ticks) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Ticks != 0L) hash ^= Ticks.GetHashCode();
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
      if (Ticks != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(Ticks);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Ticks != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Ticks);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PingPacket other) {
      if (other == null) {
        return;
      }
      if (other.Ticks != 0L) {
        Ticks = other.Ticks;
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
            Ticks = input.ReadInt64();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
