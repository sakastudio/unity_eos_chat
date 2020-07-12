// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Lobby
{
	/// <summary>
	/// Function prototype definition for notifications that comes from <see cref="LobbyInterface.AddNotifyLobbyMemberUpdateReceived" />
	/// </summary>
	/// <param name="data">A <see cref="LobbyMemberUpdateReceivedCallbackInfo" /> containing the output information and result</param>
	public delegate void OnLobbyMemberUpdateReceivedCallback(LobbyMemberUpdateReceivedCallbackInfo data);

	internal delegate void OnLobbyMemberUpdateReceivedCallbackInternal(IntPtr messagePtr);
}