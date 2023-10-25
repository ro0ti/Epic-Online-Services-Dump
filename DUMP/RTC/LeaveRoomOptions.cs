using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.RTC
{
	// Token: 0x0200026A RID: 618
	[Token(Token = "0x200026A")]
	public struct LeaveRoomOptions
	{
		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x06001137 RID: 4407 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001138 RID: 4408 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700047A")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6001137")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001138")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x06001139 RID: 4409 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600113A RID: 4410 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700047B")]
		public Utf8String RoomName
		{
			[Token(Token = "0x6001139")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600113A")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
