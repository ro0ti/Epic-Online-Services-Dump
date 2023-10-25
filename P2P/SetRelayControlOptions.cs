using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.P2P
{
	// Token: 0x0200035D RID: 861
	[Token(Token = "0x200035D")]
	public struct SetRelayControlOptions
	{
		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x06001721 RID: 5921 RVA: 0x000069BC File Offset: 0x00004BBC
		// (set) Token: 0x06001722 RID: 5922 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000653")]
		public RelayControl RelayControl
		{
			[Token(Token = "0x6001721")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return RelayControl.NoRelays;
			}
			[Token(Token = "0x6001722")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
