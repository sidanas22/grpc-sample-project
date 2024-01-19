// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/chatbot.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace BasicGrpcService {

  /// <summary>Holder for reflection information generated from Protos/chatbot.proto</summary>
  public static partial class ChatbotReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/chatbot.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChatbotReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRQcm90b3MvY2hhdGJvdC5wcm90bxISYmFzaWNfZ3JwY19zZXJ2aWNlIiwK",
            "C0NoYXRSZXF1ZXN0EgwKBG5hbWUYASABKAkSDwoHbWVzc2FnZRgCIAEoCSJ/",
            "CglDaGF0UmVwbHkSDwoHbWVzc2FnZRgBIAEoCRIUCgxhbnN3ZXJfZm91bmQY",
            "AiABKAgSFgoOcmVwbHlfaW5fYnl0ZXMYAyABKAwSMwoHcGF5bG9hZBgEIAEo",
            "CzIiLmJhc2ljX2dycGNfc2VydmljZS5OdW1lcmljUGF5bG9hZCKPAgoOTnVt",
            "ZXJpY1BheWxvYWQSEgoKZmxvYXRfZGVtbxgBIAEoAhITCgtkb3VibGVfZGVt",
            "bxgCIAEoARISCgppbnQzMl9kZW1vGAMgASgFEhIKCmludDY0X2RlbW8YBCAB",
            "KAMSEwoLdWludDMyX2RlbW8YBSABKA0SEwoLdWludDY0X2RlbW8YBiABKAQS",
            "EwoLc2ludDMyX2RlbW8YByABKBESEwoLc2ludDY0X2RlbW8YCCABKBISFAoM",
            "Zml4ZWQzMl9kZW1vGAkgASgHEhQKDGZpeGVkNjRfZGVtbxgKIAEoBhIVCg1z",
            "Zml4ZWQzMl9kZW1vGAsgASgPEhUKDXNmaXhlZDY0X2RlbW8YDCABKBAyWAoH",
            "Q2hhdGJvdBJNCgtTZW5kTWVzc2FnZRIfLmJhc2ljX2dycGNfc2VydmljZS5D",
            "aGF0UmVxdWVzdBodLmJhc2ljX2dycGNfc2VydmljZS5DaGF0UmVwbHlCE6oC",
            "EEJhc2ljR3JwY1NlcnZpY2ViBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::BasicGrpcService.ChatRequest), global::BasicGrpcService.ChatRequest.Parser, new[]{ "Name", "Message" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::BasicGrpcService.ChatReply), global::BasicGrpcService.ChatReply.Parser, new[]{ "Message", "AnswerFound", "ReplyInBytes", "Payload" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::BasicGrpcService.NumericPayload), global::BasicGrpcService.NumericPayload.Parser, new[]{ "FloatDemo", "DoubleDemo", "Int32Demo", "Int64Demo", "Uint32Demo", "Uint64Demo", "Sint32Demo", "Sint64Demo", "Fixed32Demo", "Fixed64Demo", "Sfixed32Demo", "Sfixed64Demo" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ChatRequest : pb::IMessage<ChatRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChatRequest> _parser = new pb::MessageParser<ChatRequest>(() => new ChatRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ChatRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::BasicGrpcService.ChatbotReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ChatRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ChatRequest(ChatRequest other) : this() {
      name_ = other.name_;
      message_ = other.message_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ChatRequest Clone() {
      return new ChatRequest(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "message" field.</summary>
    public const int MessageFieldNumber = 2;
    private string message_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Message {
      get { return message_; }
      set {
        message_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ChatRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ChatRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (Message != other.Message) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Message.Length != 0) hash ^= Message.GetHashCode();
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
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (Message.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Message);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (Message.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Message);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Message.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Message);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ChatRequest other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Message.Length != 0) {
        Message = other.Message;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
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
            Name = input.ReadString();
            break;
          }
          case 18: {
            Message = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 18: {
            Message = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class ChatReply : pb::IMessage<ChatReply>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChatReply> _parser = new pb::MessageParser<ChatReply>(() => new ChatReply());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ChatReply> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::BasicGrpcService.ChatbotReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ChatReply() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ChatReply(ChatReply other) : this() {
      message_ = other.message_;
      answerFound_ = other.answerFound_;
      replyInBytes_ = other.replyInBytes_;
      payload_ = other.payload_ != null ? other.payload_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ChatReply Clone() {
      return new ChatReply(this);
    }

    /// <summary>Field number for the "message" field.</summary>
    public const int MessageFieldNumber = 1;
    private string message_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Message {
      get { return message_; }
      set {
        message_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "answer_found" field.</summary>
    public const int AnswerFoundFieldNumber = 2;
    private bool answerFound_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool AnswerFound {
      get { return answerFound_; }
      set {
        answerFound_ = value;
      }
    }

    /// <summary>Field number for the "reply_in_bytes" field.</summary>
    public const int ReplyInBytesFieldNumber = 3;
    private pb::ByteString replyInBytes_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString ReplyInBytes {
      get { return replyInBytes_; }
      set {
        replyInBytes_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "payload" field.</summary>
    public const int PayloadFieldNumber = 4;
    private global::BasicGrpcService.NumericPayload payload_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::BasicGrpcService.NumericPayload Payload {
      get { return payload_; }
      set {
        payload_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ChatReply);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ChatReply other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Message != other.Message) return false;
      if (AnswerFound != other.AnswerFound) return false;
      if (ReplyInBytes != other.ReplyInBytes) return false;
      if (!object.Equals(Payload, other.Payload)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Message.Length != 0) hash ^= Message.GetHashCode();
      if (AnswerFound != false) hash ^= AnswerFound.GetHashCode();
      if (ReplyInBytes.Length != 0) hash ^= ReplyInBytes.GetHashCode();
      if (payload_ != null) hash ^= Payload.GetHashCode();
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
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Message.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Message);
      }
      if (AnswerFound != false) {
        output.WriteRawTag(16);
        output.WriteBool(AnswerFound);
      }
      if (ReplyInBytes.Length != 0) {
        output.WriteRawTag(26);
        output.WriteBytes(ReplyInBytes);
      }
      if (payload_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Payload);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Message.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Message);
      }
      if (AnswerFound != false) {
        output.WriteRawTag(16);
        output.WriteBool(AnswerFound);
      }
      if (ReplyInBytes.Length != 0) {
        output.WriteRawTag(26);
        output.WriteBytes(ReplyInBytes);
      }
      if (payload_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Payload);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Message.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Message);
      }
      if (AnswerFound != false) {
        size += 1 + 1;
      }
      if (ReplyInBytes.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(ReplyInBytes);
      }
      if (payload_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Payload);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ChatReply other) {
      if (other == null) {
        return;
      }
      if (other.Message.Length != 0) {
        Message = other.Message;
      }
      if (other.AnswerFound != false) {
        AnswerFound = other.AnswerFound;
      }
      if (other.ReplyInBytes.Length != 0) {
        ReplyInBytes = other.ReplyInBytes;
      }
      if (other.payload_ != null) {
        if (payload_ == null) {
          Payload = new global::BasicGrpcService.NumericPayload();
        }
        Payload.MergeFrom(other.Payload);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
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
            Message = input.ReadString();
            break;
          }
          case 16: {
            AnswerFound = input.ReadBool();
            break;
          }
          case 26: {
            ReplyInBytes = input.ReadBytes();
            break;
          }
          case 34: {
            if (payload_ == null) {
              Payload = new global::BasicGrpcService.NumericPayload();
            }
            input.ReadMessage(Payload);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            Message = input.ReadString();
            break;
          }
          case 16: {
            AnswerFound = input.ReadBool();
            break;
          }
          case 26: {
            ReplyInBytes = input.ReadBytes();
            break;
          }
          case 34: {
            if (payload_ == null) {
              Payload = new global::BasicGrpcService.NumericPayload();
            }
            input.ReadMessage(Payload);
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class NumericPayload : pb::IMessage<NumericPayload>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<NumericPayload> _parser = new pb::MessageParser<NumericPayload>(() => new NumericPayload());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<NumericPayload> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::BasicGrpcService.ChatbotReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public NumericPayload() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public NumericPayload(NumericPayload other) : this() {
      floatDemo_ = other.floatDemo_;
      doubleDemo_ = other.doubleDemo_;
      int32Demo_ = other.int32Demo_;
      int64Demo_ = other.int64Demo_;
      uint32Demo_ = other.uint32Demo_;
      uint64Demo_ = other.uint64Demo_;
      sint32Demo_ = other.sint32Demo_;
      sint64Demo_ = other.sint64Demo_;
      fixed32Demo_ = other.fixed32Demo_;
      fixed64Demo_ = other.fixed64Demo_;
      sfixed32Demo_ = other.sfixed32Demo_;
      sfixed64Demo_ = other.sfixed64Demo_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public NumericPayload Clone() {
      return new NumericPayload(this);
    }

    /// <summary>Field number for the "float_demo" field.</summary>
    public const int FloatDemoFieldNumber = 1;
    private float floatDemo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float FloatDemo {
      get { return floatDemo_; }
      set {
        floatDemo_ = value;
      }
    }

    /// <summary>Field number for the "double_demo" field.</summary>
    public const int DoubleDemoFieldNumber = 2;
    private double doubleDemo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double DoubleDemo {
      get { return doubleDemo_; }
      set {
        doubleDemo_ = value;
      }
    }

    /// <summary>Field number for the "int32_demo" field.</summary>
    public const int Int32DemoFieldNumber = 3;
    private int int32Demo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Int32Demo {
      get { return int32Demo_; }
      set {
        int32Demo_ = value;
      }
    }

    /// <summary>Field number for the "int64_demo" field.</summary>
    public const int Int64DemoFieldNumber = 4;
    private long int64Demo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Int64Demo {
      get { return int64Demo_; }
      set {
        int64Demo_ = value;
      }
    }

    /// <summary>Field number for the "uint32_demo" field.</summary>
    public const int Uint32DemoFieldNumber = 5;
    private uint uint32Demo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint Uint32Demo {
      get { return uint32Demo_; }
      set {
        uint32Demo_ = value;
      }
    }

    /// <summary>Field number for the "uint64_demo" field.</summary>
    public const int Uint64DemoFieldNumber = 6;
    private ulong uint64Demo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong Uint64Demo {
      get { return uint64Demo_; }
      set {
        uint64Demo_ = value;
      }
    }

    /// <summary>Field number for the "sint32_demo" field.</summary>
    public const int Sint32DemoFieldNumber = 7;
    private int sint32Demo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Sint32Demo {
      get { return sint32Demo_; }
      set {
        sint32Demo_ = value;
      }
    }

    /// <summary>Field number for the "sint64_demo" field.</summary>
    public const int Sint64DemoFieldNumber = 8;
    private long sint64Demo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Sint64Demo {
      get { return sint64Demo_; }
      set {
        sint64Demo_ = value;
      }
    }

    /// <summary>Field number for the "fixed32_demo" field.</summary>
    public const int Fixed32DemoFieldNumber = 9;
    private uint fixed32Demo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint Fixed32Demo {
      get { return fixed32Demo_; }
      set {
        fixed32Demo_ = value;
      }
    }

    /// <summary>Field number for the "fixed64_demo" field.</summary>
    public const int Fixed64DemoFieldNumber = 10;
    private ulong fixed64Demo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong Fixed64Demo {
      get { return fixed64Demo_; }
      set {
        fixed64Demo_ = value;
      }
    }

    /// <summary>Field number for the "sfixed32_demo" field.</summary>
    public const int Sfixed32DemoFieldNumber = 11;
    private int sfixed32Demo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Sfixed32Demo {
      get { return sfixed32Demo_; }
      set {
        sfixed32Demo_ = value;
      }
    }

    /// <summary>Field number for the "sfixed64_demo" field.</summary>
    public const int Sfixed64DemoFieldNumber = 12;
    private long sfixed64Demo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Sfixed64Demo {
      get { return sfixed64Demo_; }
      set {
        sfixed64Demo_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as NumericPayload);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(NumericPayload other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(FloatDemo, other.FloatDemo)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(DoubleDemo, other.DoubleDemo)) return false;
      if (Int32Demo != other.Int32Demo) return false;
      if (Int64Demo != other.Int64Demo) return false;
      if (Uint32Demo != other.Uint32Demo) return false;
      if (Uint64Demo != other.Uint64Demo) return false;
      if (Sint32Demo != other.Sint32Demo) return false;
      if (Sint64Demo != other.Sint64Demo) return false;
      if (Fixed32Demo != other.Fixed32Demo) return false;
      if (Fixed64Demo != other.Fixed64Demo) return false;
      if (Sfixed32Demo != other.Sfixed32Demo) return false;
      if (Sfixed64Demo != other.Sfixed64Demo) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (FloatDemo != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(FloatDemo);
      if (DoubleDemo != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(DoubleDemo);
      if (Int32Demo != 0) hash ^= Int32Demo.GetHashCode();
      if (Int64Demo != 0L) hash ^= Int64Demo.GetHashCode();
      if (Uint32Demo != 0) hash ^= Uint32Demo.GetHashCode();
      if (Uint64Demo != 0UL) hash ^= Uint64Demo.GetHashCode();
      if (Sint32Demo != 0) hash ^= Sint32Demo.GetHashCode();
      if (Sint64Demo != 0L) hash ^= Sint64Demo.GetHashCode();
      if (Fixed32Demo != 0) hash ^= Fixed32Demo.GetHashCode();
      if (Fixed64Demo != 0UL) hash ^= Fixed64Demo.GetHashCode();
      if (Sfixed32Demo != 0) hash ^= Sfixed32Demo.GetHashCode();
      if (Sfixed64Demo != 0L) hash ^= Sfixed64Demo.GetHashCode();
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
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (FloatDemo != 0F) {
        output.WriteRawTag(13);
        output.WriteFloat(FloatDemo);
      }
      if (DoubleDemo != 0D) {
        output.WriteRawTag(17);
        output.WriteDouble(DoubleDemo);
      }
      if (Int32Demo != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Int32Demo);
      }
      if (Int64Demo != 0L) {
        output.WriteRawTag(32);
        output.WriteInt64(Int64Demo);
      }
      if (Uint32Demo != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Uint32Demo);
      }
      if (Uint64Demo != 0UL) {
        output.WriteRawTag(48);
        output.WriteUInt64(Uint64Demo);
      }
      if (Sint32Demo != 0) {
        output.WriteRawTag(56);
        output.WriteSInt32(Sint32Demo);
      }
      if (Sint64Demo != 0L) {
        output.WriteRawTag(64);
        output.WriteSInt64(Sint64Demo);
      }
      if (Fixed32Demo != 0) {
        output.WriteRawTag(77);
        output.WriteFixed32(Fixed32Demo);
      }
      if (Fixed64Demo != 0UL) {
        output.WriteRawTag(81);
        output.WriteFixed64(Fixed64Demo);
      }
      if (Sfixed32Demo != 0) {
        output.WriteRawTag(93);
        output.WriteSFixed32(Sfixed32Demo);
      }
      if (Sfixed64Demo != 0L) {
        output.WriteRawTag(97);
        output.WriteSFixed64(Sfixed64Demo);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (FloatDemo != 0F) {
        output.WriteRawTag(13);
        output.WriteFloat(FloatDemo);
      }
      if (DoubleDemo != 0D) {
        output.WriteRawTag(17);
        output.WriteDouble(DoubleDemo);
      }
      if (Int32Demo != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Int32Demo);
      }
      if (Int64Demo != 0L) {
        output.WriteRawTag(32);
        output.WriteInt64(Int64Demo);
      }
      if (Uint32Demo != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Uint32Demo);
      }
      if (Uint64Demo != 0UL) {
        output.WriteRawTag(48);
        output.WriteUInt64(Uint64Demo);
      }
      if (Sint32Demo != 0) {
        output.WriteRawTag(56);
        output.WriteSInt32(Sint32Demo);
      }
      if (Sint64Demo != 0L) {
        output.WriteRawTag(64);
        output.WriteSInt64(Sint64Demo);
      }
      if (Fixed32Demo != 0) {
        output.WriteRawTag(77);
        output.WriteFixed32(Fixed32Demo);
      }
      if (Fixed64Demo != 0UL) {
        output.WriteRawTag(81);
        output.WriteFixed64(Fixed64Demo);
      }
      if (Sfixed32Demo != 0) {
        output.WriteRawTag(93);
        output.WriteSFixed32(Sfixed32Demo);
      }
      if (Sfixed64Demo != 0L) {
        output.WriteRawTag(97);
        output.WriteSFixed64(Sfixed64Demo);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (FloatDemo != 0F) {
        size += 1 + 4;
      }
      if (DoubleDemo != 0D) {
        size += 1 + 8;
      }
      if (Int32Demo != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Int32Demo);
      }
      if (Int64Demo != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Int64Demo);
      }
      if (Uint32Demo != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Uint32Demo);
      }
      if (Uint64Demo != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(Uint64Demo);
      }
      if (Sint32Demo != 0) {
        size += 1 + pb::CodedOutputStream.ComputeSInt32Size(Sint32Demo);
      }
      if (Sint64Demo != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeSInt64Size(Sint64Demo);
      }
      if (Fixed32Demo != 0) {
        size += 1 + 4;
      }
      if (Fixed64Demo != 0UL) {
        size += 1 + 8;
      }
      if (Sfixed32Demo != 0) {
        size += 1 + 4;
      }
      if (Sfixed64Demo != 0L) {
        size += 1 + 8;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(NumericPayload other) {
      if (other == null) {
        return;
      }
      if (other.FloatDemo != 0F) {
        FloatDemo = other.FloatDemo;
      }
      if (other.DoubleDemo != 0D) {
        DoubleDemo = other.DoubleDemo;
      }
      if (other.Int32Demo != 0) {
        Int32Demo = other.Int32Demo;
      }
      if (other.Int64Demo != 0L) {
        Int64Demo = other.Int64Demo;
      }
      if (other.Uint32Demo != 0) {
        Uint32Demo = other.Uint32Demo;
      }
      if (other.Uint64Demo != 0UL) {
        Uint64Demo = other.Uint64Demo;
      }
      if (other.Sint32Demo != 0) {
        Sint32Demo = other.Sint32Demo;
      }
      if (other.Sint64Demo != 0L) {
        Sint64Demo = other.Sint64Demo;
      }
      if (other.Fixed32Demo != 0) {
        Fixed32Demo = other.Fixed32Demo;
      }
      if (other.Fixed64Demo != 0UL) {
        Fixed64Demo = other.Fixed64Demo;
      }
      if (other.Sfixed32Demo != 0) {
        Sfixed32Demo = other.Sfixed32Demo;
      }
      if (other.Sfixed64Demo != 0L) {
        Sfixed64Demo = other.Sfixed64Demo;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
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
          case 13: {
            FloatDemo = input.ReadFloat();
            break;
          }
          case 17: {
            DoubleDemo = input.ReadDouble();
            break;
          }
          case 24: {
            Int32Demo = input.ReadInt32();
            break;
          }
          case 32: {
            Int64Demo = input.ReadInt64();
            break;
          }
          case 40: {
            Uint32Demo = input.ReadUInt32();
            break;
          }
          case 48: {
            Uint64Demo = input.ReadUInt64();
            break;
          }
          case 56: {
            Sint32Demo = input.ReadSInt32();
            break;
          }
          case 64: {
            Sint64Demo = input.ReadSInt64();
            break;
          }
          case 77: {
            Fixed32Demo = input.ReadFixed32();
            break;
          }
          case 81: {
            Fixed64Demo = input.ReadFixed64();
            break;
          }
          case 93: {
            Sfixed32Demo = input.ReadSFixed32();
            break;
          }
          case 97: {
            Sfixed64Demo = input.ReadSFixed64();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 13: {
            FloatDemo = input.ReadFloat();
            break;
          }
          case 17: {
            DoubleDemo = input.ReadDouble();
            break;
          }
          case 24: {
            Int32Demo = input.ReadInt32();
            break;
          }
          case 32: {
            Int64Demo = input.ReadInt64();
            break;
          }
          case 40: {
            Uint32Demo = input.ReadUInt32();
            break;
          }
          case 48: {
            Uint64Demo = input.ReadUInt64();
            break;
          }
          case 56: {
            Sint32Demo = input.ReadSInt32();
            break;
          }
          case 64: {
            Sint64Demo = input.ReadSInt64();
            break;
          }
          case 77: {
            Fixed32Demo = input.ReadFixed32();
            break;
          }
          case 81: {
            Fixed64Demo = input.ReadFixed64();
            break;
          }
          case 93: {
            Sfixed32Demo = input.ReadSFixed32();
            break;
          }
          case 97: {
            Sfixed64Demo = input.ReadSFixed64();
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
