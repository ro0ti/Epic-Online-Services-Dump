﻿using System;


namespace Epic.OnlineServices.Sessions
{
	// Token: 0x020000E7 RID: 231
	[Token(Token = "0x20000E7")]
	internal struct ActiveSessionCopyInfoOptionsInternal : ISettable<ActiveSessionCopyInfoOptions>, IDisposable
	{
		// Token: 0x0600080C RID: 2060 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600080C")]
		[Address(RVA = "0x4875E0", Offset = "0x485BE0", VA = "0x1804875E0", Slot = "4")]
		public void Set(ref ActiveSessionCopyInfoOptions other)
		{
		}

		// Token: 0x0600080D RID: 2061 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600080D")]
		[Address(RVA = "0x4B83F0", Offset = "0x4B69F0", VA = "0x1804B83F0", Slot = "5")]
		public void Set(ref ActiveSessionCopyInfoOptions? other)
		{
		}

		// Token: 0x0600080E RID: 2062 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600080E")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x040003F1 RID: 1009
		[Token(Token = "0x40003F1")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;
	}
}
