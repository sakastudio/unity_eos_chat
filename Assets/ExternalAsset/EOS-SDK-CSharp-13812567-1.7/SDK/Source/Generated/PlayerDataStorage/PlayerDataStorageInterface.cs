// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.PlayerDataStorage
{
	public sealed class PlayerDataStorageInterface : Handle
	{
		public PlayerDataStorageInterface() : base(IntPtr.Zero)
		{
		}

		public PlayerDataStorageInterface(IntPtr innerHandle) : base(innerHandle)
		{
		}

		/// <summary>
		/// Maximum File size in bytes
		/// </summary>
		public const int FileMaxSizeBytes = (64 * 1024 * 1024);

		/// <summary>
		/// Maximum File Name Length in bytes
		/// </summary>
		public const int FilenameMaxLengthBytes = 64;

		/// <summary>
		/// Query a specific file's metadata, such as file names, size, and a MD5 hash of the data. This is not required before a file may be opened, saved, copied, or deleted. Once a file has
		/// been queried, its metadata will be available by the <see cref="CopyFileMetadataAtIndex" /> and <see cref="CopyFileMetadataByFilename" /> functions.
		/// <seealso cref="GetFileMetadataCount" />
		/// <seealso cref="CopyFileMetadataAtIndex" />
		/// <seealso cref="CopyFileMetadataByFilename" />
		/// </summary>
		/// <param name="options">Object containing properties related to which user is querying files, and what file is being queried</param>
		/// <param name="clientData">Optional pointer to help clients track this request, that is returned in the completion callback</param>
		/// <param name="completionCallback">This function is called when the query operation completes</param>
		public void QueryFile(QueryFileOptions queryFileOptions, object clientData, OnQueryFileCompleteCallback completionCallback)
		{
			var queryFileOptionsInternal = Helper.CopyProperties<QueryFileOptionsInternal>(queryFileOptions);

			var completionCallbackInternal = new OnQueryFileCompleteCallbackInternal(OnQueryFileComplete);
			var clientDataAddress = IntPtr.Zero;
			Helper.AddCallback(ref clientDataAddress, clientData, completionCallback, completionCallbackInternal);

			EOS_PlayerDataStorage_QueryFile(InnerHandle, ref queryFileOptionsInternal, clientDataAddress, completionCallbackInternal);
			Helper.TryMarshalDispose(ref queryFileOptionsInternal);
		}

		/// <summary>
		/// Query the file metadata, such as file names, size, and a MD5 hash of the data, for all files owned by this user for this application. This is not required before a file may be opened,
		/// saved, copied, or deleted.
		/// <seealso cref="GetFileMetadataCount" />
		/// <seealso cref="CopyFileMetadataAtIndex" />
		/// <seealso cref="CopyFileMetadataByFilename" />
		/// </summary>
		/// <param name="options">Object containing properties related to which user is querying files</param>
		/// <param name="clientData">Optional pointer to help clients track this request, that is returned in the completion callback</param>
		/// <param name="completionCallback">This function is called when the query operation completes</param>
		public void QueryFileList(QueryFileListOptions queryFileListOptions, object clientData, OnQueryFileListCompleteCallback completionCallback)
		{
			var queryFileListOptionsInternal = Helper.CopyProperties<QueryFileListOptionsInternal>(queryFileListOptions);

			var completionCallbackInternal = new OnQueryFileListCompleteCallbackInternal(OnQueryFileListComplete);
			var clientDataAddress = IntPtr.Zero;
			Helper.AddCallback(ref clientDataAddress, clientData, completionCallback, completionCallbackInternal);

			EOS_PlayerDataStorage_QueryFileList(InnerHandle, ref queryFileListOptionsInternal, clientDataAddress, completionCallbackInternal);
			Helper.TryMarshalDispose(ref queryFileListOptionsInternal);
		}

		/// <summary>
		/// Create the cached copy of a file's metadata by filename. The metadata will be for the last retrieved or successfully saved version, and will not include any changes that have not
		/// completed writing. The returned pointer must be released by the user when no longer needed.
		/// </summary>
		/// <param name="copyFileMetadataOptions">Object containing properties related to which user is requesting metadata, and for which filename</param>
		/// <param name="outMetadata">A copy of the FileMetadata structure will be set if successful. This data must be released by calling <see cref="Release" />.</param>
		/// <returns>
		/// <see cref="Result" />::<see cref="Result.Success" /> if the metadata is currently cached, otherwise an error result explaining what went wrong
		/// </returns>
		public Result CopyFileMetadataByFilename(CopyFileMetadataByFilenameOptions copyFileMetadataOptions, out FileMetadata outMetadata)
		{
			var copyFileMetadataOptionsInternal = Helper.CopyProperties<CopyFileMetadataByFilenameOptionsInternal>(copyFileMetadataOptions);

			outMetadata = Helper.GetDefault<FileMetadata>();

			var outMetadataAddress = IntPtr.Zero;

			var funcResult = EOS_PlayerDataStorage_CopyFileMetadataByFilename(InnerHandle, ref copyFileMetadataOptionsInternal, ref outMetadataAddress);
			Helper.TryMarshalDispose(ref copyFileMetadataOptionsInternal);

			if (Helper.TryMarshalGet<FileMetadataInternal, FileMetadata>(outMetadataAddress, out outMetadata))
			{
				EOS_PlayerDataStorage_FileMetadata_Release(outMetadataAddress);
			}

			var funcResultReturn = Helper.GetDefault<Result>();
			Helper.TryMarshalGet(funcResult, out funcResultReturn);
			return funcResultReturn;
		}

		/// <summary>
		/// Get the count of files we have previously queried information for and files we have previously read from / written to.
		/// <seealso cref="CopyFileMetadataAtIndex" />
		/// </summary>
		/// <param name="getFileMetadataCountOptions">Object containing properties related to which user is requesting the metadata count</param>
		/// <param name="outFileMetadataCount">If successful, the count of metadata currently cached</param>
		/// <returns>
		/// <see cref="Result" />::<see cref="Result.Success" /> if the input was valid, otherwise an error result explaining what went wrong
		/// </returns>
		public Result GetFileMetadataCount(GetFileMetadataCountOptions getFileMetadataCountOptions, out int outFileMetadataCount)
		{
			var getFileMetadataCountOptionsInternal = Helper.CopyProperties<GetFileMetadataCountOptionsInternal>(getFileMetadataCountOptions);

			outFileMetadataCount = Helper.GetDefault<int>();

			var funcResult = EOS_PlayerDataStorage_GetFileMetadataCount(InnerHandle, ref getFileMetadataCountOptionsInternal, ref outFileMetadataCount);
			Helper.TryMarshalDispose(ref getFileMetadataCountOptionsInternal);

			var funcResultReturn = Helper.GetDefault<Result>();
			Helper.TryMarshalGet(funcResult, out funcResultReturn);
			return funcResultReturn;
		}

		/// <summary>
		/// Get the cached copy of a file's metadata by index. The metadata will be for the last retrieved or successfully saved version, and will not include any local changes that have not been
		/// committed by calling SaveFile. The returned pointer must be released by the user when no longer needed.
		/// <seealso cref="GetFileMetadataCount" />
		/// <seealso cref="Release" />
		/// </summary>
		/// <param name="copyFileMetadataOptions">Object containing properties related to which user is requesting metadata, and at what index</param>
		/// <param name="outMetadata">A copy of the FileMetadata structure will be set if successful. This data must be released by calling <see cref="Release" />.</param>
		/// <returns>
		/// <see cref="Result" />::<see cref="Result.Success" /> if the requested metadata is currently cached, otherwise an error result explaining what went wrong
		/// </returns>
		public Result CopyFileMetadataAtIndex(CopyFileMetadataAtIndexOptions copyFileMetadataOptions, out FileMetadata outMetadata)
		{
			var copyFileMetadataOptionsInternal = Helper.CopyProperties<CopyFileMetadataAtIndexOptionsInternal>(copyFileMetadataOptions);

			outMetadata = Helper.GetDefault<FileMetadata>();

			var outMetadataAddress = IntPtr.Zero;

			var funcResult = EOS_PlayerDataStorage_CopyFileMetadataAtIndex(InnerHandle, ref copyFileMetadataOptionsInternal, ref outMetadataAddress);
			Helper.TryMarshalDispose(ref copyFileMetadataOptionsInternal);

			if (Helper.TryMarshalGet<FileMetadataInternal, FileMetadata>(outMetadataAddress, out outMetadata))
			{
				EOS_PlayerDataStorage_FileMetadata_Release(outMetadataAddress);
			}

			var funcResultReturn = Helper.GetDefault<Result>();
			Helper.TryMarshalGet(funcResult, out funcResultReturn);
			return funcResultReturn;
		}

		/// <summary>
		/// Copies the data of an existing file to a new filename. This action happens entirely on the server and will not upload the contents of the source destination file from the host. This
		/// function paired with a subsequent <see cref="DeleteFile" /> can be used to rename a file. If successful, the destination file's metadata will be updated in our local cache.
		/// </summary>
		/// <param name="duplicateOptions">Object containing properties related to which user is duplicating the file, and what the source and destination file names are</param>
		/// <param name="clientData">Optional pointer to help clients track this request, that is returned in the completion callback</param>
		/// <param name="completionCallback">This function is called when the duplicate operation completes</param>
		public void DuplicateFile(DuplicateFileOptions duplicateOptions, object clientData, OnDuplicateFileCompleteCallback completionCallback)
		{
			var duplicateOptionsInternal = Helper.CopyProperties<DuplicateFileOptionsInternal>(duplicateOptions);

			var completionCallbackInternal = new OnDuplicateFileCompleteCallbackInternal(OnDuplicateFileComplete);
			var clientDataAddress = IntPtr.Zero;
			Helper.AddCallback(ref clientDataAddress, clientData, completionCallback, completionCallbackInternal);

			EOS_PlayerDataStorage_DuplicateFile(InnerHandle, ref duplicateOptionsInternal, clientDataAddress, completionCallbackInternal);
			Helper.TryMarshalDispose(ref duplicateOptionsInternal);
		}

		/// <summary>
		/// Deletes an existing file in the cloud. If successful, the file's data will be removed from our local cache.
		/// </summary>
		/// <param name="delteOptions">Object containing properties related to which user is deleting the file, and what file name is</param>
		/// <param name="clientData">Optional pointer to help clients track this request, that is returned in the completion callback</param>
		/// <param name="completionCallback">This function is called when the delete operation completes</param>
		public void DeleteFile(DeleteFileOptions deleteOptions, object clientData, OnDeleteFileCompleteCallback completionCallback)
		{
			var deleteOptionsInternal = Helper.CopyProperties<DeleteFileOptionsInternal>(deleteOptions);

			var completionCallbackInternal = new OnDeleteFileCompleteCallbackInternal(OnDeleteFileComplete);
			var clientDataAddress = IntPtr.Zero;
			Helper.AddCallback(ref clientDataAddress, clientData, completionCallback, completionCallbackInternal);

			EOS_PlayerDataStorage_DeleteFile(InnerHandle, ref deleteOptionsInternal, clientDataAddress, completionCallbackInternal);
			Helper.TryMarshalDispose(ref deleteOptionsInternal);
		}

		/// <summary>
		/// Retrieve the contents of a specific file, potentially downloading the contents if we do not have a local copy, from the cloud. This request will occur asynchronously, potentially over
		/// multiple frames. All callbacks for this function will come from the same thread that the SDK is ticked from. If specified, the FileTransferProgressCallback will always be called at
		/// least once if the request is started successfully.
		/// <seealso cref="PlayerDataStorageFileTransferRequest.Release" />
		/// </summary>
		/// <param name="readOptions">Object containing properties related to which user is opening the file, what the file's name is, and related mechanisms for copying the data</param>
		/// <param name="clientData">Optional pointer to help clients track this request, that is returned in associated callbacks</param>
		/// <param name="completionCallback">This function is called when the read operation completes</param>
		/// <returns>
		/// A valid Player Data Storage File Request handle if successful, or NULL otherwise. Data contained in the completion callback will have more detailed information about issues with the request in failure cases. This handle must be released when it is no longer needed
		/// </returns>
		public PlayerDataStorageFileTransferRequest ReadFile(ReadFileOptions readOptions, object clientData, OnReadFileCompleteCallback completionCallback)
		{
			var readOptionsInternal = Helper.CopyProperties<ReadFileOptionsInternal>(readOptions);

			var completionCallbackInternal = new OnReadFileCompleteCallbackInternal(OnReadFileComplete);
			var clientDataAddress = IntPtr.Zero;
			Helper.AddCallback(ref clientDataAddress, clientData, completionCallback, completionCallbackInternal, readOptions.ReadFileDataCallback, readOptionsInternal.ReadFileDataCallback, readOptions.FileTransferProgressCallback, readOptionsInternal.FileTransferProgressCallback);

			var funcResult = EOS_PlayerDataStorage_ReadFile(InnerHandle, ref readOptionsInternal, clientDataAddress, completionCallbackInternal);
			Helper.TryMarshalDispose(ref readOptionsInternal);

			var funcResultReturn = Helper.GetDefault<PlayerDataStorageFileTransferRequest>();
			Helper.TryMarshalGet(funcResult, out funcResultReturn);
			return funcResultReturn;
		}

		/// <summary>
		/// Write new data to a specific file, potentially overwriting any existing file by the same name, to the cloud. This request will occur asynchronously, potentially over multiple frames.
		/// All callbacks for this function will come from the same thread that the SDK is ticked from. If specified, the FileTransferProgressCallback will always be called at least once if the
		/// request is started successfully.
		/// <seealso cref="PlayerDataStorageFileTransferRequest.Release" />
		/// </summary>
		/// <param name="writeOptions">Object containing properties related to which user is writing the file, what the file's name is, and related mechanisms for writing the data</param>
		/// <param name="clientData">Optional pointer to help clients track this request, that is returned in associated callbacks</param>
		/// <param name="completionCallback">This function is called when the write operation completes</param>
		/// <returns>
		/// A valid Player Data Storage File Request handle if successful, or NULL otherwise. Data contained in the completion callback will have more detailed information about issues with the request in failure cases. This handle must be released when it is no longer needed
		/// </returns>
		public PlayerDataStorageFileTransferRequest WriteFile(WriteFileOptions writeOptions, object clientData, OnWriteFileCompleteCallback completionCallback)
		{
			var writeOptionsInternal = Helper.CopyProperties<WriteFileOptionsInternal>(writeOptions);

			var completionCallbackInternal = new OnWriteFileCompleteCallbackInternal(OnWriteFileComplete);
			var clientDataAddress = IntPtr.Zero;
			Helper.AddCallback(ref clientDataAddress, clientData, completionCallback, completionCallbackInternal, writeOptions.WriteFileDataCallback, writeOptionsInternal.WriteFileDataCallback, writeOptions.FileTransferProgressCallback, writeOptionsInternal.FileTransferProgressCallback);

			var funcResult = EOS_PlayerDataStorage_WriteFile(InnerHandle, ref writeOptionsInternal, clientDataAddress, completionCallbackInternal);
			Helper.TryMarshalDispose(ref writeOptionsInternal);

			var funcResultReturn = Helper.GetDefault<PlayerDataStorageFileTransferRequest>();
			Helper.TryMarshalGet(funcResult, out funcResultReturn);
			return funcResultReturn;
		}

		[MonoPInvokeCallback]
		internal static WriteResult OnWriteFileData(IntPtr callbackInfoAddress, IntPtr outDataBuffer, ref uint outDataWritten)
		{
			OnWriteFileDataCallback callback = null;
			WriteFileDataCallbackInfo callbackInfo = null;
			if (Helper.TryGetAdditionalCallback<OnWriteFileDataCallback, WriteFileDataCallbackInfoInternal, WriteFileDataCallbackInfo>(callbackInfoAddress, out callback, out callbackInfo))
			{
				byte[] outDataBufferArray = null;
				var result = callback(callbackInfo, out outDataBufferArray, out outDataWritten);

				Marshal.Copy(outDataBufferArray, 0, outDataBuffer, (int)outDataWritten);

				return result;
			}

			return Helper.GetDefault<WriteResult>();
		}

		[MonoPInvokeCallback]
		internal static void OnFileTransferProgress(IntPtr callbackInfoAddress)
		{
			OnFileTransferProgressCallback callback = null;
			FileTransferProgressCallbackInfo callbackInfo = null;
			if (Helper.TryGetAdditionalCallback<OnFileTransferProgressCallback, FileTransferProgressCallbackInfoInternal, FileTransferProgressCallbackInfo>(callbackInfoAddress, out callback, out callbackInfo))
			{
				callback(callbackInfo);
			}
		}

		[MonoPInvokeCallback]
		internal static ReadResult OnReadFileData(IntPtr callbackInfoAddress)
		{
			OnReadFileDataCallback callback = null;
			ReadFileDataCallbackInfo callbackInfo = null;
			if (Helper.TryGetAdditionalCallback<OnReadFileDataCallback, ReadFileDataCallbackInfoInternal, ReadFileDataCallbackInfo>(callbackInfoAddress, out callback, out callbackInfo))
			{
				var result = callback(callbackInfo);
				return result;
			}

			return Helper.GetDefault<ReadResult>();
		}

		[MonoPInvokeCallback]
		internal static void OnWriteFileComplete(IntPtr address)
		{
			OnWriteFileCompleteCallback callback = null;
			WriteFileCallbackInfo callbackInfo = null;
			if (Helper.TryGetAndRemoveCallback<OnWriteFileCompleteCallback, WriteFileCallbackInfoInternal, WriteFileCallbackInfo>(address, out callback, out callbackInfo))
			{
				callback(callbackInfo);
			}
		}

		[MonoPInvokeCallback]
		internal static void OnReadFileComplete(IntPtr address)
		{
			OnReadFileCompleteCallback callback = null;
			ReadFileCallbackInfo callbackInfo = null;
			if (Helper.TryGetAndRemoveCallback<OnReadFileCompleteCallback, ReadFileCallbackInfoInternal, ReadFileCallbackInfo>(address, out callback, out callbackInfo))
			{
				callback(callbackInfo);
			}
		}

		[MonoPInvokeCallback]
		internal static void OnDeleteFileComplete(IntPtr address)
		{
			OnDeleteFileCompleteCallback callback = null;
			DeleteFileCallbackInfo callbackInfo = null;
			if (Helper.TryGetAndRemoveCallback<OnDeleteFileCompleteCallback, DeleteFileCallbackInfoInternal, DeleteFileCallbackInfo>(address, out callback, out callbackInfo))
			{
				callback(callbackInfo);
			}
		}

		[MonoPInvokeCallback]
		internal static void OnDuplicateFileComplete(IntPtr address)
		{
			OnDuplicateFileCompleteCallback callback = null;
			DuplicateFileCallbackInfo callbackInfo = null;
			if (Helper.TryGetAndRemoveCallback<OnDuplicateFileCompleteCallback, DuplicateFileCallbackInfoInternal, DuplicateFileCallbackInfo>(address, out callback, out callbackInfo))
			{
				callback(callbackInfo);
			}
		}

		[MonoPInvokeCallback]
		internal static void OnQueryFileListComplete(IntPtr address)
		{
			OnQueryFileListCompleteCallback callback = null;
			QueryFileListCallbackInfo callbackInfo = null;
			if (Helper.TryGetAndRemoveCallback<OnQueryFileListCompleteCallback, QueryFileListCallbackInfoInternal, QueryFileListCallbackInfo>(address, out callback, out callbackInfo))
			{
				callback(callbackInfo);
			}
		}

		[MonoPInvokeCallback]
		internal static void OnQueryFileComplete(IntPtr address)
		{
			OnQueryFileCompleteCallback callback = null;
			QueryFileCallbackInfo callbackInfo = null;
			if (Helper.TryGetAndRemoveCallback<OnQueryFileCompleteCallback, QueryFileCallbackInfoInternal, QueryFileCallbackInfo>(address, out callback, out callbackInfo))
			{
				callback(callbackInfo);
			}
		}

		[DllImport(Config.BinaryName)]
		private static extern void EOS_PlayerDataStorage_FileMetadata_Release(IntPtr fileMetadata);

		[DllImport(Config.BinaryName)]
		private static extern IntPtr EOS_PlayerDataStorage_WriteFile(IntPtr handle, ref WriteFileOptionsInternal writeOptions, IntPtr clientData, OnWriteFileCompleteCallbackInternal completionCallback);

		[DllImport(Config.BinaryName)]
		private static extern IntPtr EOS_PlayerDataStorage_ReadFile(IntPtr handle, ref ReadFileOptionsInternal readOptions, IntPtr clientData, OnReadFileCompleteCallbackInternal completionCallback);

		[DllImport(Config.BinaryName)]
		private static extern void EOS_PlayerDataStorage_DeleteFile(IntPtr handle, ref DeleteFileOptionsInternal deleteOptions, IntPtr clientData, OnDeleteFileCompleteCallbackInternal completionCallback);

		[DllImport(Config.BinaryName)]
		private static extern void EOS_PlayerDataStorage_DuplicateFile(IntPtr handle, ref DuplicateFileOptionsInternal duplicateOptions, IntPtr clientData, OnDuplicateFileCompleteCallbackInternal completionCallback);

		[DllImport(Config.BinaryName)]
		private static extern Result EOS_PlayerDataStorage_CopyFileMetadataAtIndex(IntPtr handle, ref CopyFileMetadataAtIndexOptionsInternal copyFileMetadataOptions, ref IntPtr outMetadata);

		[DllImport(Config.BinaryName)]
		private static extern Result EOS_PlayerDataStorage_GetFileMetadataCount(IntPtr handle, ref GetFileMetadataCountOptionsInternal getFileMetadataCountOptions, ref int outFileMetadataCount);

		[DllImport(Config.BinaryName)]
		private static extern Result EOS_PlayerDataStorage_CopyFileMetadataByFilename(IntPtr handle, ref CopyFileMetadataByFilenameOptionsInternal copyFileMetadataOptions, ref IntPtr outMetadata);

		[DllImport(Config.BinaryName)]
		private static extern void EOS_PlayerDataStorage_QueryFileList(IntPtr handle, ref QueryFileListOptionsInternal queryFileListOptions, IntPtr clientData, OnQueryFileListCompleteCallbackInternal completionCallback);

		[DllImport(Config.BinaryName)]
		private static extern void EOS_PlayerDataStorage_QueryFile(IntPtr handle, ref QueryFileOptionsInternal queryFileOptions, IntPtr clientData, OnQueryFileCompleteCallbackInternal completionCallback);
	}
}