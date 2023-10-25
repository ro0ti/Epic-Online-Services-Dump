using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.AntiCheatCommon
{
	// Token: 0x020006BC RID: 1724
	[Token(Token = "0x20006BC")]
	public enum AntiCheatCommonPlayerMovementState
	{
		// Token: 0x04001362 RID: 4962
		[Token(Token = "0x4001362")]
		None,
		// Token: 0x04001363 RID: 4963
		[Token(Token = "0x4001363")]
		Crouching,
		// Token: 0x04001364 RID: 4964
		[Token(Token = "0x4001364")]
		Prone,
		// Token: 0x04001365 RID: 4965
		[Token(Token = "0x4001365")]
		Mounted,
		// Token: 0x04001366 RID: 4966
		[Token(Token = "0x4001366")]
		Swimming,
		// Token: 0x04001367 RID: 4967
		[Token(Token = "0x4001367")]
		Falling,
		// Token: 0x04001368 RID: 4968
		[Token(Token = "0x4001368")]
		Flying,
		// Token: 0x04001369 RID: 4969
		[Token(Token = "0x4001369")]
		OnLadder
	}
}
