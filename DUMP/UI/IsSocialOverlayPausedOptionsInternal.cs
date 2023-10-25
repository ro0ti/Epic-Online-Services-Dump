using System;


namespace Epic.OnlineServices.UI
{
	// Token: 0x0200006F RID: 111
	[Token(Token = "0x200006F")]
	internal struct IsSocialOverlayPausedOptionsInternal : ISettable<IsSocialOverlayPausedOptions>, IDisposable
	{
		// Token: 0x060004EC RID: 1260 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x4875E0", Offset = "0x485BE0", VA = "0x1804875E0", Slot = "4")]
		public void Set(ref IsSocialOverlayPausedOptions other)
		{
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x4AA6D0", Offset = "0x4A8CD0", VA = "0x1804AA6D0", Slot = "5")]
		public void Set(ref IsSocialOverlayPausedOptions? other)
		{
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000232 RID: 562
		[Token(Token = "0x4000232")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;
	}
}
