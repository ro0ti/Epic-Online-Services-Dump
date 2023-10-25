using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.AntiCheatClient
{
	// Token: 0x020006FA RID: 1786
	[Token(Token = "0x20006FA")]
	public enum AntiCheatClientViolationType
	{
		// Token: 0x04001456 RID: 5206
		[Token(Token = "0x4001456")]
		Invalid,
		// Token: 0x04001457 RID: 5207
		[Token(Token = "0x4001457")]
		IntegrityCatalogNotFound,
		// Token: 0x04001458 RID: 5208
		[Token(Token = "0x4001458")]
		IntegrityCatalogError,
		// Token: 0x04001459 RID: 5209
		[Token(Token = "0x4001459")]
		IntegrityCatalogCertificateRevoked,
		// Token: 0x0400145A RID: 5210
		[Token(Token = "0x400145A")]
		IntegrityCatalogMissingMainExecutable,
		// Token: 0x0400145B RID: 5211
		[Token(Token = "0x400145B")]
		GameFileMismatch,
		// Token: 0x0400145C RID: 5212
		[Token(Token = "0x400145C")]
		RequiredGameFileNotFound,
		// Token: 0x0400145D RID: 5213
		[Token(Token = "0x400145D")]
		UnknownGameFileForbidden,
		// Token: 0x0400145E RID: 5214
		[Token(Token = "0x400145E")]
		SystemFileUntrusted,
		// Token: 0x0400145F RID: 5215
		[Token(Token = "0x400145F")]
		ForbiddenModuleLoaded,
		// Token: 0x04001460 RID: 5216
		[Token(Token = "0x4001460")]
		CorruptedMemory,
		// Token: 0x04001461 RID: 5217
		[Token(Token = "0x4001461")]
		ForbiddenToolDetected,
		// Token: 0x04001462 RID: 5218
		[Token(Token = "0x4001462")]
		InternalAntiCheatViolation,
		// Token: 0x04001463 RID: 5219
		[Token(Token = "0x4001463")]
		CorruptedNetworkMessageFlow,
		// Token: 0x04001464 RID: 5220
		[Token(Token = "0x4001464")]
		VirtualMachineNotAllowed,
		// Token: 0x04001465 RID: 5221
		[Token(Token = "0x4001465")]
		ForbiddenSystemConfiguration
	}
}
