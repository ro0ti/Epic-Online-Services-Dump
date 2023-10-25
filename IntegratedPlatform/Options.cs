using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.IntegratedPlatform
{
	// Token: 0x020004EA RID: 1258
	[Token(Token = "0x20004EA")]
	public struct Options
	{
		// Token: 0x17000916 RID: 2326
		// (get) Token: 0x0600202D RID: 8237 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600202E RID: 8238 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000916")]
		public Utf8String Type
		{
			[Token(Token = "0x600202D")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600202E")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000917 RID: 2327
		// (get) Token: 0x0600202F RID: 8239 RVA: 0x00008A8C File Offset: 0x00006C8C
		// (set) Token: 0x06002030 RID: 8240 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000917")]
		public IntegratedPlatformManagementFlags Flags
		{
			[Token(Token = "0x600202F")]
			[Address(RVA = "0x4875A0", Offset = "0x485BA0", VA = "0x1804875A0")]
			[CompilerGenerated]
			readonly get
			{
				return (IntegratedPlatformManagementFlags)0;
			}
			[Token(Token = "0x6002030")]
			[Address(RVA = "0x4875C0", Offset = "0x485BC0", VA = "0x1804875C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000918 RID: 2328
		// (get) Token: 0x06002031 RID: 8241 RVA: 0x00008AA4 File Offset: 0x00006CA4
		// (set) Token: 0x06002032 RID: 8242 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000918")]
		public IntPtr InitOptions
		{
			[Token(Token = "0x6002031")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[Token(Token = "0x6002032")]
			[Address(RVA = "0x4A6940", Offset = "0x4A4F40", VA = "0x1804A6940")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002033 RID: 8243 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002033")]
		[Address(RVA = "0x530710", Offset = "0x52ED10", VA = "0x180530710")]
		internal void Set(ref OptionsInternal other)
		{
		}
	}
}
