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
  public partial class Transaction : TBase
  {
    private long _id;
    private byte[] _source;
    private byte[] _target;
    private Amount _amount;
    private Amount _balance;
    private sbyte _currency;
    private byte[] _signature;
    private SmartContractInvocation _smartContract;
    private AmountCommission _fee;
    private long _timeCreation;
    private byte[] _userFields;
    private TransactionType _type;
    private SmartTransInfo _smartInfo;

    public long Id
    {
      get
      {
        return _id;
      }
      set
      {
        __isset.id = true;
        this._id = value;
      }
    }

    public byte[] Source
    {
      get
      {
        return _source;
      }
      set
      {
        __isset.source = true;
        this._source = value;
      }
    }

    public byte[] Target
    {
      get
      {
        return _target;
      }
      set
      {
        __isset.target = true;
        this._target = value;
      }
    }

    public Amount Amount
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

    public Amount Balance
    {
      get
      {
        return _balance;
      }
      set
      {
        __isset.balance = true;
        this._balance = value;
      }
    }

    public sbyte Currency
    {
      get
      {
        return _currency;
      }
      set
      {
        __isset.currency = true;
        this._currency = value;
      }
    }

    public byte[] Signature
    {
      get
      {
        return _signature;
      }
      set
      {
        __isset.signature = true;
        this._signature = value;
      }
    }

    public SmartContractInvocation SmartContract
    {
      get
      {
        return _smartContract;
      }
      set
      {
        __isset.smartContract = true;
        this._smartContract = value;
      }
    }

    public AmountCommission Fee
    {
      get
      {
        return _fee;
      }
      set
      {
        __isset.fee = true;
        this._fee = value;
      }
    }

    public long TimeCreation
    {
      get
      {
        return _timeCreation;
      }
      set
      {
        __isset.timeCreation = true;
        this._timeCreation = value;
      }
    }

    public byte[] UserFields
    {
      get
      {
        return _userFields;
      }
      set
      {
        __isset.userFields = true;
        this._userFields = value;
      }
    }

    /// <summary>
    /// 
    /// <seealso cref="TransactionType"/>
    /// </summary>
    public TransactionType Type
    {
      get
      {
        return _type;
      }
      set
      {
        __isset.type = true;
        this._type = value;
      }
    }

    public SmartTransInfo SmartInfo
    {
      get
      {
        return _smartInfo;
      }
      set
      {
        __isset.smartInfo = true;
        this._smartInfo = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool id;
      public bool source;
      public bool target;
      public bool amount;
      public bool balance;
      public bool currency;
      public bool signature;
      public bool smartContract;
      public bool fee;
      public bool timeCreation;
      public bool userFields;
      public bool type;
      public bool smartInfo;
    }

    public Transaction() {
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
              if (field.Type == TType.I64) {
                Id = iprot.ReadI64();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 2:
              if (field.Type == TType.String) {
                Source = iprot.ReadBinary();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 3:
              if (field.Type == TType.String) {
                Target = iprot.ReadBinary();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 4:
              if (field.Type == TType.Struct) {
                Amount = new Amount();
                Amount.Read(iprot);
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 5:
              if (field.Type == TType.Struct) {
                Balance = new Amount();
                Balance.Read(iprot);
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 6:
              if (field.Type == TType.Byte) {
                Currency = iprot.ReadByte();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 7:
              if (field.Type == TType.String) {
                Signature = iprot.ReadBinary();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 8:
              if (field.Type == TType.Struct) {
                SmartContract = new SmartContractInvocation();
                SmartContract.Read(iprot);
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 9:
              if (field.Type == TType.Struct) {
                Fee = new AmountCommission();
                Fee.Read(iprot);
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 10:
              if (field.Type == TType.I64) {
                TimeCreation = iprot.ReadI64();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 11:
              if (field.Type == TType.String) {
                UserFields = iprot.ReadBinary();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 12:
              if (field.Type == TType.I32) {
                Type = (TransactionType)iprot.ReadI32();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 13:
              if (field.Type == TType.Struct) {
                SmartInfo = new SmartTransInfo();
                SmartInfo.Read(iprot);
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
        TStruct struc = new TStruct("Transaction");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (__isset.id) {
          field.Name = "id";
          field.Type = TType.I64;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          oprot.WriteI64(Id);
          oprot.WriteFieldEnd();
        }
        if (Source != null && __isset.source) {
          field.Name = "source";
          field.Type = TType.String;
          field.ID = 2;
          oprot.WriteFieldBegin(field);
          oprot.WriteBinary(Source);
          oprot.WriteFieldEnd();
        }
        if (Target != null && __isset.target) {
          field.Name = "target";
          field.Type = TType.String;
          field.ID = 3;
          oprot.WriteFieldBegin(field);
          oprot.WriteBinary(Target);
          oprot.WriteFieldEnd();
        }
        if (Amount != null && __isset.amount) {
          field.Name = "amount";
          field.Type = TType.Struct;
          field.ID = 4;
          oprot.WriteFieldBegin(field);
          Amount.Write(oprot);
          oprot.WriteFieldEnd();
        }
        if (Balance != null && __isset.balance) {
          field.Name = "balance";
          field.Type = TType.Struct;
          field.ID = 5;
          oprot.WriteFieldBegin(field);
          Balance.Write(oprot);
          oprot.WriteFieldEnd();
        }
        if (__isset.currency) {
          field.Name = "currency";
          field.Type = TType.Byte;
          field.ID = 6;
          oprot.WriteFieldBegin(field);
          oprot.WriteByte(Currency);
          oprot.WriteFieldEnd();
        }
        if (Signature != null && __isset.signature) {
          field.Name = "signature";
          field.Type = TType.String;
          field.ID = 7;
          oprot.WriteFieldBegin(field);
          oprot.WriteBinary(Signature);
          oprot.WriteFieldEnd();
        }
        if (SmartContract != null && __isset.smartContract) {
          field.Name = "smartContract";
          field.Type = TType.Struct;
          field.ID = 8;
          oprot.WriteFieldBegin(field);
          SmartContract.Write(oprot);
          oprot.WriteFieldEnd();
        }
        if (Fee != null && __isset.fee) {
          field.Name = "fee";
          field.Type = TType.Struct;
          field.ID = 9;
          oprot.WriteFieldBegin(field);
          Fee.Write(oprot);
          oprot.WriteFieldEnd();
        }
        if (__isset.timeCreation) {
          field.Name = "timeCreation";
          field.Type = TType.I64;
          field.ID = 10;
          oprot.WriteFieldBegin(field);
          oprot.WriteI64(TimeCreation);
          oprot.WriteFieldEnd();
        }
        if (UserFields != null && __isset.userFields) {
          field.Name = "userFields";
          field.Type = TType.String;
          field.ID = 11;
          oprot.WriteFieldBegin(field);
          oprot.WriteBinary(UserFields);
          oprot.WriteFieldEnd();
        }
        if (__isset.type) {
          field.Name = "type";
          field.Type = TType.I32;
          field.ID = 12;
          oprot.WriteFieldBegin(field);
          oprot.WriteI32((int)Type);
          oprot.WriteFieldEnd();
        }
        if (SmartInfo != null && __isset.smartInfo) {
          field.Name = "smartInfo";
          field.Type = TType.Struct;
          field.ID = 13;
          oprot.WriteFieldBegin(field);
          SmartInfo.Write(oprot);
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
      StringBuilder __sb = new StringBuilder("Transaction(");
      bool __first = true;
      if (__isset.id) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Id: ");
        __sb.Append(Id);
      }
      if (Source != null && __isset.source) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Source: ");
        __sb.Append(Source);
      }
      if (Target != null && __isset.target) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Target: ");
        __sb.Append(Target);
      }
      if (Amount != null && __isset.amount) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Amount: ");
        __sb.Append(Amount== null ? "<null>" : Amount.ToString());
      }
      if (Balance != null && __isset.balance) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Balance: ");
        __sb.Append(Balance== null ? "<null>" : Balance.ToString());
      }
      if (__isset.currency) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Currency: ");
        __sb.Append(Currency);
      }
      if (Signature != null && __isset.signature) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Signature: ");
        __sb.Append(Signature);
      }
      if (SmartContract != null && __isset.smartContract) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("SmartContract: ");
        __sb.Append(SmartContract== null ? "<null>" : SmartContract.ToString());
      }
      if (Fee != null && __isset.fee) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Fee: ");
        __sb.Append(Fee== null ? "<null>" : Fee.ToString());
      }
      if (__isset.timeCreation) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("TimeCreation: ");
        __sb.Append(TimeCreation);
      }
      if (UserFields != null && __isset.userFields) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("UserFields: ");
        __sb.Append(UserFields);
      }
      if (__isset.type) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Type: ");
        __sb.Append(Type);
      }
      if (SmartInfo != null && __isset.smartInfo) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("SmartInfo: ");
        __sb.Append(SmartInfo== null ? "<null>" : SmartInfo.ToString());
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}
