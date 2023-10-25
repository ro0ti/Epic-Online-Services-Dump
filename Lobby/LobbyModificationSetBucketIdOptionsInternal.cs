using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x02000413 RID: 1043
	[Token(Token = "0x2000413")]
	internal struct LobbyModificationSetBucketIdOptionsInternal : ISettable<LobbyModificationSetBucketIdOptions>, IDisposable
	{
		// Token: 0x170007E3 RID: 2019
		// (set) Token: 0x06001BB7 RID: 7095 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170007E3")]
		public Utf8String BucketId
		{
			[Token(Token = "0x6001BB7")]
			[Address(RVA = "0x52AB60", Offset = "0x529160", VA = "0x18052AB60")]
			set
			{
			}
		}

		// Token: 0x06001BB8 RID: 7096 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001BB8")]
		[Address(RVA = "0x52AA60", Offset = "0x529060", VA = "0x18052AA60", Slot = "4")]
		public void Set(ref LobbyModificationSetBucketIdOptions other)
		{
		}

		// Token: 0x06001BB9 RID: 7097 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001BB9")]
		[Address(RVA = "0x52AAC0", Offset = "0x5290C0", VA = "0x18052AAC0", Slot = "5")]
		public void Set(ref LobbyModificationSetBucketIdOptions? other)
		{
		}

		// Token: 0x06001BBA RID: 7098 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001BBA")]
		[Address(RVA = "0x52AA10", Offset = "0x529010", VA = "0x18052AA10", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000C9C RID: 3228
		[Token(Token = "0x4000C9C")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000C9D RID: 3229
		[Token(Token = "0x4000C9D")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_BucketId;
	}
}
