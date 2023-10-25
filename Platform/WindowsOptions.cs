using System;
using System.Runtime.CompilerServices;
using Epic.OnlineServices.IntegratedPlatform;
// Dumped by ro0ti

namespace Epic.OnlineServices.Platform
{
	// Token: 0x02000738 RID: 1848
	[Token(Token = "0x2000738")]
	public struct WindowsOptions
	{
		// Token: 0x17000E22 RID: 3618
		// (get) Token: 0x06002F55 RID: 12117 RVA: 0x0000C50C File Offset: 0x0000A70C
		// (set) Token: 0x06002F56 RID: 12118 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E22")]
		public IntPtr Reserved
		{
			[Token(Token = "0x6002F55")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[Token(Token = "0x6002F56")]
			[Address(RVA = "0x4875D0", Offset = "0x485BD0", VA = "0x1804875D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000E23 RID: 3619
		// (get) Token: 0x06002F57 RID: 12119 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002F58 RID: 12120 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E23")]
		public Utf8String ProductId
		{
			[Token(Token = "0x6002F57")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002F58")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000E24 RID: 3620
		// (get) Token: 0x06002F59 RID: 12121 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002F5A RID: 12122 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E24")]
		public Utf8String SandboxId
		{
			[Token(Token = "0x6002F59")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002F5A")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000E25 RID: 3621
		// (get) Token: 0x06002F5B RID: 12123 RVA: 0x0000C524 File Offset: 0x0000A724
		// (set) Token: 0x06002F5C RID: 12124 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E25")]
		public ClientCredentials ClientCredentials
		{
			[Token(Token = "0x6002F5B")]
			[Address(RVA = "0x51A4B0", Offset = "0x518AB0", VA = "0x18051A4B0")]
			[CompilerGenerated]
			readonly get
			{
				return default(ClientCredentials);
			}
			[Token(Token = "0x6002F5C")]
			[Address(RVA = "0x57A4D0", Offset = "0x578AD0", VA = "0x18057A4D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000E26 RID: 3622
		// (get) Token: 0x06002F5D RID: 12125 RVA: 0x0000C53C File Offset: 0x0000A73C
		// (set) Token: 0x06002F5E RID: 12126 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E26")]
		public bool IsServer
		{
			[Token(Token = "0x6002F5D")]
			[Address(RVA = "0x481820", Offset = "0x47FE20", VA = "0x180481820")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Token(Token = "0x6002F5E")]
			[Address(RVA = "0x4818D0", Offset = "0x47FED0", VA = "0x1804818D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000E27 RID: 3623
		// (get) Token: 0x06002F5F RID: 12127 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002F60 RID: 12128 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E27")]
		public Utf8String EncryptionKey
		{
			[Token(Token = "0x6002F5F")]
			[Address(RVA = "0x475020", Offset = "0x473620", VA = "0x180475020")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002F60")]
			[Address(RVA = "0x4D5030", Offset = "0x4D3630", VA = "0x1804D5030")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000E28 RID: 3624
		// (get) Token: 0x06002F61 RID: 12129 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002F62 RID: 12130 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E28")]
		public Utf8String OverrideCountryCode
		{
			[Token(Token = "0x6002F61")]
			[Address(RVA = "0x4BBE60", Offset = "0x4BA460", VA = "0x1804BBE60")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002F62")]
			[Address(RVA = "0x4BBE90", Offset = "0x4BA490", VA = "0x1804BBE90")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000E29 RID: 3625
		// (get) Token: 0x06002F63 RID: 12131 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002F64 RID: 12132 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E29")]
		public Utf8String OverrideLocaleCode
		{
			[Token(Token = "0x6002F63")]
			[Address(RVA = "0x4C33D0", Offset = "0x4C19D0", VA = "0x1804C33D0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002F64")]
			[Address(RVA = "0x4C3420", Offset = "0x4C1A20", VA = "0x1804C3420")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000E2A RID: 3626
		// (get) Token: 0x06002F65 RID: 12133 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002F66 RID: 12134 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E2A")]
		public Utf8String DeploymentId
		{
			[Token(Token = "0x6002F65")]
			[Address(RVA = "0x4C8040", Offset = "0x4C6640", VA = "0x1804C8040")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002F66")]
			[Address(RVA = "0x4C8070", Offset = "0x4C6670", VA = "0x1804C8070")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000E2B RID: 3627
		// (get) Token: 0x06002F67 RID: 12135 RVA: 0x0000C554 File Offset: 0x0000A754
		// (set) Token: 0x06002F68 RID: 12136 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E2B")]
		public PlatformFlags Flags
		{
			[Token(Token = "0x6002F67")]
			[Address(RVA = "0x3D6650", Offset = "0x3D4C50", VA = "0x1803D6650")]
			[CompilerGenerated]
			readonly get
			{
				return PlatformFlags.None;
			}
			[Token(Token = "0x6002F68")]
			[Address(RVA = "0x53ABB0", Offset = "0x5391B0", VA = "0x18053ABB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000E2C RID: 3628
		// (get) Token: 0x06002F69 RID: 12137 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002F6A RID: 12138 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E2C")]
		public Utf8String CacheDirectory
		{
			[Token(Token = "0x6002F69")]
			[Address(RVA = "0x55E7E0", Offset = "0x55CDE0", VA = "0x18055E7E0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002F6A")]
			[Address(RVA = "0x55E810", Offset = "0x55CE10", VA = "0x18055E810")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000E2D RID: 3629
		// (get) Token: 0x06002F6B RID: 12139 RVA: 0x0000C56C File Offset: 0x0000A76C
		// (set) Token: 0x06002F6C RID: 12140 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E2D")]
		public uint TickBudgetInMilliseconds
		{
			[Token(Token = "0x6002F6B")]
			[Address(RVA = "0x575DC0", Offset = "0x5743C0", VA = "0x180575DC0")]
			[CompilerGenerated]
			readonly get
			{
				return 0U;
			}
			[Token(Token = "0x6002F6C")]
			[Address(RVA = "0x575EE0", Offset = "0x5744E0", VA = "0x180575EE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000E2E RID: 3630
		// (get) Token: 0x06002F6D RID: 12141 RVA: 0x0000C584 File Offset: 0x0000A784
		// (set) Token: 0x06002F6E RID: 12142 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E2E")]
		public WindowsRTCOptions? RTCOptions
		{
			[Token(Token = "0x6002F6D")]
			[Address(RVA = "0x583330", Offset = "0x581930", VA = "0x180583330")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002F6E")]
			[Address(RVA = "0x583370", Offset = "0x581970", VA = "0x180583370")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000E2F RID: 3631
		// (get) Token: 0x06002F6F RID: 12143 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002F70 RID: 12144 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E2F")]
		public IntegratedPlatformOptionsContainer IntegratedPlatformOptionsContainerHandle
		{
			[Token(Token = "0x6002F6F")]
			[Address(RVA = "0x53BAD0", Offset = "0x53A0D0", VA = "0x18053BAD0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002F70")]
			[Address(RVA = "0x583350", Offset = "0x581950", VA = "0x180583350")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000E30 RID: 3632
		// (get) Token: 0x06002F71 RID: 12145 RVA: 0x0000C59C File Offset: 0x0000A79C
		// (set) Token: 0x06002F72 RID: 12146 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E30")]
		public IntPtr SystemSpecificOptions
		{
			[Token(Token = "0x6002F71")]
			[Address(RVA = "0x400180", Offset = "0x3FE780", VA = "0x180400180")]
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[Token(Token = "0x6002F72")]
			[Address(RVA = "0x583390", Offset = "0x581990", VA = "0x180583390")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
