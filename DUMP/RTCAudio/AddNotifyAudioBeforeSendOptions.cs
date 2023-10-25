using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.RTCAudio
{
	// Token: 0x020001B2 RID: 434
	[Token(Token = "0x20001B2")]
	public struct AddNotifyAudioBeforeSendOptions
	{
		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x06000C6A RID: 3178 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000C6B RID: 3179 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170002E2")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6000C6A")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000C6B")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x06000C6C RID: 3180 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000C6D RID: 3181 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170002E3")]
		public Utf8String RoomName
		{
			[Token(Token = "0x6000C6C")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000C6D")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
