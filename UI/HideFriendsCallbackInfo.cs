using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.UI
{
	// Token: 0x02000069 RID: 105
	[Token(Token = "0x2000069")]
	public struct HideFriendsCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060004D3 RID: 1235 RVA: 0x000028DC File Offset: 0x00000ADC
		// (set) Token: 0x060004D4 RID: 1236 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000094")]
		public Result ResultCode
		{
			[Token(Token = "0x60004D3")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x60004D4")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060004D5 RID: 1237 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060004D6 RID: 1238 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000095")]
		public object ClientData
		{
			[Token(Token = "0x60004D5")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60004D6")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x060004D7 RID: 1239 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060004D8 RID: 1240 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000096")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x60004D7")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60004D8")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060004D9 RID: 1241 RVA: 0x000028F4 File Offset: 0x00000AF4
		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x4AA3A0", Offset = "0x4A89A0", VA = "0x1804AA3A0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x4AA3F0", Offset = "0x4A89F0", VA = "0x1804AA3F0")]
		internal void Set(ref HideFriendsCallbackInfoInternal other)
		{
		}
	}
}
