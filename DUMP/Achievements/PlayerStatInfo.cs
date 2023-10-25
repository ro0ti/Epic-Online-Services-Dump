using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.Achievements
{
	// Token: 0x02000773 RID: 1907
	[Token(Token = "0x2000773")]
	public struct PlayerStatInfo
	{
		// Token: 0x17000EC5 RID: 3781
		// (get) Token: 0x06003118 RID: 12568 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06003119 RID: 12569 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000EC5")]
		public Utf8String Name
		{
			[Token(Token = "0x6003118")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6003119")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000EC6 RID: 3782
		// (get) Token: 0x0600311A RID: 12570 RVA: 0x0000CA4C File Offset: 0x0000AC4C
		// (set) Token: 0x0600311B RID: 12571 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000EC6")]
		public int CurrentValue
		{
			[Token(Token = "0x600311A")]
			[Address(RVA = "0x4875A0", Offset = "0x485BA0", VA = "0x1804875A0")]
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[Token(Token = "0x600311B")]
			[Address(RVA = "0x4875C0", Offset = "0x485BC0", VA = "0x1804875C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000EC7 RID: 3783
		// (get) Token: 0x0600311C RID: 12572 RVA: 0x0000CA64 File Offset: 0x0000AC64
		// (set) Token: 0x0600311D RID: 12573 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000EC7")]
		public int ThresholdValue
		{
			[Token(Token = "0x600311C")]
			[Address(RVA = "0x4AF750", Offset = "0x4ADD50", VA = "0x1804AF750")]
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[Token(Token = "0x600311D")]
			[Address(RVA = "0x4AF760", Offset = "0x4ADD60", VA = "0x1804AF760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600311E RID: 12574 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600311E")]
		[Address(RVA = "0x58BA70", Offset = "0x58A070", VA = "0x18058BA70")]
		internal void Set(ref PlayerStatInfoInternal other)
		{
		}
	}
}
