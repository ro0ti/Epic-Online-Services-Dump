using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Connect
{
	// Token: 0x02000611 RID: 1553
	[Token(Token = "0x2000611")]
	public struct LinkAccountCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000B96 RID: 2966
		// (get) Token: 0x060027D1 RID: 10193 RVA: 0x0000A19C File Offset: 0x0000839C
		// (set) Token: 0x060027D2 RID: 10194 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B96")]
		public Result ResultCode
		{
			[Token(Token = "0x60027D1")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x60027D2")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000B97 RID: 2967
		// (get) Token: 0x060027D3 RID: 10195 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060027D4 RID: 10196 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B97")]
		public object ClientData
		{
			[Token(Token = "0x60027D3")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60027D4")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000B98 RID: 2968
		// (get) Token: 0x060027D5 RID: 10197 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060027D6 RID: 10198 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B98")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60027D5")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60027D6")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060027D7 RID: 10199 RVA: 0x0000A1B4 File Offset: 0x000083B4
		[Token(Token = "0x60027D7")]
		[Address(RVA = "0x55CB90", Offset = "0x55B190", VA = "0x18055CB90", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x060027D8 RID: 10200 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60027D8")]
		[Address(RVA = "0x55CD30", Offset = "0x55B330", VA = "0x18055CD30")]
		internal void Set(ref LinkAccountCallbackInfoInternal other)
		{
		}
	}
}
