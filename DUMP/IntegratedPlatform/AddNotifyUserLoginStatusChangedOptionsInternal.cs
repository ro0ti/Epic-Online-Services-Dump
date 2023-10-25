using System;


namespace Epic.OnlineServices.IntegratedPlatform
{
	// Token: 0x020004D9 RID: 1241
	[Token(Token = "0x20004D9")]
	internal struct AddNotifyUserLoginStatusChangedOptionsInternal : ISettable<AddNotifyUserLoginStatusChangedOptions>, IDisposable
	{
		// Token: 0x06001FF2 RID: 8178 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001FF2")]
		[Address(RVA = "0x4875E0", Offset = "0x485BE0", VA = "0x1804875E0", Slot = "4")]
		public void Set(ref AddNotifyUserLoginStatusChangedOptions other)
		{
		}

		// Token: 0x06001FF3 RID: 8179 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001FF3")]
		[Address(RVA = "0x5214B0", Offset = "0x51FAB0", VA = "0x1805214B0", Slot = "5")]
		public void Set(ref AddNotifyUserLoginStatusChangedOptions? other)
		{
		}

		// Token: 0x06001FF4 RID: 8180 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001FF4")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000E18 RID: 3608
		[Token(Token = "0x4000E18")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;
	}
}
