using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.RTC
{
	// Token: 0x02000265 RID: 613
	[Token(Token = "0x2000265")]
	[Flags]
	public enum JoinRoomFlags : uint
	{
		// Token: 0x04000794 RID: 1940
		[Token(Token = "0x4000794")]
		None = 0U,
		// Token: 0x04000795 RID: 1941
		[Token(Token = "0x4000795")]
		EnableEcho = 1U,
		// Token: 0x04000796 RID: 1942
		[Token(Token = "0x4000796")]
		EnableDatachannel = 4U
	}
}
