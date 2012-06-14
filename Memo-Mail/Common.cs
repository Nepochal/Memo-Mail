﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Principal;
using System.Security.Cryptography;
using System.Collections;

namespace Nepochal.MemoMail
{
  public static class Common
  {

    #region Configuration-checks

    public static bool CheckMailAddress(string psMailAddress)
    {
      //Check @
      string[] lsAt = psMailAddress.Split(new char[] { '@' }, StringSplitOptions.RemoveEmptyEntries);
      if (lsAt.Length != 2)
        return false;

      //Check dot
      string[] lsDot = lsAt[1].Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
      if (lsDot.Length < 2)
        return false;

      return lsDot[lsDot.Length - 1].Length > 1;
    }

    public static bool CheckServer(string psServer)
    {
      //Check for URL
      string[] lsDot = psServer.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
      if (lsDot.Length > 1 && lsDot[lsDot.Length - 1].Length > 1)
        return true;

      //Check for valid IPv4
      if (lsDot.Length == 4)
      {
        bool lbValid = true;
        foreach (string lsCur in lsDot)
        {
          int liValue;
          if (!int.TryParse(lsCur, out liValue) || liValue < 0 || liValue > 255)
          {
            lbValid = false;
            break;
          }
        }
        if (lbValid)
          return true;
      }

      //Check for localhost
      return psServer.ToLower() == "localhost";
    }

    #endregion

    #region Crypt-key creation

    public static byte[] CreateKey(string psPassword)
    {
      byte[] lbSha = Common.GetSHAHash(psPassword);
      return Common.SaltHash(lbSha);
    }

    public static byte[] CreateKey()
    {
      return CreateKey(Common.GetSID());
    }

    public static string GetSID()
    {
      NTAccount lnaAccount = new NTAccount(Environment.UserName);
      SecurityIdentifier lsiIdentifier = (SecurityIdentifier)lnaAccount.Translate(typeof(SecurityIdentifier));
      return lsiIdentifier.ToString();
    }

    public static byte[] GetSHAHash(string psValue)
    {
      //convert string into a byte array
      byte[] lbInput = Encoding.Unicode.GetBytes(psValue);

      //calculate hash
      SHA256 lsHasher = SHA256.Create();
      byte[] lbOutput = lsHasher.ComputeHash(lbInput);

      return lbOutput;
    }

    public static byte[] SaltHash(byte[] pbByteArray)
    {
      BitArray lbHashBits = new BitArray(pbByteArray);

      //create a salt-key
      int liSaltKey = 0;
      for (int i = 0; i < 3; i++)
        if (lbHashBits[i])
          liSaltKey += (int)Math.Pow(2, (double)i);

      //no salting when key is 0
      if (liSaltKey == 0)
        return pbByteArray;

      //salt hash using the key
      for (int liCurrentBit = 0; liCurrentBit < lbHashBits.Length; liCurrentBit++)
        if ((liCurrentBit + 1) % liSaltKey == 0)
          lbHashBits[liCurrentBit] = lbHashBits[liCurrentBit] ? false : true;

      byte[] lbReturn = new byte[32];
      lbHashBits.CopyTo(lbReturn, 0);
      return lbReturn;
    }

    #endregion

  }
}