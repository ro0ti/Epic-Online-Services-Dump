using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x020003C4 RID: 964
	[Token(Token = "0x20003C4")]
	internal struct GetRTCRoomNameOptionsInternal : ISettable<GetRTCRoomNameOptions>, IDisposable
	{
		// Token: 0x17000714 RID: 1812
		// (set) Token: 0x06001957 RID: 6487 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000714")]
		public Utf8String LobbyId
		{
			[Token(Token = "0x6001957")]
			[Address(RVA = "0x50C1C0", Offset = "0x50A7C0", VA = "0x18050C1C0")]
			set
			{
			}
		}

		// Token: 0x17000715 RID: 1813
		// (set) Token: 0x06001958 RID: 6488 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000715")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6001958")]
			[Address(RVA = "0x50C220", Offset = "0x50A820", VA = "0x18050C220")]
			set
			{
			}
		}

		// Token: 0x06001959 RID: 6489 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001959")]
		[Address(RVA = "0x50BFF0", Offset = "0x50A5F0", VA = "0x18050BFF0", Slot = "4")]
		public void Set(ref GetRTCRoomNameOptions other)
		{
		}

		// Token: 0x0600195A RID: 6490 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600195A")]
		[Address(RVA = "0x50C0B0", Offset = "0x50A6B0", VA = "0x18050C0B0", Slot = "5")]
		public void Set(ref GetRTCRoomNameOptions? other)
		{
		}

		// Token: 0x0600195B RID: 6491 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600195B")]
		[Address(RVA = "0x50BF90", Offset = "0x50A590", VA = "0x18050BF90", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000B6D RID: 2925
		[Token(Token = "0x4000B6D")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000B6E RID: 2926
		[Token(Token = "0x4000B6E")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LobbyId;

		// Token: 0x04000B6F RID: 2927
		[Token(Token = "0x4000B6F")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;
	}
}
