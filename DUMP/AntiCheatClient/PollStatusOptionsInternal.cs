using System;


namespace Epic.OnlineServices.AntiCheatClient
{
	// Token: 0x02000710 RID: 1808
	[Token(Token = "0x2000710")]
	internal struct PollStatusOptionsInternal : ISettable<PollStatusOptions>, IDisposable
	{
		// Token: 0x17000DA7 RID: 3495
		// (set) Token: 0x06002E15 RID: 11797 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000DA7")]
		public uint OutMessageLength
		{
			[Token(Token = "0x6002E15")]
			[Address(RVA = "0x4A4E90", Offset = "0x4A3490", VA = "0x1804A4E90")]
			set
			{
			}
		}

		// Token: 0x06002E16 RID: 11798 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002E16")]
		[Address(RVA = "0x4AFC00", Offset = "0x4AE200", VA = "0x1804AFC00", Slot = "4")]
		public void Set(ref PollStatusOptions other)
		{
		}

		// Token: 0x06002E17 RID: 11799 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002E17")]
		[Address(RVA = "0x57C340", Offset = "0x57A940", VA = "0x18057C340", Slot = "5")]
		public void Set(ref PollStatusOptions? other)
		{
		}

		// Token: 0x06002E18 RID: 11800 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002E18")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x0400147B RID: 5243
		[Token(Token = "0x400147B")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x0400147C RID: 5244
		[Token(Token = "0x400147C")]
		[FieldOffset(Offset = "0x4")]
		private uint m_OutMessageLength;
	}
}
