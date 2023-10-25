using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.RTC
{
	// Token: 0x02000268 RID: 616
	[Token(Token = "0x2000268")]
	public struct LeaveRoomCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x06001120 RID: 4384 RVA: 0x000054EC File Offset: 0x000036EC
		// (set) Token: 0x06001121 RID: 4385 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000471")]
		public Result ResultCode
		{
			[Token(Token = "0x6001120")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x6001121")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x06001122 RID: 4386 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001123 RID: 4387 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000472")]
		public object ClientData
		{
			[Token(Token = "0x6001122")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001123")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x06001124 RID: 4388 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001125 RID: 4389 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000473")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6001124")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001125")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x06001126 RID: 4390 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001127 RID: 4391 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000474")]
		public Utf8String RoomName
		{
			[Token(Token = "0x6001126")]
			[Address(RVA = "0x3E4B20", Offset = "0x3E3120", VA = "0x1803E4B20")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001127")]
			[Address(RVA = "0x488180", Offset = "0x486780", VA = "0x180488180")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001128 RID: 4392 RVA: 0x00005504 File Offset: 0x00003704
		[Token(Token = "0x6001128")]
		[Address(RVA = "0x4F57D0", Offset = "0x4F3DD0", VA = "0x1804F57D0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06001129 RID: 4393 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001129")]
		[Address(RVA = "0x4F5820", Offset = "0x4F3E20", VA = "0x1804F5820")]
		internal void Set(ref LeaveRoomCallbackInfoInternal other)
		{
		}
	}
}
