﻿using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.Ecom
{
	// Token: 0x02000540 RID: 1344
	[Token(Token = "0x2000540")]
	public struct CopyOfferByIdOptions
	{
		// Token: 0x17000A0D RID: 2573
		// (get) Token: 0x060022C4 RID: 8900 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060022C5 RID: 8901 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A0D")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x60022C4")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60022C5")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000A0E RID: 2574
		// (get) Token: 0x060022C6 RID: 8902 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060022C7 RID: 8903 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A0E")]
		public Utf8String OfferId
		{
			[Token(Token = "0x60022C6")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60022C7")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
