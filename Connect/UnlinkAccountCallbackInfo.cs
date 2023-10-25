using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Connect
{
	// Token: 0x0200063F RID: 1599
	[Token(Token = "0x200063F")]
	public struct UnlinkAccountCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000BDE RID: 3038
		// (get) Token: 0x060028E1 RID: 10465 RVA: 0x0000A46C File Offset: 0x0000866C
		// (set) Token: 0x060028E2 RID: 10466 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BDE")]
		public Result ResultCode
		{
			[Token(Token = "0x60028E1")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x60028E2")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000BDF RID: 3039
		// (get) Token: 0x060028E3 RID: 10467 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060028E4 RID: 10468 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BDF")]
		public object ClientData
		{
			[Token(Token = "0x60028E3")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60028E4")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000BE0 RID: 3040
		// (get) Token: 0x060028E5 RID: 10469 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060028E6 RID: 10470 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BE0")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60028E5")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60028E6")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060028E7 RID: 10471 RVA: 0x0000A484 File Offset: 0x00008684
		[Token(Token = "0x60028E7")]
		[Address(RVA = "0x5693B0", Offset = "0x5679B0", VA = "0x1805693B0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x060028E8 RID: 10472 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60028E8")]
		[Address(RVA = "0x569400", Offset = "0x567A00", VA = "0x180569400")]
		internal void Set(ref UnlinkAccountCallbackInfoInternal other)
		{
		}
	}
}
