using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Sessions
{
	// Token: 0x0200014B RID: 331
	[Token(Token = "0x200014B")]
	internal struct RegisterPlayersOptionsInternal : ISettable<RegisterPlayersOptions>, IDisposable
	{
		// Token: 0x17000213 RID: 531
		// (set) Token: 0x060009E1 RID: 2529 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000213")]
		public Utf8String SessionName
		{
			[Token(Token = "0x60009E1")]
			[Address(RVA = "0x4C55F0", Offset = "0x4C3BF0", VA = "0x1804C55F0")]
			set
			{
			}
		}

		// Token: 0x17000214 RID: 532
		// (set) Token: 0x060009E2 RID: 2530 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000214")]
		public ProductUserId[] PlayersToRegister
		{
			[Token(Token = "0x60009E2")]
			[Address(RVA = "0x4C5570", Offset = "0x4C3B70", VA = "0x1804C5570")]
			set
			{
			}
		}

		// Token: 0x060009E3 RID: 2531 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009E3")]
		[Address(RVA = "0x4C54E0", Offset = "0x4C3AE0", VA = "0x1804C54E0", Slot = "4")]
		public void Set(ref RegisterPlayersOptions other)
		{
		}

		// Token: 0x060009E4 RID: 2532 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009E4")]
		[Address(RVA = "0x4C5400", Offset = "0x4C3A00", VA = "0x1804C5400", Slot = "5")]
		public void Set(ref RegisterPlayersOptions? other)
		{
		}

		// Token: 0x060009E5 RID: 2533 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009E5")]
		[Address(RVA = "0x4C53A0", Offset = "0x4C39A0", VA = "0x1804C53A0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x0400048E RID: 1166
		[Token(Token = "0x400048E")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x0400048F RID: 1167
		[Token(Token = "0x400048F")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_SessionName;

		// Token: 0x04000490 RID: 1168
		[Token(Token = "0x4000490")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_PlayersToRegister;

		// Token: 0x04000491 RID: 1169
		[Token(Token = "0x4000491")]
		[FieldOffset(Offset = "0x18")]
		private uint m_PlayersToRegisterCount;
	}
}
