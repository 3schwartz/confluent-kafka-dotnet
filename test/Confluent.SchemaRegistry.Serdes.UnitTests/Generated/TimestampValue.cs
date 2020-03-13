// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: TimestampValue.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from TimestampValue.proto</summary>
public static partial class TimestampValueReflection {

  #region Descriptor
  /// <summary>File descriptor for TimestampValue.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static TimestampValueReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChRUaW1lc3RhbXBWYWx1ZS5wcm90bxofZ29vZ2xlL3Byb3RvYnVmL3RpbWVz",
          "dGFtcC5wcm90byI7Cg5UaW1lc3RhbXBWYWx1ZRIpCgV2YWx1ZRgBIAEoCzIa",
          "Lmdvb2dsZS5wcm90b2J1Zi5UaW1lc3RhbXBCLgosaW8uY29uZmx1ZW50Lmth",
          "ZmthLnNlcmlhbGl6ZXJzLnByb3RvYnVmLnRlc3RiBnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::TimestampValue), global::TimestampValue.Parser, new[]{ "Value" }, null, null, null)
        }));
  }
  #endregion

}
#region Messages
/// <summary>
/// Wrapper message for `Timestamp`.
/// </summary>
public sealed partial class TimestampValue : pb::IMessage<TimestampValue> {
  private static readonly pb::MessageParser<TimestampValue> _parser = new pb::MessageParser<TimestampValue>(() => new TimestampValue());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<TimestampValue> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::TimestampValueReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public TimestampValue() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public TimestampValue(TimestampValue other) : this() {
    value_ = other.value_ != null ? other.value_.Clone() : null;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public TimestampValue Clone() {
    return new TimestampValue(this);
  }

  /// <summary>Field number for the "value" field.</summary>
  public const int ValueFieldNumber = 1;
  private global::Google.Protobuf.WellKnownTypes.Timestamp value_;
  /// <summary>
  /// The bytes value.
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public global::Google.Protobuf.WellKnownTypes.Timestamp Value {
    get { return value_; }
    set {
      value_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as TimestampValue);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(TimestampValue other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (!object.Equals(Value, other.Value)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (value_ != null) hash ^= Value.GetHashCode();
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
    if (value_ != null) {
      output.WriteRawTag(10);
      output.WriteMessage(Value);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (value_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(Value);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(TimestampValue other) {
    if (other == null) {
      return;
    }
    if (other.value_ != null) {
      if (value_ == null) {
        Value = new global::Google.Protobuf.WellKnownTypes.Timestamp();
      }
      Value.MergeFrom(other.Value);
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
        case 10: {
          if (value_ == null) {
            Value = new global::Google.Protobuf.WellKnownTypes.Timestamp();
          }
          input.ReadMessage(Value);
          break;
        }
      }
    }
  }

}

#endregion


#endregion Designer generated code
