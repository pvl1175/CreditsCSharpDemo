/**
 * Autogenerated by Thrift Compiler (0.12.0)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using System.Runtime.Serialization;
using Thrift.Protocol;
using Thrift.Transport;

namespace NodeApi
{

  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class TokenTransfer : TBase
  {
    private byte[] _token;
    private string _code;
    private byte[] _sender;
    private byte[] _receiver;
    private string _amount;
    private byte[] _initiator;
    private TransactionId _transaction;
    private long _time;

    public byte[] Token
    {
      get
      {
        return _token;
      }
      set
      {
        __isset.token = true;
        this._token = value;
      }
    }

    public string Code
    {
      get
      {
        return _code;
      }
      set
      {
        __isset.code = true;
        this._code = value;
      }
    }

    public byte[] Sender
    {
      get
      {
        return _sender;
      }
      set
      {
        __isset.sender = true;
        this._sender = value;
      }
    }

    public byte[] Receiver
    {
      get
      {
        return _receiver;
      }
      set
      {
        __isset.receiver = true;
        this._receiver = value;
      }
    }

    public string Amount
    {
      get
      {
        return _amount;
      }
      set
      {
        __isset.amount = true;
        this._amount = value;
      }
    }

    public byte[] Initiator
    {
      get
      {
        return _initiator;
      }
      set
      {
        __isset.initiator = true;
        this._initiator = value;
      }
    }

    public TransactionId Transaction
    {
      get
      {
        return _transaction;
      }
      set
      {
        __isset.transaction = true;
        this._transaction = value;
      }
    }

    public long Time
    {
      get
      {
        return _time;
      }
      set
      {
        __isset.time = true;
        this._time = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool token;
      public bool code;
      public bool sender;
      public bool receiver;
      public bool amount;
      public bool initiator;
      public bool transaction;
      public bool time;
    }

    public TokenTransfer() {
    }

    public void Read (TProtocol iprot)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        TField field;
        iprot.ReadStructBegin();
        while (true)
        {
          field = iprot.ReadFieldBegin();
          if (field.Type == TType.Stop) { 
            break;
          }
          switch (field.ID)
          {
            case 1:
              if (field.Type == TType.String) {
                Token = iprot.ReadBinary();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 2:
              if (field.Type == TType.String) {
                Code = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 3:
              if (field.Type == TType.String) {
                Sender = iprot.ReadBinary();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 4:
              if (field.Type == TType.String) {
                Receiver = iprot.ReadBinary();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 5:
              if (field.Type == TType.String) {
                Amount = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 6:
              if (field.Type == TType.String) {
                Initiator = iprot.ReadBinary();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 7:
              if (field.Type == TType.Struct) {
                Transaction = new TransactionId();
                Transaction.Read(iprot);
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 8:
              if (field.Type == TType.I64) {
                Time = iprot.ReadI64();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            default: 
              TProtocolUtil.Skip(iprot, field.Type);
              break;
          }
          iprot.ReadFieldEnd();
        }
        iprot.ReadStructEnd();
      }
      finally
      {
        iprot.DecrementRecursionDepth();
      }
    }

    public void Write(TProtocol oprot) {
      oprot.IncrementRecursionDepth();
      try
      {
        TStruct struc = new TStruct("TokenTransfer");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (Token != null && __isset.token) {
          field.Name = "token";
          field.Type = TType.String;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          oprot.WriteBinary(Token);
          oprot.WriteFieldEnd();
        }
        if (Code != null && __isset.code) {
          field.Name = "code";
          field.Type = TType.String;
          field.ID = 2;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(Code);
          oprot.WriteFieldEnd();
        }
        if (Sender != null && __isset.sender) {
          field.Name = "sender";
          field.Type = TType.String;
          field.ID = 3;
          oprot.WriteFieldBegin(field);
          oprot.WriteBinary(Sender);
          oprot.WriteFieldEnd();
        }
        if (Receiver != null && __isset.receiver) {
          field.Name = "receiver";
          field.Type = TType.String;
          field.ID = 4;
          oprot.WriteFieldBegin(field);
          oprot.WriteBinary(Receiver);
          oprot.WriteFieldEnd();
        }
        if (Amount != null && __isset.amount) {
          field.Name = "amount";
          field.Type = TType.String;
          field.ID = 5;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(Amount);
          oprot.WriteFieldEnd();
        }
        if (Initiator != null && __isset.initiator) {
          field.Name = "initiator";
          field.Type = TType.String;
          field.ID = 6;
          oprot.WriteFieldBegin(field);
          oprot.WriteBinary(Initiator);
          oprot.WriteFieldEnd();
        }
        if (Transaction != null && __isset.transaction) {
          field.Name = "transaction";
          field.Type = TType.Struct;
          field.ID = 7;
          oprot.WriteFieldBegin(field);
          Transaction.Write(oprot);
          oprot.WriteFieldEnd();
        }
        if (__isset.time) {
          field.Name = "time";
          field.Type = TType.I64;
          field.ID = 8;
          oprot.WriteFieldBegin(field);
          oprot.WriteI64(Time);
          oprot.WriteFieldEnd();
        }
        oprot.WriteFieldStop();
        oprot.WriteStructEnd();
      }
      finally
      {
        oprot.DecrementRecursionDepth();
      }
    }

    public override string ToString() {
      StringBuilder __sb = new StringBuilder("TokenTransfer(");
      bool __first = true;
      if (Token != null && __isset.token) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Token: ");
        __sb.Append(Token);
      }
      if (Code != null && __isset.code) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Code: ");
        __sb.Append(Code);
      }
      if (Sender != null && __isset.sender) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Sender: ");
        __sb.Append(Sender);
      }
      if (Receiver != null && __isset.receiver) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Receiver: ");
        __sb.Append(Receiver);
      }
      if (Amount != null && __isset.amount) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Amount: ");
        __sb.Append(Amount);
      }
      if (Initiator != null && __isset.initiator) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Initiator: ");
        __sb.Append(Initiator);
      }
      if (Transaction != null && __isset.transaction) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Transaction: ");
        __sb.Append(Transaction== null ? "<null>" : Transaction.ToString());
      }
      if (__isset.time) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Time: ");
        __sb.Append(Time);
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}
