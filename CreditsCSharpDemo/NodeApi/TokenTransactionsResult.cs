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
  public partial class TokenTransactionsResult : TBase
  {
    private APIResponse _status;
    private int _count;
    private List<TokenTransaction> _transactions;

    public APIResponse Status
    {
      get
      {
        return _status;
      }
      set
      {
        __isset.status = true;
        this._status = value;
      }
    }

    public int Count
    {
      get
      {
        return _count;
      }
      set
      {
        __isset.count = true;
        this._count = value;
      }
    }

    public List<TokenTransaction> Transactions
    {
      get
      {
        return _transactions;
      }
      set
      {
        __isset.transactions = true;
        this._transactions = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool status;
      public bool count;
      public bool transactions;
    }

    public TokenTransactionsResult() {
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
              if (field.Type == TType.Struct) {
                Status = new APIResponse();
                Status.Read(iprot);
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 2:
              if (field.Type == TType.I32) {
                Count = iprot.ReadI32();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 3:
              if (field.Type == TType.List) {
                {
                  Transactions = new List<TokenTransaction>();
                  TList _list83 = iprot.ReadListBegin();
                  for( int _i84 = 0; _i84 < _list83.Count; ++_i84)
                  {
                    TokenTransaction _elem85;
                    _elem85 = new TokenTransaction();
                    _elem85.Read(iprot);
                    Transactions.Add(_elem85);
                  }
                  iprot.ReadListEnd();
                }
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
        TStruct struc = new TStruct("TokenTransactionsResult");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (Status != null && __isset.status) {
          field.Name = "status";
          field.Type = TType.Struct;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          Status.Write(oprot);
          oprot.WriteFieldEnd();
        }
        if (__isset.count) {
          field.Name = "count";
          field.Type = TType.I32;
          field.ID = 2;
          oprot.WriteFieldBegin(field);
          oprot.WriteI32(Count);
          oprot.WriteFieldEnd();
        }
        if (Transactions != null && __isset.transactions) {
          field.Name = "transactions";
          field.Type = TType.List;
          field.ID = 3;
          oprot.WriteFieldBegin(field);
          {
            oprot.WriteListBegin(new TList(TType.Struct, Transactions.Count));
            foreach (TokenTransaction _iter86 in Transactions)
            {
              _iter86.Write(oprot);
            }
            oprot.WriteListEnd();
          }
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
      StringBuilder __sb = new StringBuilder("TokenTransactionsResult(");
      bool __first = true;
      if (Status != null && __isset.status) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Status: ");
        __sb.Append(Status== null ? "<null>" : Status.ToString());
      }
      if (__isset.count) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Count: ");
        __sb.Append(Count);
      }
      if (Transactions != null && __isset.transactions) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Transactions: ");
        __sb.Append(Transactions);
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}
