using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x02000421 RID: 1057
	[Token(Token = "0x2000421")]
	internal struct LobbySearchFindOptionsInternal : ISettable<LobbySearchFindOptions>, IDisposable
	{
		// Token: 0x170007F2 RID: 2034
		// (set) Token: 0x06001BF0 RID: 7152 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170007F2")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6001BF0")]
			[Address(RVA = "0x52BAD0", Offset = "0x52A0D0", VA = "0x18052BAD0")]
			set
			{
			}
		}

		// Token: 0x06001BF1 RID: 7153 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001BF1")]
		[Address(RVA = "0x52BA70", Offset = "0x52A070", VA = "0x18052BA70", Slot = "4")]
		public void Set(ref LobbySearchFindOptions other)
		{
		}

		// Token: 0x06001BF2 RID: 7154 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001BF2")]
		[Address(RVA = "0x52B9D0", Offset = "0x529FD0", VA = "0x18052B9D0", Slot = "5")]
		public void Set(ref LobbySearchFindOptions? other)
		{
		}

		// Token: 0x06001BF3 RID: 7155 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001BF3")]
		[Address(RVA = "0x52B980", Offset = "0x529F80", VA = "0x18052B980", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000CBB RID: 3259
		[Token(Token = "0x4000CBB")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000CBC RID: 3260
		[Token(Token = "0x4000CBC")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;
	}
}
