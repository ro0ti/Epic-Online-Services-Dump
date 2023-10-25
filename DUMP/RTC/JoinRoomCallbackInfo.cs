using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.RTC
{
	// Token: 0x02000263 RID: 611
	[Token(Token = "0x2000263")]
	public struct JoinRoomCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x060010EA RID: 4330 RVA: 0x00005444 File Offset: 0x00003644
		// (set) Token: 0x060010EB RID: 4331 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000456")]
		public Result ResultCode
		{
			[Token(Token = "0x60010EA")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x60010EB")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x060010EC RID: 4332 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060010ED RID: 4333 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000457")]
		public object ClientData
		{
			[Token(Token = "0x60010EC")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60010ED")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x060010EE RID: 4334 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060010EF RID: 4335 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000458")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60010EE")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60010EF")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x060010F0 RID: 4336 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060010F1 RID: 4337 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000459")]
		public Utf8String RoomName
		{
			[Token(Token = "0x60010F0")]
			[Address(RVA = "0x3E4B20", Offset = "0x3E3120", VA = "0x1803E4B20")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60010F1")]
			[Address(RVA = "0x488180", Offset = "0x486780", VA = "0x180488180")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x060010F2 RID: 4338 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060010F3 RID: 4339 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700045A")]
		public Option[] RoomOptions
		{
			[Token(Token = "0x60010F2")]
			[Address(RVA = "0x4447A0", Offset = "0x442DA0", VA = "0x1804447A0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60010F3")]
			[Address(RVA = "0x444810", Offset = "0x442E10", VA = "0x180444810")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060010F4 RID: 4340 RVA: 0x0000545C File Offset: 0x0000365C
		[Token(Token = "0x60010F4")]
		[Address(RVA = "0x4F4870", Offset = "0x4F2E70", VA = "0x1804F4870", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x060010F5 RID: 4341 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60010F5")]
		[Address(RVA = "0x4F48C0", Offset = "0x4F2EC0", VA = "0x1804F48C0")]
		internal void Set(ref JoinRoomCallbackInfoInternal other)
		{
		}
	}
}
