using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.RTC
{
	// Token: 0x02000261 RID: 609
	[Token(Token = "0x2000261")]
	public struct DisconnectedCallbackInfo : ICallbackInfo
	{
		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x060010D3 RID: 4307 RVA: 0x000053E4 File Offset: 0x000035E4
		// (set) Token: 0x060010D4 RID: 4308 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700044D")]
		public Result ResultCode
		{
			[Token(Token = "0x60010D3")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x60010D4")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x060010D5 RID: 4309 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060010D6 RID: 4310 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700044E")]
		public object ClientData
		{
			[Token(Token = "0x60010D5")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60010D6")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x060010D7 RID: 4311 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060010D8 RID: 4312 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700044F")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60010D7")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60010D8")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x060010D9 RID: 4313 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060010DA RID: 4314 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000450")]
		public Utf8String RoomName
		{
			[Token(Token = "0x60010D9")]
			[Address(RVA = "0x3E4B20", Offset = "0x3E3120", VA = "0x1803E4B20")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60010DA")]
			[Address(RVA = "0x488180", Offset = "0x486780", VA = "0x180488180")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060010DB RID: 4315 RVA: 0x000053FC File Offset: 0x000035FC
		[Token(Token = "0x60010DB")]
		[Address(RVA = "0x4D92E0", Offset = "0x4D78E0", VA = "0x1804D92E0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x060010DC RID: 4316 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60010DC")]
		[Address(RVA = "0x4D9330", Offset = "0x4D7930", VA = "0x1804D9330")]
		internal void Set(ref DisconnectedCallbackInfoInternal other)
		{
		}
	}
}
