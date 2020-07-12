// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Metrics
{
	/// <summary>
	/// EndPlayerSession.
	/// </summary>
	public class EndPlayerSessionOptions
	{
		/// <summary>
		/// API Version
		/// </summary>
		public int ApiVersion { get { return 1; } }

		public EndPlayerSessionOptionsAccountId AccountId { get; set; }
	}

	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	internal struct EndPlayerSessionOptionsInternal : IDisposable
	{
		private int m_ApiVersion;
		private EndPlayerSessionOptionsAccountIdInternal m_AccountId;

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

		public EndPlayerSessionOptionsAccountIdInternal AccountId
		{
			get
			{
				var value = Helper.GetDefault<EndPlayerSessionOptionsAccountIdInternal>();
				Helper.TryMarshalGet(m_AccountId, out value);
				return value;
			}
			set { Helper.TryMarshalSet(ref m_AccountId, value); }
		}

		public void Dispose()
		{
			Helper.TryMarshalDispose(ref m_AccountId);
		}
	}
}