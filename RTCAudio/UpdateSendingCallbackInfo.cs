using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x02000236 RID: 566
	[Token(Token = "0x2000236")]
	public struct UpdateSendingCallbackInfo : ICallbackInfo
	{
		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x06000F9A RID: 3994 RVA: 0x00004FDC File Offset: 0x000031DC
		// (set) Token: 0x06000F9B RID: 3995 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170003D5")]
		public Result ResultCode
		{
			[Token(Token = "0x6000F9A")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x6000F9B")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x06000F9C RID: 3996 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000F9D RID: 3997 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170003D6")]
		public object ClientData
		{
			[Token(Token = "0x6000F9C")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000F9D")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x06000F9E RID: 3998 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000F9F RID: 3999 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170003D7")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6000F9E")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000F9F")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x06000FA0 RID: 4000 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000FA1 RID: 4001 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170003D8")]
		public Utf8String RoomName
		{
			[Token(Token = "0x6000FA0")]
			[Address(RVA = "0x3E4B20", Offset = "0x3E3120", VA = "0x1803E4B20")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000FA1")]
			[Address(RVA = "0x488180", Offset = "0x486780", VA = "0x180488180")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x06000FA2 RID: 4002 RVA: 0x00004FF4 File Offset: 0x000031F4
		// (set) Token: 0x06000FA3 RID: 4003 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170003D9")]
		public RTCAudioStatus AudioStatus
		{
			[Token(Token = "0x6000FA2")]
			[Address(RVA = "0x3D2F80", Offset = "0x3D1580", VA = "0x1803D2F80")]
			[CompilerGenerated]
			readonly get
			{
				return RTCAudioStatus.Unsupported;
			}
			[Token(Token = "0x6000FA3")]
			[Address(RVA = "0x488190", Offset = "0x486790", VA = "0x180488190")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000FA4 RID: 4004 RVA: 0x0000500C File Offset: 0x0000320C
		[Token(Token = "0x6000FA4")]
		[Address(RVA = "0x4EA150", Offset = "0x4E8750", VA = "0x1804EA150", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06000FA5 RID: 4005 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FA5")]
		[Address(RVA = "0x4EA1A0", Offset = "0x4E87A0", VA = "0x1804EA1A0")]
		internal void Set(ref UpdateSendingCallbackInfoInternal other)
		{
		}
	}
}
