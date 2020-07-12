// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Platform
{
	/// <summary>
	/// Platform options for <see cref="PlatformInterface.Create" />.
	/// </summary>
	public class Options
	{
		/// <summary>
		/// API version of <see cref="PlatformInterface.Create" />.
		/// </summary>
		public int ApiVersion { get { return 8; } }

		/// <summary>
		/// A reserved field that should always be nulled.
		/// </summary>
		public IntPtr Reserved { get; set; }

		/// <summary>
		/// The product id for the running application, found on the dev portal
		/// </summary>
		public string ProductId { get; set; }

		/// <summary>
		/// The sandbox id for the running application, found on the dev portal
		/// </summary>
		public string SandboxId { get; set; }

		/// <summary>
		/// Set of service permissions associated with the running application
		/// </summary>
		public ClientCredentials ClientCredentials { get; set; }

		/// <summary>
		/// Is this running as a server
		/// </summary>
		public bool IsServer { get; set; }

		/// <summary>
		/// Only used by Player Data Storage. Must be null initialized if unused. 256-bit Encryption Key for file encryption in hexadecimal format (64 hex chars)
		/// </summary>
		public string EncryptionKey { get; set; }

		/// <summary>
		/// The override country code to use for the logged in user. (<see cref="PlatformInterface.CountrycodeMaxLength" />)
		/// </summary>
		public string OverrideCountryCode { get; set; }

		/// <summary>
		/// The override locale code to use for the logged in user. This follows ISO 639. (<see cref="PlatformInterface.LocalecodeMaxLength" />)
		/// </summary>
		public string OverrideLocaleCode { get; set; }

		/// <summary>
		/// The deployment id for the running application, found on the dev portal
		/// </summary>
		public string DeploymentId { get; set; }

		/// <summary>
		/// Platform creation flags, e.g. <see cref="PlatformFlags.LoadingInEditor" />. This is a bitwise-or union of the defined flags.
		/// </summary>
		public PlatformFlags Flags { get; set; }

		/// <summary>
		/// Only used by Player Data Storage. Must be null initialized if unused. Cache directory path. Absolute path to the folder that is going to be used for caching temporary data. The path is created if it's missing.
		/// </summary>
		public string CacheDirectory { get; set; }

		/// <summary>
		/// A budget, measured in milliseconds, for <see cref="PlatformInterface.Tick" /> to do its work. When the budget is met or exceeded (or if no work is available), <see cref="PlatformInterface.Tick" /> will return.
		/// This allows your game to amortize the cost of SDK work across multiple frames in the event that a lot of work is queued for processing.
		/// Zero is interpreted as "perform all available work"
		/// </summary>
		public uint TickBudgetInMilliseconds { get; set; }
	}

	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	internal struct OptionsInternal : IDisposable
	{
		private int m_ApiVersion;
		private IntPtr m_Reserved;
		[MarshalAs(UnmanagedType.LPStr)]
		private string m_ProductId;
		[MarshalAs(UnmanagedType.LPStr)]
		private string m_SandboxId;
		private ClientCredentialsInternal m_ClientCredentials;
		private int m_IsServer;
		[MarshalAs(UnmanagedType.LPStr)]
		private string m_EncryptionKey;
		[MarshalAs(UnmanagedType.LPStr)]
		private string m_OverrideCountryCode;
		[MarshalAs(UnmanagedType.LPStr)]
		private string m_OverrideLocaleCode;
		[MarshalAs(UnmanagedType.LPStr)]
		private string m_DeploymentId;
		private PlatformFlags m_Flags;
		[MarshalAs(UnmanagedType.LPStr)]
		private string m_CacheDirectory;
		private uint m_TickBudgetInMilliseconds;

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

		public IntPtr Reserved
		{
			get
			{
				var value = Helper.GetDefault<IntPtr>();
				Helper.TryMarshalGet(m_Reserved, out value);
				return value;
			}
			set { Helper.TryMarshalSet(ref m_Reserved, value); }
		}

		public string ProductId
		{
			get
			{
				var value = Helper.GetDefault<string>();
				Helper.TryMarshalGet(m_ProductId, out value);
				return value;
			}
			set { Helper.TryMarshalSet(ref m_ProductId, value); }
		}

		public string SandboxId
		{
			get
			{
				var value = Helper.GetDefault<string>();
				Helper.TryMarshalGet(m_SandboxId, out value);
				return value;
			}
			set { Helper.TryMarshalSet(ref m_SandboxId, value); }
		}

		public ClientCredentialsInternal ClientCredentials
		{
			get
			{
				var value = Helper.GetDefault<ClientCredentialsInternal>();
				Helper.TryMarshalGet(m_ClientCredentials, out value);
				return value;
			}
			set { Helper.TryMarshalSet(ref m_ClientCredentials, value); }
		}

		public bool IsServer
		{
			get
			{
				var value = Helper.GetDefault<bool>();
				Helper.TryMarshalGet(m_IsServer, out value);
				return value;
			}
			set { Helper.TryMarshalSet(ref m_IsServer, value); }
		}

		public string EncryptionKey
		{
			get
			{
				var value = Helper.GetDefault<string>();
				Helper.TryMarshalGet(m_EncryptionKey, out value);
				return value;
			}
			set { Helper.TryMarshalSet(ref m_EncryptionKey, value); }
		}

		public string OverrideCountryCode
		{
			get
			{
				var value = Helper.GetDefault<string>();
				Helper.TryMarshalGet(m_OverrideCountryCode, out value);
				return value;
			}
			set { Helper.TryMarshalSet(ref m_OverrideCountryCode, value); }
		}

		public string OverrideLocaleCode
		{
			get
			{
				var value = Helper.GetDefault<string>();
				Helper.TryMarshalGet(m_OverrideLocaleCode, out value);
				return value;
			}
			set { Helper.TryMarshalSet(ref m_OverrideLocaleCode, value); }
		}

		public string DeploymentId
		{
			get
			{
				var value = Helper.GetDefault<string>();
				Helper.TryMarshalGet(m_DeploymentId, out value);
				return value;
			}
			set { Helper.TryMarshalSet(ref m_DeploymentId, value); }
		}

		public PlatformFlags Flags
		{
			get
			{
				var value = Helper.GetDefault<PlatformFlags>();
				Helper.TryMarshalGet(m_Flags, out value);
				return value;
			}
			set { Helper.TryMarshalSet(ref m_Flags, value); }
		}

		public string CacheDirectory
		{
			get
			{
				var value = Helper.GetDefault<string>();
				Helper.TryMarshalGet(m_CacheDirectory, out value);
				return value;
			}
			set { Helper.TryMarshalSet(ref m_CacheDirectory, value); }
		}

		public uint TickBudgetInMilliseconds
		{
			get
			{
				var value = Helper.GetDefault<uint>();
				Helper.TryMarshalGet(m_TickBudgetInMilliseconds, out value);
				return value;
			}
			set { Helper.TryMarshalSet(ref m_TickBudgetInMilliseconds, value); }
		}

		public void Dispose()
		{
			Helper.TryMarshalDispose(ref m_ClientCredentials);
		}
	}
}