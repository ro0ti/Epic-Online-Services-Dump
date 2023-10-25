using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.TitleStorage
{
	// Token: 0x020000C1 RID: 193
	[Token(Token = "0x20000C1")]
	public struct QueryFileListOptions
	{
		// Token: 0x17000139 RID: 313
		// (get) Token: 0x060006F8 RID: 1784 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060006F9 RID: 1785 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000139")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60006F8")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60006F9")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x060006FA RID: 1786 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060006FB RID: 1787 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700013A")]
		public Utf8String[] ListOfTags
		{
			[Token(Token = "0x60006FA")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60006FB")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
