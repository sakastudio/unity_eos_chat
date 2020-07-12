// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Auth
{
	/// <summary>
	/// Intermediate data needed to complete the <see cref="LoginCredentialType.DeviceCode" /> login flow, returned by <see cref="LoginCallbackInfo" />.
	/// The data inside should be exposed to the user for entry on a secondary device
	/// All data must be copied out before the completion of this callback
	/// </summary>
	public class PinGrantInfo
	{
		/// <summary>
		/// Version of the API
		/// </summary>
		public int ApiVersion { get { return 2; } }

		/// <summary>
		/// Code the user must input on an external device to activate the login
		/// </summary>
		public string UserCode { get; set; }

		/// <summary>
		/// The end-user verification URI. Users can be asked to manually type this into their browser.
		/// </summary>
		public string VerificationURI { get; set; }

		/// <summary>
		/// Time the user has, in seconds, to complete the process or else timeout
		/// </summary>
		public int ExpiresIn { get; set; }

		/// <summary>
		/// A verification URI that includes the user code. Useful for non-textual transmission.
		/// </summary>
		public string VerificationURIComplete { get; set; }
	}

	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	internal struct PinGrantInfoInternal : IDisposable
	{
		private int m_ApiVersion;
		[MarshalAs(UnmanagedType.LPStr)]
		private string m_UserCode;
		[MarshalAs(UnmanagedType.LPStr)]
		private string m_VerificationURI;
		private int m_ExpiresIn;
		[MarshalAs(UnmanagedType.LPStr)]
		private string m_VerificationURIComplete;

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

		public string UserCode
		{
			get
			{
				var value = Helper.GetDefault<string>();
				Helper.TryMarshalGet(m_UserCode, out value);
				return value;
			}
			set { Helper.TryMarshalSet(ref m_UserCode, value); }
		}

		public string VerificationURI
		{
			get
			{
				var value = Helper.GetDefault<string>();
				Helper.TryMarshalGet(m_VerificationURI, out value);
				return value;
			}
			set { Helper.TryMarshalSet(ref m_VerificationURI, value); }
		}

		public int ExpiresIn
		{
			get
			{
				var value = Helper.GetDefault<int>();
				Helper.TryMarshalGet(m_ExpiresIn, out value);
				return value;
			}
			set { Helper.TryMarshalSet(ref m_ExpiresIn, value); }
		}

		public string VerificationURIComplete
		{
			get
			{
				var value = Helper.GetDefault<string>();
				Helper.TryMarshalGet(m_VerificationURIComplete, out value);
				return value;
			}
			set { Helper.TryMarshalSet(ref m_VerificationURIComplete, value); }
		}

		public void Dispose()
		{
		}
	}
}