using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.PlayerDataStorage
{
	// Token: 0x02000300 RID: 768
	[Token(Token = "0x2000300")]
	public struct QueryFileCallbackInfo : ICallbackInfo
	{
		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x060014B3 RID: 5299 RVA: 0x00005E4C File Offset: 0x0000404C
		// (set) Token: 0x060014B4 RID: 5300 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700056F")]
		public Result ResultCode
		{
			[Token(Token = "0x60014B3")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x60014B4")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x060014B5 RID: 5301 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060014B6 RID: 5302 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000570")]
		public object ClientData
		{
			[Token(Token = "0x60014B5")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60014B6")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x060014B7 RID: 5303 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060014B8 RID: 5304 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000571")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60014B7")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60014B8")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060014B9 RID: 5305 RVA: 0x00005E64 File Offset: 0x00004064
		[Token(Token = "0x60014B9")]
		[Address(RVA = "0x4FD6A0", Offset = "0x4FBCA0", VA = "0x1804FD6A0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x060014BA RID: 5306 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60014BA")]
		[Address(RVA = "0x4FD6F0", Offset = "0x4FBCF0", VA = "0x1804FD6F0")]
		internal void Set(ref QueryFileCallbackInfoInternal other)
		{
		}
	}
}
