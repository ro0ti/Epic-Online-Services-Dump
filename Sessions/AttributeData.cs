using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Sessions
{
	// Token: 0x020000FA RID: 250
	[Token(Token = "0x20000FA")]
	public struct AttributeData
	{
		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x0600083F RID: 2111 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000840 RID: 2112 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001A3")]
		public Utf8String Key
		{
			[Token(Token = "0x600083F")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000840")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x06000841 RID: 2113 RVA: 0x000036A4 File Offset: 0x000018A4
		// (set) Token: 0x06000842 RID: 2114 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001A4")]
		public AttributeDataValue Value
		{
			[Token(Token = "0x6000841")]
			[Address(RVA = "0x4BABC0", Offset = "0x4B91C0", VA = "0x1804BABC0")]
			[CompilerGenerated]
			readonly get
			{
				return default(AttributeDataValue);
			}
			[Token(Token = "0x6000842")]
			[Address(RVA = "0x4BABF0", Offset = "0x4B91F0", VA = "0x1804BABF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000843 RID: 2115 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000843")]
		[Address(RVA = "0x4BAAA0", Offset = "0x4B90A0", VA = "0x1804BAAA0")]
		internal void Set(ref AttributeDataInternal other)
		{
		}
	}
}
