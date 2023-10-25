using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.Presence
{
	// Token: 0x020002D1 RID: 721
	[Token(Token = "0x20002D1")]
	public struct SetPresenceOptions
	{
		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x0600139E RID: 5022 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600139F RID: 5023 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700052B")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x600139E")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600139F")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x060013A0 RID: 5024 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060013A1 RID: 5025 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700052C")]
		public PresenceModification PresenceModificationHandle
		{
			[Token(Token = "0x60013A0")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60013A1")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
