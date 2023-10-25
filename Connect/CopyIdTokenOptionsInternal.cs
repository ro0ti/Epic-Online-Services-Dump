using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Connect
{
	// Token: 0x020005F0 RID: 1520
	[Token(Token = "0x20005F0")]
	internal struct CopyIdTokenOptionsInternal : ISettable<CopyIdTokenOptions>, IDisposable
	{
		// Token: 0x17000B52 RID: 2898
		// (set) Token: 0x0600271B RID: 10011 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B52")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x600271B")]
			[Address(RVA = "0x557B60", Offset = "0x556160", VA = "0x180557B60")]
			set
			{
			}
		}

		// Token: 0x0600271C RID: 10012 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600271C")]
		[Address(RVA = "0x557A00", Offset = "0x556000", VA = "0x180557A00", Slot = "4")]
		public void Set(ref CopyIdTokenOptions other)
		{
		}

		// Token: 0x0600271D RID: 10013 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600271D")]
		[Address(RVA = "0x557900", Offset = "0x555F00", VA = "0x180557900", Slot = "5")]
		public void Set(ref CopyIdTokenOptions? other)
		{
		}

		// Token: 0x0600271E RID: 10014 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600271E")]
		[Address(RVA = "0x557860", Offset = "0x555E60", VA = "0x180557860", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x0400112B RID: 4395
		[Token(Token = "0x400112B")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x0400112C RID: 4396
		[Token(Token = "0x400112C")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;
	}
}
