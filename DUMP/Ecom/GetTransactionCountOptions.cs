﻿using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.Ecom
{
	// Token: 0x02000560 RID: 1376
	[Token(Token = "0x2000560")]
	public struct GetTransactionCountOptions
	{
		// Token: 0x17000A4F RID: 2639
		// (get) Token: 0x06002384 RID: 9092 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002385 RID: 9093 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A4F")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x6002384")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002385")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
