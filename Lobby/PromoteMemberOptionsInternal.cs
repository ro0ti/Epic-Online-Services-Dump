using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x02000465 RID: 1125
	[Token(Token = "0x2000465")]
	internal struct PromoteMemberOptionsInternal : ISettable<PromoteMemberOptions>, IDisposable
	{
		// Token: 0x1700081A RID: 2074
		// (set) Token: 0x06001D16 RID: 7446 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700081A")]
		public Utf8String LobbyId
		{
			[Token(Token = "0x6001D16")]
			[Address(RVA = "0x532000", Offset = "0x530600", VA = "0x180532000")]
			set
			{
			}
		}

		// Token: 0x1700081B RID: 2075
		// (set) Token: 0x06001D17 RID: 7447 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700081B")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6001D17")]
			[Address(RVA = "0x532060", Offset = "0x530660", VA = "0x180532060")]
			set
			{
			}
		}

		// Token: 0x1700081C RID: 2076
		// (set) Token: 0x06001D18 RID: 7448 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700081C")]
		public ProductUserId TargetUserId
		{
			[Token(Token = "0x6001D18")]
			[Address(RVA = "0x5320C0", Offset = "0x5306C0", VA = "0x1805320C0")]
			set
			{
			}
		}

		// Token: 0x06001D19 RID: 7449 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001D19")]
		[Address(RVA = "0x531F00", Offset = "0x530500", VA = "0x180531F00", Slot = "4")]
		public void Set(ref PromoteMemberOptions other)
		{
		}

		// Token: 0x06001D1A RID: 7450 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001D1A")]
		[Address(RVA = "0x531DA0", Offset = "0x5303A0", VA = "0x180531DA0", Slot = "5")]
		public void Set(ref PromoteMemberOptions? other)
		{
		}

		// Token: 0x06001D1B RID: 7451 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001D1B")]
		[Address(RVA = "0x531D30", Offset = "0x530330", VA = "0x180531D30", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000CEA RID: 3306
		[Token(Token = "0x4000CEA")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000CEB RID: 3307
		[Token(Token = "0x4000CEB")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LobbyId;

		// Token: 0x04000CEC RID: 3308
		[Token(Token = "0x4000CEC")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000CED RID: 3309
		[Token(Token = "0x4000CED")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_TargetUserId;
	}
}
