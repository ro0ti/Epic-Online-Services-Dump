using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.AntiCheatCommon
{
	// Token: 0x020006E7 RID: 1767
	[Token(Token = "0x20006E7")]
	internal struct SetClientDetailsOptionsInternal : ISettable<SetClientDetailsOptions>, IDisposable
	{
		// Token: 0x17000D87 RID: 3463
		// (set) Token: 0x06002D69 RID: 11625 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D87")]
		public IntPtr ClientHandle
		{
			[Token(Token = "0x6002D69")]
			[Address(RVA = "0x487590", Offset = "0x485B90", VA = "0x180487590")]
			set
			{
			}
		}

		// Token: 0x17000D88 RID: 3464
		// (set) Token: 0x06002D6A RID: 11626 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D88")]
		public AntiCheatCommonClientFlags ClientFlags
		{
			[Token(Token = "0x6002D6A")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			set
			{
			}
		}

		// Token: 0x17000D89 RID: 3465
		// (set) Token: 0x06002D6B RID: 11627 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D89")]
		public AntiCheatCommonClientInput ClientInputMethod
		{
			[Token(Token = "0x6002D6B")]
			[Address(RVA = "0x4AFAF0", Offset = "0x4AE0F0", VA = "0x1804AFAF0")]
			set
			{
			}
		}

		// Token: 0x06002D6C RID: 11628 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002D6C")]
		[Address(RVA = "0x574F80", Offset = "0x573580", VA = "0x180574F80", Slot = "4")]
		public void Set(ref SetClientDetailsOptions other)
		{
		}

		// Token: 0x06002D6D RID: 11629 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002D6D")]
		[Address(RVA = "0x57ED80", Offset = "0x57D380", VA = "0x18057ED80", Slot = "5")]
		public void Set(ref SetClientDetailsOptions? other)
		{
		}

		// Token: 0x06002D6E RID: 11630 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002D6E")]
		[Address(RVA = "0x57ED30", Offset = "0x57D330", VA = "0x18057ED30", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04001429 RID: 5161
		[Token(Token = "0x4001429")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x0400142A RID: 5162
		[Token(Token = "0x400142A")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientHandle;

		// Token: 0x0400142B RID: 5163
		[Token(Token = "0x400142B")]
		[FieldOffset(Offset = "0x10")]
		private AntiCheatCommonClientFlags m_ClientFlags;

		// Token: 0x0400142C RID: 5164
		[Token(Token = "0x400142C")]
		[FieldOffset(Offset = "0x14")]
		private AntiCheatCommonClientInput m_ClientInputMethod;
	}
}
