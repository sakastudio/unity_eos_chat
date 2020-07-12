// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Ecom
{
	/// <summary>
	/// Output parameters for the <see cref="EcomInterface.Checkout" /> Function.
	/// </summary>
	public class CheckoutCallbackInfo
	{
		/// <summary>
		/// Result code for the operation. <see cref="Result.Success" /> is returned for a successful request, otherwise one of the error codes is returned. See <see cref="Common" />
		/// </summary>
		public Result ResultCode { get; set; }

		/// <summary>
		/// Context that was passed into <see cref="EcomInterface.Checkout" />
		/// </summary>
		public object ClientData { get; set; }

		/// <summary>
		/// The Account ID of the user which initiated the purchase
		/// </summary>
		public EpicAccountId LocalUserId { get; set; }

		/// <summary>
		/// The transaction id which can be used to obtain an <see cref="Transaction" /> using <see cref="EcomInterface.CopyTransactionById" />.
		/// </summary>
		public string TransactionId { get; set; }
	}

	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	internal struct CheckoutCallbackInfoInternal : ICallbackInfo
	{
		private Result m_ResultCode;
		private IntPtr m_ClientData;
		private IntPtr m_LocalUserId;
		[MarshalAs(UnmanagedType.LPStr)]
		private string m_TransactionId;

		public Result ResultCode
		{
			get
			{
				var value = Helper.GetDefault<Result>();
				Helper.TryMarshalGet(m_ResultCode, out value);
				return value;
			}
		}

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

		public EpicAccountId LocalUserId
		{
			get
			{
				var value = Helper.GetDefault<EpicAccountId>();
				Helper.TryMarshalGet(m_LocalUserId, out value);
				return value;
			}
		}

		public string TransactionId
		{
			get
			{
				var value = Helper.GetDefault<string>();
				Helper.TryMarshalGet(m_TransactionId, out value);
				return value;
			}
		}
	}
}