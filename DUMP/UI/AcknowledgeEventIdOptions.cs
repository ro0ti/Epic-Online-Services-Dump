using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.UI
{
	// Token: 0x0200005B RID: 91
	[Token(Token = "0x200005B")]
	public struct AcknowledgeEventIdOptions
	{
		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060004B2 RID: 1202 RVA: 0x000028AC File Offset: 0x00000AAC
		// (set) Token: 0x060004B3 RID: 1203 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700008C")]
		public ulong UiEventId
		{
			[Token(Token = "0x60004B2")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return 0UL;
			}
			[Token(Token = "0x60004B3")]
			[Address(RVA = "0x4875D0", Offset = "0x485BD0", VA = "0x1804875D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060004B4 RID: 1204 RVA: 0x000028C4 File Offset: 0x00000AC4
		// (set) Token: 0x060004B5 RID: 1205 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700008D")]
		public Result Result
		{
			[Token(Token = "0x60004B4")]
			[Address(RVA = "0x4875A0", Offset = "0x485BA0", VA = "0x1804875A0")]
			[CompilerGenerated]
			readonly get
			{
				return Result.Success;
			}
			[Token(Token = "0x60004B5")]
			[Address(RVA = "0x4875C0", Offset = "0x485BC0", VA = "0x1804875C0")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
