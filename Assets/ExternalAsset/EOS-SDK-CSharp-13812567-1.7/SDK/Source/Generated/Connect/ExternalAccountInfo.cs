// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Connect
{
	/// <summary>
	/// Contains information about an external account info
	/// </summary>
	public class ExternalAccountInfo
	{
		/// <summary>
		/// Version of the API.
		/// </summary>
		public int ApiVersion { get { return 1; } }

		/// <summary>
		/// Product user id of the target user.
		/// </summary>
		public ProductUserId ProductUserId { get; set; }

		/// <summary>
		/// Display name, can be null if not set.
		/// </summary>
		public string DisplayName { get; set; }

		/// <summary>
		/// External account id.
		/// </summary>
		public string AccountId { get; set; }

		/// <summary>
		/// The identity provider that owns the external account.
		/// </summary>
		public ExternalAccountType AccountIdType { get; set; }

		/// <summary>
		/// The POSIX timestamp for the time the user last logged in, or <see cref="ConnectInterface.TimeUndefined" />.
		/// </summary>
		public DateTimeOffset? LastLoginTime { get; set; }
	}

	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	internal struct ExternalAccountInfoInternal : IDisposable
	{
		private int m_ApiVersion;
		private IntPtr m_ProductUserId;
		[MarshalAs(UnmanagedType.LPStr)]
		private string m_DisplayName;
		[MarshalAs(UnmanagedType.LPStr)]
		private string m_AccountId;
		private ExternalAccountType m_AccountIdType;
		private long m_LastLoginTime;

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

		public ProductUserId ProductUserId
		{
			get
			{
				var value = Helper.GetDefault<ProductUserId>();
				Helper.TryMarshalGet(m_ProductUserId, out value);
				return value;
			}
			set { Helper.TryMarshalSet(ref m_ProductUserId, value); }
		}

		public string DisplayName
		{
			get
			{
				var value = Helper.GetDefault<string>();
				Helper.TryMarshalGet(m_DisplayName, out value);
				return value;
			}
			set { Helper.TryMarshalSet(ref m_DisplayName, value); }
		}

		public string AccountId
		{
			get
			{
				var value = Helper.GetDefault<string>();
				Helper.TryMarshalGet(m_AccountId, out value);
				return value;
			}
			set { Helper.TryMarshalSet(ref m_AccountId, value); }
		}

		public ExternalAccountType AccountIdType
		{
			get
			{
				var value = Helper.GetDefault<ExternalAccountType>();
				Helper.TryMarshalGet(m_AccountIdType, out value);
				return value;
			}
			set { Helper.TryMarshalSet(ref m_AccountIdType, value); }
		}

		public DateTimeOffset? LastLoginTime
		{
			get
			{
				var value = Helper.GetDefault<DateTimeOffset?>();
				Helper.TryMarshalGet(m_LastLoginTime, out value);
				return value;
			}
			set { Helper.TryMarshalSet(ref m_LastLoginTime, value); }
		}

		public void Dispose()
		{
		}
	}
}