using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.AntiCheatCommon
{
	// Token: 0x020006CB RID: 1739
	[Token(Token = "0x20006CB")]
	internal struct LogPlayerDespawnOptionsInternal : ISettable<LogPlayerDespawnOptions>, IDisposable
	{
		// Token: 0x17000D06 RID: 3334
		// (set) Token: 0x06002C58 RID: 11352 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D06")]
		public IntPtr DespawnedPlayerHandle
		{
			[Token(Token = "0x6002C58")]
			[Address(RVA = "0x487590", Offset = "0x485B90", VA = "0x180487590")]
			set
			{
			}
		}

		// Token: 0x06002C59 RID: 11353 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002C59")]
		[Address(RVA = "0x4ACEA0", Offset = "0x4AB4A0", VA = "0x1804ACEA0", Slot = "4")]
		public void Set(ref LogPlayerDespawnOptions other)
		{
		}

		// Token: 0x06002C5A RID: 11354 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002C5A")]
		[Address(RVA = "0x574D20", Offset = "0x573320", VA = "0x180574D20", Slot = "5")]
		public void Set(ref LogPlayerDespawnOptions? other)
		{
		}

		// Token: 0x06002C5B RID: 11355 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002C5B")]
		[Address(RVA = "0x574CD0", Offset = "0x5732D0", VA = "0x180574CD0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x040013A1 RID: 5025
		[Token(Token = "0x40013A1")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040013A2 RID: 5026
		[Token(Token = "0x40013A2")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_DespawnedPlayerHandle;
	}
}
