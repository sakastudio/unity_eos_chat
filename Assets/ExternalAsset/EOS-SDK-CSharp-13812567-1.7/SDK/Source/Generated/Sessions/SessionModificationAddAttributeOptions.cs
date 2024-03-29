// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Sessions
{
	/// <summary>
	/// Input parameters for the <see cref="SessionModification.AddAttribute" /> Function.
	/// </summary>
	public class SessionModificationAddAttributeOptions
	{
		/// <summary>
		/// Version of the API
		/// </summary>
		public int ApiVersion { get { return 1; } }

		/// <summary>
		/// Key/Value pair describing the attribute to add to the session
		/// </summary>
		public AttributeData SessionAttribute { get; set; }

		/// <summary>
		/// Is this attribution advertised with the backend or simply stored locally
		/// </summary>
		public SessionAttributeAdvertisementType AdvertisementType { get; set; }
	}

	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	internal struct SessionModificationAddAttributeOptionsInternal : IDisposable
	{
		private int m_ApiVersion;
		private IntPtr m_SessionAttribute;
		private SessionAttributeAdvertisementType m_AdvertisementType;

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

		public AttributeDataInternal? SessionAttribute
		{
			get
			{
				var value = Helper.GetDefault<AttributeDataInternal?>();
				Helper.TryMarshalGet(m_SessionAttribute, out value);
				return value;
			}
			set { Helper.TryMarshalSet(ref m_SessionAttribute, value); }
		}

		public SessionAttributeAdvertisementType AdvertisementType
		{
			get
			{
				var value = Helper.GetDefault<SessionAttributeAdvertisementType>();
				Helper.TryMarshalGet(m_AdvertisementType, out value);
				return value;
			}
			set { Helper.TryMarshalSet(ref m_AdvertisementType, value); }
		}

		public void Dispose()
		{
			Helper.TryMarshalDispose(ref m_SessionAttribute);
		}
	}
}