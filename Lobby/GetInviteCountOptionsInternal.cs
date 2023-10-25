using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x020003C0 RID: 960
	[Token(Token = "0x20003C0")]
	internal struct GetInviteCountOptionsInternal : ISettable<GetInviteCountOptions>, IDisposable
	{
		// Token: 0x1700070D RID: 1805
		// (set) Token: 0x06001946 RID: 6470 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700070D")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6001946")]
			[Address(RVA = "0x50BD30", Offset = "0x50A330", VA = "0x18050BD30")]
			set
			{
			}
		}

		// Token: 0x06001947 RID: 6471 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001947")]
		[Address(RVA = "0x50BC30", Offset = "0x50A230", VA = "0x18050BC30", Slot = "4")]
		public void Set(ref GetInviteCountOptions other)
		{
		}

		// Token: 0x06001948 RID: 6472 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001948")]
		[Address(RVA = "0x50BC90", Offset = "0x50A290", VA = "0x18050BC90", Slot = "5")]
		public void Set(ref GetInviteCountOptions? other)
		{
		}

		// Token: 0x06001949 RID: 6473 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001949")]
		[Address(RVA = "0x50BBE0", Offset = "0x50A1E0", VA = "0x18050BBE0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000B64 RID: 2916
		[Token(Token = "0x4000B64")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000B65 RID: 2917
		[Token(Token = "0x4000B65")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;
	}
}
