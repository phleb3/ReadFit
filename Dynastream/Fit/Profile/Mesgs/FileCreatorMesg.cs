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
   /// Implements the FileCreator profile message.
   /// </summary>  
   public class FileCreatorMesg : Mesg 
   {    
      #region Fields     
      #endregion

      #region Constructors                 
      public FileCreatorMesg() : base(Profile.mesgs[Profile.FileCreatorIndex])               
      {                 
      }
      
      public FileCreatorMesg(Mesg mesg) : base(mesg)
      {
      }
      #endregion // Constructors

      #region Methods    
      ///<summary>      
      /// Retrieves the SoftwareVersion field</summary>
      /// <returns>Returns nullable ushort representing the SoftwareVersion field</returns>      
      public ushort? GetSoftwareVersion()   
      {                
         return (ushort?)GetFieldValue(0, 0, Fit.SubfieldIndexMainField);                     
      }

      /// <summary>        
      /// Set SoftwareVersion field</summary>
      /// <param name="softwareVersion_">Nullable field value to be set</param>      
      public void SetSoftwareVersion(ushort? softwareVersion_) 
      {  
         SetFieldValue(0, 0, softwareVersion_, Fit.SubfieldIndexMainField);
      }
          
      ///<summary>      
      /// Retrieves the HardwareVersion field</summary>
      /// <returns>Returns nullable byte representing the HardwareVersion field</returns>      
      public byte? GetHardwareVersion()   
      {                
         return (byte?)GetFieldValue(1, 0, Fit.SubfieldIndexMainField);                     
      }

      /// <summary>        
      /// Set HardwareVersion field</summary>
      /// <param name="hardwareVersion_">Nullable field value to be set</param>      
      public void SetHardwareVersion(byte? hardwareVersion_) 
      {  
         SetFieldValue(1, 0, hardwareVersion_, Fit.SubfieldIndexMainField);
      }
                        
      #endregion // Methods
   } // Class
} // namespace
