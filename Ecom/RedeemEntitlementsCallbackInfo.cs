using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Ecom
{
	// Token: 0x0200058F RID: 1423
	[Token(Token = "0x200058F")]
	public struct RedeemEntitlementsCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000AAD RID: 2733
		// (get) Token: 0x060024AD RID: 9389 RVA: 0x000098FC File Offset: 0x00007AFC
		// (set) Token: 0x060024AE RID: 9390 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000AAD")]
		public Result ResultCode
		{
			[Token(Token = "0x60024AD")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x60024AE")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000AAE RID: 2734
		// (get) Token: 0x060024AF RID: 9391 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060024B0 RID: 9392 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000AAE")]
		public object ClientData
		{
			[Token(Token = "0x60024AF")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60024B0")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000AAF RID: 2735
		// (get) Token: 0x060024B1 RID: 9393 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060024B2 RID: 9394 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000AAF")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x60024B1")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60024B2")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000AB0 RID: 2736
		// (get) Token: 0x060024B3 RID: 9395 RVA: 0x00009914 File Offset: 0x00007B14
		// (set) Token: 0x060024B4 RID: 9396 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000AB0")]
		public uint RedeemedEntitlementIdsCount
		{
			[Token(Token = "0x60024B3")]
			[Address(RVA = "0x4447E0", Offset = "0x442DE0", VA = "0x1804447E0")]
			[CompilerGenerated]
			readonly get
			{
				return 0U;
			}
			[Token(Token = "0x60024B4")]
			[Address(RVA = "0x444820", Offset = "0x442E20", VA = "0x180444820")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060024B5 RID: 9397 RVA: 0x0000992C File Offset: 0x00007B2C
		[Token(Token = "0x60024B5")]
		[Address(RVA = "0x54F2C0", Offset = "0x54D8C0", VA = "0x18054F2C0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x060024B6 RID: 9398 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60024B6")]
		[Address(RVA = "0x54F310", Offset = "0x54D910", VA = "0x18054F310")]
		internal void Set(ref RedeemEntitlementsCallbackInfoInternal other)
		{
		}
	}
}
