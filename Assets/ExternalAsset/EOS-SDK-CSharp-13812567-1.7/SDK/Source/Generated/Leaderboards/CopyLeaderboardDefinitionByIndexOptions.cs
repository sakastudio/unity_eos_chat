// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Leaderboards
{
	/// <summary>
	/// Input parameters for the <see cref="LeaderboardsInterface.CopyLeaderboardDefinitionByIndex" /> Function.
	/// </summary>
	public class CopyLeaderboardDefinitionByIndexOptions
	{
		/// <summary>
		/// API Version of the <see cref="CopyLeaderboardDefinitionByIndexOptions" /> function
		/// </summary>
		public int ApiVersion { get { return 1; } }

		/// <summary>
		/// Index of the leaderboard definition to retrieve from the cache
		/// </summary>
		public uint LeaderboardIndex { get; set; }
	}

	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	internal struct CopyLeaderboardDefinitionByIndexOptionsInternal : IDisposable
	{
		private int m_ApiVersion;
		private uint m_LeaderboardIndex;

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

		public uint LeaderboardIndex
		{
			get
			{
				var value = Helper.GetDefault<uint>();
				Helper.TryMarshalGet(m_LeaderboardIndex, out value);
				return value;
			}
			set { Helper.TryMarshalSet(ref m_LeaderboardIndex, value); }
		}

		public void Dispose()
		{
		}
	}
}