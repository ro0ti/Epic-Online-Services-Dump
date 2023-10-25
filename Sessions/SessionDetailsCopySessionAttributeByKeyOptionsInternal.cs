using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Sessions
{
	// Token: 0x0200015F RID: 351
	[Token(Token = "0x200015F")]
	internal struct SessionDetailsCopySessionAttributeByKeyOptionsInternal : ISettable<SessionDetailsCopySessionAttributeByKeyOptions>, IDisposable
	{
		// Token: 0x1700023D RID: 573
		// (set) Token: 0x06000A57 RID: 2647 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700023D")]
		public Utf8String AttrKey
		{
			[Token(Token = "0x6000A57")]
			[Address(RVA = "0x4C7470", Offset = "0x4C5A70", VA = "0x1804C7470")]
			set
			{
			}
		}

		// Token: 0x06000A58 RID: 2648 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A58")]
		[Address(RVA = "0x4C7370", Offset = "0x4C5970", VA = "0x1804C7370", Slot = "4")]
		public void Set(ref SessionDetailsCopySessionAttributeByKeyOptions other)
		{
		}

		// Token: 0x06000A59 RID: 2649 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A59")]
		[Address(RVA = "0x4C73D0", Offset = "0x4C59D0", VA = "0x1804C73D0", Slot = "5")]
		public void Set(ref SessionDetailsCopySessionAttributeByKeyOptions? other)
		{
		}

		// Token: 0x06000A5A RID: 2650 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A5A")]
		[Address(RVA = "0x4C7320", Offset = "0x4C5920", VA = "0x1804C7320", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x040004C6 RID: 1222
		[Token(Token = "0x40004C6")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040004C7 RID: 1223
		[Token(Token = "0x40004C7")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_AttrKey;
	}
}
