/*
This file is part of the Memo-Mail Source Code.  

Memo-Mail is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

Memo-Mail is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with Memo-Mail. If not, see <http://www.gnu.org/licenses/gpl.html>.

The complete source code can be found at <https://github.com/Nepochal/Memo-Mail>.
The installer for the current version can be found at [PLACEHOLDER].
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Security.Cryptography;
using System.Drawing;

namespace Nepochal.MemoMail
{
  public class Config
  {

    #region Accessors

    public string SmtpServer
    {
      get { return msSmtpServer; }
      set { msSmtpServer = value; }
    }

    public string Username
    {
      get { return msUsername; }
      set { msUsername = value; }
    }

    public string Password
    {
      get { return msPassword; }
      set { msPassword = value; }
    }

    public string SmtpAddress
    {
      get { return msSmtpAddress; }
      set { msSmtpAddress = value; }
    }

    public string ReceiverAddress
    {
      get { return msReceiverAddress; }
      set { msReceiverAddress = value; }
    }

    public string Header
    {
      get { return msHeader; }
      set { msHeader = value; }
    }

    public int Port
    {
      get { return miPort; }
      set { miPort = value; }
    }

    public string From
    {
      get { return msFrom; }
      set { msFrom = value; }
    }

    public bool AlwaysUseDefaultheader
    {
      get { return mbAlwaysUseDefaultHeader; }
      set { mbAlwaysUseDefaultHeader = value; }
    }

    public bool SendMailOnDoubleEnter
    {
      get { return mbSendMailOnDoubleEnter; }
      set { mbSendMailOnDoubleEnter = value; }
    }

    public bool Clipboard2Mail
    {
      get { return mbClipboard2Mail; }
      set { mbClipboard2Mail = value; }
    }

    public bool ShowManual
    {
      get { return mbShowManual; }
      set { mbShowManual = value; }
    }

    public Point LocationSendForm
    {
      get { return mpSendFormPosition; }
      set { mpSendFormPosition = value; }
    }

    public int WidthSendForm
    {
      get { return miSendFormWidth; }
      set { miSendFormWidth = value; }
    }

    public int HeightSendForm
    {
      get { return miSendFormHeight; }
      set { miSendFormHeight = value; }
    }

    public Point LocationHelp
    {
      get { return mpHelpPosition; }
      set { mpHelpPosition = value; }
    }

    public Point LocationConfiguration
    {
      get { return mpConfigPosition; }
      set { mpConfigPosition = value; }
    }

    #endregion

    #region Member Variables

    private string msSmtpServer;
    private string msUsername;
    private string msPassword;
    private string msSmtpAddress;
    private string msReceiverAddress;
    private string msHeader;
    private int miPort;
    private string msFrom;
    private bool mbAlwaysUseDefaultHeader = false;
    private bool mbSendMailOnDoubleEnter = false;
    private bool mbClipboard2Mail = false;
    private bool mbShowManual = true;
    private Point mpSendFormPosition = new Point(200, 200);
    private int miSendFormHeight = 80;
    private int miSendFormWidth = 420;
    private Point mpConfigPosition = new Point(200, 200);
    private Point mpHelpPosition = new Point(200, 200);

    #endregion

    #region ctors

    public Config()
    {
    }

    #endregion

    #region Methods

    internal static bool SaveConfig(Config pcConfig, byte[] pbKey)
    {
      if (pbKey.Length != 32)
        return false;

      try
      {
        Rijndael lrCrypto = Rijndael.Create();
        lrCrypto.KeySize = 256;
        lrCrypto.IV = Encoding.ASCII.GetBytes("nepochalnepochal");
        lrCrypto.Key = pbKey;

        string lsFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Memo-Mail");
        if (!Directory.Exists(lsFilePath))
          Directory.CreateDirectory(lsFilePath);
        lsFilePath = Path.Combine(lsFilePath, "Config.ini");

        FileStream lfsFile = new FileStream(lsFilePath, FileMode.Create, FileAccess.Write);
        CryptoStream lcsEncrypt = new CryptoStream(lfsFile, lrCrypto.CreateEncryptor(), CryptoStreamMode.Write);
        StreamWriter lswWriter = new StreamWriter(lcsEncrypt, Encoding.Unicode);
        XmlSerializer lxsSerializer = new XmlSerializer(typeof(Config));

        lxsSerializer.Serialize(lswWriter, pcConfig);

        lswWriter.Flush();
        lswWriter.Close();

        lswWriter.Dispose();
        lfsFile.Dispose();

        return true;
      }
      catch (Exception)
      {
        return false;
      }
    }

    internal static Config LoadConfig(byte[] pbKey)
    {
      if (pbKey.Length != 32)
        return null;

      try
      {
        string lsFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Memo-Mail");
        lsFilePath = Path.Combine(lsFilePath, "Config.ini");
        if(!File.Exists(lsFilePath))
          return null;

        Config lcConfig = null;

        Rijndael lrCrypto = Rijndael.Create();
        lrCrypto.KeySize = 256;
        lrCrypto.IV = Encoding.ASCII.GetBytes("nepochalnepochal");
        lrCrypto.Key = pbKey;

        FileStream lfsFile = new FileStream(lsFilePath, FileMode.Open, FileAccess.Read);
        CryptoStream lcsDecrypt = new CryptoStream(lfsFile, lrCrypto.CreateDecryptor(), CryptoStreamMode.Read);
        StreamReader lsrReader = new StreamReader(lcsDecrypt, Encoding.Unicode);
        XmlSerializer lxsSerializer = new XmlSerializer(typeof(Config));

        lcConfig = (Config)lxsSerializer.Deserialize(lsrReader);

        lsrReader.Close();
        lsrReader.Dispose();
        lfsFile.Dispose();

        return lcConfig;
      }
      catch
      {
        return null;
      }
    }

    #endregion

  }
}
