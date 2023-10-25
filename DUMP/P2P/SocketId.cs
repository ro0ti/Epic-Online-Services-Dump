using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.P2P
{
	// Token: 0x0200035F RID: 863
	[Token(Token = "0x200035F")]
	public struct SocketId
	{
		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x06001727 RID: 5927 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001728 RID: 5928 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000655")]
		public string SocketName
		{
			[Token(Token = "0x6001727")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001728")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001729 RID: 5929 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001729")]
		[Address(RVA = "0x51FDA0", Offset = "0x51E3A0", VA = "0x18051FDA0")]
		internal void Set(ref SocketIdInternal other)
		{
		}
	}
}
