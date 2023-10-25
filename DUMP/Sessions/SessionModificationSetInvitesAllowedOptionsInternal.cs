using System;


namespace Epic.OnlineServices.Sessions
{
	// Token: 0x02000178 RID: 376
	[Token(Token = "0x2000178")]
	internal struct SessionModificationSetInvitesAllowedOptionsInternal : ISettable<SessionModificationSetInvitesAllowedOptions>, IDisposable
	{
		// Token: 0x17000284 RID: 644
		// (set) Token: 0x06000B18 RID: 2840 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000284")]
		public bool InvitesAllowed
		{
			[Token(Token = "0x6000B18")]
			[Address(RVA = "0x4CB470", Offset = "0x4C9A70", VA = "0x1804CB470")]
			set
			{
			}
		}

		// Token: 0x06000B19 RID: 2841 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B19")]
		[Address(RVA = "0x4CB400", Offset = "0x4C9A00", VA = "0x1804CB400", Slot = "4")]
		public void Set(ref SessionModificationSetInvitesAllowedOptions other)
		{
		}

		// Token: 0x06000B1A RID: 2842 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B1A")]
		[Address(RVA = "0x4CB360", Offset = "0x4C9960", VA = "0x1804CB360", Slot = "5")]
		public void Set(ref SessionModificationSetInvitesAllowedOptions? other)
		{
		}

		// Token: 0x06000B1B RID: 2843 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B1B")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000522 RID: 1314
		[Token(Token = "0x4000522")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000523 RID: 1315
		[Token(Token = "0x4000523")]
		[FieldOffset(Offset = "0x4")]
		private int m_InvitesAllowed;
	}
}
