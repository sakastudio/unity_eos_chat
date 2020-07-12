// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Ecom
{
	/// <summary>
	/// Input parameters for the <see cref="EcomInterface.CopyItemReleaseByIndex" /> Function.
	/// </summary>
	public class CopyItemReleaseByIndexOptions
	{
		/// <summary>
		/// Version of the API
		/// </summary>
		public int ApiVersion { get { return 1; } }

		/// <summary>
		/// Local user whose item release is being copied
		/// </summary>
		public EpicAccountId LocalUserId { get; set; }

		/// <summary>
		/// The ID of the item to get the releases for.
		/// </summary>
		public string ItemId { get; set; }

		/// <summary>
		/// The index of the release to get.
		/// </summary>
		public uint ReleaseIndex { get; set; }
	}

	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	internal struct CopyItemReleaseByIndexOptionsInternal : IDisposable
	{
		private int m_ApiVersion;
		private IntPtr m_LocalUserId;
		[MarshalAs(UnmanagedType.LPStr)]
		private string m_ItemId;
		private uint m_ReleaseIndex;

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

		public string ItemId
		{
			get
			{
				var value = Helper.GetDefault<string>();
				Helper.TryMarshalGet(m_ItemId, out value);
				return value;
			}
			set { Helper.TryMarshalSet(ref m_ItemId, value); }
		}

		public uint ReleaseIndex
		{
			get
			{
				var value = Helper.GetDefault<uint>();
				Helper.TryMarshalGet(m_ReleaseIndex, out value);
				return value;
			}
			set { Helper.TryMarshalSet(ref m_ReleaseIndex, value); }
		}

		public void Dispose()
		{
		}
	}
}