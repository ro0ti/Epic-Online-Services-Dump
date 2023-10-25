using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.RTC
{
	// Token: 0x02000259 RID: 601
	[Token(Token = "0x2000259")]
	public struct AddNotifyParticipantStatusChangedOptions
	{
		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x06001093 RID: 4243 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001094 RID: 4244 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000430")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6001093")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001094")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x06001095 RID: 4245 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001096 RID: 4246 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000431")]
		public Utf8String RoomName
		{
			[Token(Token = "0x6001095")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001096")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
