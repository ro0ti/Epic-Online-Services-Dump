using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Stats
{
	// Token: 0x020000D4 RID: 212
	[Token(Token = "0x20000D4")]
	public struct IngestData
	{
		// Token: 0x1700016B RID: 363
		// (get) Token: 0x0600077F RID: 1919 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000780 RID: 1920 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700016B")]
		public Utf8String StatName
		{
			[Token(Token = "0x600077F")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000780")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06000781 RID: 1921 RVA: 0x00003404 File Offset: 0x00001604
		// (set) Token: 0x06000782 RID: 1922 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700016C")]
		public int IngestAmount
		{
			[Token(Token = "0x6000781")]
			[Address(RVA = "0x4875A0", Offset = "0x485BA0", VA = "0x1804875A0")]
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[Token(Token = "0x6000782")]
			[Address(RVA = "0x4875C0", Offset = "0x485BC0", VA = "0x1804875C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000783 RID: 1923 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000783")]
		[Address(RVA = "0x4BD280", Offset = "0x4BB880", VA = "0x1804BD280")]
		internal void Set(ref IngestDataInternal other)
		{
		}
	}
}
