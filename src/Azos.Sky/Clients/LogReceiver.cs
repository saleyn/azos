/*<FILE_LICENSE>
 * Azos (A to Z Application Operating System) Framework
 * The A to Z Foundation (a.k.a. Azist) licenses this file to you under the MIT license.
 * See the LICENSE file in the project root for more information.
</FILE_LICENSE>*/
//Generated by Azos.Sky.Clients.Tools.SkyGluecCompiler

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using Azos.Glue;
using Azos.Glue.Protocol;


namespace Azos.Sky.Clients
{
// This implementation needs @Azos.@Sky.@Contracts.@ILogReceiverClient, so
// it can be used with ServiceClientHub class

  ///<summary>
  /// Client for glued contract Azos.Sky.Contracts.ILogReceiver server.
  /// Each contract method has synchronous and asynchronous versions, the later denoted by 'Async_' prefix.
  /// May inject client-level inspectors here like so:
  ///   client.MsgInspectors.Register( new YOUR_CLIENT_INSPECTOR_TYPE());
  ///</summary>
  public class LogReceiver : ClientEndPoint, @Azos.@Sky.@Contracts.@ILogReceiverClient
  {

  #region Static Members

     private static TypeSpec s_ts_CONTRACT;
     private static MethodSpec @s_ms_SendLog_0;
     private static MethodSpec @s_ms_GetByID_1;
     private static MethodSpec @s_ms_List_2;

     //static .ctor
     static LogReceiver()
     {
         var t = typeof(@Azos.@Sky.@Contracts.@ILogReceiver);
         s_ts_CONTRACT = new TypeSpec(t);
         @s_ms_SendLog_0 = new MethodSpec(t.GetMethod("SendLog", new Type[]{ typeof(@Azos.@Log.@Message) }));
         @s_ms_GetByID_1 = new MethodSpec(t.GetMethod("GetByID", new Type[]{ typeof(@System.@Guid), typeof(@System.@String) }));
         @s_ms_List_2 = new MethodSpec(t.GetMethod("List", new Type[]{ typeof(@System.@String), typeof(@System.@DateTime), typeof(@System.@DateTime), typeof(@System.@Nullable<@Azos.@Log.@MessageType>), typeof(@System.@String), typeof(@System.@String), typeof(@System.@String), typeof(@System.@Nullable<@System.@Guid>), typeof(@System.@Int32) }));
     }
  #endregion

  #region .ctor
     public LogReceiver(IGlue glue, string node, Binding binding = null) : base(glue, node, binding) { ctor(); }
     public LogReceiver(IGlue glue, Node node, Binding binding = null) : base(glue, node, binding) { ctor(); }

     //common instance .ctor body
     private void ctor()
     {

     }

  #endregion

     public override Type Contract
     {
       get { return typeof(@Azos.@Sky.@Contracts.@ILogReceiver); }
     }



  #region Contract Methods

         ///<summary>
         /// Synchronous invoker for  'Azos.Sky.Contracts.ILogReceiver.SendLog'.
         /// This is a one-way call per contract specification, meaning - the server sends no acknowledgement of this call receipt and
         /// there is no result that server could return back to the caller.
         /// ClientCallException is thrown if the call could not be placed in the outgoing queue.
         ///</summary>
         public void @SendLog(@Azos.@Log.@Message  @data)
         {
            var call = Async_SendLog(@data);
            if (call.CallStatus != CallStatus.Dispatched)
                throw new ClientCallException(call.CallStatus, "Call failed: 'LogReceiver.SendLog'");
         }

         ///<summary>
         /// Asynchronous invoker for  'Azos.Sky.Contracts.ILogReceiver.SendLog'.
         /// This is a one-way call per contract specification, meaning - the server sends no acknowledgement of this call receipt and
         /// there is no result that server could return back to the caller.
         /// CallSlot is returned that can be queried for CallStatus, ResponseMsg.
         ///</summary>
         public CallSlot Async_SendLog(@Azos.@Log.@Message  @data)
         {
            var request = new @Azos.@Sky.@Contracts.@RequestMsg_ILogReceiver_SendLog(s_ts_CONTRACT, @s_ms_SendLog_0, true, RemoteInstance)
            {
               MethodArg_0_data = @data,
            };
            return DispatchCall(request);
         }



