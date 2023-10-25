using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x020003A9 RID: 937
	[Token(Token = "0x20003A9")]
	public struct AttributeData
	{
		// Token: 0x170006C3 RID: 1731
		// (get) Token: 0x0600189B RID: 6299 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600189C RID: 6300 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170006C3")]
		public Utf8String Key
		{
			[Token(Token = "0x600189B")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600189C")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006C4 RID: 1732
		// (get) Token: 0x0600189D RID: 6301 RVA: 0x00006EE4 File Offset: 0x000050E4
		// (set) Token: 0x0600189E RID: 6302 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170006C4")]
		public AttributeDataValue Value
		{
			[Token(Token = "0x600189D")]
			[Address(RVA = "0x4BABC0", Offset = "0x4B91C0", VA = "0x1804BABC0")]
			[CompilerGenerated]
			readonly get
			{
				return default(AttributeDataValue);
			}
			[Token(Token = "0x600189E")]
			[Address(RVA = "0x4BABF0", Offset = "0x4B91F0", VA = "0x1804BABF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600189F RID: 6303 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600189F")]
		[Address(RVA = "0x507070", Offset = "0x505670", VA = "0x180507070")]
		internal void Set(ref AttributeDataInternal other)
		{
		}
	}
}
