// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Stats
{
	/// <summary>
	/// Input parameters for the <see cref="StatsInterface.QueryStats" /> Function.
	/// </summary>
	public class QueryStatsOptions
	{
		/// <summary>
		/// API Version.
		/// </summary>
		public int ApiVersion { get { return 1; } }

		/// <summary>
		/// The account ID for the user whose stats are to be retrieved.
		/// </summary>
		public ProductUserId UserId { get; set; }

		/// <summary>
		/// If not <see cref="StatsInterface.TimeUndefined" /> then this is the POSIX timestamp for start time (Optional).
		/// </summary>
		public DateTimeOffset? StartTime { get; set; }

		/// <summary>
		/// If not <see cref="StatsInterface.TimeUndefined" /> then this is the POSIX timestamp for end time (Optional).
		/// </summary>
		public DateTimeOffset? EndTime { get; set; }

		/// <summary>
		/// An array of stat names to query for (Optional).
		/// </summary>
		public string[] StatNames { get; set; }

	}

	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	internal struct QueryStatsOptionsInternal : IDisposable
	{
		private int m_ApiVersion;
		private IntPtr m_UserId;
		private long m_StartTime;
		private long m_EndTime;
		private IntPtr m_StatNames;
		private uint m_StatNamesCount;

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

		public ProductUserId UserId
		{
			get
			{
				var value = Helper.GetDefault<ProductUserId>();
				Helper.TryMarshalGet(m_UserId, out value);
				return value;
			}
			set { Helper.TryMarshalSet(ref m_UserId, value); }
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

		public string[] StatNames
		{
			get
			{
				var value = Helper.GetDefault<string[]>();
				Helper.TryMarshalGet(m_StatNames, out value, m_StatNamesCount);
				return value;
			}
			set { Helper.TryMarshalSet(ref m_StatNames, value, out m_StatNamesCount); }
		}


		public void Dispose()
		{
			Helper.TryMarshalDispose(ref m_StatNames);
		}
	}
}