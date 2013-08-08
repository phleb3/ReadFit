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
   /// Implements the Monitoring profile message.
   /// </summary>  
   public class MonitoringMesg : Mesg 
   {    
      #region Fields     
      #endregion

      #region Constructors                 
      public MonitoringMesg() : base(Profile.mesgs[Profile.MonitoringIndex])               
      {                 
      }
      
      public MonitoringMesg(Mesg mesg) : base(mesg)
      {
      }
      #endregion // Constructors

      #region Methods    
      ///<summary>      
      /// Retrieves the Timestamp field
      /// Units: s
      /// Comment: Must align to logging interval, for example, time must be 00:00:00 for daily log.</summary>
      /// <returns>Returns DateTime representing the Timestamp field</returns>      
      public DateTime GetTimestamp()   
      {                
         return TimestampToDateTime((uint?)GetFieldValue(253, 0, Fit.SubfieldIndexMainField));                     
      }

      /// <summary>        
      /// Set Timestamp field
      /// Units: s
      /// Comment: Must align to logging interval, for example, time must be 00:00:00 for daily log.</summary>
      /// <param name="timestamp_">Nullable field value to be set</param>      
      public void SetTimestamp(DateTime timestamp_) 
      {  
         SetFieldValue(253, 0, timestamp_.GetTimeStamp(), Fit.SubfieldIndexMainField);
      }
          
      ///<summary>      
      /// Retrieves the DeviceIndex field
      /// Comment: Associates this data to device_info message.  Not required for file with single device (sensor).</summary>
      /// <returns>Returns nullable byte representing the DeviceIndex field</returns>      
      public byte? GetDeviceIndex()   
      {                
         return (byte?)GetFieldValue(0, 0, Fit.SubfieldIndexMainField);                     
      }

      /// <summary>        
      /// Set DeviceIndex field
      /// Comment: Associates this data to device_info message.  Not required for file with single device (sensor).</summary>
      /// <param name="deviceIndex_">Nullable field value to be set</param>      
      public void SetDeviceIndex(byte? deviceIndex_) 
      {  
         SetFieldValue(0, 0, deviceIndex_, Fit.SubfieldIndexMainField);
      }
          
      ///<summary>      
      /// Retrieves the Calories field
      /// Units: kcal</summary>
      /// <returns>Returns nullable ushort representing the Calories field</returns>      
      public ushort? GetCalories()   
      {                
         return (ushort?)GetFieldValue(1, 0, Fit.SubfieldIndexMainField);                     
      }

      /// <summary>        
      /// Set Calories field
      /// Units: kcal</summary>
      /// <param name="calories_">Nullable field value to be set</param>      
      public void SetCalories(ushort? calories_) 
      {  
         SetFieldValue(1, 0, calories_, Fit.SubfieldIndexMainField);
      }
          
      ///<summary>      
      /// Retrieves the Distance field
      /// Units: m</summary>
      /// <returns>Returns nullable float representing the Distance field</returns>      
      public float? GetDistance()   
      {                
         return (float?)GetFieldValue(2, 0, Fit.SubfieldIndexMainField);                     
      }

      /// <summary>        
      /// Set Distance field
      /// Units: m</summary>
      /// <param name="distance_">Nullable field value to be set</param>      
      public void SetDistance(float? distance_) 
      {  
         SetFieldValue(2, 0, distance_, Fit.SubfieldIndexMainField);
      }
          
      ///<summary>      
      /// Retrieves the Cycles field
      /// Units: cycles</summary>
      /// <returns>Returns nullable uint representing the Cycles field</returns>      
      public uint? GetCycles()   
      {                
         return (uint?)GetFieldValue(3, 0, Fit.SubfieldIndexMainField);                     
      }

      /// <summary>        
      /// Set Cycles field
      /// Units: cycles</summary>
      /// <param name="cycles_">Nullable field value to be set</param>      
      public void SetCycles(uint? cycles_) 
      {  
         SetFieldValue(3, 0, cycles_, Fit.SubfieldIndexMainField);
      }
          
      ///<summary>      
      /// Retrieves the ActiveTime field
      /// Units: s</summary>
      /// <returns>Returns nullable float representing the ActiveTime field</returns>      
      public float? GetActiveTime()   
      {                
         return (float?)GetFieldValue(4, 0, Fit.SubfieldIndexMainField);                     
      }

      /// <summary>        
      /// Set ActiveTime field
      /// Units: s</summary>
      /// <param name="activeTime_">Nullable field value to be set</param>      
      public void SetActiveTime(float? activeTime_) 
      {  
         SetFieldValue(4, 0, activeTime_, Fit.SubfieldIndexMainField);
      }
          
      ///<summary>      
      /// Retrieves the ActivityType field</summary>
      /// <returns>Returns nullable ActivityType enum representing the ActivityType field</returns>      
      public ActivityType? GetActivityType()   
      { 
         object obj = GetFieldValue(5, 0, Fit.SubfieldIndexMainField);
         ActivityType? value = obj == null ? (ActivityType?)null : (ActivityType)obj;
         return value;                     
      }

      /// <summary>        
      /// Set ActivityType field</summary>
      /// <param name="activityType_">Nullable field value to be set</param>      
      public void SetActivityType(ActivityType? activityType_) 
      {  
         SetFieldValue(5, 0, activityType_, Fit.SubfieldIndexMainField);
      }
          
      ///<summary>      
      /// Retrieves the ActivitySubtype field</summary>
      /// <returns>Returns nullable ActivitySubtype enum representing the ActivitySubtype field</returns>      
      public ActivitySubtype? GetActivitySubtype()   
      { 
         object obj = GetFieldValue(6, 0, Fit.SubfieldIndexMainField);
         ActivitySubtype? value = obj == null ? (ActivitySubtype?)null : (ActivitySubtype)obj;
         return value;                     
      }

      /// <summary>        
      /// Set ActivitySubtype field</summary>
      /// <param name="activitySubtype_">Nullable field value to be set</param>      
      public void SetActivitySubtype(ActivitySubtype? activitySubtype_) 
      {  
         SetFieldValue(6, 0, activitySubtype_, Fit.SubfieldIndexMainField);
      }
          
      ///<summary>      
      /// Retrieves the CompressedDistance field</summary>
      /// <returns>Returns nullable ushort representing the CompressedDistance field</returns>      
      public ushort? GetCompressedDistance()   
      {                
         return (ushort?)GetFieldValue(8, 0, Fit.SubfieldIndexMainField);                     
      }

      /// <summary>        
      /// Set CompressedDistance field</summary>
      /// <param name="compressedDistance_">Nullable field value to be set</param>      
      public void SetCompressedDistance(ushort? compressedDistance_) 
      {  
         SetFieldValue(8, 0, compressedDistance_, Fit.SubfieldIndexMainField);
      }
          
      ///<summary>      
      /// Retrieves the CompressedCycles field</summary>
      /// <returns>Returns nullable ushort representing the CompressedCycles field</returns>      
      public ushort? GetCompressedCycles()   
      {                
         return (ushort?)GetFieldValue(9, 0, Fit.SubfieldIndexMainField);                     
      }

      /// <summary>        
      /// Set CompressedCycles field</summary>
      /// <param name="compressedCycles_">Nullable field value to be set</param>      
      public void SetCompressedCycles(ushort? compressedCycles_) 
      {  
         SetFieldValue(9, 0, compressedCycles_, Fit.SubfieldIndexMainField);
      }
          
      ///<summary>      
      /// Retrieves the CompressedActiveTime field</summary>
      /// <returns>Returns nullable ushort representing the CompressedActiveTime field</returns>      
      public ushort? GetCompressedActiveTime()   
      {                
         return (ushort?)GetFieldValue(10, 0, Fit.SubfieldIndexMainField);                     
      }

      /// <summary>        
      /// Set CompressedActiveTime field</summary>
      /// <param name="compressedActiveTime_">Nullable field value to be set</param>      
      public void SetCompressedActiveTime(ushort? compressedActiveTime_) 
      {  
         SetFieldValue(10, 0, compressedActiveTime_, Fit.SubfieldIndexMainField);
      }
          
      ///<summary>      
      /// Retrieves the LocalTimestamp field
      /// Comment: Must align to logging interval, for example, time must be 00:00:00 for daily log.</summary>
      /// <returns>Returns nullable uint representing the LocalTimestamp field</returns>      
      public uint? GetLocalTimestamp()   
      {                
         return (uint?)GetFieldValue(11, 0, Fit.SubfieldIndexMainField);                     
      }

      /// <summary>        
      /// Set LocalTimestamp field
      /// Comment: Must align to logging interval, for example, time must be 00:00:00 for daily log.</summary>
      /// <param name="localTimestamp_">Nullable field value to be set</param>      
      public void SetLocalTimestamp(uint? localTimestamp_) 
      {  
         SetFieldValue(11, 0, localTimestamp_, Fit.SubfieldIndexMainField);
      }
                        
      #endregion // Methods
   } // Class
} // namespace
