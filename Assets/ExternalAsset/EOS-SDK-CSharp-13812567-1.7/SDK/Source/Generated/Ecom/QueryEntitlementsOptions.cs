// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Ecom
{
	/// <summary>
	/// Input parameters for the <see cref="EcomInterface.QueryEntitlements" /> Function.
	/// </summary>
	public class QueryEntitlementsOptions
	{
		/// <summary>
		/// Version of the API
		/// </summary>
		public int ApiVersion { get { return 2; } }

		/// <summary>
		/// Local user whose entitlement to query
		/// </summary>
		public EpicAccountId LocalUserId { get; set; }

		/// <summary>
		/// List of entitlement names, matching in number to the EntitlementNameCount
		/// </summary>
		public string[] EntitlementNames { get; set; }

		/// <summary>
		/// Determines rater or not to include redeemed entitlements
		/// </summary>
		public bool IncludeRedeemed { get; set; }
	}

	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	internal struct QueryEntitlementsOptionsInternal : IDisposable
	{
		private int m_ApiVersion;
		private IntPtr m_LocalUserId;
		private IntPtr m_EntitlementNames;
		private uint m_EntitlementNameCount;
		private int m_IncludeRedeemed;

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

		public EpicAccountId LocalUserId
		{
			get
			{
				var value = Helper.GetDefault<EpicAccountId>();
				Helper.TryMarshalGet(m_LocalUserId, out value);
				return value;
			}
			set { Helper.TryMarshalSet(ref m_LocalUserId, value); }
		}

		public string[] EntitlementNames
		{
			get
			{
				var value = Helper.GetDefault<string[]>();
				Helper.TryMarshalGet(m_EntitlementNames, out value, m_EntitlementNameCount);
				return value;
			}
			set { Helper.TryMarshalSet(ref m_EntitlementNames, value, out m_EntitlementNameCount); }
		}

		public bool IncludeRedeemed
		{
			get
			{
				var value = Helper.GetDefault<bool>();
				Helper.TryMarshalGet(m_IncludeRedeemed, out value);
				return value;
			}
			set { Helper.TryMarshalSet(ref m_IncludeRedeemed, value); }
		}

		public void Dispose()
		{
			Helper.TryMarshalDispose(ref m_EntitlementNames);
		}
	}
}