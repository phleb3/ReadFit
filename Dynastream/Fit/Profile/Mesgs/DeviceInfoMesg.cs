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
   /// Implements the DeviceInfo profile message.
   /// </summary>  
   public class DeviceInfoMesg : Mesg 
   {    
      #region Fields     
      #endregion

      #region Constructors                 
      public DeviceInfoMesg() : base(Profile.mesgs[Profile.DeviceInfoIndex])               
      {                 
      }
      
      public DeviceInfoMesg(Mesg mesg) : base(mesg)
      {
      }
      #endregion // Constructors

      #region Methods    
      ///<summary>      
      /// Retrieves the Timestamp field
      /// Units: s</summary>
      /// <returns>Returns DateTime representing the Timestamp field</returns>      
      public DateTime GetTimestamp()   
      {                
         return TimestampToDateTime((uint?)GetFieldValue(253, 0, Fit.SubfieldIndexMainField));                     
      }

      /// <summary>        
      /// Set Timestamp field
      /// Units: s</summary>
      /// <param name="timestamp_">Nullable field value to be set</param>      
      public void SetTimestamp(DateTime timestamp_) 
      {  
         SetFieldValue(253, 0, timestamp_.GetTimeStamp(), Fit.SubfieldIndexMainField);
      }
          
      ///<summary>      
      /// Retrieves the DeviceIndex field</summary>
      /// <returns>Returns nullable byte representing the DeviceIndex field</returns>      
      public byte? GetDeviceIndex()   
      {                
         return (byte?)GetFieldValue(0, 0, Fit.SubfieldIndexMainField);                     
      }

      /// <summary>        
      /// Set DeviceIndex field</summary>
      /// <param name="deviceIndex_">Nullable field value to be set</param>      
      public void SetDeviceIndex(byte? deviceIndex_) 
      {  
         SetFieldValue(0, 0, deviceIndex_, Fit.SubfieldIndexMainField);
      }
          
      ///<summary>      
      /// Retrieves the DeviceType field</summary>
      /// <returns>Returns nullable byte representing the DeviceType field</returns>      
      public byte? GetDeviceType()   
      {                
         return (byte?)GetFieldValue(1, 0, Fit.SubfieldIndexMainField);                     
      }

      /// <summary>        
      /// Set DeviceType field</summary>
      /// <param name="deviceType_">Nullable field value to be set</param>      
      public void SetDeviceType(byte? deviceType_) 
      {  
         SetFieldValue(1, 0, deviceType_, Fit.SubfieldIndexMainField);
      }
          
      ///<summary>      
      /// Retrieves the Manufacturer field</summary>
      /// <returns>Returns nullable ushort representing the Manufacturer field</returns>      
      public ushort? GetManufacturer()   
      {                
         return (ushort?)GetFieldValue(2, 0, Fit.SubfieldIndexMainField);                     
      }

      /// <summary>        
      /// Set Manufacturer field</summary>
      /// <param name="manufacturer_">Nullable field value to be set</param>      
      public void SetManufacturer(ushort? manufacturer_) 
      {  
         SetFieldValue(2, 0, manufacturer_, Fit.SubfieldIndexMainField);
      }
          
      ///<summary>      
      /// Retrieves the SerialNumber field</summary>
      /// <returns>Returns nullable uint representing the SerialNumber field</returns>      
      public uint? GetSerialNumber()   
      {                
         return (uint?)GetFieldValue(3, 0, Fit.SubfieldIndexMainField);                     
      }

      /// <summary>        
      /// Set SerialNumber field</summary>
      /// <param name="serialNumber_">Nullable field value to be set</param>      
      public void SetSerialNumber(uint? serialNumber_) 
      {  
         SetFieldValue(3, 0, serialNumber_, Fit.SubfieldIndexMainField);
      }
          
      ///<summary>      
      /// Retrieves the Product field</summary>
      /// <returns>Returns nullable ushort representing the Product field</returns>      
      public ushort? GetProduct()   
      {                
         return (ushort?)GetFieldValue(4, 0, Fit.SubfieldIndexMainField);                     
      }

      /// <summary>        
      /// Set Product field</summary>
      /// <param name="product_">Nullable field value to be set</param>      
      public void SetProduct(ushort? product_) 
      {  
         SetFieldValue(4, 0, product_, Fit.SubfieldIndexMainField);
      }
          
      ///<summary>      
      /// Retrieves the SoftwareVersion field</summary>
      /// <returns>Returns nullable float representing the SoftwareVersion field</returns>      
      public float? GetSoftwareVersion()   
      {                
         return (float?)GetFieldValue(5, 0, Fit.SubfieldIndexMainField);                     
      }

      /// <summary>        
      /// Set SoftwareVersion field</summary>
      /// <param name="softwareVersion_">Nullable field value to be set</param>      
      public void SetSoftwareVersion(float? softwareVersion_) 
      {  
         SetFieldValue(5, 0, softwareVersion_, Fit.SubfieldIndexMainField);
      }
          
      ///<summary>      
      /// Retrieves the HardwareVersion field</summary>
      /// <returns>Returns nullable byte representing the HardwareVersion field</returns>      
      public byte? GetHardwareVersion()   
      {                
         return (byte?)GetFieldValue(6, 0, Fit.SubfieldIndexMainField);                     
      }

      /// <summary>        
      /// Set HardwareVersion field</summary>
      /// <param name="hardwareVersion_">Nullable field value to be set</param>      
      public void SetHardwareVersion(byte? hardwareVersion_) 
      {  
         SetFieldValue(6, 0, hardwareVersion_, Fit.SubfieldIndexMainField);
      }
          
      ///<summary>      
      /// Retrieves the CumOperatingTime field
      /// Units: s
      /// Comment: Reset by new battery or charge.</summary>
      /// <returns>Returns nullable uint representing the CumOperatingTime field</returns>      
      public uint? GetCumOperatingTime()   
      {                
         return (uint?)GetFieldValue(7, 0, Fit.SubfieldIndexMainField);                     
      }

      /// <summary>        
      /// Set CumOperatingTime field
      /// Units: s
      /// Comment: Reset by new battery or charge.</summary>
      /// <param name="cumOperatingTime_">Nullable field value to be set</param>      
      public void SetCumOperatingTime(uint? cumOperatingTime_) 
      {  
         SetFieldValue(7, 0, cumOperatingTime_, Fit.SubfieldIndexMainField);
      }
          
      ///<summary>      
      /// Retrieves the BatteryVoltage field
      /// Units: V</summary>
      /// <returns>Returns nullable float representing the BatteryVoltage field</returns>      
      public float? GetBatteryVoltage()   
      {                
         return (float?)GetFieldValue(10, 0, Fit.SubfieldIndexMainField);                     
      }

      /// <summary>        
      /// Set BatteryVoltage field
      /// Units: V</summary>
      /// <param name="batteryVoltage_">Nullable field value to be set</param>      
      public void SetBatteryVoltage(float? batteryVoltage_) 
      {  
         SetFieldValue(10, 0, batteryVoltage_, Fit.SubfieldIndexMainField);
      }
          
      ///<summary>      
      /// Retrieves the BatteryStatus field</summary>
      /// <returns>Returns nullable byte representing the BatteryStatus field</returns>      
      public byte? GetBatteryStatus()   
      {                
         return (byte?)GetFieldValue(11, 0, Fit.SubfieldIndexMainField);                     
      }

      /// <summary>        
      /// Set BatteryStatus field</summary>
      /// <param name="batteryStatus_">Nullable field value to be set</param>      
      public void SetBatteryStatus(byte? batteryStatus_) 
      {  
         SetFieldValue(11, 0, batteryStatus_, Fit.SubfieldIndexMainField);
      }
                        
      #endregion // Methods
   } // Class
} // namespace
