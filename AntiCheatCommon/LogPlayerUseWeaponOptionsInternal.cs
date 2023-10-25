using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.AntiCheatCommon
{
	// Token: 0x020006D9 RID: 1753
	[Token(Token = "0x20006D9")]
	internal struct LogPlayerUseWeaponOptionsInternal : ISettable<LogPlayerUseWeaponOptions>, IDisposable
	{
		// Token: 0x17000D56 RID: 3414
		// (set) Token: 0x06002CED RID: 11501 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D56")]
		public LogPlayerUseWeaponData? UseWeaponData
		{
			[Token(Token = "0x6002CED")]
			[Address(RVA = "0x5772A0", Offset = "0x5758A0", VA = "0x1805772A0")]
			set
			{
			}
		}

		// Token: 0x06002CEE RID: 11502 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002CEE")]
		[Address(RVA = "0x577210", Offset = "0x575810", VA = "0x180577210", Slot = "4")]
		public void Set(ref LogPlayerUseWeaponOptions other)
		{
		}

		// Token: 0x06002CEF RID: 11503 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002CEF")]
		[Address(RVA = "0x577120", Offset = "0x575720", VA = "0x180577120", Slot = "5")]
		public void Set(ref LogPlayerUseWeaponOptions? other)
		{
		}

		// Token: 0x06002CF0 RID: 11504 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002CF0")]
		[Address(RVA = "0x5770D0", Offset = "0x5756D0", VA = "0x1805770D0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x040013F7 RID: 5111
		[Token(Token = "0x40013F7")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040013F8 RID: 5112
		[Token(Token = "0x40013F8")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_UseWeaponData;
	}
}
