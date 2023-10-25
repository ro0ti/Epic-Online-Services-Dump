using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x020003B2 RID: 946
	[Token(Token = "0x20003B2")]
	internal struct CopyLobbyDetailsHandleOptionsInternal : ISettable<CopyLobbyDetailsHandleOptions>, IDisposable
	{
		// Token: 0x170006D6 RID: 1750
		// (set) Token: 0x060018D4 RID: 6356 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170006D6")]
		public Utf8String LobbyId
		{
			[Token(Token = "0x60018D4")]
			[Address(RVA = "0x508880", Offset = "0x506E80", VA = "0x180508880")]
			set
			{
			}
		}

		// Token: 0x170006D7 RID: 1751
		// (set) Token: 0x060018D5 RID: 6357 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170006D7")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60018D5")]
			[Address(RVA = "0x5088E0", Offset = "0x506EE0", VA = "0x1805088E0")]
			set
			{
			}
		}

		// Token: 0x060018D6 RID: 6358 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60018D6")]
		[Address(RVA = "0x5087C0", Offset = "0x506DC0", VA = "0x1805087C0", Slot = "4")]
		public void Set(ref CopyLobbyDetailsHandleOptions other)
		{
		}

		// Token: 0x060018D7 RID: 6359 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60018D7")]
		[Address(RVA = "0x5086B0", Offset = "0x506CB0", VA = "0x1805086B0", Slot = "5")]
		public void Set(ref CopyLobbyDetailsHandleOptions? other)
		{
		}

		// Token: 0x060018D8 RID: 6360 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60018D8")]
		[Address(RVA = "0x508650", Offset = "0x506C50", VA = "0x180508650", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000B29 RID: 2857
		[Token(Token = "0x4000B29")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000B2A RID: 2858
		[Token(Token = "0x4000B2A")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LobbyId;

		// Token: 0x04000B2B RID: 2859
		[Token(Token = "0x4000B2B")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;
	}
}
