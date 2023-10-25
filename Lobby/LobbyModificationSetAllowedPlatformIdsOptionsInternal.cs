using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x02000411 RID: 1041
	[Token(Token = "0x2000411")]
	internal struct LobbyModificationSetAllowedPlatformIdsOptionsInternal : ISettable<LobbyModificationSetAllowedPlatformIdsOptions>, IDisposable
	{
		// Token: 0x170007E1 RID: 2017
		// (set) Token: 0x06001BB1 RID: 7089 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170007E1")]
		public uint[] AllowedPlatformIds
		{
			[Token(Token = "0x6001BB1")]
			[Address(RVA = "0x52A990", Offset = "0x528F90", VA = "0x18052A990")]
			set
			{
			}
		}

		// Token: 0x06001BB2 RID: 7090 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001BB2")]
		[Address(RVA = "0x52A900", Offset = "0x528F00", VA = "0x18052A900", Slot = "4")]
		public void Set(ref LobbyModificationSetAllowedPlatformIdsOptions other)
		{
		}

		// Token: 0x06001BB3 RID: 7091 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001BB3")]
		[Address(RVA = "0x52A920", Offset = "0x528F20", VA = "0x18052A920", Slot = "5")]
		public void Set(ref LobbyModificationSetAllowedPlatformIdsOptions? other)
		{
		}

		// Token: 0x06001BB4 RID: 7092 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001BB4")]
		[Address(RVA = "0x52A8B0", Offset = "0x528EB0", VA = "0x18052A8B0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000C98 RID: 3224
		[Token(Token = "0x4000C98")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000C99 RID: 3225
		[Token(Token = "0x4000C99")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_AllowedPlatformIds;

		// Token: 0x04000C9A RID: 3226
		[Token(Token = "0x4000C9A")]
		[FieldOffset(Offset = "0x10")]
		private uint m_AllowedPlatformIdsCount;
	}
}
