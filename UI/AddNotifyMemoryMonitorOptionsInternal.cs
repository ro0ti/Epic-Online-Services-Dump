using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.UI
{
	// Token: 0x02000060 RID: 96
	[Token(Token = "0x2000060")]
	internal struct AddNotifyMemoryMonitorOptionsInternal : ISettable<AddNotifyMemoryMonitorOptions>, IDisposable
	{
		// Token: 0x060004BE RID: 1214 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x4875E0", Offset = "0x485BE0", VA = "0x1804875E0", Slot = "4")]
		public void Set(ref AddNotifyMemoryMonitorOptions other)
		{
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x487640", Offset = "0x485C40", VA = "0x180487640", Slot = "5")]
		public void Set(ref AddNotifyMemoryMonitorOptions? other)
		{
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x0400020F RID: 527
		[Token(Token = "0x400020F")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;
	}
}
