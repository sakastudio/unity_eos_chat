// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Sessions
{
	/// <summary>
	/// Output parameters for the <see cref="OnSessionInviteReceivedCallback" /> Function.
	/// </summary>
	public class SessionInviteReceivedCallbackInfo
	{
		/// <summary>
		/// Context that was passed into <see cref="SessionsInterface.AddNotifySessionInviteReceived" />
		/// </summary>
		public object ClientData { get; set; }

		/// <summary>
		/// User that received the invite
		/// </summary>
		public ProductUserId LocalUserId { get; set; }

		/// <summary>
		/// Target user that sent the invite
		/// </summary>
		public ProductUserId TargetUserId { get; set; }

		/// <summary>
		/// Invite Id used to retrieve the actual session details
		/// </summary>
		public string InviteId { get; set; }
	}

	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	internal struct SessionInviteReceivedCallbackInfoInternal : ICallbackInfo
	{
		private IntPtr m_ClientData;
		private IntPtr m_LocalUserId;
		private IntPtr m_TargetUserId;
		[MarshalAs(UnmanagedType.LPStr)]
		private string m_InviteId;

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

		public ProductUserId LocalUserId
		{
			get
			{
				var value = Helper.GetDefault<ProductUserId>();
				Helper.TryMarshalGet(m_LocalUserId, out value);
				return value;
			}
		}

		public ProductUserId TargetUserId
		{
			get
			{
				var value = Helper.GetDefault<ProductUserId>();
				Helper.TryMarshalGet(m_TargetUserId, out value);
				return value;
			}
		}

		public string InviteId
		{
			get
			{
				var value = Helper.GetDefault<string>();
				Helper.TryMarshalGet(m_InviteId, out value);
				return value;
			}
		}
	}
}