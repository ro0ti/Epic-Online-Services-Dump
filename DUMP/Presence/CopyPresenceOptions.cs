using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.Presence
{
	// Token: 0x020002A5 RID: 677
	[Token(Token = "0x20002A5")]
	public struct CopyPresenceOptions
	{
		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x06001286 RID: 4742 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001287 RID: 4743 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170004D5")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x6001286")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001287")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x06001288 RID: 4744 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001289 RID: 4745 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170004D6")]
		public EpicAccountId TargetUserId
		{
			[Token(Token = "0x6001288")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001289")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
