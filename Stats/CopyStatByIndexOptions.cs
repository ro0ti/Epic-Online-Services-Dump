﻿using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Stats
{
	// Token: 0x020000CE RID: 206
	[Token(Token = "0x20000CE")]
	public struct CopyStatByIndexOptions
	{
		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000767 RID: 1895 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06000768 RID: 1896 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000161")]
		public ProductUserId TargetUserId
		{
			[Token(Token = "0x6000767")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000768")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06000769 RID: 1897 RVA: 0x000033EC File Offset: 0x000015EC
		// (set) Token: 0x0600076A RID: 1898 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000162")]
		public uint StatIndex
		{
			[Token(Token = "0x6000769")]
			[Address(RVA = "0x4875A0", Offset = "0x485BA0", VA = "0x1804875A0")]
			[CompilerGenerated]
			readonly get
			{
				return 0U;
			}
			[Token(Token = "0x600076A")]
			[Address(RVA = "0x4875C0", Offset = "0x485BC0", VA = "0x1804875C0")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
