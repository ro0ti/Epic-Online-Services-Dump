using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Presence
{
	// Token: 0x020002C7 RID: 711
	[Token(Token = "0x20002C7")]
	public struct PresenceModificationSetStatusOptions
	{
		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x0600135D RID: 4957 RVA: 0x00005A44 File Offset: 0x00003C44
		// (set) Token: 0x0600135E RID: 4958 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000515")]
		public Status Status
		{
			[Token(Token = "0x600135D")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return Status.Offline;
			}
			[Token(Token = "0x600135E")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
