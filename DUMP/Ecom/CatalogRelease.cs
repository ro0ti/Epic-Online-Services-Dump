using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.Ecom
{
	// Token: 0x0200052A RID: 1322
	[Token(Token = "0x200052A")]
	public struct CatalogRelease
	{
		// Token: 0x170009D4 RID: 2516
		// (get) Token: 0x0600223F RID: 8767 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002240 RID: 8768 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170009D4")]
		public Utf8String[] CompatibleAppIds
		{
			[Token(Token = "0x600223F")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002240")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170009D5 RID: 2517
		// (get) Token: 0x06002241 RID: 8769 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002242 RID: 8770 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170009D5")]
		public Utf8String[] CompatiblePlatforms
		{
			[Token(Token = "0x6002241")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002242")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170009D6 RID: 2518
		// (get) Token: 0x06002243 RID: 8771 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002244 RID: 8772 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170009D6")]
		public Utf8String ReleaseNote
		{
			[Token(Token = "0x6002243")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002244")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002245 RID: 8773 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002245")]
		[Address(RVA = "0x53C8E0", Offset = "0x53AEE0", VA = "0x18053C8E0")]
		internal void Set(ref CatalogReleaseInternal other)
		{
		}
	}
}
