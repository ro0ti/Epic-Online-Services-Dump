using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.P2P
{
	// Token: 0x0200031C RID: 796
	[Token(Token = "0x200031C")]
	public struct AddNotifyPeerConnectionEstablishedOptions
	{
		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x0600158C RID: 5516 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600158D RID: 5517 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170005CB")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x600158C")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600158D")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x0600158E RID: 5518 RVA: 0x0000617C File Offset: 0x0000437C
		// (set) Token: 0x0600158F RID: 5519 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170005CC")]
		public SocketId? SocketId
		{
			[Token(Token = "0x600158E")]
			[Address(RVA = "0x4EC7F0", Offset = "0x4EADF0", VA = "0x1804EC7F0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600158F")]
			[Address(RVA = "0x4EC800", Offset = "0x4EAE00", VA = "0x1804EC800")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
