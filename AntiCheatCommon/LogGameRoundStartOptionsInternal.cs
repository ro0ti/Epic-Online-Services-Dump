using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.AntiCheatCommon
{
	// Token: 0x020006C9 RID: 1737
	[Token(Token = "0x20006C9")]
	internal struct LogGameRoundStartOptionsInternal : ISettable<LogGameRoundStartOptions>, IDisposable
	{
		// Token: 0x17000D01 RID: 3329
		// (set) Token: 0x06002C4F RID: 11343 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D01")]
		public Utf8String SessionIdentifier
		{
			[Token(Token = "0x6002C4F")]
			[Address(RVA = "0x574C70", Offset = "0x573270", VA = "0x180574C70")]
			set
			{
			}
		}

		// Token: 0x17000D02 RID: 3330
		// (set) Token: 0x06002C50 RID: 11344 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D02")]
		public Utf8String LevelName
		{
			[Token(Token = "0x6002C50")]
			[Address(RVA = "0x574BB0", Offset = "0x5731B0", VA = "0x180574BB0")]
			set
			{
			}
		}

		// Token: 0x17000D03 RID: 3331
		// (set) Token: 0x06002C51 RID: 11345 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D03")]
		public Utf8String ModeName
		{
			[Token(Token = "0x6002C51")]
			[Address(RVA = "0x574C10", Offset = "0x573210", VA = "0x180574C10")]
			set
			{
			}
		}

		// Token: 0x17000D04 RID: 3332
		// (set) Token: 0x06002C52 RID: 11346 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D04")]
		public uint RoundTimeSeconds
		{
			[Token(Token = "0x6002C52")]
			[Address(RVA = "0x488190", Offset = "0x486790", VA = "0x180488190")]
			set
			{
			}
		}

		// Token: 0x06002C53 RID: 11347 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002C53")]
		[Address(RVA = "0x574AA0", Offset = "0x5730A0", VA = "0x180574AA0", Slot = "4")]
		public void Set(ref LogGameRoundStartOptions other)
		{
		}

		// Token: 0x06002C54 RID: 11348 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002C54")]
		[Address(RVA = "0x574920", Offset = "0x572F20", VA = "0x180574920", Slot = "5")]
		public void Set(ref LogGameRoundStartOptions? other)
		{
		}

		// Token: 0x06002C55 RID: 11349 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002C55")]
		[Address(RVA = "0x5748B0", Offset = "0x572EB0", VA = "0x1805748B0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x0400139B RID: 5019
		[Token(Token = "0x400139B")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x0400139C RID: 5020
		[Token(Token = "0x400139C")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_SessionIdentifier;

		// Token: 0x0400139D RID: 5021
		[Token(Token = "0x400139D")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LevelName;

		// Token: 0x0400139E RID: 5022
		[Token(Token = "0x400139E")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_ModeName;

		// Token: 0x0400139F RID: 5023
		[Token(Token = "0x400139F")]
		[FieldOffset(Offset = "0x20")]
		private uint m_RoundTimeSeconds;
	}
}
