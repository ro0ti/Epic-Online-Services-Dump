using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x020003C8 RID: 968
	[Token(Token = "0x20003C8")]
	internal struct HardMuteMemberOptionsInternal : ISettable<HardMuteMemberOptions>, IDisposable
	{
		// Token: 0x17000723 RID: 1827
		// (set) Token: 0x0600197B RID: 6523 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000723")]
		public Utf8String LobbyId
		{
			[Token(Token = "0x600197B")]
			[Address(RVA = "0x50CD50", Offset = "0x50B350", VA = "0x18050CD50")]
			set
			{
			}
		}

		// Token: 0x17000724 RID: 1828
		// (set) Token: 0x0600197C RID: 6524 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000724")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x600197C")]
			[Address(RVA = "0x50CDB0", Offset = "0x50B3B0", VA = "0x18050CDB0")]
			set
			{
			}
		}

		// Token: 0x17000725 RID: 1829
		// (set) Token: 0x0600197D RID: 6525 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000725")]
		public ProductUserId TargetUserId
		{
			[Token(Token = "0x600197D")]
			[Address(RVA = "0x50CE10", Offset = "0x50B410", VA = "0x18050CE10")]
			set
			{
			}
		}

		// Token: 0x17000726 RID: 1830
		// (set) Token: 0x0600197E RID: 6526 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000726")]
		public bool HardMute
		{
			[Token(Token = "0x600197E")]
			[Address(RVA = "0x50CCF0", Offset = "0x50B2F0", VA = "0x18050CCF0")]
			set
			{
			}
		}

		// Token: 0x0600197F RID: 6527 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600197F")]
		[Address(RVA = "0x50C9E0", Offset = "0x50AFE0", VA = "0x18050C9E0", Slot = "4")]
		public void Set(ref HardMuteMemberOptions other)
		{
		}

		// Token: 0x06001980 RID: 6528 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001980")]
		[Address(RVA = "0x50CB30", Offset = "0x50B130", VA = "0x18050CB30", Slot = "5")]
		public void Set(ref HardMuteMemberOptions? other)
		{
		}

		// Token: 0x06001981 RID: 6529 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001981")]
		[Address(RVA = "0x50C970", Offset = "0x50AF70", VA = "0x18050C970", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000B7C RID: 2940
		[Token(Token = "0x4000B7C")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000B7D RID: 2941
		[Token(Token = "0x4000B7D")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LobbyId;

		// Token: 0x04000B7E RID: 2942
		[Token(Token = "0x4000B7E")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000B7F RID: 2943
		[Token(Token = "0x4000B7F")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_TargetUserId;

		// Token: 0x04000B80 RID: 2944
		[Token(Token = "0x4000B80")]
		[FieldOffset(Offset = "0x20")]
		private int m_HardMute;
	}
}
