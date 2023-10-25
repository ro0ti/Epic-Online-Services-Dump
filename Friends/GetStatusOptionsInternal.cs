using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Friends
{
	// Token: 0x02000509 RID: 1289
	[Token(Token = "0x2000509")]
	internal struct GetStatusOptionsInternal : ISettable<GetStatusOptions>, IDisposable
	{
		// Token: 0x1700095D RID: 2397
		// (set) Token: 0x060020F9 RID: 8441 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700095D")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x60020F9")]
			[Address(RVA = "0x5483E0", Offset = "0x5469E0", VA = "0x1805483E0")]
			set
			{
			}
		}

		// Token: 0x1700095E RID: 2398
		// (set) Token: 0x060020FA RID: 8442 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700095E")]
		public EpicAccountId TargetUserId
		{
			[Token(Token = "0x60020FA")]
			[Address(RVA = "0x548440", Offset = "0x546A40", VA = "0x180548440")]
			set
			{
			}
		}

		// Token: 0x060020FB RID: 8443 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60020FB")]
		[Address(RVA = "0x548210", Offset = "0x546810", VA = "0x180548210", Slot = "4")]
		public void Set(ref GetStatusOptions other)
		{
		}

		// Token: 0x060020FC RID: 8444 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60020FC")]
		[Address(RVA = "0x5482D0", Offset = "0x5468D0", VA = "0x1805482D0", Slot = "5")]
		public void Set(ref GetStatusOptions? other)
		{
		}

		// Token: 0x060020FD RID: 8445 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60020FD")]
		[Address(RVA = "0x5481B0", Offset = "0x5467B0", VA = "0x1805481B0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000E9A RID: 3738
		[Token(Token = "0x4000E9A")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000E9B RID: 3739
		[Token(Token = "0x4000E9B")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000E9C RID: 3740
		[Token(Token = "0x4000E9C")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_TargetUserId;
	}
}
