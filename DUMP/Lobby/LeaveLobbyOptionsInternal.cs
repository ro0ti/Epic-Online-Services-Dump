using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x020003DC RID: 988
	[Token(Token = "0x20003DC")]
	internal struct LeaveLobbyOptionsInternal : ISettable<LeaveLobbyOptions>, IDisposable
	{
		// Token: 0x1700076A RID: 1898
		// (set) Token: 0x06001A1E RID: 6686 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700076A")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6001A1E")]
			[Address(RVA = "0x510B00", Offset = "0x50F100", VA = "0x180510B00")]
			set
			{
			}
		}

		// Token: 0x1700076B RID: 1899
		// (set) Token: 0x06001A1F RID: 6687 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700076B")]
		public Utf8String LobbyId
		{
			[Token(Token = "0x6001A1F")]
			[Address(RVA = "0x510AA0", Offset = "0x50F0A0", VA = "0x180510AA0")]
			set
			{
			}
		}

		// Token: 0x06001A20 RID: 6688 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A20")]
		[Address(RVA = "0x5109E0", Offset = "0x50EFE0", VA = "0x1805109E0", Slot = "4")]
		public void Set(ref LeaveLobbyOptions other)
		{
		}

		// Token: 0x06001A21 RID: 6689 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A21")]
		[Address(RVA = "0x5108D0", Offset = "0x50EED0", VA = "0x1805108D0", Slot = "5")]
		public void Set(ref LeaveLobbyOptions? other)
		{
		}

		// Token: 0x06001A22 RID: 6690 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001A22")]
		[Address(RVA = "0x510870", Offset = "0x50EE70", VA = "0x180510870", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000BC3 RID: 3011
		[Token(Token = "0x4000BC3")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000BC4 RID: 3012
		[Token(Token = "0x4000BC4")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000BC5 RID: 3013
		[Token(Token = "0x4000BC5")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LobbyId;
	}
}
