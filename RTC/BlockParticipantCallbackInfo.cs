using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.RTC
{
	// Token: 0x0200025D RID: 605
	[Token(Token = "0x200025D")]
	public struct BlockParticipantCallbackInfo : ICallbackInfo
	{
		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x060010A5 RID: 4261 RVA: 0x0000533C File Offset: 0x0000353C
		// (set) Token: 0x060010A6 RID: 4262 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000438")]
		public Result ResultCode
		{
			[Token(Token = "0x60010A5")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x60010A6")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x060010A7 RID: 4263 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060010A8 RID: 4264 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000439")]
		public object ClientData
		{
			[Token(Token = "0x60010A7")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60010A8")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x060010A9 RID: 4265 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060010AA RID: 4266 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700043A")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60010A9")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60010AA")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x060010AB RID: 4267 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060010AC RID: 4268 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700043B")]
		public Utf8String RoomName
		{
			[Token(Token = "0x60010AB")]
			[Address(RVA = "0x3E4B20", Offset = "0x3E3120", VA = "0x1803E4B20")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60010AC")]
			[Address(RVA = "0x488180", Offset = "0x486780", VA = "0x180488180")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x060010AD RID: 4269 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060010AE RID: 4270 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700043C")]
		public ProductUserId ParticipantId
		{
			[Token(Token = "0x60010AD")]
			[Address(RVA = "0x4447A0", Offset = "0x442DA0", VA = "0x1804447A0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60010AE")]
			[Address(RVA = "0x444810", Offset = "0x442E10", VA = "0x180444810")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x060010AF RID: 4271 RVA: 0x00005354 File Offset: 0x00003554
		// (set) Token: 0x060010B0 RID: 4272 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700043D")]
		public bool Blocked
		{
			[Token(Token = "0x60010AF")]
			[Address(RVA = "0x481820", Offset = "0x47FE20", VA = "0x180481820")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Token(Token = "0x60010B0")]
			[Address(RVA = "0x4818D0", Offset = "0x47FED0", VA = "0x1804818D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060010B1 RID: 4273 RVA: 0x0000536C File Offset: 0x0000356C
		[Token(Token = "0x60010B1")]
		[Address(RVA = "0x4D8130", Offset = "0x4D6730", VA = "0x1804D8130", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x060010B2 RID: 4274 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60010B2")]
		[Address(RVA = "0x4D8180", Offset = "0x4D6780", VA = "0x1804D8180")]
		internal void Set(ref BlockParticipantCallbackInfoInternal other)
		{
		}
	}
}
