using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.IntegratedPlatform
{
	// Token: 0x020004F0 RID: 1264
	[Token(Token = "0x20004F0")]
	public struct SteamOptions
	{
		// Token: 0x17000922 RID: 2338
		// (get) Token: 0x0600204D RID: 8269 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600204E RID: 8270 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000922")]
		public Utf8String OverrideLibraryPath
		{
			[Token(Token = "0x600204D")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600204E")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000923 RID: 2339
		// (get) Token: 0x0600204F RID: 8271 RVA: 0x00008B04 File Offset: 0x00006D04
		// (set) Token: 0x06002050 RID: 8272 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000923")]
		public uint SteamMajorVersion
		{
			[Token(Token = "0x600204F")]
			[Address(RVA = "0x4875A0", Offset = "0x485BA0", VA = "0x1804875A0")]
			[CompilerGenerated]
			readonly get
			{
				return 0U;
			}
			[Token(Token = "0x6002050")]
			[Address(RVA = "0x4875C0", Offset = "0x485BC0", VA = "0x1804875C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000924 RID: 2340
		// (get) Token: 0x06002051 RID: 8273 RVA: 0x00008B1C File Offset: 0x00006D1C
		// (set) Token: 0x06002052 RID: 8274 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000924")]
		public uint SteamMinorVersion
		{
			[Token(Token = "0x6002051")]
			[Address(RVA = "0x4AF750", Offset = "0x4ADD50", VA = "0x1804AF750")]
			[CompilerGenerated]
			readonly get
			{
				return 0U;
			}
			[Token(Token = "0x6002052")]
			[Address(RVA = "0x4AF760", Offset = "0x4ADD60", VA = "0x1804AF760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002053 RID: 8275 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002053")]
		[Address(RVA = "0x551430", Offset = "0x54FA30", VA = "0x180551430")]
		internal void Set(ref SteamOptionsInternal other)
		{
		}
	}
}
