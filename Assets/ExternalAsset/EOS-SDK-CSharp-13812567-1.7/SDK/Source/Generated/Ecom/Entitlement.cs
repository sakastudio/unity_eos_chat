// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Ecom
{
	/// <summary>
	/// Contains information about a single entitlement associated with an account. Instances of this structure are
	/// created by <see cref="EcomInterface.CopyEntitlementByIndex" />, <see cref="EcomInterface.CopyEntitlementByNameAndIndex" />, or <see cref="EcomInterface.CopyEntitlementById" />.
	/// They must be passed to <see cref="EcomInterface.Release" />.
	/// </summary>
	public class Entitlement
	{
		/// <summary>
		/// Version of the API
		/// </summary>
		public int ApiVersion { get { return 2; } }

		/// <summary>
		/// Name of the entitlement
		/// </summary>
		public string EntitlementName { get; set; }

		/// <summary>
		/// Id of the entitlement owned by an account
		/// </summary>
		public string EntitlementId { get; set; }

		/// <summary>
		/// Id of the item associated with the offer which granted this entitlement
		/// </summary>
		public string CatalogItemId { get; set; }

		/// <summary>
		/// If queried using pagination then ServerIndex represents the index of the entitlement as it
		/// exists on the server. If not queried using pagination then ServerIndex will be -1.
		/// </summary>
		public int ServerIndex { get; set; }

		/// <summary>
		/// If true then the catalog has this entitlement marked as redeemed
		/// </summary>
		public bool Redeemed { get; set; }

		/// <summary>
		/// If not -1 then this is a POSIX timestamp that this entitlement will end
		/// </summary>
		public long EndTimestamp { get; set; }
	}

	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	internal struct EntitlementInternal : IDisposable
	{
		private int m_ApiVersion;
		[MarshalAs(UnmanagedType.LPStr)]
		private string m_EntitlementName;
		[MarshalAs(UnmanagedType.LPStr)]
		private string m_EntitlementId;
		[MarshalAs(UnmanagedType.LPStr)]
		private string m_CatalogItemId;
		private int m_ServerIndex;
		private int m_Redeemed;
		private long m_EndTimestamp;

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

		public string EntitlementName
		{
			get
			{
				var value = Helper.GetDefault<string>();
				Helper.TryMarshalGet(m_EntitlementName, out value);
				return value;
			}
			set { Helper.TryMarshalSet(ref m_EntitlementName, value); }
		}

		public string EntitlementId
		{
			get
			{
				var value = Helper.GetDefault<string>();
				Helper.TryMarshalGet(m_EntitlementId, out value);
				return value;
			}
			set { Helper.TryMarshalSet(ref m_EntitlementId, value); }
		}

		public string CatalogItemId
		{
			get
			{
				var value = Helper.GetDefault<string>();
				Helper.TryMarshalGet(m_CatalogItemId, out value);
				return value;
			}
			set { Helper.TryMarshalSet(ref m_CatalogItemId, value); }
		}

		public int ServerIndex
		{
			get
			{
				var value = Helper.GetDefault<int>();
				Helper.TryMarshalGet(m_ServerIndex, out value);
				return value;
			}
			set { Helper.TryMarshalSet(ref m_ServerIndex, value); }
		}

		public bool Redeemed
		{
			get
			{
				var value = Helper.GetDefault<bool>();
				Helper.TryMarshalGet(m_Redeemed, out value);
				return value;
			}
			set { Helper.TryMarshalSet(ref m_Redeemed, value); }
		}

		public long EndTimestamp
		{
			get
			{
				var value = Helper.GetDefault<long>();
				Helper.TryMarshalGet(m_EndTimestamp, out value);
				return value;
			}
			set { Helper.TryMarshalSet(ref m_EndTimestamp, value); }
		}

		public void Dispose()
		{
		}
	}
}