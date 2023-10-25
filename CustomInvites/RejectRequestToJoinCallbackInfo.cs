using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.CustomInvites
{
	// Token: 0x020005D3 RID: 1491
	[Token(Token = "0x20005D3")]
	public struct RejectRequestToJoinCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000B04 RID: 2820
		// (get) Token: 0x0600262B RID: 9771 RVA: 0x00009C44 File Offset: 0x00007E44
		// (set) Token: 0x0600262C RID: 9772 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B04")]
		public Result ResultCode
		{
			[Token(Token = "0x600262B")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x600262C")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000B05 RID: 2821
		// (get) Token: 0x0600262D RID: 9773 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600262E RID: 9774 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B05")]
		public object ClientData
		{
			[Token(Token = "0x600262D")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600262E")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000B06 RID: 2822
		// (get) Token: 0x0600262F RID: 9775 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002630 RID: 9776 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B06")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x600262F")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002630")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000B07 RID: 2823
		// (get) Token: 0x06002631 RID: 9777 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002632 RID: 9778 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B07")]
		public ProductUserId TargetUserId
		{
			[Token(Token = "0x6002631")]
			[Address(RVA = "0x3E4B20", Offset = "0x3E3120", VA = "0x1803E4B20")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002632")]
			[Address(RVA = "0x488180", Offset = "0x486780", VA = "0x180488180")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002633 RID: 9779 RVA: 0x00009C5C File Offset: 0x00007E5C
		[Token(Token = "0x6002633")]
		[Address(RVA = "0x565640", Offset = "0x563C40", VA = "0x180565640", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06002634 RID: 9780 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002634")]
		[Address(RVA = "0x565690", Offset = "0x563C90", VA = "0x180565690")]
		internal void Set(ref RejectRequestToJoinCallbackInfoInternal other)
		{
		}
	}
}