         ///<summary>
         /// Synchronous invoker for  'Azos.Sky.Contracts.ILogReceiver.GetByID'.
         /// This is a two-way call per contract specification, meaning - the server sends the result back either
         ///  returning '@Azos@Log.@Message' or WrappedExceptionData instance.
         /// ClientCallException is thrown if the call could not be placed in the outgoing queue.
         /// RemoteException is thrown if the server generated exception during method execution.
         ///</summary>
         public @Azos.@Log.@Message @GetByID(@System.@Guid  @id, Atom  @channel)
         {
            var call = Async_GetByID(@id, @channel);
            return call.GetValue<@Azos.@Log.@Message>();
         }

         ///<summary>
         /// Asynchronous invoker for  'Azos.Sky.Contracts.ILogReceiver.GetByID'.
         /// This is a two-way call per contract specification, meaning - the server sends the result back either
         ///  returning no exception or WrappedExceptionData instance.
         /// CallSlot is returned that can be queried for CallStatus, ResponseMsg and result.
         ///</summary>
         public CallSlot Async_GetByID(@System.@Guid  @id, Atom  @channel)
         {
            var request = new RequestAnyMsg(s_ts_CONTRACT, @s_ms_GetByID_1, false, RemoteInstance, new object[]{@id, @channel});
            return DispatchCall(request);
         }



         ///<summary>
         /// Synchronous invoker for  'Azos.Sky.Contracts.ILogReceiver.List'.
         /// This is a two-way call per contract specification, meaning - the server sends the result back either
         ///  returning '@System.@Collections.@Generic.@IEnumerable[@Azos.@Log.@Message]' or WrappedExceptionData instance.
         /// ClientCallException is thrown if the call could not be placed in the outgoing queue.
         /// RemoteException is thrown if the server generated exception during method execution.
         ///</summary>
         public @System.@Collections.@Generic.@IEnumerable<@Azos.@Log.@Message> @List(Atom channel, @System.@String  @archiveDimensionsFilter, @System.@DateTime  @startDate, @System.@DateTime  @endDate, @System.@Nullable<@Azos.@Log.@MessageType>  @type, @System.@String  @host, @System.@String  @topic, @System.@Nullable<@System.@Guid>  @relatedTo, @System.@Int32  @skipCount)
         {
            var call = Async_List(channel, @archiveDimensionsFilter, @startDate, @endDate, @type, @host, @topic, @relatedTo, @skipCount);
            return call.GetValue<@System.@Collections.@Generic.@IEnumerable<@Azos.@Log.@Message>>();
         }

         ///<summary>
         /// Asynchronous invoker for  'Azos.Sky.Contracts.ILogReceiver.List'.
         /// This is a two-way call per contract specification, meaning - the server sends the result back either
         ///  returning no exception or WrappedExceptionData instance.
         /// CallSlot is returned that can be queried for CallStatus, ResponseMsg and result.
         ///</summary>
         public CallSlot Async_List(Atom channel, @System.@String  @archiveDimensionsFilter, @System.@DateTime  @startDate, @System.@DateTime  @endDate, @System.@Nullable<@Azos.@Log.@MessageType>  @type, @System.@String  @host, @System.@String  @topic, @System.@Nullable<@System.@Guid>  @relatedTo, @System.@Int32  @skipCount)
         {
            var request = new RequestAnyMsg(s_ts_CONTRACT, @s_ms_List_2, false, RemoteInstance, new object[]{ @channel, @archiveDimensionsFilter, @startDate, @endDate, @type, @host, @topic, @relatedTo, @skipCount});
            return DispatchCall(request);
         }


  #endregion

  }//class
}//namespace
