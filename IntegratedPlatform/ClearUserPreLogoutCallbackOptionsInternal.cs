﻿using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.IntegratedPlatform
{
	// Token: 0x020004DB RID: 1243
	[Token(Token = "0x20004DB")]
	internal struct ClearUserPreLogoutCallbackOptionsInternal : ISettable<ClearUserPreLogoutCallbackOptions>, IDisposable
	{
		// Token: 0x06001FF5 RID: 8181 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001FF5")]
		[Address(RVA = "0x4875E0", Offset = "0x485BE0", VA = "0x1804875E0", Slot = "4")]
		public void Set(ref ClearUserPreLogoutCallbackOptions other)
		{
		}

		// Token: 0x06001FF6 RID: 8182 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001FF6")]
		[Address(RVA = "0x521500", Offset = "0x51FB00", VA = "0x180521500", Slot = "5")]
		public void Set(ref ClearUserPreLogoutCallbackOptions? other)
		{
		}

		// Token: 0x06001FF7 RID: 8183 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001FF7")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000E19 RID: 3609
		[Token(Token = "0x4000E19")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;
	}
}
