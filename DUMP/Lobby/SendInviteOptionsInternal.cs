using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x02000473 RID: 1139
	[Token(Token = "0x2000473")]
	internal struct SendInviteOptionsInternal : ISettable<SendInviteOptions>, IDisposable
	{
		// Token: 0x17000846 RID: 2118
		// (set) Token: 0x06001D85 RID: 7557 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000846")]
		public Utf8String LobbyId
		{
			[Token(Token = "0x6001D85")]
			[Address(RVA = "0x5369D0", Offset = "0x534FD0", VA = "0x1805369D0")]
			set
			{
			}
		}

		// Token: 0x17000847 RID: 2119
		// (set) Token: 0x06001D86 RID: 7558 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000847")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6001D86")]
			[Address(RVA = "0x536A30", Offset = "0x535030", VA = "0x180536A30")]
			set
			{
			}
		}

		// Token: 0x17000848 RID: 2120
		// (set) Token: 0x06001D87 RID: 7559 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000848")]
		public ProductUserId TargetUserId
		{
			[Token(Token = "0x6001D87")]
			[Address(RVA = "0x536A90", Offset = "0x535090", VA = "0x180536A90")]
			set
			{
			}
		}

		// Token: 0x06001D88 RID: 7560 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001D88")]
		[Address(RVA = "0x536770", Offset = "0x534D70", VA = "0x180536770", Slot = "4")]
		public void Set(ref SendInviteOptions other)
		{
		}

		// Token: 0x06001D89 RID: 7561 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001D89")]
		[Address(RVA = "0x536870", Offset = "0x534E70", VA = "0x180536870", Slot = "5")]
		public void Set(ref SendInviteOptions? other)
		{
		}

		// Token: 0x06001D8A RID: 7562 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001D8A")]
		[Address(RVA = "0x536700", Offset = "0x534D00", VA = "0x180536700", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000D15 RID: 3349
		[Token(Token = "0x4000D15")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000D16 RID: 3350
		[Token(Token = "0x4000D16")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LobbyId;

		// Token: 0x04000D17 RID: 3351
		[Token(Token = "0x4000D17")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000D18 RID: 3352
		[Token(Token = "0x4000D18")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_TargetUserId;
	}
}
