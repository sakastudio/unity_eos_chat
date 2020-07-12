// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Achievements
{
	/// <summary>
	/// Contains information about a single unlocked achievement.
	/// </summary>
	public class UnlockedAchievement
	{
		/// <summary>
		/// Version of the API.
		/// </summary>
		public int ApiVersion { get { return 1; } }

		/// <summary>
		/// Achievement ID that can be used to uniquely identify the unlocked achievement.
		/// </summary>
		public string AchievementId { get; set; }

		/// <summary>
		/// If not <see cref="AchievementsInterface.AchievementUnlocktimeUndefined" /> then this is the POSIX timestamp that the achievement was unlocked.
		/// </summary>
		public DateTimeOffset? UnlockTime { get; set; }
	}

	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	internal struct UnlockedAchievementInternal : IDisposable
	{
		private int m_ApiVersion;
		[MarshalAs(UnmanagedType.LPStr)]
		private string m_AchievementId;
		private long m_UnlockTime;

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

		public string AchievementId
		{
			get
			{
				var value = Helper.GetDefault<string>();
				Helper.TryMarshalGet(m_AchievementId, out value);
				return value;
			}
			set { Helper.TryMarshalSet(ref m_AchievementId, value); }
		}

		public DateTimeOffset? UnlockTime
		{
			get
			{
				var value = Helper.GetDefault<DateTimeOffset?>();
				Helper.TryMarshalGet(m_UnlockTime, out value);
				return value;
			}
			set { Helper.TryMarshalSet(ref m_UnlockTime, value); }
		}

		public void Dispose()
		{
		}
	}
}