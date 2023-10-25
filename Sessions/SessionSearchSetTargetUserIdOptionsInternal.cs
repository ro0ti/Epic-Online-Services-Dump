using System;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Sessions
{
	// Token: 0x02000193 RID: 403
	[Token(Token = "0x2000193")]
	internal struct SessionSearchSetTargetUserIdOptionsInternal : ISettable<SessionSearchSetTargetUserIdOptions>, IDisposable
	{
		// Token: 0x170002A1 RID: 673
		// (set) Token: 0x06000B80 RID: 2944 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170002A1")]
		public ProductUserId TargetUserId
		{
			[Token(Token = "0x6000B80")]
			[Address(RVA = "0x4CCD60", Offset = "0x4CB360", VA = "0x1804CCD60")]
			set
			{
			}
		}

		// Token: 0x06000B81 RID: 2945 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B81")]
		[Address(RVA = "0x4CCC60", Offset = "0x4CB260", VA = "0x1804CCC60", Slot = "4")]
		public void Set(ref SessionSearchSetTargetUserIdOptions other)
		{
		}

		// Token: 0x06000B82 RID: 2946 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B82")]
		[Address(RVA = "0x4CCCC0", Offset = "0x4CB2C0", VA = "0x1804CCCC0", Slot = "5")]
		public void Set(ref SessionSearchSetTargetUserIdOptions? other)
		{
		}

		// Token: 0x06000B83 RID: 2947 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B83")]
		[Address(RVA = "0x4CCC10", Offset = "0x4CB210", VA = "0x1804CCC10", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000551 RID: 1361
		[Token(Token = "0x4000551")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000552 RID: 1362
		[Token(Token = "0x4000552")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_TargetUserId;
	}
}
