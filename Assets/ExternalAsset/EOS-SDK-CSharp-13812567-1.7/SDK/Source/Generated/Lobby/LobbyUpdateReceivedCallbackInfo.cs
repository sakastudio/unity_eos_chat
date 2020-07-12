// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Lobby
{
	/// <summary>
	/// Output parameters for the <see cref="OnLobbyUpdateReceivedCallback" /> Function.
	/// </summary>
	public class LobbyUpdateReceivedCallbackInfo
	{
		/// <summary>
		/// Context that was passed into <see cref="LobbyInterface.AddNotifyLobbyUpdateReceived" />
		/// </summary>
		public object ClientData { get; set; }

		/// <summary>
		/// The id of the lobby affected
		/// </summary>
		public string LobbyId { get; set; }
	}

	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	internal struct LobbyUpdateReceivedCallbackInfoInternal : ICallbackInfo
	{
		private IntPtr m_ClientData;
		[MarshalAs(UnmanagedType.LPStr)]
		private string m_LobbyId;

		public object ClientData
		{
			get
			{
				var value = Helper.GetDefault<object>();
				Helper.TryMarshalGet(m_ClientData, out value);
				return value;
			}
		}

		public IntPtr ClientDataAddress { get { return m_ClientData; } }

		public string LobbyId
		{
			get
			{
				var value = Helper.GetDefault<string>();
				Helper.TryMarshalGet(m_LobbyId, out value);
				return value;
			}
		}
	}
}