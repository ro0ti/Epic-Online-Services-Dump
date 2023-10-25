using System;


namespace Epic.OnlineServices.Auth
{
	// Token: 0x0200064E RID: 1614
	[Token(Token = "0x200064E")]
	[Flags]
	public enum AuthScopeFlags
	{
		// Token: 0x04001201 RID: 4609
		[Token(Token = "0x4001201")]
		NoFlags = 0,
		// Token: 0x04001202 RID: 4610
		[Token(Token = "0x4001202")]
		BasicProfile = 1,
		// Token: 0x04001203 RID: 4611
		[Token(Token = "0x4001203")]
		FriendsList = 2,
		// Token: 0x04001204 RID: 4612
		[Token(Token = "0x4001204")]
		Presence = 4,
		// Token: 0x04001205 RID: 4613
		[Token(Token = "0x4001205")]
		FriendsManagement = 8,
		// Token: 0x04001206 RID: 4614
		[Token(Token = "0x4001206")]
		Email = 16,
		// Token: 0x04001207 RID: 4615
		[Token(Token = "0x4001207")]
		Country = 32
	}
}
