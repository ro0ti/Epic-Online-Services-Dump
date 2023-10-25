using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.Sessions
{
	// Token: 0x0200018E RID: 398
	[Token(Token = "0x200018E")]
	public struct SessionSearchSetParameterOptions
	{
		// Token: 0x1700029A RID: 666
		// (get) Token: 0x06000B6F RID: 2927 RVA: 0x0000419C File Offset: 0x0000239C
		// (set) Token: 0x06000B70 RID: 2928 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700029A")]
		public AttributeData? Parameter
		{
			[Token(Token = "0x6000B6F")]
			[Address(RVA = "0x4C7200", Offset = "0x4C5800", VA = "0x1804C7200")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000B70")]
			[Address(RVA = "0x4C7230", Offset = "0x4C5830", VA = "0x1804C7230")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x06000B71 RID: 2929 RVA: 0x000041B4 File Offset: 0x000023B4
		// (set) Token: 0x06000B72 RID: 2930 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700029B")]
		public ComparisonOp ComparisonOp
		{
			[Token(Token = "0x6000B71")]
			[Address(RVA = "0x3D6600", Offset = "0x3D4C00", VA = "0x1803D6600")]
			[CompilerGenerated]
			readonly get
			{
				return ComparisonOp.Equal;
			}
			[Token(Token = "0x6000B72")]
			[Address(RVA = "0x3E45C0", Offset = "0x3E2BC0", VA = "0x1803E45C0")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
