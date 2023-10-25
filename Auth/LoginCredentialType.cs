using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Auth
{
	// Token: 0x02000663 RID: 1635
	[Token(Token = "0x2000663")]
	public enum LoginCredentialType
	{
		// Token: 0x04001249 RID: 4681
		[Token(Token = "0x4001249")]
		Password,
		// Token: 0x0400124A RID: 4682
		[Token(Token = "0x400124A")]
		ExchangeCode,
		// Token: 0x0400124B RID: 4683
		[Token(Token = "0x400124B")]
		PersistentAuth,
		// Token: 0x0400124C RID: 4684
		[Token(Token = "0x400124C")]
		DeviceCode,
		// Token: 0x0400124D RID: 4685
		[Token(Token = "0x400124D")]
		Developer,
		// Token: 0x0400124E RID: 4686
		[Token(Token = "0x400124E")]
		RefreshToken,
		// Token: 0x0400124F RID: 4687
		[Token(Token = "0x400124F")]
		AccountPortal,
		// Token: 0x04001250 RID: 4688
		[Token(Token = "0x4001250")]
		ExternalAuth
	}
}
