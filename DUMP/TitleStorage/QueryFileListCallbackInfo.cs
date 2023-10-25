using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.TitleStorage
{
	// Token: 0x020000BF RID: 191
	[Token(Token = "0x20000BF")]
	public struct QueryFileListCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000130 RID: 304
		// (get) Token: 0x060006E1 RID: 1761 RVA: 0x00003164 File Offset: 0x00001364
		// (set) Token: 0x060006E2 RID: 1762 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000130")]
		public Result ResultCode
		{
			[Token(Token = "0x60006E1")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x60006E2")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x060006E3 RID: 1763 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060006E4 RID: 1764 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000131")]
		public object ClientData
		{
			[Token(Token = "0x60006E3")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60006E4")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x060006E5 RID: 1765 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060006E6 RID: 1766 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000132")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60006E5")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60006E6")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x060006E7 RID: 1767 RVA: 0x0000317C File Offset: 0x0000137C
		// (set) Token: 0x060006E8 RID: 1768 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000133")]
		public uint FileCount
		{
			[Token(Token = "0x60006E7")]
			[Address(RVA = "0x4447E0", Offset = "0x442DE0", VA = "0x1804447E0")]
			[CompilerGenerated]
			readonly get
			{
				return 0U;
			}
			[Token(Token = "0x60006E8")]
			[Address(RVA = "0x444820", Offset = "0x442E20", VA = "0x180444820")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060006E9 RID: 1769 RVA: 0x00003194 File Offset: 0x00001394
		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x4C1FC0", Offset = "0x4C05C0", VA = "0x1804C1FC0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x060006EA RID: 1770 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x4C2010", Offset = "0x4C0610", VA = "0x1804C2010")]
		internal void Set(ref QueryFileListCallbackInfoInternal other)
		{
		}
	}
}
