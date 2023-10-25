using System;
using Epic.OnlineServices.IntegratedPlatform;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Platform
{
	// Token: 0x02000731 RID: 1841
	[Token(Token = "0x2000731")]
	internal struct OptionsInternal : ISettable<Options>, IDisposable
	{
		// Token: 0x17000E0F RID: 3599
		// (set) Token: 0x06002F2E RID: 12078 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E0F")]
		public IntPtr Reserved
		{
			[Token(Token = "0x6002F2E")]
			[Address(RVA = "0x487590", Offset = "0x485B90", VA = "0x180487590")]
			set
			{
			}
		}

		// Token: 0x17000E10 RID: 3600
		// (set) Token: 0x06002F2F RID: 12079 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E10")]
		public Utf8String ProductId
		{
			[Token(Token = "0x6002F2F")]
			[Address(RVA = "0x57A380", Offset = "0x578980", VA = "0x18057A380")]
			set
			{
			}
		}

		// Token: 0x17000E11 RID: 3601
		// (set) Token: 0x06002F30 RID: 12080 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E11")]
		public Utf8String SandboxId
		{
			[Token(Token = "0x6002F30")]
			[Address(RVA = "0x57A450", Offset = "0x578A50", VA = "0x18057A450")]
			set
			{
			}
		}

		// Token: 0x17000E12 RID: 3602
		// (set) Token: 0x06002F31 RID: 12081 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E12")]
		public ClientCredentials ClientCredentials
		{
			[Token(Token = "0x6002F31")]
			[Address(RVA = "0x57A0C0", Offset = "0x5786C0", VA = "0x18057A0C0")]
			set
			{
			}
		}

		// Token: 0x17000E13 RID: 3603
		// (set) Token: 0x06002F32 RID: 12082 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E13")]
		public bool IsServer
		{
			[Token(Token = "0x6002F32")]
			[Address(RVA = "0x57A260", Offset = "0x578860", VA = "0x18057A260")]
			set
			{
			}
		}

		// Token: 0x17000E14 RID: 3604
		// (set) Token: 0x06002F33 RID: 12083 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E14")]
		public Utf8String EncryptionKey
		{
			[Token(Token = "0x6002F33")]
			[Address(RVA = "0x57A190", Offset = "0x578790", VA = "0x18057A190")]
			set
			{
			}
		}

		// Token: 0x17000E15 RID: 3605
		// (set) Token: 0x06002F34 RID: 12084 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E15")]
		public Utf8String OverrideCountryCode
		{
			[Token(Token = "0x6002F34")]
			[Address(RVA = "0x57A2C0", Offset = "0x5788C0", VA = "0x18057A2C0")]
			set
			{
			}
		}

		// Token: 0x17000E16 RID: 3606
		// (set) Token: 0x06002F35 RID: 12085 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E16")]
		public Utf8String OverrideLocaleCode
		{
			[Token(Token = "0x6002F35")]
			[Address(RVA = "0x57A320", Offset = "0x578920", VA = "0x18057A320")]
			set
			{
			}
		}

		// Token: 0x17000E17 RID: 3607
		// (set) Token: 0x06002F36 RID: 12086 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E17")]
		public Utf8String DeploymentId
		{
			[Token(Token = "0x6002F36")]
			[Address(RVA = "0x57A130", Offset = "0x578730", VA = "0x18057A130")]
			set
			{
			}
		}

		// Token: 0x17000E18 RID: 3608
		// (set) Token: 0x06002F37 RID: 12087 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E18")]
		public PlatformFlags Flags
		{
			[Token(Token = "0x6002F37")]
			[Address(RVA = "0x57A1F0", Offset = "0x5787F0", VA = "0x18057A1F0")]
			set
			{
			}
		}

		// Token: 0x17000E19 RID: 3609
		// (set) Token: 0x06002F38 RID: 12088 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E19")]
		public Utf8String CacheDirectory
		{
			[Token(Token = "0x6002F38")]
			[Address(RVA = "0x57A060", Offset = "0x578660", VA = "0x18057A060")]
			set
			{
			}
		}

		// Token: 0x17000E1A RID: 3610
		// (set) Token: 0x06002F39 RID: 12089 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E1A")]
		public uint TickBudgetInMilliseconds
		{
			[Token(Token = "0x6002F39")]
			[Address(RVA = "0x575C30", Offset = "0x574230", VA = "0x180575C30")]
			set
			{
			}
		}

		// Token: 0x17000E1B RID: 3611
		// (set) Token: 0x06002F3A RID: 12090 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E1B")]
		public RTCOptions? RTCOptions
		{
			[Token(Token = "0x6002F3A")]
			[Address(RVA = "0x57A3E0", Offset = "0x5789E0", VA = "0x18057A3E0")]
			set
			{
			}
		}

		// Token: 0x17000E1C RID: 3612
		// (set) Token: 0x06002F3B RID: 12091 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E1C")]
		public IntegratedPlatformOptionsContainer IntegratedPlatformOptionsContainerHandle
		{
			[Token(Token = "0x6002F3B")]
			[Address(RVA = "0x57A200", Offset = "0x578800", VA = "0x18057A200")]
			set
			{
			}
		}

		// Token: 0x17000E1D RID: 3613
		// (set) Token: 0x06002F3C RID: 12092 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E1D")]
		public IntPtr SystemSpecificOptions
		{
			[Token(Token = "0x6002F3C")]
			[Address(RVA = "0x53BF80", Offset = "0x53A580", VA = "0x18053BF80")]
			set
			{
			}
		}

		// Token: 0x06002F3D RID: 12093 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002F3D")]
		[Address(RVA = "0x579CD0", Offset = "0x5782D0", VA = "0x180579CD0", Slot = "4")]
		public void Set(ref Options other)
		{
		}

		// Token: 0x06002F3E RID: 12094 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002F3E")]
		[Address(RVA = "0x579810", Offset = "0x577E10", VA = "0x180579810", Slot = "5")]
		public void Set(ref Options? other)
		{
		}

		// Token: 0x06002F3F RID: 12095 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002F3F")]
		[Address(RVA = "0x579730", Offset = "0x577D30", VA = "0x180579730", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x0400151A RID: 5402
		[Token(Token = "0x400151A")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x0400151B RID: 5403
		[Token(Token = "0x400151B")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_Reserved;

		// Token: 0x0400151C RID: 5404
		[Token(Token = "0x400151C")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_ProductId;

		// Token: 0x0400151D RID: 5405
		[Token(Token = "0x400151D")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_SandboxId;

		// Token: 0x0400151E RID: 5406
		[Token(Token = "0x400151E")]
		[FieldOffset(Offset = "0x20")]
		private ClientCredentialsInternal m_ClientCredentials;

		// Token: 0x0400151F RID: 5407
		[Token(Token = "0x400151F")]
		[FieldOffset(Offset = "0x30")]
		private int m_IsServer;

		// Token: 0x04001520 RID: 5408
		[Token(Token = "0x4001520")]
		[FieldOffset(Offset = "0x38")]
		private IntPtr m_EncryptionKey;

		// Token: 0x04001521 RID: 5409
		[Token(Token = "0x4001521")]
		[FieldOffset(Offset = "0x40")]
		private IntPtr m_OverrideCountryCode;

		// Token: 0x04001522 RID: 5410
		[Token(Token = "0x4001522")]
		[FieldOffset(Offset = "0x48")]
		private IntPtr m_OverrideLocaleCode;

		// Token: 0x04001523 RID: 5411
		[Token(Token = "0x4001523")]
		[FieldOffset(Offset = "0x50")]
		private IntPtr m_DeploymentId;

		// Token: 0x04001524 RID: 5412
		[Token(Token = "0x4001524")]
		[FieldOffset(Offset = "0x58")]
		private PlatformFlags m_Flags;

		// Token: 0x04001525 RID: 5413
		[Token(Token = "0x4001525")]
		[FieldOffset(Offset = "0x60")]
		private IntPtr m_CacheDirectory;

		// Token: 0x04001526 RID: 5414
		[Token(Token = "0x4001526")]
		[FieldOffset(Offset = "0x68")]
		private uint m_TickBudgetInMilliseconds;

		// Token: 0x04001527 RID: 5415
		[Token(Token = "0x4001527")]
		[FieldOffset(Offset = "0x70")]
		private IntPtr m_RTCOptions;

		// Token: 0x04001528 RID: 5416
		[Token(Token = "0x4001528")]
		[FieldOffset(Offset = "0x78")]
		private IntPtr m_IntegratedPlatformOptionsContainerHandle;

		// Token: 0x04001529 RID: 5417
		[Token(Token = "0x4001529")]
		[FieldOffset(Offset = "0x80")]
		private IntPtr m_SystemSpecificOptions;
	}
}
