using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Sessions
{
	// Token: 0x0200018B RID: 395
	[Token(Token = "0x200018B")]
	internal struct SessionSearchRemoveParameterOptionsInternal : ISettable<SessionSearchRemoveParameterOptions>, IDisposable
	{
		// Token: 0x17000296 RID: 662
		// (set) Token: 0x06000B64 RID: 2916 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000296")]
		public Utf8String Key
		{
			[Token(Token = "0x6000B64")]
			[Address(RVA = "0x4CC700", Offset = "0x4CAD00", VA = "0x1804CC700")]
			set
			{
			}
		}

		// Token: 0x17000297 RID: 663
		// (set) Token: 0x06000B65 RID: 2917 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000297")]
		public ComparisonOp ComparisonOp
		{
			[Token(Token = "0x6000B65")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			set
			{
			}
		}

		// Token: 0x06000B66 RID: 2918 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B66")]
		[Address(RVA = "0x4CC5B0", Offset = "0x4CABB0", VA = "0x1804CC5B0", Slot = "4")]
		public void Set(ref SessionSearchRemoveParameterOptions other)
		{
		}

		// Token: 0x06000B67 RID: 2919 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B67")]
		[Address(RVA = "0x4CC630", Offset = "0x4CAC30", VA = "0x1804CC630", Slot = "5")]
		public void Set(ref SessionSearchRemoveParameterOptions? other)
		{
		}

		// Token: 0x06000B68 RID: 2920 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B68")]
		[Address(RVA = "0x4CC560", Offset = "0x4CAB60", VA = "0x1804CC560", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000542 RID: 1346
		[Token(Token = "0x4000542")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000543 RID: 1347
		[Token(Token = "0x4000543")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_Key;

		// Token: 0x04000544 RID: 1348
		[Token(Token = "0x4000544")]
		[FieldOffset(Offset = "0x10")]
		private ComparisonOp m_ComparisonOp;
	}
}
