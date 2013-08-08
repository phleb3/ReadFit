#region Copyright
////////////////////////////////////////////////////////////////////////////////
// The following FIT Protocol software provided may be used with FIT protocol
// devices only and remains the copyrighted property of Dynastream Innovations Inc.
// The software is being provided on an "as-is" basis and as an accommodation,
// and therefore all warranties, representations, or guarantees of any kind
// (whether express, implied or statutory) including, without limitation,
// warranties of merchantability, non-infringement, or fitness for a particular
// purpose, are specifically disclaimed.
//
// Copyright 2013 Dynastream Innovations Inc.
////////////////////////////////////////////////////////////////////////////////
// ****WARNING****  This file is auto-generated!  Do NOT edit this file.
// Profile Version = 6.10Release
// Tag = $Name:  $
////////////////////////////////////////////////////////////////////////////////

#endregion

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.IO;


namespace Dynastream.Fit
{
   /// <summary>
   /// Implements the Hrv profile message.
   /// </summary>  
   public class HrvMesg : Mesg 
   {    
      #region Fields     
      #endregion

      #region Constructors                 
      public HrvMesg() : base(Profile.mesgs[Profile.HrvIndex])               
      {                 
      }
      
      public HrvMesg(Mesg mesg) : base(mesg)
      {
      }
      #endregion // Constructors

      #region Methods    
      
      /// <summary>
      /// 
      /// </summary>  
      /// <returns>returns number of elements in field Time</returns>      
      public int GetNumTime() 
      {
         return GetNumFieldValues(0, Fit.SubfieldIndexMainField);
      }

      ///<summary>      
      /// Retrieves the Time field
      /// Units: s
      /// Comment: Time between beats</summary>
      /// <param name="index">0 based index of Time element to retrieve</param>
      /// <returns>Returns nullable float representing the Time field</returns>      
      public float? GetTime(int index)   
      {                
         return (float?)GetFieldValue(0, index, Fit.SubfieldIndexMainField);                     
      }

      /// <summary>        
      /// Set Time field
      /// Units: s
      /// Comment: Time between beats</summary>      
      /// <param name="index">0 based index of time</param>
      /// <param name="time_">Nullable field value to be set</param>      
      public void SetTime(int index, float? time_) 
      {  
         SetFieldValue(0, index, time_, Fit.SubfieldIndexMainField);
      }
                        
      #endregion // Methods
   } // Class
} // namespace
