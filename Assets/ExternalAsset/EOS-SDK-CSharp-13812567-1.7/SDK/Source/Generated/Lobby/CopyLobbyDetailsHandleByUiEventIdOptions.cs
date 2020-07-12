// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Lobby
{
	/// <summary>
	/// Input parameters for the <see cref="LobbyInterface.CopyLobbyDetailsHandleByUiEventId" /> Function.
	/// </summary>
	public class CopyLobbyDetailsHandleByUiEventIdOptions
	{
		/// <summary>
		/// Version of the API
		/// </summary>
		public int ApiVersion { get { return 1; } }

		/// <summary>
		/// UI Event associated with the session
		/// </summary>
		public ulong UiEventId { get; set; }
	}

	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	internal struct CopyLobbyDetailsHandleByUiEventIdOptionsInternal : IDisposable
	{
		private int m_ApiVersion;
		private ulong m_UiEventId;

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

		public ulong UiEventId
		{
			get
			{
				var value = Helper.GetDefault<ulong>();
				Helper.TryMarshalGet(m_UiEventId, out value);
				return value;
			}
			set { Helper.TryMarshalSet(ref m_UiEventId, value); }
		}

		public void Dispose()
		{
		}
	}
}