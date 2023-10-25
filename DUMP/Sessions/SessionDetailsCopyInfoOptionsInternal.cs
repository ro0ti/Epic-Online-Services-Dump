using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Sessions
{
	// Token: 0x0200015B RID: 347
	[Token(Token = "0x200015B")]
	internal struct SessionDetailsCopyInfoOptionsInternal : ISettable<SessionDetailsCopyInfoOptions>, IDisposable
	{
		// Token: 0x06000A4C RID: 2636 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A4C")]
		[Address(RVA = "0x4875E0", Offset = "0x485BE0", VA = "0x1804875E0", Slot = "4")]
		public void Set(ref SessionDetailsCopyInfoOptions other)
		{
		}

		// Token: 0x06000A4D RID: 2637 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A4D")]
		[Address(RVA = "0x4C7270", Offset = "0x4C5870", VA = "0x1804C7270", Slot = "5")]
		public void Set(ref SessionDetailsCopyInfoOptions? other)
		{
		}

		// Token: 0x06000A4E RID: 2638 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A4E")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x040004C1 RID: 1217
		[Token(Token = "0x40004C1")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;
	}
}
