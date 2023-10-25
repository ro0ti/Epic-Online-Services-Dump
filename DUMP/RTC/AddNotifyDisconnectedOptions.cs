using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.RTC
{
	// Token: 0x02000257 RID: 599
	[Token(Token = "0x2000257")]
	public struct AddNotifyDisconnectedOptions
	{
		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x0600108A RID: 4234 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600108B RID: 4235 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700042C")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x600108A")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600108B")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x0600108C RID: 4236 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600108D RID: 4237 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700042D")]
		public Utf8String RoomName
		{
			[Token(Token = "0x600108C")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600108D")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
