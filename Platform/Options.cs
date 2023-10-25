using System;
using System.Runtime.CompilerServices;
using Epic.OnlineServices.IntegratedPlatform;
// Dumped by ro0ti

namespace Epic.OnlineServices.Platform
{
	// Token: 0x02000730 RID: 1840
	[Token(Token = "0x2000730")]
	public struct Options
	{
		// Token: 0x17000E00 RID: 3584
		// (get) Token: 0x06002F10 RID: 12048 RVA: 0x0000C404 File Offset: 0x0000A604
		// (set) Token: 0x06002F11 RID: 12049 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E00")]
		public IntPtr Reserved
		{
			[Token(Token = "0x6002F10")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[Token(Token = "0x6002F11")]
			[Address(RVA = "0x4875D0", Offset = "0x485BD0", VA = "0x1804875D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000E01 RID: 3585
		// (get) Token: 0x06002F12 RID: 12050 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002F13 RID: 12051 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E01")]
		public Utf8String ProductId
		{
			[Token(Token = "0x6002F12")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002F13")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000E02 RID: 3586
		// (get) Token: 0x06002F14 RID: 12052 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002F15 RID: 12053 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E02")]
		public Utf8String SandboxId
		{
			[Token(Token = "0x6002F14")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002F15")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000E03 RID: 3587
		// (get) Token: 0x06002F16 RID: 12054 RVA: 0x0000C41C File Offset: 0x0000A61C
		// (set) Token: 0x06002F17 RID: 12055 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E03")]
		public ClientCredentials ClientCredentials
		{
			[Token(Token = "0x6002F16")]
			[Address(RVA = "0x51A4B0", Offset = "0x518AB0", VA = "0x18051A4B0")]
			[CompilerGenerated]
			readonly get
			{
				return default(ClientCredentials);
			}
			[Token(Token = "0x6002F17")]
			[Address(RVA = "0x57A4D0", Offset = "0x578AD0", VA = "0x18057A4D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000E04 RID: 3588
		// (get) Token: 0x06002F18 RID: 12056 RVA: 0x0000C434 File Offset: 0x0000A634
		// (set) Token: 0x06002F19 RID: 12057 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E04")]
		public bool IsServer
		{
			[Token(Token = "0x6002F18")]
			[Address(RVA = "0x481820", Offset = "0x47FE20", VA = "0x180481820")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Token(Token = "0x6002F19")]
			[Address(RVA = "0x4818D0", Offset = "0x47FED0", VA = "0x1804818D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000E05 RID: 3589
		// (get) Token: 0x06002F1A RID: 12058 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002F1B RID: 12059 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E05")]
		public Utf8String EncryptionKey
		{
			[Token(Token = "0x6002F1A")]
			[Address(RVA = "0x475020", Offset = "0x473620", VA = "0x180475020")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002F1B")]
			[Address(RVA = "0x4D5030", Offset = "0x4D3630", VA = "0x1804D5030")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000E06 RID: 3590
		// (get) Token: 0x06002F1C RID: 12060 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002F1D RID: 12061 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E06")]
		public Utf8String OverrideCountryCode
		{
			[Token(Token = "0x6002F1C")]
			[Address(RVA = "0x4BBE60", Offset = "0x4BA460", VA = "0x1804BBE60")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002F1D")]
			[Address(RVA = "0x4BBE90", Offset = "0x4BA490", VA = "0x1804BBE90")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000E07 RID: 3591
		// (get) Token: 0x06002F1E RID: 12062 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002F1F RID: 12063 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E07")]
		public Utf8String OverrideLocaleCode
		{
			[Token(Token = "0x6002F1E")]
			[Address(RVA = "0x4C33D0", Offset = "0x4C19D0", VA = "0x1804C33D0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002F1F")]
			[Address(RVA = "0x4C3420", Offset = "0x4C1A20", VA = "0x1804C3420")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000E08 RID: 3592
		// (get) Token: 0x06002F20 RID: 12064 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002F21 RID: 12065 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E08")]
		public Utf8String DeploymentId
		{
			[Token(Token = "0x6002F20")]
			[Address(RVA = "0x4C8040", Offset = "0x4C6640", VA = "0x1804C8040")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002F21")]
			[Address(RVA = "0x4C8070", Offset = "0x4C6670", VA = "0x1804C8070")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000E09 RID: 3593
		// (get) Token: 0x06002F22 RID: 12066 RVA: 0x0000C44C File Offset: 0x0000A64C
		// (set) Token: 0x06002F23 RID: 12067 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E09")]
		public PlatformFlags Flags
		{
			[Token(Token = "0x6002F22")]
			[Address(RVA = "0x3D6650", Offset = "0x3D4C50", VA = "0x1803D6650")]
			[CompilerGenerated]
			readonly get
			{
				return PlatformFlags.None;
			}
			[Token(Token = "0x6002F23")]
			[Address(RVA = "0x53ABB0", Offset = "0x5391B0", VA = "0x18053ABB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000E0A RID: 3594
		// (get) Token: 0x06002F24 RID: 12068 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002F25 RID: 12069 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E0A")]
		public Utf8String CacheDirectory
		{
			[Token(Token = "0x6002F24")]
			[Address(RVA = "0x55E7E0", Offset = "0x55CDE0", VA = "0x18055E7E0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002F25")]
			[Address(RVA = "0x55E810", Offset = "0x55CE10", VA = "0x18055E810")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000E0B RID: 3595
		// (get) Token: 0x06002F26 RID: 12070 RVA: 0x0000C464 File Offset: 0x0000A664
		// (set) Token: 0x06002F27 RID: 12071 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E0B")]
		public uint TickBudgetInMilliseconds
		{
			[Token(Token = "0x6002F26")]
			[Address(RVA = "0x575DC0", Offset = "0x5743C0", VA = "0x180575DC0")]
			[CompilerGenerated]
			readonly get
			{
				return 0U;
			}
			[Token(Token = "0x6002F27")]
			[Address(RVA = "0x575EE0", Offset = "0x5744E0", VA = "0x180575EE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000E0C RID: 3596
		// (get) Token: 0x06002F28 RID: 12072 RVA: 0x0000C47C File Offset: 0x0000A67C
		// (set) Token: 0x06002F29 RID: 12073 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E0C")]
		public RTCOptions? RTCOptions
		{
			[Token(Token = "0x6002F28")]
			[Address(RVA = "0x57A4B0", Offset = "0x578AB0", VA = "0x18057A4B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002F29")]
			[Address(RVA = "0x57A500", Offset = "0x578B00", VA = "0x18057A500")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000E0D RID: 3597
		// (get) Token: 0x06002F2A RID: 12074 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002F2B RID: 12075 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E0D")]
		public IntegratedPlatformOptionsContainer IntegratedPlatformOptionsContainerHandle
		{
			[Token(Token = "0x6002F2A")]
			[Address(RVA = "0x456070", Offset = "0x454670", VA = "0x180456070")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002F2B")]
			[Address(RVA = "0x57A4F0", Offset = "0x578AF0", VA = "0x18057A4F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000E0E RID: 3598
		// (get) Token: 0x06002F2C RID: 12076 RVA: 0x0000C494 File Offset: 0x0000A694
		// (set) Token: 0x06002F2D RID: 12077 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E0E")]
		public IntPtr SystemSpecificOptions
		{
			[Token(Token = "0x6002F2C")]
			[Address(RVA = "0x53BAD0", Offset = "0x53A0D0", VA = "0x18053BAD0")]
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[Token(Token = "0x6002F2D")]
			[Address(RVA = "0x53BE80", Offset = "0x53A480", VA = "0x18053BE80")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
