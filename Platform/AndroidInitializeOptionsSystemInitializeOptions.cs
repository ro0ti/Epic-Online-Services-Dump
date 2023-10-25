using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Platform
{
	// Token: 0x0200071F RID: 1823
	[Token(Token = "0x200071F")]
	public struct AndroidInitializeOptionsSystemInitializeOptions
	{
		// Token: 0x17000DD6 RID: 3542
		// (get) Token: 0x06002E73 RID: 11891 RVA: 0x0000C05C File Offset: 0x0000A25C
		// (set) Token: 0x06002E74 RID: 11892 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000DD6")]
		public IntPtr Reserved
		{
			[Token(Token = "0x6002E73")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[Token(Token = "0x6002E74")]
			[Address(RVA = "0x4875D0", Offset = "0x485BD0", VA = "0x1804875D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000DD7 RID: 3543
		// (get) Token: 0x06002E75 RID: 11893 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002E76 RID: 11894 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000DD7")]
		public Utf8String OptionalInternalDirectory
		{
			[Token(Token = "0x6002E75")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002E76")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000DD8 RID: 3544
		// (get) Token: 0x06002E77 RID: 11895 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002E78 RID: 11896 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000DD8")]
		public Utf8String OptionalExternalDirectory
		{
			[Token(Token = "0x6002E77")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002E78")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002E79 RID: 11897 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002E79")]
		[Address(RVA = "0x56C380", Offset = "0x56A980", VA = "0x18056C380")]
		internal void Set(ref AndroidInitializeOptionsSystemInitializeOptionsInternal other)
		{
		}
	}
}
