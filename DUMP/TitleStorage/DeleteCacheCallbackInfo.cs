using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.TitleStorage
{
	// Token: 0x020000A7 RID: 167
	[Token(Token = "0x20000A7")]
	public struct DeleteCacheCallbackInfo : ICallbackInfo
	{
		// Token: 0x1700010B RID: 267
		// (get) Token: 0x0600064F RID: 1615 RVA: 0x00002FB4 File Offset: 0x000011B4
		// (set) Token: 0x06000650 RID: 1616 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700010B")]
		public Result ResultCode
		{
			[Token(Token = "0x600064F")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x6000650")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x06000651 RID: 1617 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000652 RID: 1618 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700010C")]
		public object ClientData
		{
			[Token(Token = "0x6000651")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000652")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x06000653 RID: 1619 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000654 RID: 1620 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700010D")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6000653")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000654")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x00002FCC File Offset: 0x000011CC
		[Token(Token = "0x6000655")]
		[Address(RVA = "0x4A1C70", Offset = "0x4A0270", VA = "0x1804A1C70", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000656")]
		[Address(RVA = "0x4A1CC0", Offset = "0x4A02C0", VA = "0x1804A1CC0")]
		internal void Set(ref DeleteCacheCallbackInfoInternal other)
		{
		}
	}
}
