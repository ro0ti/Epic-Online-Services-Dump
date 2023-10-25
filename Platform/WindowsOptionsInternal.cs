using System;
using Epic.OnlineServices.IntegratedPlatform;
// Dumped by ro0ti

namespace Epic.OnlineServices.Platform
{
	// Token: 0x02000739 RID: 1849
	[Token(Token = "0x2000739")]
	internal struct WindowsOptionsInternal : ISettable<WindowsOptions>, IDisposable
	{
		// Token: 0x17000E31 RID: 3633
		// (set) Token: 0x06002F73 RID: 12147 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E31")]
		public IntPtr Reserved
		{
			[Token(Token = "0x6002F73")]
			[Address(RVA = "0x487590", Offset = "0x485B90", VA = "0x180487590")]
			set
			{
			}
		}

		// Token: 0x17000E32 RID: 3634
		// (set) Token: 0x06002F74 RID: 12148 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E32")]
		public Utf8String ProductId
		{
			[Token(Token = "0x6002F74")]
			[Address(RVA = "0x583200", Offset = "0x581800", VA = "0x180583200")]
			set
			{
			}
		}

		// Token: 0x17000E33 RID: 3635
		// (set) Token: 0x06002F75 RID: 12149 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E33")]
		public Utf8String SandboxId
		{
			[Token(Token = "0x6002F75")]
			[Address(RVA = "0x5832D0", Offset = "0x5818D0", VA = "0x1805832D0")]
			set
			{
			}
		}

		// Token: 0x17000E34 RID: 3636
		// (set) Token: 0x06002F76 RID: 12150 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E34")]
		public ClientCredentials ClientCredentials
		{
			[Token(Token = "0x6002F76")]
			[Address(RVA = "0x582F50", Offset = "0x581550", VA = "0x180582F50")]
			set
			{
			}
		}

		// Token: 0x17000E35 RID: 3637
		// (set) Token: 0x06002F77 RID: 12151 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E35")]
		public bool IsServer
		{
			[Token(Token = "0x6002F77")]
			[Address(RVA = "0x5830E0", Offset = "0x5816E0", VA = "0x1805830E0")]
			set
			{
			}
		}

		// Token: 0x17000E36 RID: 3638
		// (set) Token: 0x06002F78 RID: 12152 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E36")]
		public Utf8String EncryptionKey
		{
			[Token(Token = "0x6002F78")]
			[Address(RVA = "0x583020", Offset = "0x581620", VA = "0x180583020")]
			set
			{
			}
		}

		// Token: 0x17000E37 RID: 3639
		// (set) Token: 0x06002F79 RID: 12153 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E37")]
		public Utf8String OverrideCountryCode
		{
			[Token(Token = "0x6002F79")]
			[Address(RVA = "0x583140", Offset = "0x581740", VA = "0x180583140")]
			set
			{
			}
		}

		// Token: 0x17000E38 RID: 3640
		// (set) Token: 0x06002F7A RID: 12154 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E38")]
		public Utf8String OverrideLocaleCode
		{
			[Token(Token = "0x6002F7A")]
			[Address(RVA = "0x5831A0", Offset = "0x5817A0", VA = "0x1805831A0")]
			set
			{
			}
		}

		// Token: 0x17000E39 RID: 3641
		// (set) Token: 0x06002F7B RID: 12155 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E39")]
		public Utf8String DeploymentId
		{
			[Token(Token = "0x6002F7B")]
			[Address(RVA = "0x582FC0", Offset = "0x5815C0", VA = "0x180582FC0")]
			set
			{
			}
		}

		// Token: 0x17000E3A RID: 3642
		// (set) Token: 0x06002F7C RID: 12156 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E3A")]
		public PlatformFlags Flags
		{
			[Token(Token = "0x6002F7C")]
			[Address(RVA = "0x57A1F0", Offset = "0x5787F0", VA = "0x18057A1F0")]
			set
			{
			}
		}

		// Token: 0x17000E3B RID: 3643
		// (set) Token: 0x06002F7D RID: 12157 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E3B")]
		public Utf8String CacheDirectory
		{
			[Token(Token = "0x6002F7D")]
			[Address(RVA = "0x582EF0", Offset = "0x5814F0", VA = "0x180582EF0")]
			set
			{
			}
		}

		// Token: 0x17000E3C RID: 3644
		// (set) Token: 0x06002F7E RID: 12158 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E3C")]
		public uint TickBudgetInMilliseconds
		{
			[Token(Token = "0x6002F7E")]
			[Address(RVA = "0x575C30", Offset = "0x574230", VA = "0x180575C30")]
			set
			{
			}
		}

