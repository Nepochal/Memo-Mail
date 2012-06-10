using System;
using System.Collections.Generic;
using System.Text;

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

  }
}
