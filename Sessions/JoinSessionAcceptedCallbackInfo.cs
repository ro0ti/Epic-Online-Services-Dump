using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Sessions
{
	// Token: 0x0200011A RID: 282
	[Token(Token = "0x200011A")]
	public struct JoinSessionAcceptedCallbackInfo : ICallbackInfo
	{
		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x060008E9 RID: 2281 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060008EA RID: 2282 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001E4")]
		public object ClientData
		{
			[Token(Token = "0x60008E9")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60008EA")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x060008EB RID: 2283 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060008EC RID: 2284 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001E5")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60008EB")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60008EC")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x060008ED RID: 2285 RVA: 0x00003944 File Offset: 0x00001B44
		// (set) Token: 0x060008EE RID: 2286 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001E6")]
		public ulong UiEventId
		{
			[Token(Token = "0x60008ED")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return 0UL;
			}
			[Token(Token = "0x60008EE")]
			[Address(RVA = "0x4A6940", Offset = "0x4A4F40", VA = "0x1804A6940")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060008EF RID: 2287 RVA: 0x0000395C File Offset: 0x00001B5C
		[Token(Token = "0x60008EF")]
		[Address(RVA = "0x42B2A0", Offset = "0x4298A0", VA = "0x18042B2A0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x060008F0 RID: 2288 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008F0")]
		[Address(RVA = "0x4BE470", Offset = "0x4BCA70", VA = "0x1804BE470")]
		internal void Set(ref JoinSessionAcceptedCallbackInfoInternal other)
		{
		}
	}
}
