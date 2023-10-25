using System;


namespace Epic.OnlineServices.Sessions
{
	// Token: 0x0200015D RID: 349
	[Token(Token = "0x200015D")]
	internal struct SessionDetailsCopySessionAttributeByIndexOptionsInternal : ISettable<SessionDetailsCopySessionAttributeByIndexOptions>, IDisposable
	{
		// Token: 0x1700023B RID: 571
		// (set) Token: 0x06000A51 RID: 2641 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700023B")]
		public uint AttrIndex
		{
			[Token(Token = "0x6000A51")]
			[Address(RVA = "0x4A4E90", Offset = "0x4A3490", VA = "0x1804A4E90")]
			set
			{
			}
		}

		// Token: 0x06000A52 RID: 2642 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A52")]
		[Address(RVA = "0x4AFC00", Offset = "0x4AE200", VA = "0x1804AFC00", Slot = "4")]
		public void Set(ref SessionDetailsCopySessionAttributeByIndexOptions other)
		{
		}

		// Token: 0x06000A53 RID: 2643 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A53")]
		[Address(RVA = "0x4C72C0", Offset = "0x4C58C0", VA = "0x1804C72C0", Slot = "5")]
		public void Set(ref SessionDetailsCopySessionAttributeByIndexOptions? other)
		{
		}

		// Token: 0x06000A54 RID: 2644 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A54")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x040004C3 RID: 1219
		[Token(Token = "0x40004C3")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040004C4 RID: 1220
		[Token(Token = "0x40004C4")]
		[FieldOffset(Offset = "0x4")]
		private uint m_AttrIndex;
	}
}
