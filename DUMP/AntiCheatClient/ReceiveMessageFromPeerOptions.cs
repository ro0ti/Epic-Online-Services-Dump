using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.AntiCheatClient
{
	// Token: 0x02000713 RID: 1811
	[Token(Token = "0x2000713")]
	public struct ReceiveMessageFromPeerOptions
	{
		// Token: 0x17000DAC RID: 3500
		// (get) Token: 0x06002E22 RID: 11810 RVA: 0x0000BEDC File Offset: 0x0000A0DC
		// (set) Token: 0x06002E23 RID: 11811 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000DAC")]
		public IntPtr PeerHandle
		{
			[Token(Token = "0x6002E22")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[Token(Token = "0x6002E23")]
			[Address(RVA = "0x4875D0", Offset = "0x485BD0", VA = "0x1804875D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000DAD RID: 3501
		// (get) Token: 0x06002E24 RID: 11812 RVA: 0x0000BEF4 File Offset: 0x0000A0F4
		// (set) Token: 0x06002E25 RID: 11813 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000DAD")]
		public ArraySegment<byte> Data
		{
			[Token(Token = "0x6002E24")]
			[Address(RVA = "0x4EC7F0", Offset = "0x4EADF0", VA = "0x1804EC7F0")]
			[CompilerGenerated]
			readonly get
			{
				return default(ArraySegment<byte>);
			}
			[Token(Token = "0x6002E25")]
			[Address(RVA = "0x5790E0", Offset = "0x5776E0", VA = "0x1805790E0")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
