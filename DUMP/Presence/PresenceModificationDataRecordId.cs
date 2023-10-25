using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.Presence
{
	// Token: 0x020002BD RID: 701
	[Token(Token = "0x20002BD")]
	public struct PresenceModificationDataRecordId
	{
		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x0600133C RID: 4924 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600133D RID: 4925 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700050B")]
		public Utf8String Key
		{
			[Token(Token = "0x600133C")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600133D")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600133E RID: 4926 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600133E")]
		[Address(RVA = "0x4FC030", Offset = "0x4FA630", VA = "0x1804FC030")]
		internal void Set(ref PresenceModificationDataRecordIdInternal other)
		{
		}
	}
}
