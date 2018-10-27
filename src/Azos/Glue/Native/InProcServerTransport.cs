/*<FILE_LICENSE>
 * Azos (A to Z Application Operating System) Framework
 * The A to Z Foundation (a.k.a. Azist) licenses this file to you under the MIT license.
 * See the LICENSE file in the project root for more information.
</FILE_LICENSE>*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Azos.Glue.Protocol;

namespace Azos.Glue.Native
{
    /// <summary>
    /// Provides server-side functionality for synchronous communication pattern based on
    ///  in-memory message exchange without serialization
    /// </summary>
    public class InProcServerTransport : ServerTransport<InProcBinding>
    {
        #region .ctor

           public InProcServerTransport(InProcBinding binding, ServerEndPoint serverEndpoint) : base(binding, serverEndpoint)
           {
             Node = serverEndpoint.Node;
           }

        #endregion

        #region Fields/Props

        #endregion

        #region Protected

            protected override bool DoSendResponse(ResponseMsg response)
            {
              throw new InvalidGlueOperationException(StringConsts.OPERATION_NOT_SUPPORTED_ERROR + GetType().FullName+".SendResponse()");
            }

        #endregion
    }
}
