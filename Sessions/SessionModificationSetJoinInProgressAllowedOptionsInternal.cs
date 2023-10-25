using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Sessions
{
	// Token: 0x0200017A RID: 378
	[Token(Token = "0x200017A")]
	internal struct SessionModificationSetJoinInProgressAllowedOptionsInternal : ISettable<SessionModificationSetJoinInProgressAllowedOptions>, IDisposable
	{
		// Token: 0x17000286 RID: 646
		// (set) Token: 0x06000B1E RID: 2846 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000286")]
		public bool AllowJoinInProgress
		{
			[Token(Token = "0x6000B1E")]
			[Address(RVA = "0x4CB5E0", Offset = "0x4C9BE0", VA = "0x1804CB5E0")]
			set
			{
			}
		}

		// Token: 0x06000B1F RID: 2847 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B1F")]
		[Address(RVA = "0x4CB570", Offset = "0x4C9B70", VA = "0x1804CB570", Slot = "4")]
		public void Set(ref SessionModificationSetJoinInProgressAllowedOptions other)
		{
		}

		// Token: 0x06000B20 RID: 2848 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B20")]
		[Address(RVA = "0x4CB4D0", Offset = "0x4C9AD0", VA = "0x1804CB4D0", Slot = "5")]
		public void Set(ref SessionModificationSetJoinInProgressAllowedOptions? other)
		{
		}

		// Token: 0x06000B21 RID: 2849 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B21")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000525 RID: 1317
		[Token(Token = "0x4000525")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000526 RID: 1318
		[Token(Token = "0x4000526")]
		[FieldOffset(Offset = "0x4")]
		private int m_AllowJoinInProgress;
	}
}
