// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Lobby
{
	/// <summary>
	/// Input parameters for the <see cref="LobbyDetails.GetMemberAttributeCount" /> Function.
	/// </summary>
	public class LobbyDetailsGetMemberAttributeCountOptions
	{
		/// <summary>
		/// Version of the API
		/// </summary>
		public int ApiVersion { get { return 1; } }

		/// <summary>
		/// Lobby member of interest
		/// </summary>
		public ProductUserId TargetUserId { get; set; }
	}

	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	internal struct LobbyDetailsGetMemberAttributeCountOptionsInternal : IDisposable
	{
		private int m_ApiVersion;
		private IntPtr m_TargetUserId;

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

		public ProductUserId TargetUserId
		{
			get
			{
				var value = Helper.GetDefault<ProductUserId>();
				Helper.TryMarshalGet(m_TargetUserId, out value);
				return value;
			}
			set { Helper.TryMarshalSet(ref m_TargetUserId, value); }
		}

		public void Dispose()
		{
		}
	}
}