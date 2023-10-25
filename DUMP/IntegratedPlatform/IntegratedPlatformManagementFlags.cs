using System;


namespace Epic.OnlineServices.IntegratedPlatform
{
	// Token: 0x020004E1 RID: 1249
	[Token(Token = "0x20004E1")]
	[Flags]
	public enum IntegratedPlatformManagementFlags
	{
		// Token: 0x04000E2C RID: 3628
		[Token(Token = "0x4000E2C")]
		Disabled = 1,
		// Token: 0x04000E2D RID: 3629
		[Token(Token = "0x4000E2D")]
		LibraryManagedByApplication = 2,
		// Token: 0x04000E2E RID: 3630
		[Token(Token = "0x4000E2E")]
		LibraryManagedBySDK = 4,
		// Token: 0x04000E2F RID: 3631
		[Token(Token = "0x4000E2F")]
		DisablePresenceMirroring = 8,
		// Token: 0x04000E30 RID: 3632
		[Token(Token = "0x4000E30")]
		DisableSDKManagedSessions = 16,
		// Token: 0x04000E31 RID: 3633
		[Token(Token = "0x4000E31")]
		PreferEOSIdentity = 32,
		// Token: 0x04000E32 RID: 3634
		[Token(Token = "0x4000E32")]
		PreferIntegratedIdentity = 64,
		// Token: 0x04000E33 RID: 3635
		[Token(Token = "0x4000E33")]
		ApplicationManagedIdentityLogin = 128
	}
}