		// Token: 0x17000E3D RID: 3645
		// (set) Token: 0x06002F7F RID: 12159 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E3D")]
		public WindowsRTCOptions? RTCOptions
		{
			[Token(Token = "0x6002F7F")]
			[Address(RVA = "0x583260", Offset = "0x581860", VA = "0x180583260")]
			set
			{
			}
		}

		// Token: 0x17000E3E RID: 3646
		// (set) Token: 0x06002F80 RID: 12160 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E3E")]
		public IntegratedPlatformOptionsContainer IntegratedPlatformOptionsContainerHandle
		{
			[Token(Token = "0x6002F80")]
			[Address(RVA = "0x583080", Offset = "0x581680", VA = "0x180583080")]
			set
			{
			}
		}

		// Token: 0x17000E3F RID: 3647
		// (set) Token: 0x06002F81 RID: 12161 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E3F")]
		public IntPtr SystemSpecificOptions
		{
			[Token(Token = "0x6002F81")]
			[Address(RVA = "0x53BF80", Offset = "0x53A580", VA = "0x18053BF80")]
			set
			{
			}
		}

		// Token: 0x06002F82 RID: 12162 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002F82")]
		[Address(RVA = "0x5826B0", Offset = "0x580CB0", VA = "0x1805826B0", Slot = "4")]
		public void Set(ref WindowsOptions other)
		{
		}

		// Token: 0x06002F83 RID: 12163 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002F83")]
		[Address(RVA = "0x582A30", Offset = "0x581030", VA = "0x180582A30", Slot = "5")]
		public void Set(ref WindowsOptions? other)
		{
		}

		// Token: 0x06002F84 RID: 12164 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002F84")]
		[Address(RVA = "0x5825D0", Offset = "0x580BD0", VA = "0x1805825D0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x0400154B RID: 5451
		[Token(Token = "0x400154B")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x0400154C RID: 5452
		[Token(Token = "0x400154C")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_Reserved;

		// Token: 0x0400154D RID: 5453
		[Token(Token = "0x400154D")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_ProductId;

		// Token: 0x0400154E RID: 5454
		[Token(Token = "0x400154E")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_SandboxId;

		// Token: 0x0400154F RID: 5455
		[Token(Token = "0x400154F")]
		[FieldOffset(Offset = "0x20")]
		private ClientCredentialsInternal m_ClientCredentials;

		// Token: 0x04001550 RID: 5456
		[Token(Token = "0x4001550")]
		[FieldOffset(Offset = "0x30")]
		private int m_IsServer;

		// Token: 0x04001551 RID: 5457
		[Token(Token = "0x4001551")]
		[FieldOffset(Offset = "0x38")]
		private IntPtr m_EncryptionKey;

		// Token: 0x04001552 RID: 5458
		[Token(Token = "0x4001552")]
		[FieldOffset(Offset = "0x40")]
		private IntPtr m_OverrideCountryCode;

		// Token: 0x04001553 RID: 5459
		[Token(Token = "0x4001553")]
		[FieldOffset(Offset = "0x48")]
		private IntPtr m_OverrideLocaleCode;

		// Token: 0x04001554 RID: 5460
		[Token(Token = "0x4001554")]
		[FieldOffset(Offset = "0x50")]
		private IntPtr m_DeploymentId;

		// Token: 0x04001555 RID: 5461
		[Token(Token = "0x4001555")]
		[FieldOffset(Offset = "0x58")]
		private PlatformFlags m_Flags;

		// Token: 0x04001556 RID: 5462
		[Token(Token = "0x4001556")]
		[FieldOffset(Offset = "0x60")]
		private IntPtr m_CacheDirectory;

		// Token: 0x04001557 RID: 5463
		[Token(Token = "0x4001557")]
		[FieldOffset(Offset = "0x68")]
		private uint m_TickBudgetInMilliseconds;

		// Token: 0x04001558 RID: 5464
		[Token(Token = "0x4001558")]
		[FieldOffset(Offset = "0x70")]
		private IntPtr m_RTCOptions;

		// Token: 0x04001559 RID: 5465
		[Token(Token = "0x4001559")]
		[FieldOffset(Offset = "0x78")]
		private IntPtr m_IntegratedPlatformOptionsContainerHandle;

		// Token: 0x0400155A RID: 5466
		[Token(Token = "0x400155A")]
		[FieldOffset(Offset = "0x80")]
		private IntPtr m_SystemSpecificOptions;
	}
}
