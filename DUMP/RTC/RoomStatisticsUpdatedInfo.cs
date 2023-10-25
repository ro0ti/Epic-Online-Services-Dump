using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.RTC
{
	// Token: 0x0200027E RID: 638
	[Token(Token = "0x200027E")]
	public struct RoomStatisticsUpdatedInfo : ICallbackInfo
	{
		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x060011AD RID: 4525 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060011AE RID: 4526 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000495")]
		public object ClientData
		{
			[Token(Token = "0x60011AD")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60011AE")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x060011AF RID: 4527 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060011B0 RID: 4528 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000496")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60011AF")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60011B0")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x060011B1 RID: 4529 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060011B2 RID: 4530 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000497")]
		public Utf8String RoomName
		{
			[Token(Token = "0x60011B1")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60011B2")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x060011B3 RID: 4531 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060011B4 RID: 4532 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000498")]
		public Utf8String Statistic
		{
			[Token(Token = "0x60011B3")]
			[Address(RVA = "0x3E4B20", Offset = "0x3E3120", VA = "0x1803E4B20")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60011B4")]
			[Address(RVA = "0x488180", Offset = "0x486780", VA = "0x180488180")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060011B5 RID: 4533 RVA: 0x000055DC File Offset: 0x000037DC
		[Token(Token = "0x60011B5")]
		[Address(RVA = "0x42B2A0", Offset = "0x4298A0", VA = "0x18042B2A0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x060011B6 RID: 4534 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60011B6")]
		[Address(RVA = "0x501EC0", Offset = "0x5004C0", VA = "0x180501EC0")]
		internal void Set(ref RoomStatisticsUpdatedInfoInternal other)
		{
		}
	}
}
