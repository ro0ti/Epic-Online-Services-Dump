using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x02000479 RID: 1145
	[Token(Token = "0x2000479")]
	internal struct UpdateLobbyModificationOptionsInternal : ISettable<UpdateLobbyModificationOptions>, IDisposable
	{
		// Token: 0x1700085F RID: 2143
		// (set) Token: 0x06001DC1 RID: 7617 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700085F")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6001DC1")]
			[Address(RVA = "0x537CF0", Offset = "0x5362F0", VA = "0x180537CF0")]
			set
			{
			}
		}

		// Token: 0x17000860 RID: 2144
		// (set) Token: 0x06001DC2 RID: 7618 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000860")]
		public Utf8String LobbyId
		{
			[Token(Token = "0x6001DC2")]
			[Address(RVA = "0x537C90", Offset = "0x536290", VA = "0x180537C90")]
			set
			{
			}
		}

		// Token: 0x06001DC3 RID: 7619 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001DC3")]
		[Address(RVA = "0x537BD0", Offset = "0x5361D0", VA = "0x180537BD0", Slot = "4")]
		public void Set(ref UpdateLobbyModificationOptions other)
		{
		}

		// Token: 0x06001DC4 RID: 7620 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001DC4")]
		[Address(RVA = "0x537AC0", Offset = "0x5360C0", VA = "0x180537AC0", Slot = "5")]
		public void Set(ref UpdateLobbyModificationOptions? other)
		{
		}

		// Token: 0x06001DC5 RID: 7621 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001DC5")]
		[Address(RVA = "0x537A60", Offset = "0x536060", VA = "0x180537A60", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000D2D RID: 3373
		[Token(Token = "0x4000D2D")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000D2E RID: 3374
		[Token(Token = "0x4000D2E")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000D2F RID: 3375
		[Token(Token = "0x4000D2F")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LobbyId;
	}
}
