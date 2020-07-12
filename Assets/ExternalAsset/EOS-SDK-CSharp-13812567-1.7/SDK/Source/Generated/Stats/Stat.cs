// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Stats
{
	/// <summary>
	/// Contains information about a single player stat.
	/// </summary>
	public class Stat
	{
		/// <summary>
		/// Version of the API.
		/// </summary>
		public int ApiVersion { get { return 1; } }

		/// <summary>
		/// Name of the stat.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// If not <see cref="StatsInterface.TimeUndefined" /> then this is the POSIX timestamp for start time.
		/// </summary>
		public DateTimeOffset? StartTime { get; set; }

		/// <summary>
		/// If not <see cref="StatsInterface.TimeUndefined" /> then this is the POSIX timestamp for end time.
		/// </summary>
		public DateTimeOffset? EndTime { get; set; }

		/// <summary>
		/// Current value for the stat.
		/// </summary>
		public int Value { get; set; }
	}

	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	internal struct StatInternal : IDisposable
	{
		private int m_ApiVersion;
		[MarshalAs(UnmanagedType.LPStr)]
		private string m_Name;
		private long m_StartTime;
		private long m_EndTime;
		private int m_Value;

		public int ApiVersion
		{
			get
			{
				var value = Helper.GetDefault<int>();
				Helper.TryMarshalGet(m_ApiVersion, out value);
				return value;
			}
			set { Helper.TryMarshalSet(ref m_ApiVersion, value); }
		}

		public string Name
		{
			get
			{
				var value = Helper.GetDefault<string>();
				Helper.TryMarshalGet(m_Name, out value);
				return value;
			}
			set { Helper.TryMarshalSet(ref m_Name, value); }
		}

		public DateTimeOffset? StartTime
		{
			get
			{
				var value = Helper.GetDefault<DateTimeOffset?>();
				Helper.TryMarshalGet(m_StartTime, out value);
				return value;
			}
			set { Helper.TryMarshalSet(ref m_StartTime, value); }
		}

		public DateTimeOffset? EndTime
		{
			get
			{
				var value = Helper.GetDefault<DateTimeOffset?>();
				Helper.TryMarshalGet(m_EndTime, out value);
				return value;
			}
			set { Helper.TryMarshalSet(ref m_EndTime, value); }
		}

		public int Value
		{
			get
			{
				var value = Helper.GetDefault<int>();
				Helper.TryMarshalGet(m_Value, out value);
				return value;
			}
			set { Helper.TryMarshalSet(ref m_Value, value); }
		}

		public void Dispose()
		{
		}
	}
}