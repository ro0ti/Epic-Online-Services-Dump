using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.TitleStorage
{
	// Token: 0x020000C5 RID: 197
	[Token(Token = "0x20000C5")]
	public struct ReadFileCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000141 RID: 321
		// (get) Token: 0x0600070A RID: 1802 RVA: 0x000031F4 File Offset: 0x000013F4
		// (set) Token: 0x0600070B RID: 1803 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000141")]
		public Result ResultCode
		{
			[Token(Token = "0x600070A")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x600070B")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x0600070C RID: 1804 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600070D RID: 1805 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000142")]
		public object ClientData
		{
			[Token(Token = "0x600070C")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600070D")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x0600070E RID: 1806 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600070F RID: 1807 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000143")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x600070E")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600070F")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x06000710 RID: 1808 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000711 RID: 1809 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000144")]
		public Utf8String Filename
		{
			[Token(Token = "0x6000710")]
			[Address(RVA = "0x3E4B20", Offset = "0x3E3120", VA = "0x1803E4B20")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000711")]
			[Address(RVA = "0x488180", Offset = "0x486780", VA = "0x180488180")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000712 RID: 1810 RVA: 0x0000320C File Offset: 0x0000140C
		[Token(Token = "0x6000712")]
		[Address(RVA = "0x4C39C0", Offset = "0x4C1FC0", VA = "0x1804C39C0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06000713 RID: 1811 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000713")]
		[Address(RVA = "0x4C3A10", Offset = "0x4C2010", VA = "0x1804C3A10")]
		internal void Set(ref ReadFileCallbackInfoInternal other)
		{
		}
	}
}
