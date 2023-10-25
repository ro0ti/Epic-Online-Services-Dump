using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.AntiCheatCommon
{
	// Token: 0x020006B3 RID: 1715
	[Token(Token = "0x20006B3")]
	public enum AntiCheatCommonClientActionReason
	{
		// Token: 0x0400131D RID: 4893
		[Token(Token = "0x400131D")]
		Invalid,
		// Token: 0x0400131E RID: 4894
		[Token(Token = "0x400131E")]
		InternalError,
		// Token: 0x0400131F RID: 4895
		[Token(Token = "0x400131F")]
		InvalidMessage,
		// Token: 0x04001320 RID: 4896
		[Token(Token = "0x4001320")]
		AuthenticationFailed,
		// Token: 0x04001321 RID: 4897
		[Token(Token = "0x4001321")]
		NullClient,
		// Token: 0x04001322 RID: 4898
		[Token(Token = "0x4001322")]
		HeartbeatTimeout,
		// Token: 0x04001323 RID: 4899
		[Token(Token = "0x4001323")]
		ClientViolation,
		// Token: 0x04001324 RID: 4900
		[Token(Token = "0x4001324")]
		BackendViolation,
		// Token: 0x04001325 RID: 4901
		[Token(Token = "0x4001325")]
		TemporaryCooldown,
		// Token: 0x04001326 RID: 4902
		[Token(Token = "0x4001326")]
		TemporaryBanned,
		// Token: 0x04001327 RID: 4903
		[Token(Token = "0x4001327")]
		PermanentBanned
	}
}
