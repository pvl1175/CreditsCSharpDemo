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
  public partial class SmartStateTransInfo : TBase
  {
    private bool _success;
    private Amount _executionFee;
    private Variant _returnValue;
    private TransactionId _startTransaction;

    public bool Success
    {
      get
      {
        return _success;
      }
      set
      {
        __isset.success = true;
        this._success = value;
      }
    }

    public Amount ExecutionFee
    {
      get
      {
        return _executionFee;
      }
      set
      {
        __isset.executionFee = true;
        this._executionFee = value;
      }
    }

    public Variant ReturnValue
    {
      get
      {
        return _returnValue;
      }
      set
      {
        __isset.returnValue = true;
        this._returnValue = value;
      }
    }

    public TransactionId StartTransaction
    {
      get
      {
        return _startTransaction;
      }
      set
      {
        __isset.startTransaction = true;
        this._startTransaction = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool success;
      public bool executionFee;
      public bool returnValue;
      public bool startTransaction;
    }

    public SmartStateTransInfo() {
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
              if (field.Type == TType.Bool) {
                Success = iprot.ReadBool();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 2:
              if (field.Type == TType.Struct) {
                ExecutionFee = new Amount();
                ExecutionFee.Read(iprot);
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 3:
              if (field.Type == TType.Struct) {
                ReturnValue = new Variant();
                ReturnValue.Read(iprot);
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 4:
              if (field.Type == TType.Struct) {
                StartTransaction = new TransactionId();
                StartTransaction.Read(iprot);
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
        TStruct struc = new TStruct("SmartStateTransInfo");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (__isset.success) {
          field.Name = "success";
          field.Type = TType.Bool;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          oprot.WriteBool(Success);
          oprot.WriteFieldEnd();
        }
        if (ExecutionFee != null && __isset.executionFee) {
          field.Name = "executionFee";
          field.Type = TType.Struct;
          field.ID = 2;
          oprot.WriteFieldBegin(field);
          ExecutionFee.Write(oprot);
          oprot.WriteFieldEnd();
        }
        if (ReturnValue != null && __isset.returnValue) {
          field.Name = "returnValue";
          field.Type = TType.Struct;
          field.ID = 3;
          oprot.WriteFieldBegin(field);
          ReturnValue.Write(oprot);
          oprot.WriteFieldEnd();
        }
        if (StartTransaction != null && __isset.startTransaction) {
          field.Name = "startTransaction";
          field.Type = TType.Struct;
          field.ID = 4;
          oprot.WriteFieldBegin(field);
          StartTransaction.Write(oprot);
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
      StringBuilder __sb = new StringBuilder("SmartStateTransInfo(");
      bool __first = true;
      if (__isset.success) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Success: ");
        __sb.Append(Success);
      }
      if (ExecutionFee != null && __isset.executionFee) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("ExecutionFee: ");
        __sb.Append(ExecutionFee== null ? "<null>" : ExecutionFee.ToString());
      }
      if (ReturnValue != null && __isset.returnValue) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("ReturnValue: ");
        __sb.Append(ReturnValue== null ? "<null>" : ReturnValue.ToString());
      }
      if (StartTransaction != null && __isset.startTransaction) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("StartTransaction: ");
        __sb.Append(StartTransaction== null ? "<null>" : StartTransaction.ToString());
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}
