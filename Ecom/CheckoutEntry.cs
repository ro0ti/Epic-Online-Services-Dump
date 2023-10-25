using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Ecom
{
	// Token: 0x0200052E RID: 1326
	[Token(Token = "0x200052E")]
	public struct CheckoutEntry
	{
		// Token: 0x170009E3 RID: 2531
		// (get) Token: 0x06002267 RID: 8807 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002268 RID: 8808 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170009E3")]
		public Utf8String OfferId
		{
			[Token(Token = "0x6002267")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002268")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002269 RID: 8809 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002269")]
		[Address(RVA = "0x53D2C0", Offset = "0x53B8C0", VA = "0x18053D2C0")]
		internal void Set(ref CheckoutEntryInternal other)
		{
		}
	}
}
