using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.CustomInvites
{
	// Token: 0x0200059A RID: 1434
	[Token(Token = "0x200059A")]
	public struct AcceptRequestToJoinCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000AC0 RID: 2752
		// (get) Token: 0x060024E9 RID: 9449 RVA: 0x000099EC File Offset: 0x00007BEC
		// (set) Token: 0x060024EA RID: 9450 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000AC0")]
		public Result ResultCode
		{
			[Token(Token = "0x60024E9")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x60024EA")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000AC1 RID: 2753
		// (get) Token: 0x060024EB RID: 9451 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060024EC RID: 9452 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000AC1")]
		public object ClientData
		{
			[Token(Token = "0x60024EB")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60024EC")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000AC2 RID: 2754
		// (get) Token: 0x060024ED RID: 9453 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060024EE RID: 9454 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000AC2")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60024ED")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60024EE")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000AC3 RID: 2755
		// (get) Token: 0x060024EF RID: 9455 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060024F0 RID: 9456 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000AC3")]
		public ProductUserId TargetUserId
		{
			[Token(Token = "0x60024EF")]
			[Address(RVA = "0x3E4B20", Offset = "0x3E3120", VA = "0x1803E4B20")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60024F0")]
			[Address(RVA = "0x488180", Offset = "0x486780", VA = "0x180488180")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060024F1 RID: 9457 RVA: 0x00009A04 File Offset: 0x00007C04
		[Token(Token = "0x60024F1")]
		[Address(RVA = "0x539960", Offset = "0x537F60", VA = "0x180539960", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x060024F2 RID: 9458 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60024F2")]
		[Address(RVA = "0x5399B0", Offset = "0x537FB0", VA = "0x1805399B0")]
		internal void Set(ref AcceptRequestToJoinCallbackInfoInternal other)
		{
		}
	}
}
