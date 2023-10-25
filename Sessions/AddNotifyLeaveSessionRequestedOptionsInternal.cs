using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Sessions
{
	// Token: 0x020000F1 RID: 241
	[Token(Token = "0x20000F1")]
	internal struct AddNotifyLeaveSessionRequestedOptionsInternal : ISettable<AddNotifyLeaveSessionRequestedOptions>, IDisposable
	{
		// Token: 0x06000830 RID: 2096 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000830")]
		[Address(RVA = "0x4875E0", Offset = "0x485BE0", VA = "0x1804875E0", Slot = "4")]
		public void Set(ref AddNotifyLeaveSessionRequestedOptions other)
		{
		}

		// Token: 0x06000831 RID: 2097 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000831")]
		[Address(RVA = "0x4B9010", Offset = "0x4B7610", VA = "0x1804B9010", Slot = "5")]
		public void Set(ref AddNotifyLeaveSessionRequestedOptions? other)
		{
		}

		// Token: 0x06000832 RID: 2098 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000832")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000400 RID: 1024
		[Token(Token = "0x4000400")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;
	}
}
