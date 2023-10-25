using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Auth
{
	// Token: 0x0200066C RID: 1644
	[Token(Token = "0x200066C")]
	internal struct LogoutOptionsInternal : ISettable<LogoutOptions>, IDisposable
	{
		// Token: 0x17000C56 RID: 3158
		// (set) Token: 0x06002A32 RID: 10802 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000C56")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x6002A32")]
			[Address(RVA = "0x55FF00", Offset = "0x55E500", VA = "0x18055FF00")]
			set
			{
			}
		}

		// Token: 0x06002A33 RID: 10803 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002A33")]
		[Address(RVA = "0x55FE00", Offset = "0x55E400", VA = "0x18055FE00", Slot = "4")]
		public void Set(ref LogoutOptions other)
		{
		}

		// Token: 0x06002A34 RID: 10804 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002A34")]
		[Address(RVA = "0x55FE60", Offset = "0x55E460", VA = "0x18055FE60", Slot = "5")]
		public void Set(ref LogoutOptions? other)
		{
		}

		// Token: 0x06002A35 RID: 10805 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002A35")]
		[Address(RVA = "0x55FDB0", Offset = "0x55E3B0", VA = "0x18055FDB0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x0400126A RID: 4714
		[Token(Token = "0x400126A")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x0400126B RID: 4715
		[Token(Token = "0x400126B")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;
	}
}
