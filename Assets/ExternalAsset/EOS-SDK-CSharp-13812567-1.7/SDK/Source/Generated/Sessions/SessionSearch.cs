// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Sessions
{
	public sealed class SessionSearch : Handle
	{
		public SessionSearch() : base(IntPtr.Zero)
		{
		}

		public SessionSearch(IntPtr innerHandle) : base(innerHandle)
		{
		}

		/// <summary>
		/// Set a session id to find and will return at most one search result. Setting TargetUserId or SearchParameters will result in <see cref="Find" /> failing
		/// </summary>
		/// <param name="options">A specific session id for which to search</param>
		/// <returns>
		/// <see cref="Result.Success" /> if setting this session id was successful
		/// <see cref="Result.InvalidParameters" /> if the session id is invalid or null
		/// <see cref="Result.IncompatibleVersion" /> if the API version passed in is incorrect
		/// </returns>
		public Result SetSessionId(SessionSearchSetSessionIdOptions options)
		{
			var optionsInternal = Helper.CopyProperties<SessionSearchSetSessionIdOptionsInternal>(options);

			var funcResult = EOS_SessionSearch_SetSessionId(InnerHandle, ref optionsInternal);
			Helper.TryMarshalDispose(ref optionsInternal);

			var funcResultReturn = Helper.GetDefault<Result>();
			Helper.TryMarshalGet(funcResult, out funcResultReturn);
			return funcResultReturn;
		}

		/// <summary>
		/// Set a target user id to find and will return at most one search result. Setting SessionId or SearchParameters will result in <see cref="Find" /> failing
		/// NOTE: a search result will only be found if this user is in a public session
		/// </summary>
		/// <param name="options">a specific target user id to find</param>
		/// <returns>
		/// <see cref="Result.Success" /> if setting this target user id was successful
		/// <see cref="Result.InvalidParameters" /> if the target user id is invalid or null
		/// <see cref="Result.IncompatibleVersion" /> if the API version passed in is incorrect
		/// </returns>
		public Result SetTargetUserId(SessionSearchSetTargetUserIdOptions options)
		{
			var optionsInternal = Helper.CopyProperties<SessionSearchSetTargetUserIdOptionsInternal>(options);

			var funcResult = EOS_SessionSearch_SetTargetUserId(InnerHandle, ref optionsInternal);
			Helper.TryMarshalDispose(ref optionsInternal);

			var funcResultReturn = Helper.GetDefault<Result>();
			Helper.TryMarshalGet(funcResult, out funcResultReturn);
			return funcResultReturn;
		}

		/// <summary>
		/// Add a parameter to an array of search criteria combined via an implicit AND operator. Setting SessionId or TargetUserId will result in <see cref="Find" /> failing
		/// <seealso cref="AttributeData" />
		/// <seealso cref="ComparisonOp" />
		/// </summary>
		/// <param name="options">a search parameter and its comparison op</param>
		/// <returns>
		/// <see cref="Result.Success" /> if setting this search parameter was successful
		/// <see cref="Result.InvalidParameters" /> if the search criteria is invalid or null
		/// <see cref="Result.IncompatibleVersion" /> if the API version passed in is incorrect
		/// </returns>
		public Result SetParameter(SessionSearchSetParameterOptions options)
		{
			var optionsInternal = Helper.CopyProperties<SessionSearchSetParameterOptionsInternal>(options);

			var funcResult = EOS_SessionSearch_SetParameter(InnerHandle, ref optionsInternal);
			Helper.TryMarshalDispose(ref optionsInternal);

			var funcResultReturn = Helper.GetDefault<Result>();
			Helper.TryMarshalGet(funcResult, out funcResultReturn);
			return funcResultReturn;
		}

		/// <summary>
		/// Remove a parameter from the array of search criteria.
		/// 
		/// @params Options a search parameter key name to remove
		/// </summary>
		/// <returns>
		/// <see cref="Result.Success" /> if removing this search parameter was successful
		/// <see cref="Result.InvalidParameters" /> if the search key is invalid or null
		/// <see cref="Result.NotFound" /> if the parameter was not a part of the search criteria
		/// <see cref="Result.IncompatibleVersion" /> if the API version passed in is incorrect
		/// </returns>
		public Result RemoveParameter(SessionSearchRemoveParameterOptions options)
		{
			var optionsInternal = Helper.CopyProperties<SessionSearchRemoveParameterOptionsInternal>(options);

			var funcResult = EOS_SessionSearch_RemoveParameter(InnerHandle, ref optionsInternal);
			Helper.TryMarshalDispose(ref optionsInternal);

			var funcResultReturn = Helper.GetDefault<Result>();
			Helper.TryMarshalGet(funcResult, out funcResultReturn);
			return funcResultReturn;
		}

		/// <summary>
		/// Set the maximum number of search results to return in the query, can't be more than <see cref="SessionsInterface.MaxSearchResults" />
		/// </summary>
		/// <param name="options">maximum number of search results to return in the query</param>
		/// <returns>
		/// <see cref="Result.Success" /> if setting the max results was successful
		/// <see cref="Result.InvalidParameters" /> if the number of results requested is invalid
		/// <see cref="Result.IncompatibleVersion" /> if the API version passed in is incorrect
		/// </returns>
		public Result SetMaxResults(SessionSearchSetMaxResultsOptions options)
		{
			var optionsInternal = Helper.CopyProperties<SessionSearchSetMaxResultsOptionsInternal>(options);

			var funcResult = EOS_SessionSearch_SetMaxResults(InnerHandle, ref optionsInternal);
			Helper.TryMarshalDispose(ref optionsInternal);

			var funcResultReturn = Helper.GetDefault<Result>();
			Helper.TryMarshalGet(funcResult, out funcResultReturn);
			return funcResultReturn;
		}

		/// <summary>
		/// Find sessions matching the search criteria setup via this session search handle.
		/// When the operation completes, this handle will have the search results that can be parsed
		/// </summary>
		/// <param name="options">Structure containing information about the search criteria to use</param>
		/// <param name="clientData">Arbitrary data that is passed back to you in the CompletionDelegate</param>
		/// <param name="completionDelegate">A callback that is fired when the search operation completes, either successfully or in error</param>
		/// <returns>
		/// <see cref="Result.Success" /> if the find operation completes successfully
		/// <see cref="Result.NotFound" /> if searching for an individual session by sessionid or targetuserid returns no results
		/// <see cref="Result.InvalidParameters" /> if any of the options are incorrect
		/// </returns>
		public void Find(SessionSearchFindOptions options, object clientData, SessionSearchOnFindCallback completionDelegate)
		{
			var optionsInternal = Helper.CopyProperties<SessionSearchFindOptionsInternal>(options);

			var completionDelegateInternal = new SessionSearchOnFindCallbackInternal(SessionSearchOnFind);
			var clientDataAddress = IntPtr.Zero;
			Helper.AddCallback(ref clientDataAddress, clientData, completionDelegate, completionDelegateInternal);

			EOS_SessionSearch_Find(InnerHandle, ref optionsInternal, clientDataAddress, completionDelegateInternal);
			Helper.TryMarshalDispose(ref optionsInternal);
		}

		/// <summary>
		/// Get the number of search results found by the search parameters in this search
		/// </summary>
		/// <param name="options">Options associated with the search count</param>
		/// <returns>
		/// return the number of search results found by the query or 0 if search is not complete
		/// </returns>
		public uint GetSearchResultCount(SessionSearchGetSearchResultCountOptions options)
		{
			var optionsInternal = Helper.CopyProperties<SessionSearchGetSearchResultCountOptionsInternal>(options);

			var funcResult = EOS_SessionSearch_GetSearchResultCount(InnerHandle, ref optionsInternal);
			Helper.TryMarshalDispose(ref optionsInternal);

			var funcResultReturn = Helper.GetDefault<uint>();
			Helper.TryMarshalGet(funcResult, out funcResultReturn);
			return funcResultReturn;
		}

		/// <summary>
		/// <see cref="CopySearchResultByIndex" /> is used to immediately retrieve a handle to the session information from a given search result.
		/// If the call returns an <see cref="Result.Success" /> result, the out parameter, OutSessionHandle, must be passed to <see cref="SessionDetails.Release" /> to release the memory associated with it.
		/// <seealso cref="SessionSearchCopySearchResultByIndexOptions" />
		/// <seealso cref="SessionDetails.Release" />
		/// </summary>
		/// <param name="options">Structure containing the input parameters</param>
		/// <param name="outSessionHandle">out parameter used to receive the session handle</param>
		/// <returns>
		/// <see cref="Result.Success" /> if the information is available and passed out in OutSessionHandle
		/// <see cref="Result.InvalidParameters" /> if you pass an invalid index or a null pointer for the out parameter
		/// <see cref="Result.IncompatibleVersion" /> if the API version passed in is incorrect
		/// </returns>
		public Result CopySearchResultByIndex(SessionSearchCopySearchResultByIndexOptions options, out SessionDetails outSessionHandle)
		{
			var optionsInternal = Helper.CopyProperties<SessionSearchCopySearchResultByIndexOptionsInternal>(options);

			outSessionHandle = Helper.GetDefault<SessionDetails>();

			var outSessionHandleAddress = IntPtr.Zero;

			var funcResult = EOS_SessionSearch_CopySearchResultByIndex(InnerHandle, ref optionsInternal, ref outSessionHandleAddress);
			Helper.TryMarshalDispose(ref optionsInternal);

			Helper.TryMarshalGet(outSessionHandleAddress, out outSessionHandle);
			var funcResultReturn = Helper.GetDefault<Result>();
			Helper.TryMarshalGet(funcResult, out funcResultReturn);
			return funcResultReturn;
		}

		/// <summary>
		/// Release the memory associated with a session search. This must be called on data retrieved from <see cref="SessionsInterface.CreateSessionSearch" />.
		/// <seealso cref="SessionsInterface.CreateSessionSearch" />
		/// </summary>
		/// <param name="sessionSearchHandle">- The session search handle to release</param>
		public void Release()
		{
			EOS_SessionSearch_Release(InnerHandle);
		}

		[MonoPInvokeCallback]
		internal static void SessionSearchOnFind(IntPtr address)
		{
			SessionSearchOnFindCallback callback = null;
			SessionSearchFindCallbackInfo callbackInfo = null;
			if (Helper.TryGetAndRemoveCallback<SessionSearchOnFindCallback, SessionSearchFindCallbackInfoInternal, SessionSearchFindCallbackInfo>(address, out callback, out callbackInfo))
			{
				callback(callbackInfo);
			}
		}

		[DllImport(Config.BinaryName)]
		private static extern void EOS_SessionSearch_Release(IntPtr sessionSearchHandle);

		[DllImport(Config.BinaryName)]
		private static extern Result EOS_SessionSearch_CopySearchResultByIndex(IntPtr handle, ref SessionSearchCopySearchResultByIndexOptionsInternal options, ref IntPtr outSessionHandle);

		[DllImport(Config.BinaryName)]
		private static extern uint EOS_SessionSearch_GetSearchResultCount(IntPtr handle, ref SessionSearchGetSearchResultCountOptionsInternal options);

		[DllImport(Config.BinaryName)]
		private static extern void EOS_SessionSearch_Find(IntPtr handle, ref SessionSearchFindOptionsInternal options, IntPtr clientData, SessionSearchOnFindCallbackInternal completionDelegate);

		[DllImport(Config.BinaryName)]
		private static extern Result EOS_SessionSearch_SetMaxResults(IntPtr handle, ref SessionSearchSetMaxResultsOptionsInternal options);

		[DllImport(Config.BinaryName)]
		private static extern Result EOS_SessionSearch_RemoveParameter(IntPtr handle, ref SessionSearchRemoveParameterOptionsInternal options);

		[DllImport(Config.BinaryName)]
		private static extern Result EOS_SessionSearch_SetParameter(IntPtr handle, ref SessionSearchSetParameterOptionsInternal options);

		[DllImport(Config.BinaryName)]
		private static extern Result EOS_SessionSearch_SetTargetUserId(IntPtr handle, ref SessionSearchSetTargetUserIdOptionsInternal options);

		[DllImport(Config.BinaryName)]
		private static extern Result EOS_SessionSearch_SetSessionId(IntPtr handle, ref SessionSearchSetSessionIdOptionsInternal options);
	}
}