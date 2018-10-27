/*<FILE_LICENSE>
 * Azos (A to Z Application Operating System) Framework
 * The A to Z Foundation (a.k.a. Azist) licenses this file to you under the MIT license.
 * See the LICENSE file in the project root for more information.
</FILE_LICENSE>*/
using System;
using System.Collections.Generic;
using System.Linq;

using Azos.IO.FileSystem;

namespace Azos.Wave.CMS
{
  /// <summary>
  /// Represents NOPCMSBank that does nothing - indicating the absense of any CMS system
  /// </summary>
  public sealed class NOPCMSBank : ICMSBankImplementation
  {

    public static readonly NOPCMSBank Instance = new NOPCMSBank();

    private NOPCMSBank(){}

    public IFileSystemVersion LatestVersion{ get { return null;} }

    public IEnumerable<IFileSystemVersion> Versions { get { return Enumerable.Empty<IFileSystemVersion>(); } }

    public ICMSContext GetContext(Portal portal, IO.FileSystem.IFileSystemVersion version)
    {
      return new NOPCMSContext(portal, version);
    }

    public void Dispose(){ }

    public void Configure(Conf.IConfigSectionNode node){ }

    public bool InstrumentationEnabled {  get {return false; } set{ } }

    public IEnumerable<KeyValuePair<string, Type>> ExternalParameters
    {
      get{ return Enumerable.Empty<KeyValuePair<string, Type>>(); }
    }

    public IEnumerable<KeyValuePair<string, Type>> ExternalParametersForGroups(params string[] groups)
    {
      return Enumerable.Empty<KeyValuePair<string, Type>>();
    }

    public bool ExternalGetParameter(string name, out object value, params string[] groups)
    {
      value = null;
      return false;
    }

    public bool ExternalSetParameter(string name, object value, params string[] groups)
    {
      value = null;
      return false;
    }

    public IFileSystemVersion GetVersionByID(int verID)
    {
      return null;
    }
  }

  /// <summary>
  /// Represents CMS context that does nothing. Returned by NOPCMSBank
  /// </summary>
  public sealed class NOPCMSContext : ICMSContext
  {
    internal NOPCMSContext(Portal portal, IFileSystemVersion version)
    {
      m_Portal = portal;
      m_Version = version;
    }

    private Portal m_Portal;
    private IFileSystemVersion m_Version;

    public Portal Portal { get { return m_Portal; } }

    public IFileSystemVersion Version { get { return m_Version; } }

    public Resource TryNavigate(string path, Data.ICacheParams caching = null)
    {
      return null;
    }

    public void Dispose(){ }


    public DirectoryResource Root
    {
      get { return null; }
    }


    public int VersionID
    {
      get { return 0; }
    }
  }

}
