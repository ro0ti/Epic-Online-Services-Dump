using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Connect
{
	// Token: 0x02000637 RID: 1591
	[Token(Token = "0x2000637")]
	public struct QueryProductUserIdMappingsCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000BC4 RID: 3012
		// (get) Token: 0x060028A3 RID: 10403 RVA: 0x0000A394 File Offset: 0x00008594
		// (set) Token: 0x060028A4 RID: 10404 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BC4")]
		public Result ResultCode
		{
			[Token(Token = "0x60028A3")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x60028A4")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000BC5 RID: 3013
		// (get) Token: 0x060028A5 RID: 10405 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060028A6 RID: 10406 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BC5")]
		public object ClientData
		{
			[Token(Token = "0x60028A5")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60028A6")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000BC6 RID: 3014
		// (get) Token: 0x060028A7 RID: 10407 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060028A8 RID: 10408 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000BC6")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60028A7")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60028A8")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060028A9 RID: 10409 RVA: 0x0000A3AC File Offset: 0x000085AC
		[Token(Token = "0x60028A9")]
		[Address(RVA = "0x564CD0", Offset = "0x5632D0", VA = "0x180564CD0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x060028AA RID: 10410 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60028AA")]
		[Address(RVA = "0x564D20", Offset = "0x563320", VA = "0x180564D20")]
		internal void Set(ref QueryProductUserIdMappingsCallbackInfoInternal other)
		{
		}
	}
}
