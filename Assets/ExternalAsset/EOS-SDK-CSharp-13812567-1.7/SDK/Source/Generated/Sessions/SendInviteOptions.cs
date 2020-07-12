// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Sessions
{
	/// <summary>
	/// Input parameters for the <see cref="SessionsInterface.SendInvite" /> Function.
	/// </summary>
	public class SendInviteOptions
	{
		/// <summary>
		/// Version of the API
		/// </summary>
		public int ApiVersion { get { return 1; } }

		/// <summary>
		/// Name of the session associated with the invite
		/// </summary>
		public string SessionName { get; set; }

		/// <summary>
		/// The local user inviting
		/// </summary>
		public ProductUserId LocalUserId { get; set; }

		/// <summary>
		/// The remote user being invited
		/// </summary>
		public ProductUserId TargetUserId { get; set; }
	}

	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	internal struct SendInviteOptionsInternal : IDisposable
	{
		private int m_ApiVersion;
		[MarshalAs(UnmanagedType.LPStr)]
		private string m_SessionName;
		private IntPtr m_LocalUserId;
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

		public string SessionName
		{
			get
			{
				var value = Helper.GetDefault<string>();
				Helper.TryMarshalGet(m_SessionName, out value);
				return value;
			}
			set { Helper.TryMarshalSet(ref m_SessionName, value); }
		}

		public ProductUserId LocalUserId
		{
			get
			{
				var value = Helper.GetDefault<ProductUserId>();
				Helper.TryMarshalGet(m_LocalUserId, out value);
				return value;
			}
			set { Helper.TryMarshalSet(ref m_LocalUserId, value); }
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