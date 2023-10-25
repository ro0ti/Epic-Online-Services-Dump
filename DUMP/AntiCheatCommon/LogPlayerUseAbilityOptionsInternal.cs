using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.AntiCheatCommon
{
	// Token: 0x020006D5 RID: 1749
	[Token(Token = "0x20006D5")]
	internal struct LogPlayerUseAbilityOptionsInternal : ISettable<LogPlayerUseAbilityOptions>, IDisposable
	{
		// Token: 0x17000D45 RID: 3397
		// (set) Token: 0x06002CC7 RID: 11463 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D45")]
		public IntPtr PlayerHandle
		{
			[Token(Token = "0x6002CC7")]
			[Address(RVA = "0x487590", Offset = "0x485B90", VA = "0x180487590")]
			set
			{
			}
		}

		// Token: 0x17000D46 RID: 3398
		// (set) Token: 0x06002CC8 RID: 11464 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D46")]
		public uint AbilityId
		{
			[Token(Token = "0x6002CC8")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			set
			{
			}
		}

		// Token: 0x17000D47 RID: 3399
		// (set) Token: 0x06002CC9 RID: 11465 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D47")]
		public uint AbilityDurationMs
		{
			[Token(Token = "0x6002CC9")]
			[Address(RVA = "0x4AFAF0", Offset = "0x4AE0F0", VA = "0x1804AFAF0")]
			set
			{
			}
		}

		// Token: 0x17000D48 RID: 3400
		// (set) Token: 0x06002CCA RID: 11466 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D48")]
		public uint AbilityCooldownMs
		{
			[Token(Token = "0x6002CCA")]
			[Address(RVA = "0x444820", Offset = "0x442E20", VA = "0x180444820")]
			set
			{
			}
		}

		// Token: 0x06002CCB RID: 11467 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002CCB")]
		[Address(RVA = "0x5764D0", Offset = "0x574AD0", VA = "0x1805764D0", Slot = "4")]
		public void Set(ref LogPlayerUseAbilityOptions other)
		{
		}

		// Token: 0x06002CCC RID: 11468 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002CCC")]
		[Address(RVA = "0x5764F0", Offset = "0x574AF0", VA = "0x1805764F0", Slot = "5")]
		public void Set(ref LogPlayerUseAbilityOptions? other)
		{
		}

		// Token: 0x06002CCD RID: 11469 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002CCD")]
		[Address(RVA = "0x576480", Offset = "0x574A80", VA = "0x180576480", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x040013E5 RID: 5093
		[Token(Token = "0x40013E5")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040013E6 RID: 5094
		[Token(Token = "0x40013E6")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_PlayerHandle;

		// Token: 0x040013E7 RID: 5095
		[Token(Token = "0x40013E7")]
		[FieldOffset(Offset = "0x10")]
		private uint m_AbilityId;

		// Token: 0x040013E8 RID: 5096
		[Token(Token = "0x40013E8")]
		[FieldOffset(Offset = "0x14")]
		private uint m_AbilityDurationMs;

		// Token: 0x040013E9 RID: 5097
		[Token(Token = "0x40013E9")]
		[FieldOffset(Offset = "0x18")]
		private uint m_AbilityCooldownMs;
	}
}
