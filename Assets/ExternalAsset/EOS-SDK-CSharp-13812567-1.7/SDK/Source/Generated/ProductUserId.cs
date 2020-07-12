// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices
{
	public sealed class ProductUserId : Handle
	{
		public ProductUserId() : base(IntPtr.Zero)
		{
		}

		public ProductUserId(IntPtr innerHandle) : base(innerHandle)
		{
		}

		/// <summary>
		/// Check whether or not the given account unique id is considered valid
		/// </summary>
		/// <param name="accountId">The account id to check for validity</param>
		/// <returns>
		/// 1 if the <see cref="ProductUserId" /> is valid, otherwise 0
		/// </returns>
		public bool IsValid()
		{
			var funcResult = EOS_ProductUserId_IsValid(InnerHandle);
			var funcResultReturn = Helper.GetDefault<bool>();
			Helper.TryMarshalGet(funcResult, out funcResultReturn);
			return funcResultReturn;
		}

		/// <summary>
		/// Retrieve a string-ified account ID from an <see cref="ProductUserId" />. This is useful for replication of Product User IDs in multiplayer games.
		/// </summary>
		/// <param name="accountId">The account ID for which to retrieve the string-ified version.</param>
		/// <param name="outBuffer">The buffer into which the character data should be written</param>
		/// <param name="inOutBufferLength">
		/// The size of the OutBuffer in characters.
		/// The input buffer should include enough space to be null-terminated.
		/// When the function returns, this parameter will be filled with the length of the string copied into OutBuffer.
		/// </param>
		/// <returns>
		/// An <see cref="Result" /> that indicates whether the account ID string was copied into the OutBuffer.
		/// <see cref="Result.Success" /> - The OutBuffer was filled, and InOutBufferLength contains the number of characters copied into OutBuffer excluding the null terminator.
		/// <see cref="Result.InvalidParameters" /> - Either OutBuffer or InOutBufferLength were passed as NULL parameters.
		/// <see cref="Result.InvalidUser" /> - The AccountId is invalid and cannot be string-ified
		/// <see cref="Result.LimitExceeded" /> - The OutBuffer is not large enough to receive the account ID string. InOutBufferLength contains the required minimum length to perform the operation successfully.
		/// </returns>
		public Result ToString(System.Text.StringBuilder outBuffer, ref int inOutBufferLength)
		{
			var funcResult = EOS_ProductUserId_ToString(InnerHandle, outBuffer, ref inOutBufferLength);
			var funcResultReturn = Helper.GetDefault<Result>();
			Helper.TryMarshalGet(funcResult, out funcResultReturn);
			return funcResultReturn;
		}

		/// <summary>
		/// Retrieve an <see cref="EpicAccountId" /> from a raw account ID string. The input string must be null-terminated.
		/// </summary>
		/// <param name="accountIdString">The string-ified account ID for which to retrieve the <see cref="ProductUserId" /></param>
		/// <returns>
		/// The <see cref="ProductUserId" /> that corresponds to the AccountIdString
		/// </returns>
		public static ProductUserId FromString(string accountIdString)
		{
			var funcResult = EOS_ProductUserId_FromString(accountIdString);
			var funcResultReturn = Helper.GetDefault<ProductUserId>();
			Helper.TryMarshalGet(funcResult, out funcResultReturn);
			return funcResultReturn;
		}

		[DllImport(Config.BinaryName)]
		private static extern IntPtr EOS_ProductUserId_FromString([MarshalAs(UnmanagedType.LPStr)] string accountIdString);

		[DllImport(Config.BinaryName)]
		private static extern Result EOS_ProductUserId_ToString(IntPtr accountId, System.Text.StringBuilder outBuffer, ref int inOutBufferLength);

		[DllImport(Config.BinaryName)]
		private static extern int EOS_ProductUserId_IsValid(IntPtr accountId);
	}
}