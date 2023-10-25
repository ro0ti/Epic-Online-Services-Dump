using System;


namespace Epic.OnlineServices.Lobby
{
	// Token: 0x02000402 RID: 1026
	[Token(Token = "0x2000402")]
	public enum LobbyMemberStatus
	{
		// Token: 0x04000C68 RID: 3176
		[Token(Token = "0x4000C68")]
		Joined,
		// Token: 0x04000C69 RID: 3177
		[Token(Token = "0x4000C69")]
		Left,
		// Token: 0x04000C6A RID: 3178
		[Token(Token = "0x4000C6A")]
		Disconnected,
		// Token: 0x04000C6B RID: 3179
		[Token(Token = "0x4000C6B")]
		Kicked,
		// Token: 0x04000C6C RID: 3180
		[Token(Token = "0x4000C6C")]
		Promoted,
		// Token: 0x04000C6D RID: 3181
		[Token(Token = "0x4000C6D")]
		Closed
	}
}
